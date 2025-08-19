using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models
{
    public class OrderItem : BaseEntity<int>
    {

        

        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }

        // relationship
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductVariantId { get; set; }

        public ProductVariant ProductVariant { get; set; }


    }
}
