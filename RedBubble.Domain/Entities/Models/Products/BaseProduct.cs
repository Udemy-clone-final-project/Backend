using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Products
{
   
    using RedBubble.Domain.Entities.Base;

    public class BaseProduct : BaseAuditableEntity<int> 
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal BasePrice { get; set; }

        // Relationship with Category
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
