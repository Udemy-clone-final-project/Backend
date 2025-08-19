using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models
{
    public class Order : BaseAuditableEntity<int> 
    {
        // public int Id { get; set; } — inherited from BaseEntity<int>
        //public string OrderNumber { get; set; } // UK skip it for now
        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
       
        public string ShippingCountry { get; set; }
        public string ShippingPostalCode { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime UpdatedAt { get; set; }


        // relationship
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        // relationship 
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
