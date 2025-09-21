using Microsoft.AspNetCore.Identity;
using RedBubble.Domain.Entities.Models.Orders;

namespace RedBubble.Domain.Entities.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public Address? Address { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public ICollection<Design> CreatedDesigns { get; set; } = new HashSet<Design>();
        //public ICollection<Design> ReviewedDesigns { get; set; } = new HashSet<Design>();


    }
}
