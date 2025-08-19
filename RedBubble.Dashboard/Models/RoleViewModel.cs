using System.ComponentModel.DataAnnotations;

namespace RedBubble.Dashboard.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Role name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Description cannot exceed 100 characters")]
        public string Description { get; set; }
        public bool IsSelected { get; internal set; }
    }
}