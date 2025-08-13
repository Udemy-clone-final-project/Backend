using RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Products
{
    public interface IProductVariantImageService
    {
        Task<IEnumerable<ProductVariantImageDto>> GetImagesByProductVariantIdAsync(int productVariantId);
        Task<ProductVariantImageDto?> GetImageByIdAsync(int id);
        Task<ProductVariantImageDto> CreateImageAsync(CreateProductVariantImageDto createDto);
        Task<ProductVariantImageDto?> UpdateImageAsync(int id, UpdateProductVariantImageDto updateDto);
        Task<bool> DeleteImageAsync(int id);
        Task<bool> SetPrimaryImageAsync(int productVariantId, int imageId);
        Task<ProductVariantImageDto?> GetPrimaryImageAsync(int productVariantId);
    }
}
