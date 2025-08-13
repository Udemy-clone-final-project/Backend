using AutoMapper;
using RedBubble.Application.DTOs.Products.ProductVariant;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services.Products
{
    public class ProductVariantService: IProductVariantService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductVariantService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVariantDto>> GetAllProductVariantsAsync(int page, int pageSize)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var query =  repository.GetAll();
            var variants = await PagedList<ProductVariant>.CreateAsync(query, page, pageSize);
            return _mapper.Map<IEnumerable<ProductVariantDto>>(variants);
        }
     

        public async Task<ProductVariantDto?> GetProductVariantByIdAsync(int id)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variant = await repository.GetByIdAsync(id);
            return variant != null ? _mapper.Map<ProductVariantDto>(variant) : null;
        }

        public async Task<ProductVariantDto> CreateProductVariantAsync(CreateProductVariantDto createDto)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variant = _mapper.Map<ProductVariant>(createDto);

            await repository.AddAsync(variant);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<ProductVariantDto>(variant);
        }

        public async Task<ProductVariantDto?> UpdateProductVariantAsync(int id, UpdateProductVariantDto updateDto)
        {
            var repository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variant = await repository.GetByIdAsync(id);

            if (variant == null)
                return null;

            // Update only non-null properties
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

            if (updateDto.ColorId.HasValue)
                variant.ColorId = updateDto.ColorId.Value;

            if (updateDto.SizeId.HasValue)
                variant.SizeId = updateDto.SizeId.Value;

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

