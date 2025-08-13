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
        public ICollection<ProductVariantImages>? ProductVariantImages {get;set;}
        public ICollection<OrderItems>? OrderItems { get; set; }
        public int BaseProductId { get; set; }
        public BaseProduct? BaseProduct { get; set; }
        public int DesignId { get; set; }
        public Design? Design { get; set; }
        public int ColorId { get; set; }
        public Color? Color { get; set; }

        public int SizeId { get; set; }
        public Size? Size { get; set; }

    }
}
