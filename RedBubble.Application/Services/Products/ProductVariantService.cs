using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application.DTOs.Products.ProductVariant;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RedBubble.Application.Services.Products
{
    public class ProductVariantService : IProductVariantService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductVariantService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProductVariantDto> CreateAsync(CreateProductVariantDto createDto)
        {
            
            var isUnique = await IsUniqueVariantAsync(
                createDto.BaseProductId,
                createDto.DesignId,
                createDto.ColorId,
                createDto.SizeId);

            if (!isUnique)
                throw new InvalidOperationException("A variant with this combination already exists");

            
            var variantRepo = _unitOfWork.GetRepository<ProductVariant, int>();
            var baseProductRepo = _unitOfWork.GetRepository<BaseProduct, int>();
            var designRepo = _unitOfWork.GetRepository<Design, int>();

            var baseProduct = await baseProductRepo.GetByIdAsync(createDto.BaseProductId);
            var design = await designRepo.GetByIdAsync(createDto.DesignId);

            if (baseProduct == null)
                throw new ArgumentException("Base product not found", nameof(createDto.BaseProductId));

            if (design == null)
                throw new ArgumentException("Design not found", nameof(createDto.DesignId));

            
            var variant = _mapper.Map<ProductVariant>(createDto);

            
            variant.Price = baseProduct.BasePrice + design.Price;

          
            await variantRepo.AddAsync(variant);

         
            await _unitOfWork.CompleteAsync();

           
            var result = await GetByIdAsync(variant.Id);
            return result!;
        }

        public async Task<ProductVariantDto?> GetByIdAsync(int id)
        {
            var repo = _unitOfWork.GetRepository<ProductVariant, int>();

            var variant = await repo.GetAll()
                .Include(pv => pv.BaseProduct)
                .Include(pv => pv.Design)
                .Include(pv => pv.Color)
                .Include(pv => pv.Size)
                .Include(pv => pv.ProductVariantImages)
                .FirstOrDefaultAsync(pv => pv.Id == id);

            if (variant == null)
                return null;

            return _mapper.Map<ProductVariantDto>(variant);
        }

        public async Task<PagedList<ProductVariantDto>> GetAllProductVariantsAsync(
           string? searchItem, string? sortColumn, string? sortOrder,
           int? categoryId, int page, int pageSize)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var query = repository.GetAll();


            query = query.Include(p => p.BaseProduct)
                         .Include(p => p.Design)
                         .Include(p => p.Color)
                         .Include(p => p.Size)
                         .Include(p => p.ProductVariantImages)
                         .AsNoTracking();

            // Search filter
            if (!string.IsNullOrWhiteSpace(searchItem))
            {
                query = query.Where(p => p.BaseProduct.Name.ToLower().Contains(searchItem.ToLower()) ||
                                       p.Design!.Title.ToLower().Contains(searchItem.ToLower()) ||
                                        p.BaseProduct.Category.CategoryName.ToLower().Contains(searchItem.ToLower()));
            }

            // Category filter
            if (categoryId.HasValue)
            {
                query = query.Where(p => p.BaseProduct!.CategoryId == categoryId.Value);
            }

            // Sorting
            Expression<Func<ProductVariant, object>> keySelector = sortColumn?.ToLower() switch
            {
                "price" => p => p.Price,
                "stockquantity" => p => p.StockQuantity,
                "isactive" => p => p.IsActive,
                "baseproductid" => p => p.BaseProductId,
                "designid" => p => p.DesignId,
                _ => p => p.Id
            };

            query = !string.IsNullOrWhiteSpace(sortOrder) && sortOrder.ToLower() == "desc"
                ? query.OrderByDescending(keySelector)
                : query.OrderBy(keySelector);

            var dtoQuery = _mapper.ProjectTo<ProductVariantDto>(query);
            return await PagedList<ProductVariantDto>.CreateAsync(dtoQuery, page, pageSize);
        }

        public async Task<ProductVariantDto> UpdateAsync(UpdateProductVariantDto updateDto)
        {
            var repo = _unitOfWork.GetRepository<ProductVariant, int>();

            var variant = await repo.GetByIdAsync(updateDto.Id);
            if (variant == null)
                throw new ArgumentException("Product variant not found", nameof(updateDto.Id));

           
            _mapper.Map(updateDto, variant);

           
            repo.Update(variant);
            await _unitOfWork.CompleteAsync();

           
            var result = await GetByIdAsync(variant.Id);
            return result!;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var repo = _unitOfWork.GetRepository<ProductVariant, int>();

            var variant = await repo.GetByIdAsync(id);
            if (variant == null)
                return false;

            repo.Delete(variant);
            await _unitOfWork.CompleteAsync();
            return true;
        }

        
        public async Task<PagedList<ProductVariantDto>> GetActiveVariantsAsync(string? searchItem, string? sortColumn, string? sortOrder,
           int? categoryId, int page, int pageSize)
        {
            var repo = _unitOfWork.GetRepository<ProductVariant, int>();

            var query = repo.GetAll();

            query= query.Where(pv => pv.IsActive)
                .Include(pv => pv.BaseProduct)
                .Include(pv => pv.Design)
                .Include(pv => pv.Color)
                .Include(pv => pv.Size)
                .Include(pv => pv.ProductVariantImages)
                    .AsNoTracking();

            // Search filter
            if (!string.IsNullOrWhiteSpace(searchItem))
            {
                query = query.Where(p => p.BaseProduct.Name.ToLower().Contains(searchItem.ToLower()) ||
                                       p.Design!.Title.ToLower().Contains(searchItem.ToLower()) ||
                                        p.BaseProduct.Category.CategoryName.ToLower().Contains(searchItem.ToLower()));
            }

            // Category filter
            if (categoryId.HasValue)
            {
                query = query.Where(p => p.BaseProduct!.CategoryId == categoryId.Value);
            }

            // Sorting
            Expression<Func<ProductVariant, object>> keySelector = sortColumn?.ToLower() switch
            {
                "price" => p => p.Price,
                "stockquantity" => p => p.StockQuantity,
                "isactive" => p => p.IsActive,
                "baseproductid" => p => p.BaseProductId,
                "designid" => p => p.DesignId,
                _ => p => p.Id
            };

            query = !string.IsNullOrWhiteSpace(sortOrder) && sortOrder.ToLower() == "desc"
                ? query.OrderByDescending(keySelector)
                : query.OrderBy(keySelector);

            var dtoQuery = _mapper.ProjectTo<ProductVariantDto>(query);
            return await PagedList<ProductVariantDto>.CreateAsync(dtoQuery, page, pageSize);
        }

        public async Task<PagedList<ProductVariantDto>> GetInStockVariantsAsync()
        {
            var repo = _unitOfWork.GetRepository<ProductVariant, int>();

            var variants = await repo.GetAll()
                .Where(pv => pv.IsActive && pv.StockQuantity > 0)
                .Include(pv => pv.BaseProduct)
                .Include(pv => pv.Design)
                .Include(pv => pv.Color)
                .Include(pv => pv.Size)
                .Include(pv => pv.ProductVariantImages)
                .ToListAsync();

            return _mapper.Map<PagedList<ProductVariantDto>>(variants);
        }

       
        public async Task<bool> IsUniqueVariantAsync(
            int baseProductId, int designId, int colorId, int sizeId, int? excludeId = null)
        {
            var repo = _unitOfWork.GetRepository<ProductVariant, int>();

            var query = repo.GetAll()
                .Where(pv => pv.BaseProductId == baseProductId
                          && pv.DesignId == designId
                          && pv.ColorId == colorId
                          && pv.SizeId == sizeId);

            if (excludeId.HasValue)
                query = query.Where(pv => pv.Id != excludeId.Value);

            var exists = await query.AnyAsync();
            return !exists;
        }





    }
}