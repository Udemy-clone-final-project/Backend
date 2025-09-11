using RedBubble.Application.DTOs.Cart;
using RedBubble.Domain.Entities.Models.Cart;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface ICartService
    {
        Task<CustomerCartDto> GetCartAsync(string cartId);
        Task<CustomerCartDto> AddOrUpdateItemInCartAsync(string cartId, int variantId, int quantity);
        Task RemoveItemFromCartAsync(string cartId, int variantId);
        Task<bool> DeleteCartAsync(string cartId);
        Task MergeCartsAsync(string anonymousCartId, string customerId);
    }
}



