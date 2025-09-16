using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedBubble.Application.DTOs.Products
{
    // Remove the problematic BaseDto abstract class

    // Main BaseProduct DTOs
    public class CreateBaseProductDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(200, ErrorMessage = "Name cannot exceed 200 characters")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Base price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Base price must be greater than 0")]
        public decimal BasePrice { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        public bool HasSizes { get; set; }
        public bool HasColors { get; set; }

      

        // Related entities - must have at least one of each
        [Required(ErrorMessage = "At least one print area is required")]
        [MinLength(1, ErrorMessage = "At least one print area is required")]
        public List<CreatePrintAreaDto> PrintAreas { get; set; } = new();

        [Required(ErrorMessage = "At least one template is required")]
        [MinLength(1, ErrorMessage = "At least one template is required")]
        public List<CreateTemplateDto> Templates { get; set; } = new();

        public List<int> AvailableSizeIds { get; set; } = new();
        public List<int> AvailableColorIds { get; set; } = new();
    }

    public class UpdateBaseProductDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(200, ErrorMessage = "Product name cannot exceed 200 characters")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Base price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Base price must be greater than 0")]
        public decimal BasePrice { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        public bool HasSizes { get; set; }
        public bool HasColors { get; set; }
        public bool IsActive { get; set; } = true;

        [Required(ErrorMessage = "At least one print area is required")]
        [MinLength(1, ErrorMessage = "At least one print area is required")]
        public List<UpdatePrintAreaDto> PrintAreas { get; set; } = new();

        [Required(ErrorMessage = "At least one template is required")]
        [MinLength(1, ErrorMessage = "At least one template is required")]
        public List<UpdateTemplateDto> Templates { get; set; } = new();

        public List<int>? AvailableSizeIds { get; set; } = new();
        public List<int>? AvailableColorIds { get; set; } = new();
    }


    public class BaseProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal BasePrice { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public bool HasSizes { get; set; }
        public bool HasColors { get; set; }
        public bool IsActive { get; set; }
       

        // Related data
        public List<PrintAreaDto> PrintAreas { get; set; } = new();
        public List<TemplateDto> Templates { get; set; } = new();
        public List<BaseProductSizeDto> AvailableSizes { get; set; } = new();
        public List<BaseProductColorDto> AvailableColors { get; set; } = new();

        // Audit fields
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; } = null!;
        public DateTime LastModifiedOn { get; set; }
    }

    // Print Area DTOs
    public class CreatePrintAreaDto
    {
        [Required(ErrorMessage = "Area name is required")]
        [StringLength(50, ErrorMessage = "Area name cannot exceed 50 characters")]
        public string AreaName { get; set; } = null!;

        [Required(ErrorMessage = "Width is required")]
        [Range(0.1, 50, ErrorMessage = "Width must be between 0.1 and 50")]
        public decimal Width { get; set; }

        [Required(ErrorMessage = "Height is required")]
        [Range(0.1, 50, ErrorMessage = "Height must be between 0.1 and 50")]
        public decimal Height { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Position X must be non-negative")]
        public int PositionX { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Position Y must be non-negative")]
        public int PositionY { get; set; }

        [Range(72, 600, ErrorMessage = "DPI must be between 72 and 600")]
        public int MinDPI { get; set; } = 300;

        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100")]
        public int DisplayOrder { get; set; } = 1;
    }

    public class UpdatePrintAreaDto : CreatePrintAreaDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public class PrintAreaDto
    {
        public int Id { get; set; }
        public int BaseProductId { get; set; }
        public string AreaName { get; set; } = null!;
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int MinDPI { get; set; }
        public bool IsActive { get; set; }
        public int DisplayOrder { get; set; }
    }

    // Template DTOs
    public class CreateTemplateDto
    {
        [Required(ErrorMessage = "View name is required")]
        [StringLength(50)]
        public string ViewName { get; set; } = null!;

        // Instead of URLs, accept uploaded files
        public IFormFile TemplateFile { get; set; } = null!;
        public IFormFile MockupFile { get; set; } = null!;
        public IFormFile? FlatMockupFile { get; set; }

        public bool IsPrimary { get; set; }
        public int DisplayOrder { get; set; } = 1;
        public int TemplateWidth { get; set; }
        public int TemplateHeight { get; set; }

        // These will be filled later by the FileService
        public string? TemplateUrl { get; set; }
        public string? MockupUrl { get; set; }
        public string? FlatMockupUrl { get; set; }
    }


    public class UpdateTemplateDto : CreateTemplateDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public class TemplateDto
    {
        public int Id { get; set; }
        public int BaseProductId { get; set; }
        public string ViewName { get; set; } = null!;
        public string TemplateUrl { get; set; } = null!;
        public string MockupUrl { get; set; } = null!;
        public string? FlatMockupUrl { get; set; }
        public bool IsPrimary { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public int TemplateWidth { get; set; }
        public int TemplateHeight { get; set; }
    }

    // Junction table DTOs
    public class BaseProductSizeDto
    {
        public int Id { get; set; }
        public int BaseProductId { get; set; }
        public int SizeId { get; set; }
        public string SizeName { get; set; } = null!;
        public string SizeDescription { get; set; } = null!;
        public bool IsActive { get; set; }
        public decimal PriceModifier { get; set; }
    }

    public class BaseProductColorDto
    {
        public int Id { get; set; }
        public int BaseProductId { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; } = null!;
        public string ColorCode { get; set; } = null!;
        public bool IsActive { get; set; }
        public decimal PriceModifier { get; set; }
        public string? ColorSpecificMockupUrl { get; set; }
    }

    // Simplified DTOs for lists
    public class BaseProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        
        public decimal BasePrice { get; set; }
        public string? CategoryName { get; set; }
        public bool HasSizes { get; set; }
        public bool HasColors { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string PrimaryMockupUrl { get; set; } = string.Empty;
        public int VariantsCount { get; set; } // Useful for admin interface
    }
}