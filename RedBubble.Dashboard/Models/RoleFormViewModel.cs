using System.ComponentModel.DataAnnotations;

namespace RedBubble.Dashboard.Models
{
    public class RoleFormViewModel
    {
        [Required(ErrorMessage = "Role name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Description cannot exceed 100 characters")]
        public string Description { get; set; } // جعلها غير مطلوبة
    }
}
