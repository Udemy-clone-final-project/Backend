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
            SeedBaseProducts(modelBuilder);
            SeedDesigns(modelBuilder);
            SeedProductVariants(modelBuilder);
            SeedProductVariantImages(modelBuilder);
            SeedDeliveryMethods(modelBuilder);
        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);
            
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Description = "System Administrator with full access to manage products and designs",
                    CreatedAt = baseDate,
                    IsActive = true
                },
                new ApplicationRole
                {
                    Id = "2",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                    Description = "Customer who can browse and purchase products",
                    CreatedAt = baseDate,
                    IsActive = true
                }
            );
        }

        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var users = new List<ApplicationUser>();
            var baseDate = new DateTime(2024, 1, 1);

            // Admin User
            users.Add(new ApplicationUser
            {
                Id = "admin-001",
                UserName = "admin@redbubble.com",
                NormalizedUserName = "ADMIN@REDBUBBLE.COM",
                Email = "admin@redbubble.com",
                NormalizedEmail = "ADMIN@REDBUBBLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null!, "Admin123!"),
                SecurityStamp = Guid.NewGuid().ToString(),
                DisplayName = "System Administrator",
                CreatedAt = baseDate,
                UpdatedAt = baseDate,
                IsActive = true
            });

            // Customer Users (30 customers)
            string[] customerNames = {
                "John Doe", "Jane Smith", "Michael Johnson", "Sarah Williams", "David Brown",
                "Emily Davis", "Christopher Wilson", "Jessica Martinez", "Daniel Anderson", "Ashley Taylor",
                "Matthew Thomas", "Amanda Jackson", "Joshua White", "Stephanie Harris", "Andrew Martin",
                "Nicole Thompson", "Ryan Garcia", "Heather Martinez", "Kevin Robinson", "Rachel Clark",
                "Brandon Rodriguez", "Lauren Lewis", "Tyler Lee", "Samantha Walker", "Justin Hall",
                "Megan Allen", "Jacob Young", "Kayla King", "Nathan Wright", "Brittany Lopez"
            };

            for (int i = 0; i < 30; i++)
            {
                var email = $"customer{i + 1:D3}@example.com";
                users.Add(new ApplicationUser
                {
                    Id = $"customer-{i + 1:D3}",
                    UserName = email,
                    NormalizedUserName = email.ToUpper(),
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null!, "Customer123!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DisplayName = customerNames[i],
                    CreatedAt = baseDate.AddDays(-new Random(i).Next(1, 365)),
                    UpdatedAt = baseDate.AddDays(-new Random(i).Next(1, 30)),
                    IsActive = true
                });
            }

            modelBuilder.Entity<ApplicationUser>().HasData(users);
        }

        private static void SeedUserRoles(ModelBuilder modelBuilder)
        {
            var userRoles = new List<IdentityUserRole<string>>();

            // Admin role
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = "admin-001",
                RoleId = "1"
            });

            // Customer roles
            for (int i = 1; i <= 30; i++)
            {
                userRoles.Add(new IdentityUserRole<string>
                {
                    UserId = $"customer-{i:D3}",
                    RoleId = "2"
                });
            }

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }

        private static void SeedAddresses(ModelBuilder modelBuilder)
        {
            var addresses = new List<Domain.Entities.Models.Identity.Address>();
            var random = new Random(123);

            // Generate ONE address for each customer (One-to-One relationship)
            for (int i = 1; i <= 30; i++)
            {
                var customerId = $"customer-{i:D3}";

                addresses.Add(new Domain.Entities.Models.Identity.Address
                {
                    Id = i, // Use customer number as ID to ensure uniqueness
                    FirstName = $"Customer{i}",
                    LastName = "User",
                    Street = $"{random.Next(100, 9999)} Main St",
                    City = GetRandomCity(random),
                    Country = GetRandomCountry(random),
                    ApplicationUserId = customerId
                });
            }

            modelBuilder.Entity<Domain.Entities.Models.Identity.Address>().HasData(addresses);
        }

        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            var categories = new List<Category>();
            var baseDate = new DateTime(2024, 1, 1);

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
                    CreatedOn = baseDate.AddDays(-90),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = baseDate.AddDays(-30)
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
                    CreatedOn = baseDate.AddDays(-85),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = baseDate.AddDays(-25)
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
                    CreatedOn = baseDate.AddDays(-80),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = baseDate.AddDays(-20)
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
                    CreatedOn = baseDate.AddDays(-75),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = baseDate.AddDays(-15)
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
                    ParentCategoryId = 8, // Fixed: Tech Accessories category
                    CreatedBy = "admin-001",
                    CreatedOn = baseDate.AddDays(-70),
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = baseDate.AddDays(-10)
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
            var printAreas = new List<BaseProductPrintArea>();
            var templates = new List<BaseProductTemplate>();
            var productSizes = new List<BaseProductSize>();
            var productColors = new List<BaseProductColor>();
            var baseDate = new DateTime(2024, 1, 1);
            var createdDate = baseDate.AddDays(-60);
            
            // Global counters for junction table IDs
            int printAreaId = 1;
            int templateId = 1;
            int productSizeId = 1;
            int productColorId = 1;

            // T-Shirts (Category 9 - T-Shirts)
            var tshirtProducts = new[]
            {
                new { Id = 1, Name = "Classic T-Shirt", Description = "Comfortable cotton t-shirt with a relaxed fit", BasePrice = 19.99m, HasSizes = true, HasColors = true },
                new { Id = 2, Name = "Premium T-Shirt", Description = "High-quality cotton t-shirt with a modern fit", BasePrice = 24.99m, HasSizes = true, HasColors = true },
                new { Id = 3, Name = "Vintage T-Shirt", Description = "Soft vintage-style t-shirt with a worn-in feel", BasePrice = 22.99m, HasSizes = true, HasColors = true }
            };

            foreach (var product in tshirtProducts)
            {
                products.Add(new BaseProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    CategoryId = 9, // T-Shirts category
                    BasePrice = product.BasePrice,
                    HasSizes = product.HasSizes,
                    HasColors = product.HasColors,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                });

                // Add print areas for t-shirts
                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Front",
                    Width = 12.0m,
                    Height = 16.0m,
                    PositionX = 100,
                    PositionY = 150,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 1
                });

                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Back",
                    Width = 12.0m,
                    Height = 16.0m,
                    PositionX = 100,
                    PositionY = 150,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 2
                });

                // Add templates for t-shirts
                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Front",
                    TemplateUrl = "/templates/tshirt-front-template.png",
                    MockupUrl = "/mockups/tshirt-front-mockup.jpg",
                    FlatMockupUrl = "/mockups/tshirt-front-flat.jpg",
                    IsPrimary = true,
                    DisplayOrder = 1,
                    IsActive = true,
                    TemplateWidth = 800,
                    TemplateHeight = 1000
                });

                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Back",
                    TemplateUrl = "/templates/tshirt-back-template.png",
                    MockupUrl = "/mockups/tshirt-back-mockup.jpg",
                    IsPrimary = false,
                    DisplayOrder = 2,
                    IsActive = true,
                    TemplateWidth = 800,
                    TemplateHeight = 1000
                });

                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Side",
                    TemplateUrl = "/templates/tshirt-side-template.png",
                    MockupUrl = "/mockups/tshirt-side-mockup.jpg",
                    IsPrimary = false,
                    DisplayOrder = 3,
                    IsActive = true,
                    TemplateWidth = 600,
                    TemplateHeight = 800
                });

                // Add available sizes for t-shirts
                for (int sizeId = 1; sizeId <= 6; sizeId++) // XS to XXL
                {
                    productSizes.Add(new BaseProductSize
                    {
                        Id = productSizeId++,
                        BaseProductId = product.Id,
                        SizeId = sizeId,
                        IsActive = true,
                        PriceModifier = sizeId > 4 ? (sizeId - 4) * 2.0m : 0 // Extra cost for XL+
                    });
                }

                // Add available colors for t-shirts
                for (int colorId = 1; colorId <= 8; colorId++) // First 8 colors
                {
                    productColors.Add(new BaseProductColor
                    {
                        Id = productColorId++,
                        BaseProductId = product.Id,
                        ColorId = colorId,
                        IsActive = true,
                        PriceModifier = 0
                    });
                }
            }

            // Hoodies (Category 10 - Hoodies)
            var hoodieProducts = new[]
            {
                new { Id = 4, Name = "Classic Hoodie", Description = "Warm and comfortable hoodie for casual wear", BasePrice = 39.99m, HasSizes = true, HasColors = true },
                new { Id = 5, Name = "Premium Hoodie", Description = "High-quality hoodie with premium materials", BasePrice = 49.99m, HasSizes = true, HasColors = true }
            };

            foreach (var product in hoodieProducts)
            {
                products.Add(new BaseProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    CategoryId = 10, // Hoodies category
                    BasePrice = product.BasePrice,
                    HasSizes = product.HasSizes,
                    HasColors = product.HasColors,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                });

                // Add print areas for hoodies
                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Front",
                    Width = 12.0m,
                    Height = 16.0m,
                    PositionX = 100,
                    PositionY = 150,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 1
                });

                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Back",
                    Width = 12.0m,
                    Height = 16.0m,
                    PositionX = 100,
                    PositionY = 150,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 2
                });

                // Add templates for hoodies
                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Front",
                    TemplateUrl = "/templates/hoodie-front-template.png",
                    MockupUrl = "/mockups/hoodie-front-mockup.jpg",
                    IsPrimary = true,
                    DisplayOrder = 1,
                    IsActive = true,
                    TemplateWidth = 800,
                    TemplateHeight = 1000
                });

                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Back",
                    TemplateUrl = "/templates/hoodie-back-template.png",
                    MockupUrl = "/mockups/hoodie-back-mockup.jpg",
                    IsPrimary = false,
                    DisplayOrder = 2,
                    IsActive = true,
                    TemplateWidth = 800,
                    TemplateHeight = 1000
                });

                // Add available sizes for hoodies
                for (int sizeId = 1; sizeId <= 6; sizeId++) // XS to XXL
                {
                    productSizes.Add(new BaseProductSize
                    {
                        Id = productSizeId++,
                        BaseProductId = product.Id,
                        SizeId = sizeId,
                        IsActive = true,
                        PriceModifier = sizeId > 4 ? (sizeId - 4) * 3.0m : 0 // Extra cost for XL+
                    });
                }

                // Add available colors for hoodies
                for (int colorId = 1; colorId <= 6; colorId++) // First 6 colors
                {
                    productColors.Add(new BaseProductColor
                    {
                        Id = productColorId++,
                        BaseProductId = product.Id,
                        ColorId = colorId,
                        IsActive = true,
                        PriceModifier = 0
                    });
                }
            }

            // Tank Tops (Category 11 - Tank Tops)
            var tankTopProducts = new[]
            {
                new { Id = 6, Name = "Classic Tank Top", Description = "Lightweight tank top perfect for summer", BasePrice = 16.99m, HasSizes = true, HasColors = true },
                new { Id = 7, Name = "Athletic Tank Top", Description = "Moisture-wicking tank top for active wear", BasePrice = 19.99m, HasSizes = true, HasColors = true }
            };

            foreach (var product in tankTopProducts)
            {
                products.Add(new BaseProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    CategoryId = 11, // Tank Tops category
                    BasePrice = product.BasePrice,
                    HasSizes = product.HasSizes,
                    HasColors = product.HasColors,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                });

                // Add print areas for tank tops
                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Front",
                    Width = 10.0m,
                    Height = 12.0m,
                    PositionX = 100,
                    PositionY = 120,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 1
                });

                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Back",
                    Width = 10.0m,
                    Height = 12.0m,
                    PositionX = 100,
                    PositionY = 120,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 2
                });

                // Add templates for tank tops
                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Front",
                    TemplateUrl = "/templates/tank-front-template.png",
                    MockupUrl = "/mockups/tank-front-mockup.jpg",
                    IsPrimary = true,
                    DisplayOrder = 1,
                    IsActive = true,
                    TemplateWidth = 600,
                    TemplateHeight = 800
                });

                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Back",
                    TemplateUrl = "/templates/tank-back-template.png",
                    MockupUrl = "/mockups/tank-back-mockup.jpg",
                    IsPrimary = false,
                    DisplayOrder = 2,
                    IsActive = true,
                    TemplateWidth = 600,
                    TemplateHeight = 800
                });

                // Add available sizes for tank tops
                for (int sizeId = 1; sizeId <= 6; sizeId++) // XS to XXL
                {
                    productSizes.Add(new BaseProductSize
                    {
                        Id = productSizeId++,
                        BaseProductId = product.Id,
                        SizeId = sizeId,
                        IsActive = true,
                        PriceModifier = sizeId > 4 ? (sizeId - 4) * 1.5m : 0 // Extra cost for XL+
                    });
                }

                // Add available colors for tank tops
                for (int colorId = 1; colorId <= 8; colorId++) // First 8 colors
                {
                    productColors.Add(new BaseProductColor
                    {
                        Id = productColorId++,
                        BaseProductId = product.Id,
                        ColorId = colorId,
                        IsActive = true,
                        PriceModifier = 0
                    });
                }
            }

            // Mugs (Category 22 - Coffee Mugs)
            var mugProducts = new[]
            {
                new { Id = 8, Name = "Classic Ceramic Mug", Description = "High-quality ceramic mug for beverages", BasePrice = 11.99m, HasSizes = false, HasColors = true },
                new { Id = 9, Name = "Travel Mug", Description = "Insulated travel mug for on-the-go", BasePrice = 16.99m, HasSizes = false, HasColors = true }
            };

            foreach (var product in mugProducts)
            {
                products.Add(new BaseProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    CategoryId = 22, // Coffee Mugs category
                    BasePrice = product.BasePrice,
                    HasSizes = product.HasSizes,
                    HasColors = product.HasColors,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                });

                // Add print areas for mugs
                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Front",
                    Width = 8.0m,
                    Height = 3.5m,
                    PositionX = 50,
                    PositionY = 100,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 1
                });

                // Add templates for mugs
                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Front",
                    TemplateUrl = "/templates/mug-front-template.png",
                    MockupUrl = "/mockups/mug-front-mockup.jpg",
                    IsPrimary = true,
                    DisplayOrder = 1,
                    IsActive = true,
                    TemplateWidth = 400,
                    TemplateHeight = 500
                });

                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Side",
                    TemplateUrl = "/templates/mug-side-template.png",
                    MockupUrl = "/mockups/mug-side-mockup.jpg",
                    IsPrimary = false,
                    DisplayOrder = 2,
                    IsActive = true,
                    TemplateWidth = 300,
                    TemplateHeight = 400
                });

                // Add available colors for mugs
                for (int colorId = 1; colorId <= 6; colorId++) // First 6 colors
                {
                    productColors.Add(new BaseProductColor
                    {
                        Id = productColorId++,
                        BaseProductId = product.Id,
                        ColorId = colorId,
                        IsActive = true,
                        PriceModifier = 0
                    });
                }
            }

            // Posters (Category 5 - Wall Art)
            var posterProducts = new[]
            {
                new { Id = 10, Name = "Standard Poster", Description = "High-quality poster print for wall decoration", BasePrice = 8.99m, HasSizes = true, HasColors = false },
                new { Id = 11, Name = "Premium Poster", Description = "Premium quality poster with enhanced colors", BasePrice = 12.99m, HasSizes = true, HasColors = false }
            };

            foreach (var product in posterProducts)
            {
                products.Add(new BaseProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    CategoryId = 5, // Wall Art category
                    BasePrice = product.BasePrice,
                    HasSizes = product.HasSizes,
                    HasColors = product.HasColors,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                });

                // Add print areas for posters
                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Full",
                    Width = 18.0m,
                    Height = 24.0m,
                    PositionX = 0,
                    PositionY = 0,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 1
                });

                // Add templates for posters
                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Front",
                    TemplateUrl = "/templates/poster-template.png",
                    MockupUrl = "/mockups/poster-mockup.jpg",
                    IsPrimary = true,
                    DisplayOrder = 1,
                    IsActive = true,
                    TemplateWidth = 1200,
                    TemplateHeight = 1600
                });

                // Add available sizes for posters (using existing size IDs)
                var posterSizes = new[] { 1, 2, 3, 4 }; // Use existing sizes XS, S, M, L
                for (int i = 0; i < posterSizes.Length; i++)
                {
                    productSizes.Add(new BaseProductSize
                    {
                        Id = productSizeId++,
                        BaseProductId = product.Id,
                        SizeId = posterSizes[i],
                        IsActive = true,
                        PriceModifier = i * 2.0m // Extra cost for larger sizes
                    });
                }
            }

            // Phone Cases (Category 30 - iPhone Cases)
            var phoneCaseProducts = new[]
            {
                new { Id = 12, Name = "iPhone Case", Description = "Protective case for iPhone models", BasePrice = 15.99m, HasSizes = false, HasColors = true },
                new { Id = 13, Name = "Samsung Case", Description = "Protective case for Samsung Galaxy", BasePrice = 15.99m, HasSizes = false, HasColors = true }
            };

            foreach (var product in phoneCaseProducts)
            {
                products.Add(new BaseProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    CategoryId = 30, // iPhone Cases category
                    BasePrice = product.BasePrice,
                    HasSizes = product.HasSizes,
                    HasColors = product.HasColors,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                });

                // Add print areas for phone cases
                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Back",
                    Width = 3.0m,
                    Height = 5.5m,
                    PositionX = 25,
                    PositionY = 50,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 1
                });

                // Add templates for phone cases
                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Back",
                    TemplateUrl = "/templates/phone-case-template.png",
                    MockupUrl = "/mockups/phone-case-mockup.jpg",
                    IsPrimary = true,
                    DisplayOrder = 1,
                    IsActive = true,
                    TemplateWidth = 300,
                    TemplateHeight = 600
                });

                // Add available colors for phone cases
                for (int colorId = 1; colorId <= 8; colorId++) // First 8 colors
                {
                    productColors.Add(new BaseProductColor
                    {
                        Id = productColorId++,
                        BaseProductId = product.Id,
                        ColorId = colorId,
                        IsActive = true,
                        PriceModifier = 0
                    });
                }
            }

            // Stickers (Category 4 - Stickers & Decals)
            var stickerProducts = new[]
            {
                new { Id = 100, Name = "Vinyl Sticker Set", Description = "Pack of 3 durable vinyl stickers, weather resistant", BasePrice = 4.99m, HasSizes = false, HasColors = true },
                new { Id = 101, Name = "Decal Sticker", Description = "High-quality decal sticker for laptops, phones, and more", BasePrice = 2.99m, HasSizes = false, HasColors = true },
                new { Id = 102, Name = "Bumper Sticker", Description = "Weather-resistant bumper sticker for cars and vehicles", BasePrice = 3.99m, HasSizes = false, HasColors = true }
            };

            foreach (var product in stickerProducts)
            {
                products.Add(new BaseProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    CategoryId = 4, // Stickers & Decals category
                    BasePrice = product.BasePrice,
                    HasSizes = product.HasSizes,
                    HasColors = product.HasColors,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                });

                // Add print areas for stickers
                printAreas.Add(new BaseProductPrintArea
                {
                    Id = printAreaId++,
                    BaseProductId = product.Id,
                    AreaName = "Full",
                    Width = 3.0m,
                    Height = 3.0m,
                    PositionX = 0,
                    PositionY = 0,
                    MinDPI = 300,
                    IsActive = true,
                    DisplayOrder = 1
                });

                // Add templates for stickers
                templates.Add(new BaseProductTemplate
                {
                    Id = templateId++,
                    BaseProductId = product.Id,
                    ViewName = "Front",
                    TemplateUrl = "/templates/sticker-template.png",
                    MockupUrl = "/mockups/sticker-mockup.jpg",
                    IsPrimary = true,
                    DisplayOrder = 1,
                    IsActive = true,
                    TemplateWidth = 300,
                    TemplateHeight = 300
                });

                // Add available colors for stickers
                for (int colorId = 1; colorId <= 8; colorId++) // First 8 colors
                {
                    productColors.Add(new BaseProductColor
                    {
                        Id = productColorId++,
                        BaseProductId = product.Id,
                        ColorId = colorId,
                        IsActive = true,
                        PriceModifier = 0
                    });
                }
            }

            // Add the data to the model builder
            modelBuilder.Entity<BaseProduct>().HasData(products);
            modelBuilder.Entity<BaseProductPrintArea>().HasData(printAreas);
            modelBuilder.Entity<BaseProductTemplate>().HasData(templates);
            modelBuilder.Entity<BaseProductSize>().HasData(productSizes);
            modelBuilder.Entity<BaseProductColor>().HasData(productColors);
        }

        private static void SeedDesigns(ModelBuilder modelBuilder)
        {
            var designs = new List<Design>();
            var random = new Random(42);
            var baseDate = new DateTime(2024, 1, 1);

            // Curated design themes for a more realistic RedBubble experience
            var designTemplates = new[]
            {
                // Nature & Landscapes
                new { Title = "Mountain Sunset", Description = "Breathtaking mountain landscape at sunset" },
                new { Title = "Forest Path", Description = "Peaceful forest trail through tall trees" },
                new { Title = "Ocean Waves", Description = "Powerful ocean waves crashing on shore" },
                new { Title = "Desert Cactus", Description = "Majestic saguaro cactus in desert landscape" },
                new { Title = "Autumn Leaves", Description = "Colorful autumn leaves falling gracefully" },
                
                // Abstract & Geometric
                new { Title = "Geometric Mandala", Description = "Intricate geometric mandala pattern" },
                new { Title = "Colorful Spiral", Description = "Vibrant spiral design with flowing colors" },
                new { Title = "Minimalist Lines", Description = "Clean minimalist line art design" },
                new { Title = "Abstract Watercolor", Description = "Flowing watercolor abstract composition" },
                new { Title = "Geometric Triangles", Description = "Modern geometric triangle pattern" },
                
                // Typography & Text
                new { Title = "Motivational Quote", Description = "Inspirational typography design" },
                new { Title = "Vintage Script", Description = "Elegant vintage script typography" },
                new { Title = "Modern Sans Serif", Description = "Clean modern sans serif typography" },
                new { Title = "Hand Lettering", Description = "Beautiful hand-drawn lettering art" },
                new { Title = "Bold Typography", Description = "Strong and impactful typography design" },
                
                // Animals & Wildlife
                new { Title = "Majestic Eagle", Description = "Powerful eagle in flight" },
                new { Title = "Cute Cat", Description = "Adorable cat illustration" },
                new { Title = "Tropical Fish", Description = "Colorful tropical fish in coral reef" },
                new { Title = "Forest Wolf", Description = "Mysterious wolf in moonlit forest" },
                new { Title = "Butterfly Garden", Description = "Colorful butterflies in blooming garden" },
                
                // Space & Sci-Fi
                new { Title = "Galaxy Nebula", Description = "Stunning galaxy nebula in deep space" },
                new { Title = "Rocket Launch", Description = "Rocket launching into space" },
                new { Title = "Alien Planet", Description = "Mysterious alien planet landscape" },
                new { Title = "Cosmic Stars", Description = "Twinkling stars in deep space" },
                new { Title = "Space Station", Description = "Futuristic space station in orbit" },
                
                // Pop Culture & Fun
                new { Title = "Retro Gaming", Description = "Nostalgic retro gaming pixel art" },
                new { Title = "Coffee Lover", Description = "Coffee-themed design for caffeine enthusiasts" },
                new { Title = "Music Notes", Description = "Musical notes and instruments" },
                new { Title = "Vintage Camera", Description = "Classic vintage camera illustration" },
                new { Title = "Travel Adventure", Description = "Wanderlust travel and adventure theme" },
                
                // Art & Creative
                new { Title = "Watercolor Flowers", Description = "Delicate watercolor flower arrangement" },
                new { Title = "Sketch Portrait", Description = "Hand-drawn portrait sketch" },
                new { Title = "Pop Art Style", Description = "Bold pop art inspired design" },
                new { Title = "Zen Circle", Description = "Minimalist zen circle meditation" },
                new { Title = "Art Deco Pattern", Description = "Elegant art deco geometric pattern" }
            };

            // Generate 50 designs with varied themes
            for (int i = 1; i <= 50; i++)
            {
                var template = designTemplates[random.Next(designTemplates.Length)];
                var designDate = baseDate.AddDays(-random.Next(1, 180));

                designs.Add(new Design
                {
                    Id = i,
                    Title = $"{template.Title} #{i}",
                    Description = template.Description,
                    Price = Math.Round((decimal)(random.NextDouble() * 8 + 2), 2), // $2-10
                    IsActive = true,
                    ImageUrl = $"https://picsum.photos/seed/design{i}/800/600",
                    FileName = $"design_{i}.jpg",
                    AltText = $"{template.Title} design artwork",
                    AdminId = "admin-001", // Admin creates all designs now
                    CreatedBy = "admin-001",
                    CreatedOn = designDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = designDate.AddDays(random.Next(1, 30))
                });
            }

            modelBuilder.Entity<Design>().HasData(designs);
        }

        private static void SeedProductVariants(ModelBuilder modelBuilder)
        {
            var productVariants = new List<ProductVariant>();
            var random = new Random(456);
            var baseDate = new DateTime(2024, 1, 1);
            int variantId = 1;

            // Generate variants for sticker products FIRST (IDs 100-102) - Priority
            for (int productId = 100; productId <= 102; productId++)
            {
                var baseProdPrice = GetBaseProductPrice(productId);

                // Generate variants for different designs, colors, and sizes
                for (int designId = 1; designId <= 25; designId++) // Use first 25 designs
                {
                    // Get available colors and sizes for this product
                    var availableColors = GetAvailableColorsForProduct(productId);
                    var availableSizes = GetAvailableSizesForProduct(productId);

                    foreach (var colorId in availableColors)
                    {
                        foreach (var sizeId in availableSizes)
                        {
                            if (variantId > 600) break; // Limit to prevent too many variants

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
                                SizeId = sizeId
                            });
                        }
                    }
                }
            }

            // Generate variants for other base products (IDs 1-13)
            for (int productId = 1; productId <= 13; productId++)
            {
                var baseProdPrice = GetBaseProductPrice(productId);

                // Generate variants for different designs, colors, and sizes
                for (int designId = 1; designId <= 25; designId++) // Use first 25 designs
                {
                    // Get available colors and sizes for this product
                    var availableColors = GetAvailableColorsForProduct(productId);
                    var availableSizes = GetAvailableSizesForProduct(productId);

                    foreach (var colorId in availableColors)
                    {
                        foreach (var sizeId in availableSizes)
                        {
                            if (variantId > 600) break; // Limit to prevent too many variants

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
                                SizeId = sizeId
                            });
                        }
                    }
                }
            }

            modelBuilder.Entity<ProductVariant>().HasData(productVariants.Take(600));
        }

        private static List<int> GetAvailableColorsForProduct(int productId)
        {
            return productId switch
            {
                // T-shirts and tank tops - all colors
                <= 3 => new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 },
                // Hoodies - fewer colors
                4 or 5 => new List<int> { 1, 2, 3, 4, 5, 6 },
                // Tank tops - all colors
                6 or 7 => new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 },
                // Mugs - fewer colors
                8 or 9 => new List<int> { 1, 2, 3, 4, 5, 6 },
                // Posters - no colors (they are the design)
                10 or 11 => new List<int> { 1 }, // Default to black
                // Phone cases - all colors
                12 or 13 => new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 },
                // Stickers - all colors
                100 or 101 or 102 => new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 },
                _ => new List<int> { 1, 2, 3 }
            };
        }

        private static List<int> GetAvailableSizesForProduct(int productId)
        {
            return productId switch
            {
                // Clothing items - all sizes
                <= 7 => new List<int> { 1, 2, 3, 4, 5, 6 }, // XS to XXL
                // Mugs and phone cases - one size
                8 or 9 or 12 or 13 => new List<int> { 8 }, // One Size
                // Posters - use existing sizes
                10 or 11 => new List<int> { 1, 2, 3, 4 }, // XS, S, M, L for posters
                // Stickers - one size
                100 or 101 or 102 => new List<int> { 8 }, // One Size
                _ => new List<int> { 8 } // Default to One Size
            };
        }

        private static void SeedProductVariantImages(ModelBuilder modelBuilder)
        {
            var images = new List<ProductVariantImages>();
            var random = new Random(789);
            var baseDate = new DateTime(2024, 1, 1);

            // More realistic mockup URLs for different product types
            var clothingMockups = new[]
            {
                "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", // T-shirt on person
                "https://images.unsplash.com/photo-1503341504253-dff4815485f1?w=800&h=600&fit=crop", // Hoodie mockup
                "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop",  // Tank top mockup
                "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=800&h=600&fit=crop", // Casual wear
                "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?w=800&h=600&fit=crop"  // Street style
            };

            var accessoryMockups = new[]
            {
                "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", // Tote bag
                "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", // Phone case
                "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop",  // Mug
                "https://images.unsplash.com/photo-1583394838336-acd977736f90?w=800&h=600&fit=crop", // Coffee mug
                "https://images.unsplash.com/photo-1601972602288-1ec5d4c6f0e5?w=800&h=600&fit=crop"  // Travel mug
            };

            var homeMockups = new[]
            {
                "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", // Poster
                "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", // Canvas print
                "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop",  // Sticker
                "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", // Wall art
                "https://images.unsplash.com/photo-1618005182384-a83a8bd57fbe?w=800&h=600&fit=crop"  // Home decor
            };

            // Generate images for each product variant
            for (int variantId = 1; variantId <= 400; variantId++)
            {
                var mockupPool = variantId <= 200 ? clothingMockups : 
                                variantId <= 300 ? accessoryMockups : homeMockups;

                // Generate 2-3 images per variant
                var imageCount = random.Next(2, 4);
                for (int j = 0; j < imageCount; j++)
                {
                    images.Add(new ProductVariantImages
                    {
                        Id = (variantId - 1) * 3 + j + 1,
                        ImageUrl = mockupPool[random.Next(mockupPool.Length)],
                        FileName = $"variant_{variantId}_mockup_{j + 1}.jpg",
                        AltText = $"Product variant {variantId} mockup view {j + 1}",
                        IsPrimary = j == 0,
                        IsActive = true,
                        ProductVariantId = variantId
                    });
                }
            }

            modelBuilder.Entity<ProductVariantImages>().HasData(images);
        }

        private static void SeedDeliveryMethods(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);
            var deliveryMethods = new[]
            {
                new DeliveryMethod
                {
                    Id = 1,
                    ShortName = "UPS1",
                    Description = "Fastest delivery: 1-2 days",
                    DeliveryTime = "1-2 days",
                    Cost = 5.99m
                },
                new DeliveryMethod
                {
                    Id = 2,
                    ShortName = "UPS2",
                    Description = "Get it within 5 days",
                    DeliveryTime = "2-5 days",
                    Cost = 12.99m
                },
                new DeliveryMethod
                {
                    Id = 3,
                    ShortName = "UPS3",
                    Description = "Slower but cheap",
                    DeliveryTime = "5-10 days",
                    Cost = 24.99m
                },
                new DeliveryMethod
                {
                    Id = 4,
                    ShortName = "FREE",
                    Description = "Free! You get what you pay for",
                    DeliveryTime = "1-2 weeks",
                    Cost = 0m
                }
            };

            modelBuilder.Entity<DeliveryMethod>().HasData(deliveryMethods);
        }

        private static void SeedOrders(ModelBuilder modelBuilder)
        {
            // Skip seeding orders for now due to complex relationships
            // Orders will be created through the application flow
        }

        private static void SeedOrderItems(ModelBuilder modelBuilder)
        {
            // Skip seeding order items for now due to complex relationships
            // Order items will be created through the application flow
        }

        // Helper methods
        private static decimal GetBaseProductPrice(int productId)
        {
            return productId switch
            {
                1 => 19.99m, // Classic T-Shirt
                2 => 24.99m, // Premium T-Shirt
                3 => 22.99m, // Vintage T-Shirt
                4 => 39.99m, // Classic Hoodie
                5 => 49.99m, // Premium Hoodie
                6 => 16.99m, // Classic Tank Top
                7 => 19.99m, // Athletic Tank Top
                8 => 11.99m, // Classic Ceramic Mug
                9 => 16.99m, // Travel Mug
                10 => 8.99m, // Standard Poster
                11 => 12.99m, // Premium Poster
                12 => 15.99m, // iPhone Case
                13 => 15.99m, // Samsung Case
                100 => 4.99m, // Vinyl Sticker Set
                101 => 2.99m, // Decal Sticker
                102 => 3.99m, // Bumper Sticker
                _ => 19.99m
            };
        }

        private static string GetRandomCity(Random random)
        {
            var cities = new[] { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio", "San Diego", "Dallas", "San Jose" };
            return cities[random.Next(cities.Length)];
        }

        private static string GetRandomCountry(Random random)
        {
            var countries = new[] { "USA", "Canada", "United Kingdom", "Australia", "Germany", "France", "Italy", "Spain", "Netherlands", "Sweden" };
            return countries[random.Next(countries.Length)];
        }

        private static string GeneratePostalCode(string country, Random random)
        {
            return country switch
            {
                "USA" => $"{random.Next(10000, 99999)}",
                "Canada" => $"{random.Next(10000, 99999)}",
                "United Kingdom" => $"{random.Next(10000, 99999)}",
                "Australia" => $"{random.Next(1000, 9999)}",
                "Germany" => $"{random.Next(10000, 99999)}",
                _ => $"{random.Next(10000, 99999)}"
            };
        }
        }
    }
