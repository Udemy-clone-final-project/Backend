using RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Products.ProductVariant
{
    public class ProductVariantDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }

        
        public int BaseProductId { get; set; }
        public string? BaseProductName { get; set; }

        
        public int DesignId { get; set; }
        public string? DesignTitle { get; set; }

        
        public List<ColorDto> Colors { get; set; } = new List<ColorDto>();

        
        public List<SizeDto> Sizes { get; set; } = new List<SizeDto>();

      
        public ICollection<ProductVariantImageDto>? Images { get; set; }

        
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}