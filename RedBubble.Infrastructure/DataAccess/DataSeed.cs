using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess
{
    public static class DataSeed
    {
        private static void EnsureAuditFields(AppDbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries<RedBubble.Domain.Entities.Base.IBaseAuditableEntity>())
            {
                if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                {
                    if (string.IsNullOrWhiteSpace(entry.Entity.CreatedBy))
                        entry.Entity.CreatedBy = "System";
                    if (entry.Entity.CreatedOn == default)
                        entry.Entity.CreatedOn = DateTime.UtcNow;
                    if (string.IsNullOrWhiteSpace(entry.Entity.LastModifiedBy))
                        entry.Entity.LastModifiedBy = "System";
                    if (entry.Entity.LastModifiedOn == default)
                        entry.Entity.LastModifiedOn = DateTime.UtcNow;
                }
                else if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Modified)
                {
                    entry.Entity.LastModifiedBy = "System";
                    entry.Entity.LastModifiedOn = DateTime.UtcNow;
                }
            }
        }
        /// <summary>
        /// Main entry point for seeding all data.
        /// </summary>
        public static async Task SeedAllAsync(AppDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            // The order is critical due to dependencies between entities.
            await SeedRolesAsync(roleManager);
            await SeedUsersAsync(userManager);

            // Seed product data only if the database is empty of products
            if (!await context.ProductVariants.AnyAsync())
            {
                await SeedColorsAndSizesAsync(context);
                await SeedCategoriesAsync(context);
                // Persist categories before they are queried in BaseProducts seeder
                EnsureAuditFields(context);
                await context.SaveChangesAsync();

                await SeedBaseProductsAsync(context);
                // Persist base products to ensure availability for later queries
                EnsureAuditFields(context);
                await context.SaveChangesAsync();
                await SeedDesignsAsync(context, userManager);

                // Save changes here so Variants can find all the necessary related data
                EnsureAuditFields(context);
                await context.SaveChangesAsync();

                await SeedProductVariantsAsync(context);
                await SeedProductVariantImagesAsync(context);
                await SeedOrdersAsync(context, userManager);

                // Persist seeded variants, images, and orders
                EnsureAuditFields(context);
                await context.SaveChangesAsync();
            }
        }

        private static async Task SeedRolesAsync(RoleManager<ApplicationRole> roleManager)
        {
            if (!await roleManager.Roles.AnyAsync())
            {
                await roleManager.CreateAsync(new ApplicationRole { Name = "Admin", Description = "Administrator role" });
                await roleManager.CreateAsync(new ApplicationRole { Name = "Customer", Description = "Default customer role" });
                await roleManager.CreateAsync(new ApplicationRole { Name = "Artist", Description = "Artist role for uploading designs" });
                await roleManager.CreateAsync(new ApplicationRole { Name = "Moderator", Description = "Content moderator role" });
            }
        }

        private static async Task SeedUsersAsync(UserManager<ApplicationUser> userManager)
        {
            if (!await userManager.Users.AnyAsync())
            {
                var adminUser = new ApplicationUser { DisplayName = "Admin User", Email = "admin@test.com", UserName = "admin", EmailConfirmed = true, IsActive = true };
                await userManager.CreateAsync(adminUser, "Pa$$w0rd");
                await userManager.AddToRoleAsync(adminUser, "Admin");

                var artistUser = new ApplicationUser { DisplayName = "Creative Artist", Email = "artist@test.com", UserName = "artist", EmailConfirmed = true, IsActive = true };
                await userManager.CreateAsync(artistUser, "Pa$$w0rd");
                await userManager.AddToRoleAsync(artistUser, "Artist");

                var customerUser = new ApplicationUser { DisplayName = "John Doe", Email = "customer@test.com", UserName = "customer", EmailConfirmed = true, IsActive = true };
                await userManager.CreateAsync(customerUser, "Pa$$w0rd");
                await userManager.AddToRoleAsync(customerUser, "Customer");

                var moderatorUser = new ApplicationUser { DisplayName = "Content Moderator", Email = "moderator@test.com", UserName = "moderator", EmailConfirmed = true, IsActive = true };
                await userManager.CreateAsync(moderatorUser, "Pa$$w0rd");
                await userManager.AddToRoleAsync(moderatorUser, "Moderator");

                // Add more test users for variety
                var customer2 = new ApplicationUser { DisplayName = "Jane Smith", Email = "jane@test.com", UserName = "jane", EmailConfirmed = true, IsActive = true };
                await userManager.CreateAsync(customer2, "Pa$$w0rd");
                await userManager.AddToRoleAsync(customer2, "Customer");

                var artist2 = new ApplicationUser { DisplayName = "Digital Creator", Email = "creator@test.com", UserName = "creator", EmailConfirmed = true, IsActive = true };
                await userManager.CreateAsync(artist2, "Pa$$w0rd");
                await userManager.AddToRoleAsync(artist2, "Artist");
            }
        }

        private static async Task SeedColorsAndSizesAsync(AppDbContext context)
        {
            if (!await context.Colors.AnyAsync())
            {
                var colors = new List<Color>
                {
                    new Color { ColorName = "Black", ColorCode = "#000000", IsActive = true },
                    new Color { ColorName = "White", ColorCode = "#FFFFFF", IsActive = true },
                    new Color { ColorName = "Red", ColorCode = "#FF0000", IsActive = true },
                    new Color { ColorName = "Blue", ColorCode = "#0000FF", IsActive = true },
                    new Color { ColorName = "Green", ColorCode = "#008000", IsActive = true },
                    new Color { ColorName = "Yellow", ColorCode = "#FFFF00", IsActive = true },
                    new Color { ColorName = "Purple", ColorCode = "#800080", IsActive = true },
                    new Color { ColorName = "Orange", ColorCode = "#FFA500", IsActive = true },
                    new Color { ColorName = "Pink", ColorCode = "#FFC0CB", IsActive = true },
                    new Color { ColorName = "Gray", ColorCode = "#808080", IsActive = true }
                };
                await context.Colors.AddRangeAsync(colors);
            }

            if (!await context.Sizes.AnyAsync())
            {
                var sizes = new List<Size>
                {
                    new Size { SizeName = "XS", Description = "Extra Small size", IsActive = true },
                    new Size { SizeName = "S", Description = "Small size", IsActive = true },
                    new Size { SizeName = "M", Description = "Medium size", IsActive = true },
                    new Size { SizeName = "L", Description = "Large size", IsActive = true },
                    new Size { SizeName = "XL", Description = "Extra Large size", IsActive = true },
                    new Size { SizeName = "XXL", Description = "Double Extra Large size", IsActive = true },
                    new Size { SizeName = "3XL", Description = "Triple Extra Large size", IsActive = true }
                };
                await context.Sizes.AddRangeAsync(sizes);
            }
            EnsureAuditFields(context);
            await context.SaveChangesAsync();
        }

        private static async Task SeedCategoriesAsync(AppDbContext context)
        {
            if (await context.Categories.AnyAsync()) return;

            var apparel = new Category { CategoryName = "Apparel", CreatedBy = "System" };
            var accessories = new Category { CategoryName = "Accessories", CreatedBy = "System" };
            var home = new Category { CategoryName = "Home & Living", CreatedBy = "System" };
            var tech = new Category { CategoryName = "Tech Accessories", CreatedBy = "System" };

            var categories = new List<Category>
            {
                apparel, accessories, home, tech,
                new Category { CategoryName = "T-Shirts", ParentCategory = apparel, CreatedBy = "System" },
                new Category { CategoryName = "Hoodies", ParentCategory = apparel, CreatedBy = "System" },
                new Category { CategoryName = "Tank Tops", ParentCategory = apparel, CreatedBy = "System" },
                new Category { CategoryName = "Long Sleeves", ParentCategory = apparel, CreatedBy = "System" },
                new Category { CategoryName = "Phone Cases", ParentCategory = tech, CreatedBy = "System" },
                new Category { CategoryName = "Laptop Sleeves", ParentCategory = tech, CreatedBy = "System" },
                new Category { CategoryName = "Mugs", ParentCategory = home, CreatedBy = "System" },
                new Category { CategoryName = "Posters", ParentCategory = home, CreatedBy = "System" },
                new Category { CategoryName = "Stickers", ParentCategory = accessories, CreatedBy = "System" },
                new Category { CategoryName = "Tote Bags", ParentCategory = accessories, CreatedBy = "System" }
            };

            await context.Categories.AddRangeAsync(categories);
        }

        private static async Task SeedBaseProductsAsync(AppDbContext context)
        {
            if (await context.BaseProducts.AnyAsync()) return;

            var tShirtCategory = await context.Categories.FirstAsync(c => c.CategoryName == "T-Shirts");
            var hoodieCategory = await context.Categories.FirstAsync(c => c.CategoryName == "Hoodies");
            var tankTopCategory = await context.Categories.FirstAsync(c => c.CategoryName == "Tank Tops");
            var longSleeveCategory = await context.Categories.FirstAsync(c => c.CategoryName == "Long Sleeves");
            var phoneCaseCategory = await context.Categories.FirstAsync(c => c.CategoryName == "Phone Cases");
            var mugCategory = await context.Categories.FirstAsync(c => c.CategoryName == "Mugs");
            var posterCategory = await context.Categories.FirstAsync(c => c.CategoryName == "Posters");

            var baseProducts = new List<BaseProduct>
            {
                new BaseProduct { Name = "Classic T-Shirt", Description = "Premium cotton classic fit t-shirt", BasePrice = 19.99m, Category = tShirtCategory, CreatedBy = "System" },
                new BaseProduct { Name = "Pullover Hoodie", Description = "Comfortable pullover hoodie with kangaroo pocket", BasePrice = 39.99m, Category = hoodieCategory, CreatedBy = "System" },
                new BaseProduct { Name = "Slim Fit T-Shirt", Description = "Modern slim fit t-shirt for a contemporary look", BasePrice = 24.99m, Category = tShirtCategory, CreatedBy = "System" },
                new BaseProduct { Name = "Tank Top", Description = "Lightweight tank top perfect for summer", BasePrice = 14.99m, Category = tankTopCategory, CreatedBy = "System" },
                new BaseProduct { Name = "Long Sleeve Shirt", Description = "Comfortable long sleeve shirt for cooler weather", BasePrice = 29.99m, Category = longSleeveCategory, CreatedBy = "System" },
                new BaseProduct { Name = "iPhone Case", Description = "Durable protective case for iPhone", BasePrice = 9.99m, Category = phoneCaseCategory, CreatedBy = "System" },
                new BaseProduct { Name = "Ceramic Mug", Description = "High-quality ceramic mug with handle", BasePrice = 12.99m, Category = mugCategory, CreatedBy = "System" },
                new BaseProduct { Name = "Canvas Poster", Description = "Premium canvas poster print", BasePrice = 15.99m, Category = posterCategory, CreatedBy = "System" }
            };

            await context.BaseProducts.AddRangeAsync(baseProducts);
        }

        private static async Task SeedDesignsAsync(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            if (await context.Designs.AnyAsync()) return;

            var artist = await userManager.FindByNameAsync("artist");
            var creator = await userManager.FindByNameAsync("creator");
            var admin = await userManager.FindByNameAsync("admin");

            var designs = new List<Design>
            {
                new Design { Title = "Cool Abstract Art", Description = "A vibrant abstract design with geometric shapes and bold colors.", Price = 5.00m, Status = DesignStatus.Approved, Artist = artist, Admin = admin, UploadedAt = DateTime.UtcNow, ReviewedAt = DateTime.UtcNow },
                new Design { Title = "Retro Sunset", Description = "A classic retro sunset design with warm orange and pink tones.", Price = 5.00m, Status = DesignStatus.Approved, Artist = artist, Admin = admin, UploadedAt = DateTime.UtcNow, ReviewedAt = DateTime.UtcNow },
                new Design { Title = "Minimalist Cat", Description = "Simple and elegant cat silhouette design.", Price = 4.50m, Status = DesignStatus.Approved, Artist = creator, Admin = admin, UploadedAt = DateTime.UtcNow, ReviewedAt = DateTime.UtcNow },
                new Design { Title = "Space Galaxy", Description = "Beautiful galaxy design with stars and nebulas.", Price = 6.00m, Status = DesignStatus.Approved, Artist = artist, Admin = admin, UploadedAt = DateTime.UtcNow, ReviewedAt = DateTime.UtcNow },
                new Design { Title = "Vintage Typography", Description = "Classic vintage typography design with old-school fonts.", Price = 4.00m, Status = DesignStatus.Approved, Artist = creator, Admin = admin, UploadedAt = DateTime.UtcNow, ReviewedAt = DateTime.UtcNow },
                new Design { Title = "Nature Forest", Description = "Peaceful forest scene with trees and wildlife.", Price = 5.50m, Status = DesignStatus.Approved, Artist = artist, Admin = admin, UploadedAt = DateTime.UtcNow, ReviewedAt = DateTime.UtcNow },
                new Design { Title = "Geometric Patterns", Description = "Modern geometric patterns with clean lines.", Price = 4.75m, Status = DesignStatus.Approved, Artist = creator, Admin = admin, UploadedAt = DateTime.UtcNow, ReviewedAt = DateTime.UtcNow },
                new Design { Title = "Ocean Waves", Description = "Calming ocean waves design in blue tones.", Price = 5.25m, Status = DesignStatus.Approved, Artist = artist, Admin = admin, UploadedAt = DateTime.UtcNow, ReviewedAt = DateTime.UtcNow }
            };

            await context.Designs.AddRangeAsync(designs);
        }

        private static async Task SeedProductVariantsAsync(AppDbContext context)
        {
            if (await context.ProductVariants.AnyAsync()) return;

            var classicTshirt = await context.BaseProducts.FirstAsync(p => p.Name == "Classic T-Shirt");
            var slimFitTshirt = await context.BaseProducts.FirstAsync(p => p.Name == "Slim Fit T-Shirt");
            var hoodie = await context.BaseProducts.FirstAsync(p => p.Name == "Pullover Hoodie");
            var tankTop = await context.BaseProducts.FirstAsync(p => p.Name == "Tank Top");
            var longSleeve = await context.BaseProducts.FirstAsync(p => p.Name == "Long Sleeve Shirt");
            var iphoneCase = await context.BaseProducts.FirstAsync(p => p.Name == "iPhone Case");
            var mug = await context.BaseProducts.FirstAsync(p => p.Name == "Ceramic Mug");
            var poster = await context.BaseProducts.FirstAsync(p => p.Name == "Canvas Poster");

            var coolDesign = await context.Designs.FirstAsync(d => d.Title == "Cool Abstract Art");
            var retroSunset = await context.Designs.FirstAsync(d => d.Title == "Retro Sunset");
            var minimalistCat = await context.Designs.FirstAsync(d => d.Title == "Minimalist Cat");
            var spaceGalaxy = await context.Designs.FirstAsync(d => d.Title == "Space Galaxy");
            var vintageTypography = await context.Designs.FirstAsync(d => d.Title == "Vintage Typography");
            var natureForest = await context.Designs.FirstAsync(d => d.Title == "Nature Forest");

            var allColors = await context.Colors.ToListAsync();
            var allSizes = await context.Sizes.ToListAsync();

            var variants = new List<ProductVariant>
            {
                // T-Shirt variants
                new ProductVariant
                {
                    BaseProduct = classicTshirt,
                    Design = coolDesign,
                    Price = 21.99m,
                    StockQuantity = 100,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "Black"), allColors.First(c => c.ColorName == "White") },
                    Sizes = new List<Size> { allSizes.First(s => s.SizeName == "S"), allSizes.First(s => s.SizeName == "M"), allSizes.First(s => s.SizeName == "L") }
                },
                new ProductVariant
                {
                    BaseProduct = classicTshirt,
                    Design = retroSunset,
                    Price = 22.99m,
                    StockQuantity = 75,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "White"), allColors.First(c => c.ColorName == "Gray") },
                    Sizes = new List<Size> { allSizes.First(s => s.SizeName == "M"), allSizes.First(s => s.SizeName == "L"), allSizes.First(s => s.SizeName == "XL") }
                },
                new ProductVariant
                {
                    BaseProduct = slimFitTshirt,
                    Design = minimalistCat,
                    Price = 26.99m,
                    StockQuantity = 50,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "Black"), allColors.First(c => c.ColorName == "Blue") },
                    Sizes = new List<Size> { allSizes.First(s => s.SizeName == "S"), allSizes.First(s => s.SizeName == "M") }
                },
                // Hoodie variants
                new ProductVariant
                {
                    BaseProduct = hoodie,
                    Design = spaceGalaxy,
                    Price = 44.99m,
                    StockQuantity = 60,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "Black"), allColors.First(c => c.ColorName == "Blue") },
                    Sizes = new List<Size> { allSizes.First(s => s.SizeName == "M"), allSizes.First(s => s.SizeName == "L"), allSizes.First(s => s.SizeName == "XL") }
                },
                // Tank Top variants
                new ProductVariant
                {
                    BaseProduct = tankTop,
                    Design = vintageTypography,
                    Price = 16.99m,
                    StockQuantity = 80,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "White"), allColors.First(c => c.ColorName == "Gray") },
                    Sizes = new List<Size> { allSizes.First(s => s.SizeName == "S"), allSizes.First(s => s.SizeName == "M"), allSizes.First(s => s.SizeName == "L") }
                },
                // Long Sleeve variants
                new ProductVariant
                {
                    BaseProduct = longSleeve,
                    Design = natureForest,
                    Price = 32.99m,
                    StockQuantity = 45,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "Green"), allColors.First(c => c.ColorName == "Gray") },
                    Sizes = new List<Size> { allSizes.First(s => s.SizeName == "L"), allSizes.First(s => s.SizeName == "XL") }
                },
                // Accessory variants
                new ProductVariant
                {
                    BaseProduct = iphoneCase,
                    Design = coolDesign,
                    Price = 12.99m,
                    StockQuantity = 200,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "Black"), allColors.First(c => c.ColorName == "White") },
                    Sizes = new List<Size>() // Phone cases don't have sizes
                },
                new ProductVariant
                {
                    BaseProduct = mug,
                    Design = retroSunset,
                    Price = 16.99m,
                    StockQuantity = 150,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "White") },
                    Sizes = new List<Size>() // Mugs don't have sizes
                },
                new ProductVariant
                {
                    BaseProduct = poster,
                    Design = spaceGalaxy,
                    Price = 18.99m,
                    StockQuantity = 100,
                    IsActive = true,
                    Colors = new List<Color> { allColors.First(c => c.ColorName == "White") },
                    Sizes = new List<Size>() // Posters don't have sizes
                }
            };

            await context.ProductVariants.AddRangeAsync(variants);
            // Persist variants so that subsequent seeders (images/orders) can query them safely
            EnsureAuditFields(context);
            await context.SaveChangesAsync();
        }

        private static async Task SeedProductVariantImagesAsync(AppDbContext context)
        {
            if (await context.ProductVariantImages.AnyAsync()) return;

            var variants = await context.ProductVariants.Take(5).ToListAsync();
            var images = new List<ProductVariantImages>();

            foreach (var variant in variants)
            {
                images.Add(new ProductVariantImages
                {
                    ProductVariantId = variant.Id,
                    ImageUrl = $"https://example.com/images/product-{variant.Id}-1.jpg",
                    IsPrimary = true,
                    CreatedBy = "System"
                });

                if (variant.Id % 2 == 0) // Add secondary images for even variants
                {
                    images.Add(new ProductVariantImages
                    {
                        ProductVariantId = variant.Id,
                        ImageUrl = $"https://example.com/images/product-{variant.Id}-2.jpg",
                        IsPrimary = false,
                        CreatedBy = "System"
                    });
                }
            }

            await context.ProductVariantImages.AddRangeAsync(images);
            // Persist images for completeness
            EnsureAuditFields(context);
            await context.SaveChangesAsync();
        }

        private static async Task SeedOrdersAsync(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            if (await context.Orders.AnyAsync()) return;

            var customer = await userManager.FindByNameAsync("customer");
            var jane = await userManager.FindByNameAsync("jane");
            var variants = await context.ProductVariants.Take(3).ToListAsync();

            if (variants.Count == 0)
            {
                // No variants available to create orders from
                return;
            }

            var orders = new List<Order>();

            var firstOrder = new Order
            {
                Customer = customer,
                TotalAmount = variants[0].Price * 2,
                Status = OrderStatus.Shipped,
                ShippingAddress = "123 Test St",
                ShippingCity = "Testville",
                ShippingCountry = "Testland",
                ShippingPostalCode = "12345",
                OrderDate = DateTime.UtcNow.AddDays(-5),
                UpdatedAt = DateTime.UtcNow.AddDays(-3),
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { ProductVariant = variants[0], Quantity = 2, UnitPrice = variants[0].Price, TotalPrice = variants[0].Price * 2 }
                }
            };
            orders.Add(firstOrder);

            if (variants.Count >= 2)
            {
                var secondOrderItems = new List<OrderItem>
                {
                    new OrderItem { ProductVariant = variants[1], Quantity = 1, UnitPrice = variants[1].Price, TotalPrice = variants[1].Price }
                };
                if (variants.Count >= 3)
                {
                    secondOrderItems.Add(new OrderItem { ProductVariant = variants[2], Quantity = 1, UnitPrice = variants[2].Price, TotalPrice = variants[2].Price });
                }

                var secondOrder = new Order
                {
                    Customer = jane,
                    TotalAmount = variants[1].Price + (variants.Count >= 3 ? variants[2].Price : 0),
                    Status = OrderStatus.Processing,
                    ShippingAddress = "456 Sample Ave",
                    ShippingCity = "Sampletown",
                    ShippingCountry = "Sampleland",
                    ShippingPostalCode = "67890",
                    OrderDate = DateTime.UtcNow.AddDays(-2),
                    UpdatedAt = DateTime.UtcNow.AddDays(-1),
                    OrderItems = secondOrderItems
                };
                orders.Add(secondOrder);
            }

            var thirdOrder = new Order
            {
                Customer = customer,
                TotalAmount = variants[0].Price * 3,
                Status = OrderStatus.Pending,
                ShippingAddress = "789 Demo Rd",
                ShippingCity = "Democity",
                ShippingCountry = "Demoland",
                ShippingPostalCode = "11111",
                OrderDate = DateTime.UtcNow.AddDays(-1),
                UpdatedAt = DateTime.UtcNow.AddDays(-1),
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { ProductVariant = variants[0], Quantity = 3, UnitPrice = variants[0].Price, TotalPrice = variants[0].Price * 3 }
                }
            };
            orders.Add(thirdOrder);

            await context.Orders.AddRangeAsync(orders);
            EnsureAuditFields(context);
            await context.SaveChangesAsync();
        }
    }
}