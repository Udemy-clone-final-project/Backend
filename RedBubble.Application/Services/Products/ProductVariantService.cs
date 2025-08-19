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

        public async Task<PagedList<ProductVariantDto>> GetAllProductVariantsAsync(
            string? searchItem, string? sortColumn, string? sortOrder,
            int? categoryId, int page, int pageSize)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var query = repository.GetAll();

            
            query = query.Include(p => p.BaseProduct)
                         .Include(p => p.Design)
                         .Include(p => p.Colors)
                         .Include(p => p.Sizes)
                         .Include(p => p.ProductVariantImages)
                         .AsNoTracking();

            // Search filter
            if (!string.IsNullOrWhiteSpace(searchItem))
            {
                query = query.Where(p => p.BaseProduct!.Name.ToLower().Contains(searchItem.ToLower()) ||
                                       p.Design!.Title.ToLower().Contains(searchItem.ToLower())||                                      
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

        public async Task<ProductVariantDto?> GetProductVariantByIdAsync(int id)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var query = repository.GetAll()
                .Include(p => p.BaseProduct)
                .Include(p => p.Design)
                .Include(p => p.Colors)
                .Include(p => p.Sizes)
                .Include(p => p.ProductVariantImages)
                .AsNoTracking();

            var variant = await query.FirstOrDefaultAsync(p => p.Id == id);
            return variant != null ? _mapper.Map<ProductVariantDto>(variant) : null;
        }

        public async Task<ProductVariantDto> CreateProductVariantAsync(CreateProductVariantDto createDto)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var baseProductRepo = _unitOfWork.GetRepository<BaseProduct, int>();
            var designRepo = _unitOfWork.GetRepository<Design, int>();
            var colorRepo = _unitOfWork.GetRepository<Color, int>();
            var sizeRepo = _unitOfWork.GetRepository<Size, int>();

            // Validate BaseProduct and Design
            var baseProduct = await baseProductRepo.GetByIdAsync(createDto.BaseProductId);
            var design = await designRepo.GetByIdAsync(createDto.DesignId);

            if (baseProduct == null || design == null)
                throw new ArgumentException("BaseProduct or Design not found");

            // Get Colors and Sizes
            var colors = await colorRepo.GetAll()
                .Where(c => createDto.ColorIds.Contains(c.Id))
                .ToListAsync();

            var sizes = await sizeRepo.GetAll()
                .Where(s => createDto.SizeIds.Contains(s.Id))
                .ToListAsync();

            if (!colors.Any() || !sizes.Any())
                throw new ArgumentException("Colors or Sizes not found");

          
            var variant = _mapper.Map<ProductVariant>(createDto);
            variant.Price = baseProduct.BasePrice + design.Price;

          
            variant.Colors = colors;
            variant.Sizes = sizes;

            await repository.AddAsync(variant);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<ProductVariantDto>(variant);
        }

        public async Task<ProductVariantDto?> UpdateProductVariantAsync(int id, UpdateProductVariantDto updateDto)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variant = await repository.GetAll()
                .Include(p => p.Colors)
                .Include(p => p.Sizes)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (variant == null)
                return null;

            
            if (updateDto.Price.HasValue)
                variant.Price = updateDto.Price.Value;

            if (updateDto.StockQuantity.HasValue)
                variant.StockQuantity = updateDto.StockQuantity.Value;

            if (updateDto.IsActive.HasValue)
                variant.IsActive = updateDto.IsActive.Value;

            if (updateDto.BaseProductId.HasValue)
                variant.BaseProductId = updateDto.BaseProductId.Value;

            if (updateDto.DesignId.HasValue)
                variant.DesignId = updateDto.DesignId.Value;

           
            repository.Update(variant);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<ProductVariantDto>(variant);
        }

        public async Task<bool> DeleteProductVariantAsync(int id)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variant = await repository.GetByIdAsync(id);

            if (variant == null)
                return false;

            repository.Delete(variant);
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<bool> UpdateStockQuantityAsync(int id, int newQuantity)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variant = await repository.GetByIdAsync(id);

            if (variant == null)
                return false;

            variant.StockQuantity = newQuantity;
            repository.Update(variant);
            await _unitOfWork.CompleteAsync();

            return true;
        }

        public async Task<bool> SetActiveStatusAsync(int id, bool isActive)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variant = await repository.GetByIdAsync(id);

            if (variant == null)
                return false;

            variant.IsActive = isActive;
            repository.Update(variant);
            await _unitOfWork.CompleteAsync();

            return true;
        }

       

        
     
    }
}