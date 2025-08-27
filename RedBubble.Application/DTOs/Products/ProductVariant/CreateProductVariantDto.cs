using RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Products.ProductVariant
{
    public class CreateProductVariantDto
    {
        [Required]
        public int StockQuantity { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public int BaseProductId { get; set; }

        [Required]
        public int DesignId { get; set; }

        [Required]
        public int ColorId { get; set; }

        [Required]
        public int SizeId { get; set; }
        public List<CreateProductVariantImageDto>? Images { get; set; }
    }
}