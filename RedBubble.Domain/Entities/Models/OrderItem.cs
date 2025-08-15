using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models
{
    public class OrderItem : BaseEntity<Guid>
    {

        

        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }

        // relationship
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        //skip product for now 
        // do it later 


    }
}
