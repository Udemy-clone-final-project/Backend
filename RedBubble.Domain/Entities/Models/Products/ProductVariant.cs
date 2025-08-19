using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Products
{
    public class ProductVariant:BaseAuditableEntity<int>
    {
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public bool IsActive { get; set; }
               public int BaseProductId { get; set; }
        public BaseProduct? BaseProduct { get; set; }
        public int DesignId { get; set; }
        public Design? Design { get; set; }
        public ICollection<Color> Colors { get; set; } = new HashSet<Color>();
        public ICollection<Size> Sizes { get; set; } = new HashSet<Size>();
        public ICollection<ProductVariantImages> ProductVariantImages { get; set; } = new HashSet<ProductVariantImages>();
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();

    }
}
