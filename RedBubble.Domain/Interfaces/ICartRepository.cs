using RedBubble.Domain.Entities.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Interfaces
{
    public interface ICartRepository
    {
        Task<CustomerCart?> GetCartAsync(string cartId);
        Task<CustomerCart?> UpdateCartAsync(CustomerCart cart, TimeSpan timeSpan);
        Task<bool> DeleteCartAsync(string cartId);
    }
}
