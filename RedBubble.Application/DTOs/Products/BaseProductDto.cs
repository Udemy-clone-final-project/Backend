using System;
using System.ComponentModel.DataAnnotations;

namespace RedBubble.Application.DTOs.Products
{
    // DTO for creating a new product
    public class CreateProductDto
    {
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
    }

    // DTO for updating an existing product
    public class UpdateProductDto
    {
        [Required(ErrorMessage = "Product ID is required")]
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
    }

    // DTO for reading product data
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal BasePrice { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        // Audit fields
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; } = null!;
        public DateTime LastModifiedOn { get; set; }
    }

    // DTO for product list view (lighter version)
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal BasePrice { get; set; }
        public string? CategoryName { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    // DTO for product search/filter
    public class ProductSearchDto
    {
        public string? SearchTerm { get; set; }
        public int? CategoryId { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SortBy { get; set; } = "Name";
        public bool SortDescending { get; set; } = false;
    }

    // DTO for paginated results
    public class PaginatedProductsDto
    {
        public IEnumerable<ProductListDto> Products { get; set; } = new List<ProductListDto>();
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;
    }
}