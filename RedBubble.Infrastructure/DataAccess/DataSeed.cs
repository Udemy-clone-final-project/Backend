using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Entities.Models.Orders;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using Address = RedBubble.Domain.Entities.Models.Identity.Address;

namespace RedBubble.Infrastructure.DataAccess
{
    public static class DataSeed
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            SeedRoles(modelBuilder);
            SeedUsers(modelBuilder);
            SeedUserRoles(modelBuilder);
            SeedAddresses(modelBuilder);
            SeedCategories(modelBuilder);
            SeedColors(modelBuilder);
            SeedSizes(modelBuilder);
          
        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Description = "System Administrator with full access to manage products and designs",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                },
                new ApplicationRole
                {
                    Id = "2",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                    Description = "Customer who can browse and purchase products",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                }
            );
        }

        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var users = new List<ApplicationUser>();

            // Admin User
            users.Add(new ApplicationUser
            {
                Id = "admin-001",
                UserName = "admin@redbubble.com",
                NormalizedUserName = "ADMIN@REDBUBBLE.COM",
                Email = "admin@redbubble.com",
                NormalizedEmail = "ADMIN@REDBUBBLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin123!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                DisplayName = "System Administrator",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true
            });

            // Customer Users (30 customers)
            string[] customerNames = {
                "John Doe", "Jane Smith", "Michael Johnson", "Sarah Williams", "David Brown",
                "Emily Davis", "James Miller", "Jessica Wilson", "Robert Moore", "Ashley Taylor",
                "Christopher Anderson", "Amanda Thomas", "Matthew Jackson", "Melissa White", "Anthony Harris",
                "Stephanie Martin", "Mark Thompson", "Laura Garcia", "Steven Martinez", "Michelle Robinson",
                "Kevin Clark", "Kimberly Rodriguez", "Joshua Lewis", "Lisa Lee", "Andrew Walker",
                "Nancy Hall", "Brian Allen", "Betty Young", "Gary Hernandez", "Helen King"
            };

            for (int i = 0; i < 30; i++)
            {
                var email = $"{customerNames[i].ToLower().Replace(" ", ".")}@email.com";
                users.Add(new ApplicationUser
                {
                    Id = $"customer-{i + 1:D3}",
                    UserName = email,
                    NormalizedUserName = email.ToUpper(),
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Customer123!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DisplayName = customerNames[i],
                    CreatedAt = DateTime.UtcNow.AddDays(-new Random(i).Next(1, 365)),
                    UpdatedAt = DateTime.UtcNow.AddDays(-new Random(i).Next(1, 30)),
                    IsActive = true
                });
            }

            modelBuilder.Entity<ApplicationUser>().HasData(users);
        }

        private static void SeedUserRoles(ModelBuilder modelBuilder)
        {
            var userRoles = new List<IdentityUserRole<string>>();

            // Admin role
            userRoles.Add(new IdentityUserRole<string> { UserId = "admin-001", RoleId = "1" });

            // Customer roles
            for (int i = 1; i <= 30; i++)
            {
                userRoles.Add(new IdentityUserRole<string> { UserId = $"customer-{i:D3}", RoleId = "2" });
            }

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }

        private static void SeedAddresses(ModelBuilder modelBuilder)
        {
            var addresses = new List<Address>();
            var countries = new[] { "United States", "Canada", "United Kingdom", "Australia", "Germany", "France", "Japan", "Netherlands", "Sweden", "Norway" };
            var cityCountryMap = new Dictionary<string, string[]>
            {
                ["United States"] = new[] { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" },
                ["Canada"] = new[] { "Toronto", "Vancouver", "Montreal", "Calgary", "Ottawa" },
                ["United Kingdom"] = new[] { "London", "Manchester", "Birmingham", "Liverpool", "Bristol" },
                ["Australia"] = new[] { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide" },
                ["Germany"] = new[] { "Berlin", "Munich", "Hamburg", "Cologne", "Frankfurt" },
                ["France"] = new[] { "Paris", "Lyon", "Marseille", "Toulouse", "Nice" },
                ["Japan"] = new[] { "Tokyo", "Osaka", "Kyoto", "Yokohama", "Nagoya" },
                ["Netherlands"] = new[] { "Amsterdam", "Rotterdam", "The Hague", "Utrecht", "Eindhoven" },
                ["Sweden"] = new[] { "Stockholm", "Gothenburg", "Malmö", "Uppsala", "Västerås" },
                ["Norway"] = new[] { "Oslo", "Bergen", "Trondheim", "Stavanger", "Drammen" }
            };

            var streets = new[] { "Main Street", "Oak Avenue", "Pine Road", "Elm Drive", "Maple Lane", "Cedar Way", "Park Boulevard", "First Street", "Second Avenue", "Market Street" };

            // Add admin address
            addresses.Add(new Address
            {
                Id = 1,
                FirstName = "System",
                LastName = "Administrator",
                Country = "United States",
                City = "San Francisco",
                Street = "123 Admin Plaza",
                ApplicationUserId = "admin-001"
            });

            // Add customer addresses
            for (int i = 1; i <= 30; i++)
            {
                var random = new Random(i + 100);
                var country = countries[random.Next(countries.Length)];
                var cities = cityCountryMap[country];

                addresses.Add(new Address
                {
                    Id = i + 1,
                    FirstName = $"Customer{i}First",
                    LastName = $"Customer{i}Last",
                    Country = country,
                    City = cities[random.Next(cities.Length)],
                    Street = $"{random.Next(100, 9999)} {streets[random.Next(streets.Length)]}",
                    ApplicationUserId = $"customer-{i:D3}"
                });
            }

            modelBuilder.Entity<Address>().HasData(addresses);
        }

        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            var categories = new List<Category>();

            // Main Categories
            var mainCategories = new[]
            {
                new { Id = 1, Name = "Clothing", Desc = "Apparel and wearable items for all ages" },
                new { Id = 2, Name = "Accessories", Desc = "Fashion and lifestyle accessories" },
                new { Id = 3, Name = "Home & Living", Desc = "Home decor and lifestyle items" },
                new { Id = 4, Name = "Stickers & Decals", Desc = "Decorative stickers and decals" },
                new { Id = 5, Name = "Wall Art", Desc = "Prints, posters, and wall decorations" },
                new { Id = 6, Name = "Stationery & Office", Desc = "Notebooks, cards, and office supplies" },
                new { Id = 7, Name = "Bags & Purses", Desc = "Tote bags, backpacks, and purses" },
                new { Id = 8, Name = "Tech Accessories", Desc = "Phone cases and tech accessories" }
            };

            foreach (var cat in mainCategories)
            {
                categories.Add(new Category
                {
                    Id = cat.Id,
                    CategoryName = cat.Name,
                    Description = cat.Desc,
                    IsActive = true,
                    ParentCategoryId = null,
                    CreatedBy = "admin-001",
                    CreatedOn = DateTime.UtcNow.AddDays(-90),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow.AddDays(-30)
                });
            }

            // Clothing Subcategories
            var clothingSubcategories = new[]
            {
                new { Id = 9, Name = "T-Shirts", Desc = "Classic and graphic t-shirts for all occasions" },
                new { Id = 10, Name = "Tank Tops", Desc = "Comfortable sleeveless tank tops" },
                new { Id = 11, Name = "Long Sleeve Shirts", Desc = "Cozy long sleeve t-shirts" },
                new { Id = 12, Name = "Hoodies & Sweatshirts", Desc = "Warm pullover hoodies and sweatshirts" },
                new { Id = 13, Name = "Zip Hoodies", Desc = "Full-zip hoodies and jackets" },
                new { Id = 14, Name = "Crewneck Sweatshirts", Desc = "Classic crewneck style sweatshirts" },
                new { Id = 15, Name = "Dresses", Desc = "Casual and dressy options for all styles" },
                new { Id = 16, Name = "Skirts", Desc = "Mini, midi, and maxi skirts" }
            };

            foreach (var subcat in clothingSubcategories)
            {
                categories.Add(new Category
                {
                    Id = subcat.Id,
                    CategoryName = subcat.Name,
                    Description = subcat.Desc,
                    IsActive = true,
                    ParentCategoryId = 1,
                    CreatedBy = "admin-001",
                    CreatedOn = DateTime.UtcNow.AddDays(-85),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow.AddDays(-25)
                });
            }

            // Accessories Subcategories
            var accessorySubcategories = new[]
            {
                new { Id = 17, Name = "Hats & Caps", Desc = "Baseball caps, beanies, and fashion hats" },
                new { Id = 18, Name = "Scarves", Desc = "Fashionable scarves and wraps" },
                new { Id = 19, Name = "Socks", Desc = "Fun and colorful socks with unique designs" },
                new { Id = 20, Name = "Face Masks", Desc = "Stylish and protective face coverings" },
                new { Id = 21, Name = "Pins & Badges", Desc = "Enamel pins and collectible badges" }
            };

            foreach (var subcat in accessorySubcategories)
            {
                categories.Add(new Category
                {
                    Id = subcat.Id,
                    CategoryName = subcat.Name,
                    Description = subcat.Desc,
                    IsActive = true,
                    ParentCategoryId = 2,
                    CreatedBy = "admin-001",
                    CreatedOn = DateTime.UtcNow.AddDays(-80),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow.AddDays(-20)
                });
            }

            // Home & Living Subcategories
            var homeSubcategories = new[]
            {
                new { Id = 22, Name = "Coffee Mugs", Desc = "Ceramic mugs for your favorite beverages" },
                new { Id = 23, Name = "Travel Mugs", Desc = "Insulated travel mugs for on-the-go" },
                new { Id = 24, Name = "Water Bottles", Desc = "Reusable water bottles with custom designs" },
                new { Id = 25, Name = "Throw Pillows", Desc = "Decorative pillows to enhance your space" },
                new { Id = 26, Name = "Blankets & Throws", Desc = "Cozy blankets with artistic designs" },
                new { Id = 27, Name = "Wall Tapestries", Desc = "Large fabric wall art and tapestries" },
                new { Id = 28, Name = "Wall Clocks", Desc = "Functional art for keeping time" },
                new { Id = 29, Name = "Candles", Desc = "Scented candles with custom labels" }
            };

            foreach (var subcat in homeSubcategories)
            {
                categories.Add(new Category
                {
                    Id = subcat.Id,
                    CategoryName = subcat.Name,
                    Description = subcat.Desc,
                    IsActive = true,
                    ParentCategoryId = 3,
                    CreatedBy = "admin-001",
                    CreatedOn = DateTime.UtcNow.AddDays(-75),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow.AddDays(-15)
                });
            }

            // Tech Accessories Subcategories
            var techSubcategories = new[]
            {
                new { Id = 30, Name = "iPhone Cases", Desc = "Protective cases for iPhone models" },
                new { Id = 31, Name = "Samsung Cases", Desc = "Samsung Galaxy phone protection" },
                new { Id = 32, Name = "Laptop Sleeves", Desc = "Padded laptop bags and sleeves" },
                new { Id = 33, Name = "Mouse Pads", Desc = "Gaming and office mouse pads" },
                new { Id = 34, Name = "Tablet Cases", Desc = "iPad and tablet protective cases" }
            };

            foreach (var subcat in techSubcategories)
            {
                categories.Add(new Category
                {
                    Id = subcat.Id,
                    CategoryName = subcat.Name,
                    Description = subcat.Desc,
                    IsActive = true,
                    ParentCategoryId = 8,
                    CreatedBy = "admin-001",
                    CreatedOn = DateTime.UtcNow.AddDays(-70),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow.AddDays(-10)
                });
            }

            modelBuilder.Entity<Category>().HasData(categories);
            
        }

        private static void SeedColors(ModelBuilder modelBuilder)
        {
            var colors = new[]
            {
                new Color { Id = 1, ColorName = "Black", ColorCode = "#000000", IsActive = true },
                new Color { Id = 2, ColorName = "White", ColorCode = "#FFFFFF", IsActive = true },
                new Color { Id = 3, ColorName = "Navy Blue", ColorCode = "#000080", IsActive = true },
                new Color { Id = 4, ColorName = "Heather Gray", ColorCode = "#808080", IsActive = true },
                new Color { Id = 5, ColorName = "Crimson Red", ColorCode = "#DC143C", IsActive = true },
                new Color { Id = 6, ColorName = "Forest Green", ColorCode = "#228B22", IsActive = true },
                new Color { Id = 7, ColorName = "Royal Blue", ColorCode = "#4169E1", IsActive = true },
                new Color { Id = 8, ColorName = "Sunshine Yellow", ColorCode = "#FFD700", IsActive = true },
                new Color { Id = 9, ColorName = "Deep Purple", ColorCode = "#663399", IsActive = true },
                new Color { Id = 10, ColorName = "Rose Pink", ColorCode = "#FF69B4", IsActive = true },
                new Color { Id = 11, ColorName = "Sunset Orange", ColorCode = "#FF4500", IsActive = true },
                new Color { Id = 12, ColorName = "Chocolate Brown", ColorCode = "#8B4513", IsActive = true },
                new Color { Id = 13, ColorName = "Sky Blue", ColorCode = "#87CEEB", IsActive = true },
                new Color { Id = 14, ColorName = "Emerald Green", ColorCode = "#50C878", IsActive = true },
                new Color { Id = 15, ColorName = "Burgundy", ColorCode = "#800020", IsActive = true }
            };

            modelBuilder.Entity<Color>().HasData(colors);
        }

        private static void SeedSizes(ModelBuilder modelBuilder)
        {
            var sizes = new[]
            {
                new Size { Id = 1, SizeName = "XS", Description = "Extra Small", IsActive = true },
                new Size { Id = 2, SizeName = "S", Description = "Small", IsActive = true },
                new Size { Id = 3, SizeName = "M", Description = "Medium", IsActive = true },
                new Size { Id = 4, SizeName = "L", Description = "Large", IsActive = true },
                new Size { Id = 5, SizeName = "XL", Description = "Extra Large", IsActive = true },
                new Size { Id = 6, SizeName = "XXL", Description = "Double Extra Large", IsActive = true },
                new Size { Id = 7, SizeName = "3XL", Description = "Triple Extra Large", IsActive = true },
                new Size { Id = 8, SizeName = "One Size", Description = "Universal Size", IsActive = true }
            };

            modelBuilder.Entity<Size>().HasData(sizes);
        }

  
        }
    }
