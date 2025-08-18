using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Products
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public string? ParentCategoryName { get; set; }
        public bool IsMainCategory { get; set; }
        public bool IsSubCategory { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    
    public class CategoryWithSubCategoriesDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public bool IsMainCategory { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<CategoryDto> SubCategories { get; set; } = new HashSet<CategoryDto>();
        public int SubCategoriesCount { get; set; }
    }


    public class CreateCategoryDto
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string CategoryName { get; set; } = null!;

        [StringLength(250)]
        public string? Description { get; set; }

        public int? ParentCategoryId { get; set; }
    }

    
    public class UpdateCategoryDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string CategoryName { get; set; } = null!;

        [StringLength(250)]
        public string? Description { get; set; }

        public int? ParentCategoryId { get; set; }
    }
}