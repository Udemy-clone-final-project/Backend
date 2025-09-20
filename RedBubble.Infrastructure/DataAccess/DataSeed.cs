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
                    ParentCategoryId = 4,
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
            var baseDate = new DateTime(2024, 1, 1);
            var createdDate = baseDate.AddDays(-60);

            // T-Shirts (Category 5)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 1,
                    Name = "Classic T-Shirt",
                    Description = "Comfortable cotton t-shirt with a relaxed fit",
                    CategoryId = 5,
                    BasePrice = 19.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                },
                new BaseProduct
                {
                    Id = 2,
                    Name = "Premium T-Shirt",
                    Description = "High-quality cotton t-shirt with a modern fit",
                    CategoryId = 5,
                    BasePrice = 24.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Hoodies (Category 6)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 3,
                    Name = "Classic Hoodie",
                    Description = "Warm and comfortable hoodie for casual wear",
                    CategoryId = 6,
                    BasePrice = 39.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                },
                new BaseProduct
                {
                    Id = 4,
                    Name = "Premium Hoodie",
                    Description = "High-quality hoodie with premium materials",
                    CategoryId = 6,
                    BasePrice = 49.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Tank Tops (Category 7)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 5,
                    Name = "Classic Tank Top",
                    Description = "Lightweight tank top perfect for summer",
                    CategoryId = 7,
                    BasePrice = 16.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Long Sleeve (Category 8)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 6,
                    Name = "Classic Long Sleeve",
                    Description = "Comfortable long sleeve shirt for cooler weather",
                    CategoryId = 8,
                    BasePrice = 22.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Bags (Category 9)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 7,
                    Name = "Tote Bag",
                    Description = "Spacious tote bag for everyday use",
                    CategoryId = 9,
                    BasePrice = 12.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Stickers (Category 10)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 8,
                    Name = "Vinyl Sticker",
                    Description = "Durable vinyl sticker for various surfaces",
                    CategoryId = 10,
                    BasePrice = 3.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Phone Cases (Category 11)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 9,
                    Name = "Phone Case",
                    Description = "Protective case for smartphones",
                    CategoryId = 11,
                    BasePrice = 15.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });
  
            // Mugs (Category 12)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 10,
                    Name = "Ceramic Mug",
                    Description = "High-quality ceramic mug for beverages",
                    CategoryId = 12,
                    BasePrice = 11.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Posters (Category 13)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 11,
                    Name = "Poster Print",
                    Description = "High-quality poster print for wall decoration",
                    CategoryId = 13,
                    BasePrice = 8.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Canvas Prints (Category 14)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 12,
                    Name = "Canvas Print",
                    Description = "Premium canvas print for wall art",
                    CategoryId = 14,
                    BasePrice = 24.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Laptop Stickers (Category 15)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 13,
                    Name = "Laptop Sticker",
                    Description = "Decorative sticker for laptops and devices",
                    CategoryId = 15,
                    BasePrice = 2.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Mouse Pads (Category 16)
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 14,
                    Name = "Mouse Pad",
                    Description = "Comfortable mouse pad for computer use",
                    CategoryId = 16,
                    BasePrice = 9.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            // Additional products
            products.AddRange(new[]
            {
                new BaseProduct
                {
                    Id = 15,
                    Name = "Premium Tote Bag",
                    Description = "High-quality tote bag with reinforced handles",
                    CategoryId = 9,
                    BasePrice = 14.99m,
                    IsActive = true,
                    CreatedBy = "admin-001",
                    CreatedOn = createdDate,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = createdDate.AddDays(10)
                }
            });

            modelBuilder.Entity<BaseProduct>().HasData(products);
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
                new { Title = "Mountain Sunset", Description = "Breathtaking mountain landscape at sunset", Tags = "nature,mountains,sunset,landscape" },
                new { Title = "Forest Path", Description = "Peaceful forest trail through tall trees", Tags = "nature,forest,trees,path" },
                new { Title = "Ocean Waves", Description = "Powerful ocean waves crashing on shore", Tags = "nature,ocean,waves,beach" },
                
                // Abstract & Geometric
                new { Title = "Geometric Mandala", Description = "Intricate geometric mandala pattern", Tags = "abstract,geometric,mandala,pattern" },
                new { Title = "Colorful Spiral", Description = "Vibrant spiral design with flowing colors", Tags = "abstract,spiral,colorful,flow" },
                new { Title = "Minimalist Lines", Description = "Clean minimalist line art design", Tags = "abstract,minimalist,lines,simple" },
                
                // Typography & Text
                new { Title = "Motivational Quote", Description = "Inspirational typography design", Tags = "typography,quote,motivational,text" },
                new { Title = "Vintage Script", Description = "Elegant vintage script typography", Tags = "typography,vintage,script,elegant" },
                new { Title = "Modern Sans Serif", Description = "Clean modern sans serif typography", Tags = "typography,modern,sans-serif,clean" },
                
                // Animals & Wildlife
                new { Title = "Majestic Eagle", Description = "Powerful eagle in flight", Tags = "animals,eagle,bird,wildlife" },
                new { Title = "Cute Cat", Description = "Adorable cat illustration", Tags = "animals,cat,cute,pet" },
                new { Title = "Tropical Fish", Description = "Colorful tropical fish in coral reef", Tags = "animals,fish,tropical,coral" },
                
                // Space & Sci-Fi
                new { Title = "Galaxy Nebula", Description = "Stunning galaxy nebula in deep space", Tags = "space,galaxy,nebula,cosmic" },
                new { Title = "Rocket Launch", Description = "Rocket launching into space", Tags = "space,rocket,launch,sci-fi" },
                new { Title = "Alien Planet", Description = "Mysterious alien planet landscape", Tags = "space,alien,planet,sci-fi" },
                
                // Pop Culture & Fun
                new { Title = "Retro Gaming", Description = "Nostalgic retro gaming pixel art", Tags = "gaming,retro,pixel,nostalgic" },
                new { Title = "Coffee Lover", Description = "Coffee-themed design for caffeine enthusiasts", Tags = "coffee,caffeine,drink,lifestyle" },
                new { Title = "Music Notes", Description = "Musical notes and instruments", Tags = "music,notes,instruments,sound" }
            };

            // Generate 100 designs with varied themes
            for (int i = 1; i <= 100; i++)
            {
                var template = designTemplates[random.Next(designTemplates.Length)];
                var designDate = baseDate.AddDays(-random.Next(1, 180));

                designs.Add(new Design
                {
                    Id = i,
                    Title = $"{template.Title} #{i}",
                    Description = template.Description,
                    // Tags property removed - not in Design entity
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

            // Generate variants for each base product
            for (int productId = 1; productId <= 15; productId++)
            {
                var baseProdPrice = GetBaseProductPrice(productId);

                // Generate variants for different designs, colors, and sizes
                for (int designId = 1; designId <= 20; designId++) // Use first 20 designs
                {
                    for (int colorId = 1; colorId <= 5; colorId++) // Use first 5 colors
                    {
                        for (int sizeId = 1; sizeId <= 4; sizeId++) // Use first 4 sizes
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
                                SizeId = sizeId
                            });
                        }
                    }
                }
            }

            modelBuilder.Entity<ProductVariant>().HasData(productVariants.Take(350));
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
                "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop"  // Tank top mockup
            };

            var accessoryMockups = new[]
            {
                "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", // Tote bag
                "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", // Phone case
                "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop"  // Mug
            };

            var homeMockups = new[]
            {
                "https://images.unsplash.com/photo-1513475382585-d06e58bcb0e0?w=800&h=600&fit=crop", // Poster
                "https://images.unsplash.com/photo-1572635196237-14b3f281503f?w=800&h=600&fit=crop", // Canvas print
                "https://images.unsplash.com/photo-1551698618-1dfe5d97d256?w=800&h=600&fit=crop"  // Sticker
            };

            // Generate images for each product variant
            for (int variantId = 1; variantId <= 350; variantId++)
            {
                var mockupPool = variantId <= 200 ? clothingMockups : 
                                variantId <= 300 ? accessoryMockups : homeMockups;

                // Generate 2-4 images per variant
                var imageCount = random.Next(2, 5);
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
                3 => 39.99m, // Classic Hoodie
                4 => 49.99m, // Premium Hoodie
                5 => 16.99m, // Classic Tank Top
                6 => 22.99m, // Classic Long Sleeve
                7 => 12.99m, // Tote Bag
                8 => 3.99m,  // Vinyl Sticker
                9 => 15.99m, // Phone Case
                10 => 11.99m, // Ceramic Mug
                11 => 8.99m, // Poster Print
                12 => 24.99m, // Canvas Print
                13 => 2.99m, // Laptop Sticker
                14 => 9.99m, // Mouse Pad
                15 => 14.99m, // Tote Bag
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
