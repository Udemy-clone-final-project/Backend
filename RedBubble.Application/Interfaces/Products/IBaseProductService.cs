using RedBubble.Application.DTOs.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Services
{
    public interface IBaseProductService
    {
        // Read operations
        Task<IEnumerable<BaseProductListDto>> GetAllBaseProductsAsync();
        Task<BaseProductDto?> GetBaseProductByIdAsync(int id);
        //Task<IEnumerable<BaseProductListDto>> GetBaseProductsByCategoryAsync(int categoryId);
        Task<IEnumerable<BaseProductListDto>> SearchBaseProductsAsync(string searchTerm);

        // Write operations
        Task<BaseProductDto> CreateBaseProductAsync(CreateBaseProductDto createProductDto, string createdBy);
        Task<BaseProductDto> UpdateBaseProductAsync(UpdateBaseProductDto updateProductDto, string modifiedBy);
        Task<bool> DeleteBaseProductAsync(int id, string deletedBy);

        // Status management
        Task<bool> ActivateBaseProductAsync(int id, string modifiedBy);
        Task<bool> DeactivateBaseProductAsync(int id, string modifiedBy);

        // Business logic
        Task<bool> CanDeleteBaseProductAsync(int id);
        Task<IEnumerable<BaseProductListDto>> GetProductsCompatibleWithDesignAsync(int designId);

        // Validation helpers
        Task<bool> IsProductNameUniqueAsync(string name, int? excludeId = null);

    }
}