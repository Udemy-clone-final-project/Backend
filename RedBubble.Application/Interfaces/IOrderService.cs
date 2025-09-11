using RedBubble.Application.DTOs;
using RedBubble.Application.DTOs.Order;
using RedBubble.Application.DTOs.Products;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface IOrderService
    {
        Task<Order?> CreateOrderAsync(string customerEmail, string customerId, OrderDto orderDto);
        Task<IReadOnlyList<Order>> GetOrdersForUserAsync(string customerId);

    }
}
