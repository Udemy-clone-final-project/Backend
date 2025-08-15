using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.Implementations.Repositories
{
    public class OrderRepository(AppDbContext context) : GenericRepository<Order, Guid>(context), IOrderRepository
    {
        //public async Task ChangeStatus(Order order)
        //{
        //    context.Orders.Update(order);
        //}
    }
}
