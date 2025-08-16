using Microsoft.AspNetCore.Identity;
using RedBubble.Domain.Entities.Models.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess
{
    public static class AppDbContextSeed
    {
        public static async Task SeedRolesAsync(RoleManager<ApplicationRole> roleManager)
        {
            
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                var adminRole = new ApplicationRole()
                {
                    Name = "Admin",
                    Description = "Administrator role with full access",
                    IsActive = true
                };
                await roleManager.CreateAsync(adminRole);
            }
          
        }

       
        public static async Task SeedAdminUserAsync(UserManager<ApplicationUser> userManager)
        {
          
            if (!userManager.Users.Any(u => u.UserName == "MD10"))
            {
                var user = new ApplicationUser()
                {
                    DisplayName = "Mohamed Abdullah",
                    Email = "shadow@mm.com",
                    IsActive = true,
                    UserName = "MD10",
                    EmailConfirmed = true,
                    Address = new Address()
                    {
                        
                        FirstName = "Mohamed",
                        LastName = "Abdullah",
                        City = "no",
                        Country = "NeverLand",
                        Street = "no",
                    }
                };

                var result = await userManager.CreateAsync(user, "Pa$$w0rd");

             
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }


      

        public static async Task SeedCustomersAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            // 1. Ensure the "Customer" role exists
            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                await roleManager.CreateAsync(new ApplicationRole { Name = "Customer", Description = "Default role for customers." });
            }

            // 2. Create the first sample customer
            if (await userManager.FindByEmailAsync("customer1@test.com") == null)
            {
                var customer1 = new ApplicationUser
                {
                    DisplayName = "John Doe",
                    UserName = "johndoe",
                    Email = "customer1@test.com",
                    EmailConfirmed = true,
                    IsActive = true,
                    Address = new Address
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Country = "USA",
                        City = "New York",
                        Street = "123 Main St"
                    }
                };

                var result = await userManager.CreateAsync(customer1, "Pa$$w0rd");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(customer1, "Customer");
                }
            }

            // 3. Create the second sample customer
            if (await userManager.FindByEmailAsync("customer2@test.com") == null)
            {
                var customer2 = new ApplicationUser
                {
                    DisplayName = "Jane Smith",
                    UserName = "janesmith",
                    Email = "customer2@test.com",
                    EmailConfirmed = true,
                    IsActive = true,
                    Address = new Address
                    {
                        FirstName = "Jane",
                        LastName = "Smith",
                        Country = "Canada",
                        City = "Toronto",
                        Street = "456 Oak Ave"
                    }
                };

                var result = await userManager.CreateAsync(customer2, "Pa$$w0rd");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(customer2, "Customer");
                }
            }
        }
    }
}

