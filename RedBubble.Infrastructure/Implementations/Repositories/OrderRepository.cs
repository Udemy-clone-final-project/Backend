//using RedBubble.Domain.Entities.Models.Orders;
//using RedBubble.Domain.Interfaces;
//using RedBubble.Infrastructure.DataAccess;
//using RedBubble.Infrastructure.Implementations.Base;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RedBubble.Infrastructure.Implementations.Repositories
//{
//    public class OrderRepository(AppDbContext context) : GenericRepository<Order, int>(context), IOrderRepository
//    {
//        //public async Task ChangeStatus(Order order)
//        //{
//        //    context.Orders.Update(order);
//        //}

//        public async Task<IQueryable<Order>> GetAllActive()
//        {
//            var orders = context.Orders.Where(o => o.Status != OrderStatus.Cancelled);
//            return orders;
//        }

//        public async Task<IQueryable<Order>> GetByCustomerId(string customerId)
//        {
//            var orders = context.Orders.Where(o => o.CustomerId == customerId);

//            return orders;

//        }
//    }
//}
