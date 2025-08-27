using RedBubble.Application.DTOs.Products.ProductVariant;
using RedBubble.Application.Services;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Products
{
    public interface IProductVariantService
    {
        Task<ProductVariantDto> CreateAsync(CreateProductVariantDto createDto);

        Task<ProductVariantDto?> GetByIdAsync(int id);

        Task<PagedList<ProductVariantDto>> GetAllProductVariantsAsync(
          string? searchItem, string? sortColumn, string? sortOrder,
          int? categoryId, int page, int pageSize);

        Task<ProductVariantDto> UpdateAsync(UpdateProductVariantDto updateDto);

        Task<bool> DeleteAsync(int id);


        Task<PagedList<ProductVariantDto>> GetActiveVariantsAsync(string? searchItem, string? sortColumn, string? sortOrder,
      int? categoryId, int page, int pageSize);

        Task<PagedList<ProductVariantDto>> GetInStockVariantsAsync();


        Task<bool> IsUniqueVariantAsync(int baseProductId, int designId, int colorId, int sizeId, int? excludeId = null);





    }
}