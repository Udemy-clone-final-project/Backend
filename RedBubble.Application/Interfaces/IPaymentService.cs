using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Cart;
using RedBubble.Domain.Entities.Models.Orders;

namespace RedBubble.Application.Interfaces
{
    public interface IPaymentService
    {
        Task<CustomerCart?> CreateOrUpdatePaymentIntentAsync(string cartId);
        Task<(bool Success, string RefundId, string Message)> RefundAsync(string paymentIntentId, long? amountCents = null, string? reason = null);
    }
}