using RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Products.ProductVariant
{
    public class ProductVariantDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
       
        public bool IsActive { get; set; }
        public int BaseProductId { get; set; }
        public string BaseProductName { get; set; } = null!;
        public decimal BaseProductPrice { get; set; }
        public int DesignId { get; set; }
        public string DesignTitle { get; set; } = null!;
        public decimal DesignPrice { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; } = null!;
        public string ColorCode { get; set; } = null!;
        public int SizeId { get; set; }
        public string SizeName { get; set; } = null!;
      public List<ProductVariantImageDto> Images { get; set; } = new();
      
    }
    public class CreateProductVariantDto
    {

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
    public class UpdateProductVariantDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int BaseProductId { get; set; }

        [Required]
        public int DesignId { get; set; }

        [Required]
        public int ColorId { get; set; }

        [Required]
        public int SizeId { get; set; }

        public bool IsActive { get; set; } = true;


    }
}