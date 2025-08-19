using RedBubble.Application.DTOs.Products.ProductVariant;
using RedBubble.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Products
{
    public interface IProductVariantService
    {
        Task<PagedList<ProductVariantDto>> GetAllProductVariantsAsync(
            string? searchItem,
            string? sortColumn,
            string? sortOrder,
            int? categoryId,
            int page,
            int pageSize);

        Task<ProductVariantDto?> GetProductVariantByIdAsync(int id);
        Task<ProductVariantDto> CreateProductVariantAsync(CreateProductVariantDto createDto);
        Task<ProductVariantDto?> UpdateProductVariantAsync(int id, UpdateProductVariantDto updateDto);
        Task<bool> DeleteProductVariantAsync(int id);
        Task<bool> UpdateStockQuantityAsync(int id, int newQuantity);
        Task<bool> SetActiveStatusAsync(int id, bool isActive);

      

        
    }
}