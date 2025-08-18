using Microsoft.EntityFrameworkCore;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RedBubble.Infrastructure.DataAccess
{
    public static class DataSeed
    {
        public static void Seed(AppDbContext context)
        {
            // Seed Colors
            var colors = new List<Color>
            {
                new Color { ColorName = "Black", ColorCode = "#000000", IsActive = true },
                new Color { ColorName = "White", ColorCode = "#FFFFFF", IsActive = true },
                new Color { ColorName = "Red", ColorCode = "#FF0000", IsActive = true },
                new Color { ColorName = "Navy", ColorCode = "#000080", IsActive = true },
                new Color { ColorName = "Heather Grey", ColorCode = "#606060", IsActive = true },
                new Color { ColorName = "Olive Green", ColorCode = "#4B5320", IsActive = true },
                new Color { ColorName = "Maroon", ColorCode = "#800000", IsActive = true },
                new Color { ColorName = "Royal Blue", ColorCode = "#4169E1", IsActive = true },
                new Color { ColorName = "Pink", ColorCode = "#FF69B4", IsActive = true },
                new Color { ColorName = "Yellow", ColorCode = "#FFFF00", IsActive = true }
            };
            context.Colors.AddRange(colors);

            // Seed Sizes
            var sizes = new List<Size>
            {
                new Size { SizeName = "XS", Description = "Extra small size for apparel", IsActive = true },
                new Size { SizeName = "Small", Description = "Small size for apparel and accessories", IsActive = true },
                new Size { SizeName = "Medium", Description = "Medium size for apparel and accessories", IsActive = true },
                new Size { SizeName = "Large", Description = "Large size for apparel and accessories", IsActive = true },
                new Size { SizeName = "X-Large", Description = "Extra large size for apparel", IsActive = true },
                new Size { SizeName = "2XL", Description = "Double extra large size for apparel", IsActive = true },
                new Size { SizeName = "3x3", Description = "3x3 inch sticker", IsActive = true },
                new Size { SizeName = "4x4", Description = "4x4 inch sticker", IsActive = true },
                new Size { SizeName = "6x6", Description = "6x6 inch sticker", IsActive = true },
                new Size { SizeName = "iPhone Case", Description = "Standard iPhone case size", IsActive = true },
                new Size { SizeName = "Poster Small", Description = "Small poster size (16x20 inches)", IsActive = true },
                new Size { SizeName = "Poster Large", Description = "Large poster size (24x36 inches)", IsActive = true },
                new Size { SizeName = "Mug Standard", Description = "Standard mug size (11oz)", IsActive = true }
            };
            context.Sizes.AddRange(sizes);

            // Seed Categories
            var categories = new List<Category>
            {
                new Category { CategoryName = "Apparel", Description = "Clothing items", CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new Category { CategoryName = "Accessories", Description = "Wearable and carryable accessories", CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new Category { CategoryName = "Home Decor", Description = "Home decoration items", CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new Category { CategoryName = "Wall Art", Description = "Art prints and posters", CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new Category { CategoryName = "Stationery", Description = "Paper-based products", CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new Category { CategoryName = "Kids & Babies", Description = "Products for children", CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow }
            };
            // Subcategories
            categories.Add(new Category { CategoryName = "T-Shirts", Description = "Various T-shirt styles", ParentCategoryId = categories[0].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            categories.Add(new Category { CategoryName = "Hoodies", Description = "Pullover and zip-up hoodies", ParentCategoryId = categories[0].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            categories.Add(new Category { CategoryName = "Stickers", Description = "Adhesive decals", ParentCategoryId = categories[4].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            categories.Add(new Category { CategoryName = "Phone Cases", Description = "Protective phone covers", ParentCategoryId = categories[1].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            categories.Add(new Category { CategoryName = "Tote Bags", Description = "Reusable tote bags", ParentCategoryId = categories[1].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            categories.Add(new Category { CategoryName = "Posters", Description = "Large art prints", ParentCategoryId = categories[3].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            categories.Add(new Category { CategoryName = "Throw Pillows", Description = "Decorative pillows", ParentCategoryId = categories[2].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            //categories.Add(new Category { CategoryName = "Mugs", Description = "Ceramic mugs", ParentCategoryId = categories[2].Id, CreatedBy = "System", Created bridge = new Category { CategoryName = "Notebooks", Description = "Spiral-bound notebooks", ParentCategoryId = categories[4].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            categories.Add(new Category { CategoryName = "Kids T-Shirts", Description = "T-shirts for kids", ParentCategoryId = categories[5].Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow });
            context.Categories.AddRange(categories);

            // Seed Base Products
            var baseProducts = new List<BaseProduct>
            {
                new BaseProduct { Name = "Classic T-Shirt", Description = "Standard cotton T-shirt", BasePrice = 19.99m, CategoryId = categories.First(c => c.CategoryName == "T-Shirts").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Pullover Hoodie", Description = "Cozy pullover hoodie", BasePrice = 39.99m, CategoryId = categories.First(c => c.CategoryName == "Hoodies").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Zip Hoodie", Description = "Zip-up hoodie with pockets", BasePrice = 44.99m, CategoryId = categories.First(c => c.CategoryName == "Hoodies").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Sticker", Description = "Vinyl sticker", BasePrice = 2.99m, CategoryId = categories.First(c => c.CategoryName == "Stickers").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "iPhone Case", Description = "Hard-shell phone case", BasePrice = 24.99m, CategoryId = categories.First(c => c.CategoryName == "Phone Cases").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Samsung Case", Description = "Hard-shell Samsung phone case", BasePrice = 24.99m, CategoryId = categories.First(c => c.CategoryName == "Phone Cases").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Tote Bag", Description = "Reusable canvas tote bag", BasePrice = 19.99m, CategoryId = categories.First(c => c.CategoryName == "Tote Bags").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Poster", Description = "High-quality art poster", BasePrice = 14.99m, CategoryId = categories.First(c => c.CategoryName == "Posters").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Framed Print", Description = "Framed art print", BasePrice = 125.00m, CategoryId = categories.First(c => c.CategoryName == "Posters").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Throw Pillow", Description = "Decorative throw pillow", BasePrice = 29.99m, CategoryId = categories.First(c => c.CategoryName == "Throw Pillows").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Mug", Description = "11oz ceramic mug", BasePrice = 15.99m, CategoryId = categories.First(c => c.CategoryName == "Mugs").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Notebook", Description = "Spiral-bound notebook", BasePrice = 12.99m, CategoryId = categories.First(c => c.CategoryName == "Notebooks").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Kids T-Shirt", Description = "Cotton T-shirt for kids", BasePrice = 17.99m, CategoryId = categories.First(c => c.CategoryName == "Kids T-Shirts").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Leggings", Description = "Stretchy leggings", BasePrice = 39.99m, CategoryId = categories.First(c => c.CategoryName == "Apparel").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Backpack", Description = "Durable backpack", BasePrice = 49.99m, CategoryId = categories.First(c => c.CategoryName == "Accessories").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Duvet Cover", Description = "Soft duvet cover", BasePrice = 99.99m, CategoryId = categories.First(c => c.CategoryName == "Home Decor").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Art Print", Description = "Unframed art print", BasePrice = 29.99m, CategoryId = categories.First(c => c.CategoryName == "Wall Art").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Greeting Card", Description = "Printed greeting card", BasePrice = 3.99m, CategoryId = categories.First(c => c.CategoryName == "Stationery").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Mouse Pad", Description = "Custom mouse pad", BasePrice = 12.99m, CategoryId = categories.First(c => c.CategoryName == "Stationery").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Name = "Baby Onesie", Description = "Soft baby onesie", BasePrice = 19.99m, CategoryId = categories.First(c => c.CategoryName == "Kids & Babies").Id, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow }
            };
            context.BaseProducts.AddRange(baseProducts);

            // Seed Roles
            var roles = new List<ApplicationRole>
            {
                new ApplicationRole { Name = "Admin", Description = "System administrator", NormalizedName = "ADMIN" },
                new ApplicationRole { Name = "Artist", Description = "Design creator", NormalizedName = "ARTIST" },
                new ApplicationRole { Name = "Customer", Description = "Shopper", NormalizedName = "CUSTOMER" }
            };
            context.Roles.AddRange(roles);

            // Seed Users
            var users = new List<ApplicationUser>
            {
                new ApplicationUser { UserName = "admin1", Email = "admin1@example.com", FirstName = "Admin", LastName = "One", IsActive = true, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow, NormalizedEmail = "ADMIN1@EXAMPLE.COM", NormalizedUserName = "ADMIN1" },
                new ApplicationUser { UserName = "artist1", Email = "artist1@example.com", FirstName = "Artist", LastName = "One", IsActive = true, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow, NormalizedEmail = "ARTIST1@EXAMPLE.COM", NormalizedUserName = "ARTIST1" },
                new ApplicationUser { UserName = "customer1", Email = "customer1@example.com", FirstName = "Customer", LastName = "One", IsActive = true, CreatedBy = "System", CreatedOn = DateTime.UtcNow, LastModifiedBy = "System", LastModifiedOn = DateTime.UtcNow, NormalizedEmail = "CUSTOMER1@EXAMPLE.COM", NormalizedUserName = "CUSTOMER1" }
            };
            context.Users.AddRange(users);

            // Seed Designs
            var designs = new List<Design>();
            for (int i = 1; i <= 50; i++)
            {
                designs.Add(new Design
                {
                    Title = $"Design {i}",
                    Description = $"Unique artwork design {i}",
                    Price = 5.00m + (i % 5),
                    IsActive = true,
                    Status = DesignStatus.Approved,
                    UploadedAt = DateTime.UtcNow.AddDays(-i),
                    ReviewedAt = DateTime.UtcNow.AddDays(-i + 1),
                    ArtistId = users.First(u => u.UserName == "artist1").Id,
                    AdminId = users.First(u => u.UserName == "admin1").Id,
                    CreatedBy = "artist1",
                    CreatedOn = DateTime.UtcNow.AddDays(-i),
                    LastModifiedBy = "admin1",
                    LastModifiedOn = DateTime.UtcNow.AddDays(-i + 1)
                });
            }
            context.Designs.AddRange(designs);

            // Seed Design Images
            var designImages = new List<DesignImage>();
            foreach (var design in designs)
            {
                designImages.Add(new DesignImage
                {
                    ImageUrl = $"https://ih1.redbubble.net/image.{design.Id}.1000x1000.jpg",
                    FileName = $"design_{design.Id}.jpg",
                    AltText = $"Image for {design.Title}",
                    IsPrimary = true,
                    IsActive = true,
                    DsignId = design.Id, // Matches property name in DesignImage.cs
                    CreatedBy = "artist1",
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = "artist1",
                    LastModifiedOn = DateTime.UtcNow
                });
            }
            context.DesignImages.AddRange(designImages);

            // Seed Product Variants
            var productVariants = new List<ProductVariant>();
            var random = new Random();
            var sizeIds = sizes.Select(s => s.Id).ToList();
            var colorIds = colors.Select(c => c.Id).ToList();
            var baseProductIds = baseProducts.Select(bp => bp.Id).ToList();
            var designIds = designs.Select(d => d.Id).ToList();

            for (int i = 1; i <= 200; i++)
            {
                var baseProduct = baseProducts[random.Next(baseProducts.Count)];
                var variantSizes = new List<Size>();
                var variantColors = new List<Color>();
                // Assign sizes and colors based on product type
                if (baseProduct.Name.Contains("T-Shirt") || baseProduct.Name.Contains("Hoodie") || baseProduct.Name == "Leggings" || baseProduct.Name == "Baby Onesie")
                {
                    variantSizes.AddRange(sizes.Where(s => s.SizeName == "XS" || s.SizeName == "Small" || s.SizeName == "Medium" || s.SizeName == "Large" || s.SizeName == "X-Large" || s.SizeName == "2XL").OrderBy(x => random.Next()).Take(random.Next(1, 4)));
                    variantColors.AddRange(colors.OrderBy(x => random.Next()).Take(random.Next(1, 4)));
                }
                else if (baseProduct.Name.Contains("Sticker"))
                {
                    variantSizes.AddRange(sizes.Where(s => s.SizeName == "3x3" || s.SizeName == "4x4" || s.SizeName == "6x6").OrderBy(x => random.Next()).Take(random.Next(1, 3)));
                    variantColors.AddRange(colors.OrderBy(x => random.Next()).Take(1)); // Stickers typically don't vary by color
                }
                else if (baseProduct.Name.Contains("Phone Case"))
                {
                    variantSizes.AddRange(sizes.Where(s => s.SizeName == "iPhone Case" || s.SizeName == "Samsung Case").OrderBy(x => random.Next()).Take(1));
                    variantColors.AddRange(colors.OrderBy(x => random.Next()).Take(random.Next(1, 3)));
                }
                else if (baseProduct.Name.Contains("Poster") || baseProduct.Name == "Framed Print" || baseProduct.Name == "Art Print")
                {
                    variantSizes.AddRange(sizes.Where(s => s.SizeName == "Poster Small" || s.SizeName == "Poster Large").OrderBy(x => random.Next()).Take(1));
                    variantColors.AddRange(colors.OrderBy(x => random.Next()).Take(1));
                }
                else if (baseProduct.Name == "Mug")
                {
                    variantSizes.AddRange(sizes.Where(s => s.SizeName == "Mug Standard").OrderBy(x => random.Next()).Take(1));
                    variantColors.AddRange(colors.OrderBy(x => random.Next()).Take(random.Next(1, 3)));
                }
                else
                {
                    variantSizes.AddRange(sizes.OrderBy(x => random.Next()).Take(random.Next(1, 2)));
                    variantColors.AddRange(colors.OrderBy(x => random.Next()).Take(random.Next(1, 3)));
                }

                var productVariant = new ProductVariant
                {
                    Price = baseProduct.BasePrice + (decimal)(random.NextDouble() * 10),
                    StockQuantity = random.Next(0, 100),
                    IsActive = true,
                    BaseProductId = baseProduct.Id,
                    DesignId = designIds[random.Next(designIds.Count)],
                    CreatedBy = "System",
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = "System",
                    LastModifiedOn = DateTime.UtcNow
                };
                productVariant.Sizes = variantSizes;
                productVariant.Colors = variantColors;
                productVariants.Add(productVariant);
            }
            context.ProductVariants.AddRange(productVariants);

            // Seed Product Variant Images
            var productVariantImages = new List<ProductVariantImages>();
            foreach (var variant in productVariants)
            {
                productVariantImages.Add(new ProductVariantImages
                {
                    ImageUrl = $"https://ih1.redbubble.net/image.{variant.Id}.1000x1000.jpg",
                    FileName = $"variant_{variant.Id}.jpg",
                    AltText = $"Image for product variant {variant.Id}",
                    IsPrimary = true,
                    IsActive = true,
                    ProductVariantId = variant.Id,
                    CreatedBy = "System",
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = "System",
                    LastModifiedOn = DateTime.UtcNow
                });
            }
            context.ProductVariantImages.AddRange(productVariantImages);

            // Seed Orders
            var orders = new List<Order>();
            for (int i = 1; i <= 10; i++)
            {
                orders.Add(new Order
                {
                    CustomerId = users.First(u => u.UserName == "customer1").Id,
                    Status = (OrderStatus)random.Next(0, 5), // Random status: Pending, Processing, Shipped, Delivered, Cancelled
                    TotalAmount = 0, // Will be calculated based on order items
                    CreatedBy = "customer1",
                    CreatedOn = DateTime.UtcNow.AddDays(-i),
                    LastModifiedBy = "System",
                    LastModifiedOn = DateTime.UtcNow.AddDays(-i)
                });
            }
            context.Orders.AddRange(orders);

            // Seed Order Items
            var orderItems = new List<OrderItem>();
            foreach (var order in orders)
            {
                decimal orderTotal = 0;
                for (int i = 0; i < 4; i++)
                {
                    var variant = productVariants[random.Next(productVariants.Count)];
                    var quantity = random.Next(1, 5);
                    var unitPrice = variant.Price;
                    var totalPrice = unitPrice * quantity;
                    orderTotal += totalPrice;

                    orderItems.Add(new OrderItem
                    {
                        OrderId = order.Id,
                        ProductVariantId = variant.Id,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        TotalPrice = totalPrice
                    });
                }
                order.TotalAmount = orderTotal;
            }
            context.OrderItems.AddRange(orderItems);

            context.SaveChanges();
        }
    }
}