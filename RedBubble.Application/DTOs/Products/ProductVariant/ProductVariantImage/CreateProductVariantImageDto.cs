using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage
{
    public class CreateProductVariantImageDto
    {
        public string? ImageUrl { get; set; }
        public string? FileName { get; set; }
        public string? AltText { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
