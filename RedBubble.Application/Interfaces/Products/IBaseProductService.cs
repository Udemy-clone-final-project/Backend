using RedBubble.Application.DTOs.Products;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Services
{
    public interface IBaseProductService
    {
        Task<IEnumerable<ProductDto>> GetAllBaseProductsAsync();
      
       Task<ProductDto?> GetBaseProductByIdAsync(int id);
    
       Task<ProductDto> CreateBaseProductAsync(CreateProductDto createProductDto, string createdBy);
      
       Task<ProductDto?> UpdateBaseProductAsync(UpdateProductDto updateProductDto, string modifiedBy);
      
        Task<bool> DeleteBaseProductAsync(int id);

        Task<bool> IsBaseProductNameUniqueAsync(string name);
     


    }
}