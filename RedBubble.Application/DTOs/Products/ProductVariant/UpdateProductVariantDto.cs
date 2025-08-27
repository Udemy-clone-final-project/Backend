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
        [Required]
        public int Id { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be non-negative")]
        public int StockQuantity { get; set; }

        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public bool IsActive { get; set; }
    }
}