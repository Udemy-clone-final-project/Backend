using Microsoft.AspNetCore.Identity;

namespace RedBubble.Domain.Entities.Models.Identity
                {
                    public class ApplicationUser : IdentityUser
                    {
                        public string DisplayName { get; set; }
                        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
                        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
                        public bool IsActive { get; set; } = true;
                        public Address? Address { get; set; }
                    public List<Order>? Orders { get; set; }
                    }
                }
