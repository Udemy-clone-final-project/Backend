using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs
{
    public class ColorDto
    {
        public int Id { get; set; }

       
        public string ColorName { get; set; } = null!;

        
        public string ColorCode { get; set; } = null!;

      
        public bool IsActive { get; set; }
    }

    public class CreateColorDto
    {
        [Required(ErrorMessage = "Color name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Color name must be between 2 and 50 characters")]
        [Display(Name = "Color Name")]
        public string ColorName { get; set; } = null!;

        [Required(ErrorMessage = "Color code is required")]
        [RegularExpression(@"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$", ErrorMessage = "Color code must be a valid hex color (e.g., #FF5733 or #F53)")]
        [Display(Name = "Color Code")]
        public string ColorCode { get; set; } = null!;

      
        public bool IsActive { get; set; } = true;
    }

    public class UpdateColorDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Color name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Color name must be between 2 and 50 characters")]
        [Display(Name = "Color Name")]
        public string ColorName { get; set; } = null!;

        [Required(ErrorMessage = "Color code is required")]
        [RegularExpression(@"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$", ErrorMessage = "Color code must be a valid hex color (e.g., #FF5733 or #F53)")]
        [Display(Name = "Color Code")]
        public string ColorCode { get; set; } = null!;

        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }
}