using System;
using System.Collections.Generic;
using RedBubble.Domain.Entities.Base;

namespace RedBubble.Domain.Entities.Models.Products
{
    // Enhanced BaseProduct entity
    public class BaseProduct : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal BasePrice { get; set; }

        // Product Capabilities
        public bool HasSizes { get; set; }
        public bool HasColors { get; set; }
        public bool IsActive { get; set; } = true;

       

        // Relationships
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        //public string CategoryName => Category?.CategoryName ?? string.Empty;

        // Navigation properties for complex data
        public ICollection<BaseProductPrintArea> PrintAreas { get; set; } = new HashSet<BaseProductPrintArea>();
        public ICollection<BaseProductTemplate> Templates { get; set; } = new HashSet<BaseProductTemplate>();
        public ICollection<BaseProductSize> AvailableSizes { get; set; } = new HashSet<BaseProductSize>();
        public ICollection<BaseProductColor> AvailableColors { get; set; } = new HashSet<BaseProductColor>();
        public ICollection<ProductVariant> ProductVariants { get; set; } = new HashSet<ProductVariant>();
    }

    // Print areas definition for each base product
    public class BaseProductPrintArea : BaseEntity<int>
    {
        public int BaseProductId { get; set; }
        public string AreaName { get; set; } = null!; // "front", "back", "sleeve", "wrap-around"

        // Print area dimensions (in inches or cm)
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        // Position on the template (in pixels)
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        // DPI requirements for this area
        public int MinDPI { get; set; } = 300;

        public bool IsActive { get; set; } = true;
        public int DisplayOrder { get; set; } = 1; // Order for showing print areas

        public BaseProduct BaseProduct { get; set; } = null!;
    }

    // Template and mockup images for each view
    public class BaseProductTemplate : BaseEntity<int>
    {
        public int BaseProductId { get; set; }
        public string ViewName { get; set; } = null!; // "front", "back", "side", "angled"

        // Template: Technical file for design placement (usually transparent PNG)
        public string TemplateUrl { get; set; } = null!; // "/templates/tshirt-front-template.png"

        // Mockup: Realistic photo for customer preview
        public string MockupUrl { get; set; } = null!; // "/mockups/tshirt-front-mockup.jpg"

        // Optional: Flat mockup for simple overlay
        public string? FlatMockupUrl { get; set; } // "/mockups/tshirt-front-flat.jpg"

        public bool IsPrimary { get; set; } // Main view for product listings
        public int DisplayOrder { get; set; } = 1; // Order to show views
        public bool IsActive { get; set; } = true;

        // Template specifications
        public int TemplateWidth { get; set; } // Template image width in pixels
        public int TemplateHeight { get; set; } // Template image height in pixels

        public BaseProduct BaseProduct { get; set; } = null!;
    }

    // Junction table: Which sizes are available for each base product
    public class BaseProductSize : BaseEntity<int>
    {
        public int BaseProductId { get; set; }
        public int SizeId { get; set; }
        public bool IsActive { get; set; } = true;
        public decimal PriceModifier { get; set; } = 0; // Additional cost for this size

        public BaseProduct BaseProduct { get; set; } = null!;
        public Size Size { get; set; } = null!;
       
    }

    // Junction table: Which colors are available for each base product
    public class BaseProductColor : BaseEntity<int>
    {
        public int BaseProductId { get; set; }
        public int ColorId { get; set; }
        public bool IsActive { get; set; } = true;
        public decimal PriceModifier { get; set; } = 0; // Additional cost for this color

        // Color-specific mockups (if needed)
        public string? ColorSpecificMockupUrl { get; set; } // For when colors change the mockup significantly
       
        public BaseProduct BaseProduct { get; set; } = null!;
        public Color Color { get; set; } = null!;
       
    }
}