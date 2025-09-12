using RedBubble.Application.DTOs.Design.DesignImages;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.DTOs.Products.ProductVariant;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Design
{
    public class DesignDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public string? FileName { get; set; }
        public string? AltText { get; set; }
        public ICollection<ProductVariantDto> ProductVariants { get; set; } = new List<ProductVariantDto>();
        public string AdminId { get; set; }

        public string AdminName { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; } 
        public DateTime LastModifiedOn { get; set; }


    }
    public class CreateDesignDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        // ⚡ Server fills this, don’t validate client-side
        public string? ImageUrl { get; set; }
        public string? FileName { get; set; }
        public string? AltText { get; set; }
        public bool IsFileUpload { get; set; } = false;

        // ⚡ Server fills this too
        public string AdminId { get; set; }
    }

    public class UpdateDesignDto
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        
       
        public string? ImageUrl { get; set; }
        public string? FileName { get; set; }
        public string? AltText { get; set; }

   
        public bool IsFileUpload { get; set; } = false;

        public string AdminId { get; set; }


    }
}
