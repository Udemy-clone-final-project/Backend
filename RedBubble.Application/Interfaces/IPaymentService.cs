using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Cart;
using RedBubble.Domain.Entities.Models.Orders;

namespace RedBubble.Application.Interfaces
{
    public interface IPaymentService
    {
        Task<CustomerCart?> CreateOrUpdatePaymentIntentAsync(string cartId);
    }
}