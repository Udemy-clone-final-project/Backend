using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Products
{
    public class Category : BaseAuditableEntity<int>
    {
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }

        
        public ICollection<BaseProduct> BaseProducts { get; set; } = new HashSet<BaseProduct>();
    }
}
