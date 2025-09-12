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
            SeedBaseProducts(modelBuilder);
            SeedDesigns(modelBuilder);
            SeedProductVariants(modelBuilder);
            SeedProductVariantImages(modelBuilder);
            SeedOrders(modelBuilder);
            SeedOrderItems(modelBuilder);
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

        private static void SeedBaseProducts(ModelBuilder modelBuilder)
        {
            var products = new List<BaseProduct>();
            var createdDate = DateTime.UtcNow.AddDays(-60);

            // T-Shirts (Category 9)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 1,
                    Name = "Classic Unisex T-Shirt",
                    Description = "100% cotton classic fit t-shirt, perfect for everyday wear",
                    BasePrice = 19.99m,
                    CategoryId = 9,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(5)
                },
                new BaseProduct
                {
                    Id = 2,
                    Name = "Premium Fitted T-Shirt",
                    Description = "Premium soft cotton blend with modern fitted cut",
                    BasePrice = 24.99m,
                    CategoryId = 9,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(3)
                },
                new BaseProduct
                {
                    Id = 3,
                    Name = "Vintage Style T-Shirt",
                    Description = "Retro-inspired slim fit cotton t-shirt",
                    BasePrice = 22.99m,
                    CategoryId = 9,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-5),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(1)
                }
            });

            // Hoodies (Categories 12 & 13)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 4,
                    Name = "Cozy Pullover Hoodie",
                    Description = "Ultra-soft cotton blend pullover hoodie with kangaroo pocket",
                    BasePrice = 39.99m,
                    CategoryId = 12,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-10),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(2)
                },
                new BaseProduct
                {
                    Id = 5,
                    Name = "Full-Zip Hoodie",
                    Description = "Versatile full-zip cotton hoodie with front pockets",
                    BasePrice = 44.99m,
                    CategoryId = 13,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-8),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(4)
                }
            });

            // Phone Cases (Categories 30 & 31)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 6,
                    Name = "iPhone 14 Protective Case",
                    Description = "Durable iPhone 14 case with shock absorption",
                    BasePrice = 14.99m,
                    CategoryId = 30,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-15),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(1)
                },
                new BaseProduct
                {
                    Id = 7,
                    Name = "iPhone 15 Pro Case",
                    Description = "Premium iPhone 15 Pro case with wireless charging support",
                    BasePrice = 18.99m,
                    CategoryId = 30,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-12),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate
                },
                new BaseProduct
                {
                    Id = 8,
                    Name = "Samsung Galaxy S24 Case",
                    Description = "Protective Samsung Galaxy S24 case with camera protection",
                    BasePrice = 16.99m,
                    CategoryId = 31,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-20),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(-2)
                }
            });

            // Home & Living Items
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 9,
                    Name = "Ceramic Coffee Mug",
                    Description = "High-quality 11oz ceramic mug, dishwasher and microwave safe",
                    BasePrice = 12.99m,
                    CategoryId = 22,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-25),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(-5)
                },
                new BaseProduct
                {
                    Id = 10,
                    Name = "Insulated Travel Mug",
                    Description = "15oz double-wall insulated travel mug with spill-proof lid",
                    BasePrice = 18.99m,
                    CategoryId = 23,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-30),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(-3)
                },
                new BaseProduct
                {
                    Id = 11,
                    Name = "Premium Art Print",
                    Description = "Museum-quality giclée art print on archival paper",
                    BasePrice = 16.99m,
                    CategoryId = 5,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-22),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(-1)
                },
                new BaseProduct
                {
                    Id = 12,
                    Name = "Gallery Canvas Print",
                    Description = "Gallery-wrapped canvas print with 1.5 inch depth",
                    BasePrice = 32.99m,
                    CategoryId = 5,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-18),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(1)
                },
                new BaseProduct
                {
                    Id = 13,
                    Name = "Square Throw Pillow",
                    Description = "16x16 inch throw pillow with hidden zipper and machine washable cover",
                    BasePrice = 19.99m,
                    CategoryId = 25,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-14),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(2)
                }
            });

            // Stickers and Bags
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 14,
                    Name = "Vinyl Sticker Set",
                    Description = "Pack of 3 durable vinyl stickers, weather resistant",
                    BasePrice = 4.99m,
                    CategoryId = 4,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-35),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(-8)
                },
                new BaseProduct
                {
                    Id = 15,
                    Name = "Canvas Tote Bag",
                    Description = "Eco-friendly 100% cotton canvas tote bag with reinforced handles",
                    BasePrice = 14.99m,
                    CategoryId = 7,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate.AddDays(-40),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(-6)
                }
            });

            modelBuilder.Entity<BaseProduct>().HasData(products);
        }

        private static void SeedDesigns(ModelBuilder modelBuilder)
        {
            var designs = new List<Design>();
            var random = new Random(42);

            // Curated design themes for a more realistic RedBubble experience
            var designTemplates = new[]
            {
                // Nature & Landscapes
                new { Title = "Mountain Sunrise", Description = "Majestic mountain landscape with golden sunrise", Category = "Nature" },
                new { Title = "Ocean Waves", Description = "Peaceful ocean waves in watercolor style", Category = "Nature" },
                new { Title = "Forest Silhouette", Description = "Minimalist forest treeline silhouette", Category = "Nature" },
                new { Title = "Desert Sunset", Description = "Vibrant desert landscape at golden hour", Category = "Nature" },
                new { Title = "Tropical Paradise", Description = "Exotic tropical beach scene with palm trees", Category = "Nature" },
                
                // Abstract & Geometric
                new { Title = "Geometric Harmony", Description = "Modern geometric patterns in pastel colors", Category = "Abstract" },
                new { Title = "Marble Texture", Description = "Elegant marble texture with gold veins", Category = "Abstract" },
                new { Title = "Watercolor Splash", Description = "Vibrant watercolor paint splashes", Category = "Abstract" },
                new { Title = "Minimalist Lines", Description = "Clean geometric lines and shapes", Category = "Abstract" },
                new { Title = "Galaxy Swirl", Description = "Cosmic galaxy with swirling nebula", Category = "Space" },
                
                // Typography & Quotes
                new { Title = "Coffee First", Description = "Motivational coffee-themed typography", Category = "Typography" },
                new { Title = "Adventure Awaits", Description = "Inspirational travel quote design", Category = "Typography" },
                new { Title = "Good Vibes Only", Description = "Positive mindset typography art", Category = "Typography" },
                new { Title = "Dream Big", Description = "Motivational quote in elegant script", Category = "Typography" },
                new { Title = "Stay Wild", Description = "Nature-inspired motivational text", Category = "Typography" },
                
                // Animals & Characters
                new { Title = "Cute Cat Face", Description = "Adorable cartoon cat illustration", Category = "Animals" },
                new { Title = "Majestic Wolf", Description = "Realistic wolf portrait in natural setting", Category = "Animals" },
                new { Title = "Lazy Panda", Description = "Sleepy panda bear cartoon character", Category = "Animals" },
                new { Title = "Colorful Butterfly", Description = "Vibrant butterfly with rainbow wings", Category = "Animals" },
                new { Title = "Ocean Whale", Description = "Graceful whale swimming in deep blue", Category = "Animals" },
                
                // Floral & Botanical
                new { Title = "Rose Garden", Description = "Elegant vintage rose pattern", Category = "Floral" },
                new { Title = "Tropical Leaves", Description = "Modern monstera leaf pattern", Category = "Floral" },
                new { Title = "Wildflower Meadow", Description = "Delicate wildflower illustration", Category = "Floral" },
                new { Title = "Succulent Collection", Description = "Cute succulent plant arrangement", Category = "Floral" },
                new { Title = "Cherry Blossoms", Description = "Japanese cherry blossom branch in soft pink", Category = "Floral" }
            };

            // Generate 100 designs with varied themes
            for (int i = 1; i <= 100; i++)
            {
                var template = designTemplates[random.Next(designTemplates.Length)];
                var baseDate = DateTime.UtcNow.AddDays(-random.Next(1, 180));

                designs.Add(new Design
                {
                    Id = i,
                    Title = $"{template.Title} #{i}",
                    Description = $"{template.Description} - {template.Category} themed artwork",
                    Price = Math.Round((decimal)(random.NextDouble() * 8 + 2), 2), // $2-10
                    IsActive = true,
                    ImageUrl = $"https://picsum.photos/seed/design{i}/800/600",
                    FileName = $"design_{i}.jpg",
                    AltText = $"{template.Title} design artwork",
                    AdminId = "admin-001", // Admin creates all designs now
                    CreatedBy = "admin-001",
                    CreatedOn = baseDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = baseDate.AddDays(random.Next(1, 30))
                });
            }

            modelBuilder.Entity<Design>().HasData(designs);
        }

        private static void SeedProductVariants(ModelBuilder modelBuilder)
        {
            var productVariants = new List<ProductVariant>();
            var random = new Random(456);
            int variantId = 1;

            // Generate variants for each base product
            for (int productId = 1; productId <= 15; productId++)
            {
                var baseProdPrice = GetBaseProductPrice(productId);
                var isClothing = productId <= 5; // T-shirts and hoodies need sizes
                var designCount = productId <= 8 ? 12 : 8; // More designs for popular items
                var colorCount = isClothing ? 8 : 5; // More colors for clothing

                // Select designs (use different ranges for variety)
                var designStart = ((productId - 1) * 10) % 90 + 1;
                var selectedDesigns = Enumerable.Range(designStart, designCount).ToArray();

                foreach (var designId in selectedDesigns)
                {
                    var selectedColors = Enumerable.Range(1, colorCount).ToArray();

                    foreach (var colorId in selectedColors)
                    {
                        var sizeIds = isClothing ? new[] { 1, 2, 3, 4, 5, 6 } : new[] { 8 };

                        foreach (var sizeId in sizeIds)
                        {
                            if (variantId > 400) break; // Limit to prevent too many variants

                            var designPrice = Math.Round((decimal)(random.NextDouble() * 6 + 2), 2); // $2-8
                            var totalPrice = baseProdPrice + designPrice;

                            productVariants.Add(new ProductVariant
                            {
                                Id = variantId++,
                                Price = totalPrice,
                               
                                IsActive = true,
                                BaseProductId = productId,
                                DesignId = designId,
                                ColorId = colorId,
                                SizeId = sizeId,
                                //CreatedBy = "admin-001",
                                //CreatedOn = DateTime.UtcNow.AddDays(-random.Next(1, 45)),
                                //LastModifiedBy = "admin-001",
                                //LastModifiedOn = DateTime.UtcNow.AddDays(-random.Next(1, 20))
                            });
                        }
                    }
                }
            }

            modelBuilder.Entity<ProductVariant>().HasData(productVariants.Take(350));
        }

        private static decimal GetBaseProductPrice(int productId)
        {
            return productId switch
            {
                1 => 19.99m,  // Classic T-Shirt
                2 => 24.99m,  // Premium T-Shirt
                3 => 22.99m,  // Vintage T-Shirt
                4 => 39.99m,  // Pullover Hoodie
                5 => 44.99m,  // Zip Hoodie
                6 => 14.99m,  // iPhone 14 Case
                7 => 18.99m,  // iPhone 15 Case
                8 => 16.99m,  // Samsung Case
                9 => 12.99m,  // Ceramic Mug
                10 => 18.99m, // Travel Mug
                11 => 16.99m, // Art Print
                12 => 32.99m, // Canvas Print
                13 => 19.99m, // Throw Pillow
                14 => 4.99m,  // Sticker Pack
                15 => 14.99m, // Tote Bag
                _ => 19.99m
            };
        }

        private static void SeedProductVariantImages(ModelBuilder modelBuilder)
        {
            var images = new List<ProductVariantImages>();
            var random = new Random(789);

            // More realistic mockup URLs for different product types
            var clothingMockups = new[]
            {
                "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", // T-shirt on person
                "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", // Hoodie mockup
                "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", // Clothing flat lay
                "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop"  // Shirt hanging
            };

            var accessoryMockups = new[]
            {
                "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", // Phone case
                "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", // Mug
                "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", // Home items
                "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop"  // Stickers
            };

            // Generate 2-4 images per product variant (first 200 variants for performance)
            for (int variantId = 1; variantId <= 200; variantId++)
            {
                int imageCount = random.Next(2, 5);
                var isClothingVariant = variantId <= 120; // Approximate clothing variants
                var mockupPool = isClothingVariant ? clothingMockups : accessoryMockups;

                for (int j = 0; j < imageCount; j++)
                {
                    images.Add(new ProductVariantImages
                    {
                        Id = (variantId - 1) * 4 + j + 1,
                        ImageUrl = mockupPool[random.Next(mockupPool.Length)],
                        FileName = $"variant_{variantId}_mockup_{j + 1}.jpg",
                        AltText = $"Product variant {variantId} mockup view {j + 1}",
                        IsPrimary = j == 0,
                        IsActive = true,
                        ProductVariantId = variantId,
                        //CreatedBy = "admin-001",
                        //CreatedOn = DateTime.UtcNow.AddDays(-random.Next(1, 40)),
                        //LastModifiedBy = "admin-001",
                        //LastModifiedOn = DateTime.UtcNow.AddDays(-random.Next(1, 20))
                    });
                }
            }

            modelBuilder.Entity<ProductVariantImages>().HasData(images);
        }

        private static void SeedOrders(ModelBuilder modelBuilder)
        {
            var orders = new List<Order>();
            var random = new Random(999);

            var shippingData = new[]
            {
                new { Country = "United States", Cities = new[] { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" } },
                new { Country = "Canada", Cities = new[] { "Toronto", "Vancouver", "Montreal", "Calgary", "Ottawa" } },
                new { Country = "United Kingdom", Cities = new[] { "London", "Manchester", "Birmingham", "Liverpool", "Bristol" } },
                new { Country = "Australia", Cities = new[] { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide" } },
                new { Country = "Germany", Cities = new[] { "Berlin", "Munich", "Hamburg", "Cologne", "Frankfurt" } }
            };

            var streets = new[] { "Main St", "Oak Ave", "Pine Rd", "Elm Dr", "Maple Ln", "Cedar Way", "Park Blvd", "First St", "Second Ave", "Broadway" };

            // Generate 75 orders across the 30 customers
            for (int i = 1; i <= 75; i++)
            {
                var customerId = $"customer-{random.Next(1, 31):D3}";
                var orderDate = DateTime.UtcNow.AddDays(-random.Next(1, 365));
                var status = (OrderStatus)random.Next(0, 5);

                var shippingLocation = shippingData[random.Next(shippingData.Length)];
                var city = shippingLocation.Cities[random.Next(shippingLocation.Cities.Length)];

                orders.Add(new Order
                {
                    Id = i,
                    TotalAmount = 0, // Will be calculated when we add order items
                    Status = status,
                    ShippingAddress = $"{random.Next(100, 9999)} {streets[random.Next(streets.Length)]}",
                    ShippingCity = city,
                    ShippingCountry = shippingLocation.Country,
                    ShippingPostalCode = GeneratePostalCode(shippingLocation.Country, random),
                    CustomerId = customerId,
                    CreatedBy = customerId,
                    CreatedOn = orderDate,
                    LastModifiedBy = customerId,
                    LastModifiedOn = orderDate.AddHours(random.Next(1, 72))
                });
            }

            modelBuilder.Entity<Order>().HasData(orders);
        }

            //var firstOrder = new Order
            //{
            //    Customer = customer,
            //    TotalAmount = variants[0].Price * 2,
            //    Status = OrderStatus.Shipped,
            //    ShippingAddress = "123 Test St",
            //    ShippingCity = "Testville",
            //    ShippingCountry = "Testland",
            //    ShippingPostalCode = "12345",
            //    OrderDate = DateTime.UtcNow.AddDays(-5),
            //    UpdatedAt = DateTime.UtcNow.AddDays(-3),
            //    OrderItems = new List<OrderItem>
            //    {
            //        new OrderItem { ProductVariant = variants[0], Quantity = 2, UnitPrice = variants[0].Price, TotalPrice = variants[0].Price * 2 }
            //    }
            //};
            //orders.Add(firstOrder);

            //if (variants.Count >= 2)
            //{
            //    var secondOrderItems = new List<OrderItem>
            //    {
            //        new OrderItem { ProductVariant = variants[1], Quantity = 1, UnitPrice = variants[1].Price, TotalPrice = variants[1].Price }
            //    };
            //    if (variants.Count >= 3)
            //    {
            //        secondOrderItems.Add(new OrderItem { ProductVariant = variants[2], Quantity = 1, UnitPrice = variants[2].Price, TotalPrice = variants[2].Price });
            //    }

            //    var secondOrder = new Order
            //    {
            //        Customer = jane,
            //        TotalAmount = variants[1].Price + (variants.Count >= 3 ? variants[2].Price : 0),
            //        Status = OrderStatus.Processing,
            //        ShippingAddress = "456 Sample Ave",
            //        ShippingCity = "Sampletown",
            //        ShippingCountry = "Sampleland",
            //        ShippingPostalCode = "67890",
            //        OrderDate = DateTime.UtcNow.AddDays(-2),
            //        UpdatedAt = DateTime.UtcNow.AddDays(-1),
            //        OrderItems = secondOrderItems
            //    };
            //    orders.Add(secondOrder);
            //}

            //var thirdOrder = new Order
            //{
            //    Customer = customer,
            //    TotalAmount = variants[0].Price * 3,
            //    Status = OrderStatus.Pending,
            //    ShippingAddress = "789 Demo Rd",
            //    ShippingCity = "Democity",
            //    ShippingCountry = "Demoland",
            //    ShippingPostalCode = "11111",
            //    OrderDate = DateTime.UtcNow.AddDays(-1),
            //    UpdatedAt = DateTime.UtcNow.AddDays(-1),
            //    OrderItems = new List<OrderItem>
            //    {
            //        new OrderItem { ProductVariant = variants[0], Quantity = 3, UnitPrice = variants[0].Price, TotalPrice = variants[0].Price * 3 }
            //    }
            //};
            //orders.Add(thirdOrder);

            //await context.Orders.AddRangeAsync(orders);
            EnsureAuditFields(context);
            await context.SaveChangesAsync();
        }
    }
}