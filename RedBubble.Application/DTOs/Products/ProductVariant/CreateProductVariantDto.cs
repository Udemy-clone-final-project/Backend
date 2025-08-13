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
        [Range(1, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity cannot be negative")]
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
    }
}
