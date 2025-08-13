using AutoMapper;
using RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBubble.Application.Interfaces.Products;

namespace RedBubble.Application.Services.Products
{
    public class ProductVariantImageService:IProductVariantImageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductVariantImageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVariantImageDto>> GetImagesByProductVariantIdAsync(int productVariantId)
        {
            var repository = _unitOfWork.GetRepository<ProductVariantImages, int>();
            var images = await repository.GetAll()
                .Where(img => img.ProductVariantId == productVariantId).ToListAsync();
            return _mapper.Map<IEnumerable<ProductVariantImageDto>>(images);
        }

        public async Task<ProductVariantImageDto?> GetImageByIdAsync(int id)
        {
            var repository = _unitOfWork.GetRepository<ProductVariantImages, int>();
            var image = await repository.GetByIdAsync(id);
            return image != null ? _mapper.Map<ProductVariantImageDto>(image) : null;
        }

        public async Task<ProductVariantImageDto> CreateImageAsync(CreateProductVariantImageDto createDto)
        {
            var repository = _unitOfWork.GetRepository<ProductVariantImages, int>();

            // If this is set as primary, unset other primary images for this variant
            if (createDto.IsPrimary)
            {
                await UnsetPrimaryImagesForVariant(createDto.ProductVariantId);
            }

            var image = _mapper.Map<ProductVariantImages>(createDto);
            await repository.AddAsync(image);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<ProductVariantImageDto>(image);
        }

        public async Task<ProductVariantImageDto?> UpdateImageAsync(int id, UpdateProductVariantImageDto updateDto)
        {
            var repository = _unitOfWork.GetRepository<ProductVariantImages, int>();
            var image = await repository.GetByIdAsync(id);

            if (image == null)
                return null;

            // If setting as primary, unset other primary images for this variant
            if (updateDto.IsPrimary.HasValue && updateDto.IsPrimary.Value)
            {
                await UnsetPrimaryImagesForVariant(image.ProductVariantId);
            }

            // Update properties
            if (!string.IsNullOrEmpty(updateDto.ImageUrl))
                image.ImageUrl = updateDto.ImageUrl;

            if (updateDto.AltText != null)
                image.AltText = updateDto.AltText;

            if (updateDto.IsPrimary.HasValue)
                image.IsPrimary = updateDto.IsPrimary.Value;

            if (updateDto.IsActive.HasValue)
                image.IsActive = updateDto.IsActive.Value;

            repository.Update(image);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<ProductVariantImageDto>(image);
        }

        public async Task<bool> DeleteImageAsync(int id)
        {
            var repository = _unitOfWork.GetRepository<ProductVariantImages, int>();
            var image = await repository.GetByIdAsync(id);

            if (image == null)
                return false;

            repository.Delete(image);
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<bool> SetPrimaryImageAsync(int productVariantId, int imageId)
        {
            var repository = _unitOfWork.GetRepository<ProductVariantImages, int>();
            var image = await repository.GetByIdAsync(imageId);

            if (image == null || image.ProductVariantId != productVariantId)
                return false;

            // Unset other primary images for this variant
            await UnsetPrimaryImagesForVariant(productVariantId);

            // Set this image as primary
            image.IsPrimary = true;
            repository.Update(image);
            await _unitOfWork.CompleteAsync();

            return true;
        }

        public async Task<ProductVariantImageDto?> GetPrimaryImageAsync(int productVariantId)
        {
            var repository = _unitOfWork.GetRepository<ProductVariantImages, int>();
            var primaryImage = await repository.GetAll().FirstOrDefaultAsync(img =>
                img.ProductVariantId == productVariantId &&
                img.IsPrimary &&
                img.IsActive);

            return primaryImage != null ? _mapper.Map<ProductVariantImageDto>(primaryImage) : null;
        }

        private async Task UnsetPrimaryImagesForVariant(int productVariantId)
        {
            var repository = _unitOfWork.GetRepository<ProductVariantImages, int>();
            var primaryImages = await repository.GetAll()
                .Where(img=>img.ProductVariantId==productVariantId&&img.IsPrimary).ToListAsync();
          

            foreach (var img in primaryImages)
            {
                img.IsPrimary = false;
                repository.Update(img);
            }
        }
    }
}

