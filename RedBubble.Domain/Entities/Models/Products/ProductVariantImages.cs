using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Products
{
    public class ProductVariantImages:BaseAuditableEntity<int>
    {
        public string? ImageUrl { get; set; }
        public string? FileName { get; set; }
        public string? AltText { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
        public int ProductVariantId { get; set; }
        public ProductVariant? ProductVariant { get; set; }
    }
}
