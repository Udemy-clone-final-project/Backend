using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application.DTOs.Design;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    public class DesignService : IDesignService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public DesignService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<PagedList<DesignDto>> GetAllAsync(string? searchItem, string? sortColumn, string? sortOrder,
           int page, int pageSize)
        {
            var repository = _unitOfWork.GetRepository<Design, int>();
            var query = repository.GetAll();

            if (!string.IsNullOrWhiteSpace(searchItem))
            {
                query = query.Where(d => d.Description.ToLower().Contains(searchItem.ToLower()) ||
                                        d.Title.ToLower().Contains(searchItem.ToLower()));
            }

          
            query = query.Where(d => d.IsActive)
               .Include(d => d.ProductVariants.Where(pv => pv.IsActive))
                   .ThenInclude(pv => pv.BaseProduct)
               .Include(d => d.ProductVariants)
                   .ThenInclude(pv => pv.Color)
               .Include(d => d.ProductVariants)
                   .ThenInclude(pv => pv.Size)
               .Include(d => d.Admin)
               .AsNoTracking();

            Expression<Func<Design, object>> keySelector = sortColumn?.ToLower() switch
            {
                "price" => d => d.Price,
                "title" => d => d.Title,
                _ => p => p.Id
            };

            query = !string.IsNullOrWhiteSpace(sortOrder) && sortOrder.ToLower() == "desc"
                ? query.OrderByDescending(keySelector)
                : query.OrderBy(keySelector);

            
            var dtoQuery = _mapper.ProjectTo<DesignDto>(query);
            return await PagedList<DesignDto>.CreateAsync(dtoQuery, page, pageSize);
        }

        public async Task<DesignDto> GetDesignByIdAsync(int id)
        {
            var repository = _unitOfWork.GetRepository<Design, int>();
            var existingDesign = await repository.GetAll()
               
                .Include(e => e.ProductVariants.Where(pv => pv.IsActive))
                    .ThenInclude(pv => pv.BaseProduct)
                .Include(e => e.ProductVariants)
                    .ThenInclude(pv => pv.Color)
                .Include(e => e.ProductVariants)
                    .ThenInclude(pv => pv.Size)
                .Include(e => e.Admin)
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);

            if (existingDesign == null)
            {
                throw new KeyNotFoundException($"Design with id {id} not found");
            }

            return _mapper.Map<DesignDto>(existingDesign);
        }

        public async Task<DesignDto> CreateAsync(CreateDesignDto createDesignDto)
        {
            Console.WriteLine("=== DEBUG: Starting CreateAsync ===");

            try
            {
                // Log input data
                Console.WriteLine($"Input Data:");
                Console.WriteLine($"  Title: {createDesignDto.Title}");
                Console.WriteLine($"  Description: {createDesignDto.Description}");
                Console.WriteLine($"  Price: {createDesignDto.Price}");
                Console.WriteLine($"  IsActive: {createDesignDto.IsActive}");
                Console.WriteLine($"  ImageUrl: {createDesignDto.ImageUrl}");
                Console.WriteLine($"  FileName: {createDesignDto.FileName}");
                Console.WriteLine($"  AltText: {createDesignDto.AltText}");
                Console.WriteLine($"  AdminId: {createDesignDto.AdminId}");

                // Validate required fields
                if (string.IsNullOrEmpty(createDesignDto.Title))
                {
                    throw new ArgumentException("Title is required");
                }
                if (string.IsNullOrEmpty(createDesignDto.Description))
                {
                    throw new ArgumentException("Description is required");
                }
                if (string.IsNullOrEmpty(createDesignDto.ImageUrl))
                {
                    throw new ArgumentException("ImageUrl is required");
                }
                if (string.IsNullOrEmpty(createDesignDto.AdminId))
                {
                    throw new ArgumentException("AdminId is required");
                }
                if (createDesignDto.Price <= 0)
                {
                    throw new ArgumentException("Price must be greater than 0");
                }

                Console.WriteLine("✅ All required fields validated");

                var repository = _unitOfWork.GetRepository<Design, int>();
                Console.WriteLine("✅ Repository obtained");

                // Map the entity
                var design = _mapper.Map<Design>(createDesignDto);
                Console.WriteLine($"✅ Entity mapped - ID before save: {design.Id}");

                // Set audit fields explicitly
                design.CreatedBy = createDesignDto.AdminId;
                design.CreatedOn = DateTime.UtcNow;
                design.LastModifiedBy = createDesignDto.AdminId;
                design.LastModifiedOn = DateTime.UtcNow;

                Console.WriteLine($"Audit fields set:");
                Console.WriteLine($"  CreatedBy: {design.CreatedBy}");
                Console.WriteLine($"  CreatedOn: {design.CreatedOn}");
                Console.WriteLine($"  LastModifiedBy: {design.LastModifiedBy}");
                Console.WriteLine($"  LastModifiedOn: {design.LastModifiedOn}");

                // Log all entity properties before save
                Console.WriteLine($"Final entity before save:");
                Console.WriteLine($"  Title: {design.Title}");
                Console.WriteLine($"  Description: {design.Description}");
                Console.WriteLine($"  Price: {design.Price}");
                Console.WriteLine($"  IsActive: {design.IsActive}");
                Console.WriteLine($"  ImageUrl: {design.ImageUrl}");
                Console.WriteLine($"  FileName: {design.FileName}");
                Console.WriteLine($"  AltText: {design.AltText}");
                Console.WriteLine($"  AdminId: {design.AdminId}");

                // Add to repository
                Console.WriteLine("🔄 Adding entity to repository...");
                await repository.AddAsync(design);
                Console.WriteLine("✅ Entity added to repository");
                Console.WriteLine($"Entity ID after AddAsync: {design.Id}");

                // Save changes
                Console.WriteLine("🔄 Calling CompleteAsync...");
                var saveResult = await _unitOfWork.CompleteAsync();
                Console.WriteLine($"✅ CompleteAsync completed. Result: {saveResult}");
                Console.WriteLine($"Entity ID after save: {design.Id}");

                if (saveResult <= 0)
                {
                    Console.WriteLine("❌ WARNING: No rows were affected by the save operation!");
                    throw new InvalidOperationException("Failed to save design - no rows affected");
                }

                Console.WriteLine("✅ Design saved successfully!");

                // Map back to DTO
                var resultDto = _mapper.Map<DesignDto>(design);
                Console.WriteLine($"✅ Result DTO created with ID: {resultDto.Id}");

                Console.WriteLine("=== DEBUG: CreateAsync completed successfully ===");
                return resultDto;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ ERROR in CreateAsync:");
                Console.WriteLine($"Exception Type: {ex.GetType().Name}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    Console.WriteLine($"Inner Stack Trace: {ex.InnerException.StackTrace}");
                }

                Console.WriteLine("=== DEBUG: CreateAsync failed ===");
                throw;
            }
        }


        public async Task<DesignDto> Update(UpdateDesignDto updateDesignDto)
        {
            var repository = _unitOfWork.GetRepository<Design, int>();
            var existingDesign = await repository.GetAll()
                
                .Include(d => d.ProductVariants)
                .Include(d => d.Admin)
                .FirstOrDefaultAsync(d => d.Id == updateDesignDto.Id);

            if (existingDesign == null)
            {
                throw new KeyNotFoundException($"Design with id {updateDesignDto.Id} not found");
            }

         
            _mapper.Map(updateDesignDto, existingDesign);
            repository.Update(existingDesign);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<DesignDto>(existingDesign);
        }

        public async Task<bool> DeleteDesignAsync(int id)
        {
            var repository = _unitOfWork.GetRepository<Design, int>();
            var existingDesign = await repository.GetAll()
                .Include(d => d.ProductVariants)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (existingDesign == null)
            {
                return false;
            }

            foreach (var prd in existingDesign.ProductVariants)
            {
                prd.IsActive = false;
            }

            repository.Delete(existingDesign);
            await _unitOfWork.CompleteAsync();

            return true;
        }
    }
}