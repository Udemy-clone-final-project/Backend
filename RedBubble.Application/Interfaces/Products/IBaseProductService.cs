using RedBubble.Application.DTOs.Products;
namespace RedBubble.Application.Interfaces.Products { 
public interface IBaseProductService
{
    Task<BaseProductDto> CreateBaseProductAsync(CreateBaseProductDto dto);
    Task<IEnumerable<BaseProductDto>> GetAllBaseProductsAsync();
    Task<BaseProductDto?> GetBaseProductByIdAsync(int id);
    Task<bool> UpdateBaseProductAsync(int id, CreateBaseProductDto dto); 
    Task<bool> DeleteBaseProductAsync(int id); 
}
   
}
