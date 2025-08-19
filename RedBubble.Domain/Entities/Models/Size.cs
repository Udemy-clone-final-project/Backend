using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models
{

    public class Size : BaseEntity<int>
    {
        public string SizeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }= new HashSet<ProductVariant>();
    }
}