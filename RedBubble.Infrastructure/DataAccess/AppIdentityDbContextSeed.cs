using Microsoft.AspNetCore.Identity;
using RedBubble.Domain.Entities.Identity;
using RedBubble.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess
{

    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            }

            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mohamed Abdullah",
                    Email = "mohamed.shadow@mo.com",
                    UserName = "shadow",
                    Address = new Address
                    {
                        FirstName = "Mohamed",
                        LastName = "Abdullah",
                        Country = "Egypt",
                        City = "NeverLand",
                        Street = "10 nothint St."
                    }
                };

                var result = await userManager.CreateAsync(user, "Pa$$w0rd");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}
