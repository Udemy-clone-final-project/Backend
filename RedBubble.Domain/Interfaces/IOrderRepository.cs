using RedBubble.Domain.Entities.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order, int>
    {
        //Task ChangeStatus(Order order);
        // void or task ??
    }
}
