using RedBubble.Application.DTOs.Order;
using RedBubble.Application.DTOs.Products;
using RedBubble.Domain.Entities.Models;
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

        Task ChangeStatus(UpdateOrderDTO updateOrderDTO , Guid orderId);

        Task Delete(Guid orderId);


    }
}
