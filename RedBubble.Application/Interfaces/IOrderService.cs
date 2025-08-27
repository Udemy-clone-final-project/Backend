using RedBubble.Application.DTOs.Order;
using RedBubble.Application.DTOs.Products;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(CreateOrderDTO createOrderDTO);

        //Task ChangeStatus(UpdateOrderDTO updateOrderDTO , int orderId);

        Task ChangeStatus(int orderId , OrderStatus status); // for admin
        Task Delete(int orderId); // for customer

        Task<List<Order>> GetAllAsync();

        Task<List<Order>> GetOrdersByCustomerId(string customerId);

        


    }
}
