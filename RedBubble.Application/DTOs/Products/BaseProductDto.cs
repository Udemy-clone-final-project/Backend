using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedBubble.Application.DTOs.Products
{
    // FIXED: Main BaseProduct DTOs with proper checkbox binding
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

        // FIXED: Explicit boolean properties with proper initialization
        public bool HasSizes { get; set; } = false;
        public bool HasColors { get; set; } = false;

        // Related entities - must have at least one of each
        [Required(ErrorMessage = "At least one print area is required")]
        [MinLength(1, ErrorMessage = "At least one print area is required")]
        public List<CreatePrintAreaDto> PrintAreas { get; set; } = new();

        [Required(ErrorMessage = "At least one template is required")]
        [MinLength(1, ErrorMessage = "At least one template is required")]
        public List<CreateTemplateDto> Templates { get; set; } = new();

        // FIXED: Initialize as empty lists to prevent null reference errors
        public List<int> AvailableSizeIds { get; set; } = new();
        public List<int> AvailableColorIds { get; set; } = new();

        // FIXED: Custom validation method
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            // Business rule validation
            if (HasSizes && !AvailableSizeIds.Any())
            {
                results.Add(new ValidationResult(
                    "At least one size must be selected when 'Has Sizes' is enabled.",
                    new[] { nameof(AvailableSizeIds) }));
            }

            if (HasColors && !AvailableColorIds.Any())
            {
                results.Add(new ValidationResult(
                    "At least one color must be selected when 'Has Colors' is enabled.",
                    new[] { nameof(AvailableColorIds) }));
            }

            // Template validation
            if (Templates != null)
            {
                var primaryCount = Templates.Count(t => t.IsPrimary);
                if (primaryCount == 0)
                {
                    results.Add(new ValidationResult(
                        "At least one template must be marked as primary.",
                        new[] { nameof(Templates) }));
                }
                else if (primaryCount > 1)
                {
                    results.Add(new ValidationResult(
                        "Only one template can be marked as primary.",
                        new[] { nameof(Templates) }));
                }

                // Check for unique view names
                var viewNames = Templates.Select(t => t.ViewName?.ToLower()).Where(n => !string.IsNullOrEmpty(n)).ToList();
                if (viewNames.Count != viewNames.Distinct().Count())
                {
                    results.Add(new ValidationResult(
                        "Template view names must be unique.",
                        new[] { nameof(Templates) }));
                }
            }

            // Print area validation
            if (PrintAreas != null && Templates != null)
            {
                var templateViews = Templates.Select(t => t.ViewName?.ToLower()).Where(n => !string.IsNullOrEmpty(n)).ToHashSet();
                var areaNames = PrintAreas.Select(pa => pa.AreaName?.ToLower()).Where(n => !string.IsNullOrEmpty(n)).ToList();

                // Check for unique area names
                if (areaNames.Count != areaNames.Distinct().Count())
                {
                    results.Add(new ValidationResult(
                        "Print area names must be unique.",
                        new[] { nameof(PrintAreas) }));
                }

                // Check that print areas reference existing template views
                foreach (var area in PrintAreas)
                {
                    if (!string.IsNullOrEmpty(area.AreaName) && !templateViews.Contains(area.AreaName.ToLower()))
                    {
                        results.Add(new ValidationResult(
                            $"Print area '{area.AreaName}' references a template view that doesn't exist.",
                            new[] { nameof(PrintAreas) }));
                    }
                }
            }

            return results;
        }
    }

    public class UpdateBaseProductDto : IValidatableObject
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

        // FIXED: Explicit boolean properties
        public bool HasSizes { get; set; } = false;
        public bool HasColors { get; set; } = false;
        public bool IsActive { get; set; } = true;

        [Required(ErrorMessage = "At least one print area is required")]
        [MinLength(1, ErrorMessage = "At least one print area is required")]
        public List<UpdatePrintAreaDto> PrintAreas { get; set; } = new();

        [Required(ErrorMessage = "At least one template is required")]
        [MinLength(1, ErrorMessage = "At least one template is required")]
        public List<UpdateTemplateDto> Templates { get; set; } = new();

        public List<int> AvailableSizeIds { get; set; } = new();
        public List<int> AvailableColorIds { get; set; } = new();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (HasSizes && !AvailableSizeIds.Any())
            {
                results.Add(new ValidationResult(
                    "At least one size must be selected when 'Has Sizes' is enabled.",
                    new[] { nameof(AvailableSizeIds) }));
            }

            if (HasColors && !AvailableColorIds.Any())
            {
                results.Add(new ValidationResult(
                    "At least one color must be selected when 'Has Colors' is enabled.",
                    new[] { nameof(AvailableColorIds) }));
            }

            return results;
        }
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
        [Range(0.1, 5000, ErrorMessage = "Width must be between 0.1 and 5000")]
        public decimal Width { get; set; }

        [Required(ErrorMessage = "Height is required")]
        [Range(0.1, 5000, ErrorMessage = "Height must be between 0.1 and 5000")]
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

        // File uploads - marked as required for creation
        [Required(ErrorMessage = "Template file is required")]
        public IFormFile? TemplateFile { get; set; }

        [Required(ErrorMessage = "Mockup file is required")]
        public IFormFile? MockupFile { get; set; }

        public IFormFile? FlatMockupFile { get; set; }

        public bool IsPrimary { get; set; } = false;

        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100")]
        public int DisplayOrder { get; set; } = 1;

        // Dimension fields - will be populated automatically
        [Range(1, 10000, ErrorMessage = "Template width must be between 1 and 10000")]
        public int TemplateWidth { get; set; }

        [Range(1, 10000, ErrorMessage = "Template height must be between 1 and 10000")]
        public int TemplateHeight { get; set; }

        // URL fields - will be filled by the FileService
        public string? TemplateUrl { get; set; }
        public string? MockupUrl { get; set; }
        public string? FlatMockupUrl { get; set; }
    }

    // Update your UpdateTemplateDto class in BaseProductDto.cs
    public class UpdateTemplateDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "View name is required")]
        [StringLength(50)]
        public string ViewName { get; set; } = null!;

        // File upload properties - optional for updates
        public IFormFile? TemplateFile { get; set; }
        public IFormFile? MockupFile { get; set; }
        public IFormFile? FlatMockupFile { get; set; }

        public bool IsPrimary { get; set; } = false;

        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100")]
        public int DisplayOrder { get; set; } = 1;

        public bool IsActive { get; set; } = true;

        // Dimension fields - will be updated if new template uploaded
        [Range(1, 10000, ErrorMessage = "Template width must be between 1 and 10000")]
        public int TemplateWidth { get; set; }

        [Range(1, 10000, ErrorMessage = "Template height must be between 1 and 10000")]
        public int TemplateHeight { get; set; }

        // URL fields - existing URLs that will be kept if no new file uploaded
        public string? TemplateUrl { get; set; }
        public string? MockupUrl { get; set; }
        public string? FlatMockupUrl { get; set; }
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
        public int VariantsCount { get; set; }
    }
    public class CreatePrintAreaInput
    {
        public string AreaName { get; set; } = null!;

        // UI sends these as percentages (0–100)
        public decimal WidthPercent { get; set; }
        public decimal HeightPercent { get; set; }
        public decimal PositionXPercent { get; set; }
        public decimal PositionYPercent { get; set; }
    }

}