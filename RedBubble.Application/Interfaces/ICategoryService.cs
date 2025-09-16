using RedBubble.Application.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        // Basic CRUD Operations
        Task<CategoryDto?> GetByIdAsync(int id);
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<CategoryDto> CreateAsync(CreateCategoryDto createDto);
        Task<CategoryDto> UpdateAsync(UpdateCategoryDto updateDto);
        Task<bool> DeleteAsync(int id);

        // Hierarchical Operations
        Task<IEnumerable<CategoryDto>> GetMainCategoriesAsync();
        Task<IEnumerable<CategoryDto>> GetSubCategoriesAsync(int parentCategoryId);
        Task<CategoryWithSubCategoriesDto?> GetCategoryWithSubCategoriesAsync(int categoryId);
        Task<IEnumerable<CategoryWithSubCategoriesDto>> GetAllCategoriesWithSubCategoriesAsync();

        Task<bool> CanDeleteCategoryAsync(int categoryId);
     

       

     
    }
}