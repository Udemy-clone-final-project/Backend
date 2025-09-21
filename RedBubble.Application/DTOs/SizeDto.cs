using System.ComponentModel.DataAnnotations;

namespace RedBubble.Application.DTOs
{
    public class SizeDto
    {
        public int Id { get; set; }
        public string SizeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }
    }

    public class CreateSizeDto
    {
        [Required(ErrorMessage = "Size name is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Size name must be between 1 and 50 characters.")]
        [Display(Name = "Size Name")]
        public string SizeName { get; set; } = null!;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 500 characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;

       
        public bool IsActive { get; set; } = true;
    }

    public class UpdateSizeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Size name is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Size name must be between 1 and 50 characters.")]
        [Display(Name = "Size Name")]
        public string SizeName { get; set; } = null!;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 500 characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
    }
}