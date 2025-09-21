using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Orders
{
    // Domain/Entities/Models/OrderItem.cs
    public class OrderItem : BaseEntity<int>
    {
        private OrderItem() { }

        public OrderItem(VariantItemOrdered productVariantOrdered, decimal price, int quantity)
        {
            ProductVariantOrdered = productVariantOrdered;
            Price = price;
            Quantity = quantity;
        }

      
        public VariantItemOrdered ProductVariantOrdered { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
