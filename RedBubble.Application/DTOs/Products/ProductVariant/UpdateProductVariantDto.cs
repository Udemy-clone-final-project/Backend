using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Products.ProductVariant
{
    public class UpdateProductVariantDto
    {
        [Range(1, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal? Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity cannot be negative")]
        public int? StockQuantity { get; set; }

        public bool? IsActive { get; set; }

        public int? BaseProductId { get; set; }
        public int? DesignId { get; set; }
        public int? ColorId { get; set; }
        public int? SizeId { get; set; }
    }
}
