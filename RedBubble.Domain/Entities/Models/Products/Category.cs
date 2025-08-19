using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Products
{
    public class Category : BaseAuditableEntity<int>
    {
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }

        // Self-referencing foreign key for parent category
        public int? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }

        // Navigation property for child categories (subcategories)
        public ICollection<Category> SubCategories { get; set; } = new HashSet<Category>();

        public ICollection<BaseProduct> BaseProducts { get; set; } = new HashSet<BaseProduct>();

        // Helper property to check if this is a main category
        public bool IsMainCategory => ParentCategoryId == null;

        // Helper property to check if this is a subcategory
        public bool IsSubCategory => ParentCategoryId != null;
    }
}