using System.ComponentModel.DataAnnotations;

namespace RedBubble.Dashboard.Models
{
    public class AdminSettingsViewModel
    {
        [Required]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        // Read-only properties to display on the page
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
