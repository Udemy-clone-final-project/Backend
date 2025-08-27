using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Enums;

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
            SeedDesignImages(modelBuilder);
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
                    Description = "System Administrator with full access",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                },
                new ApplicationRole
                {
                    Id = "2",
                    Name = "Artist",
                    NormalizedName = "ARTIST",
                    Description = "Artist who can upload and manage designs",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                },
                new ApplicationRole
                {
                    Id = "3",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                    Description = "Customer who can purchase products",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                }
            );
        }

        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var users = new List<ApplicationUser>();

            // Admin
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
                DisplayName = "System Admin",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true
            });

            // Artists (20 artists)
            string[] artistNames = {
                "Alice Cooper", "Bob Wilson", "Charlie Brown", "Diana Prince", "Emma Stone",
                "Frank Ocean", "Grace Kelly", "Henry Ford", "Iris West", "Jack Sparrow",
                "Kate Winslet", "Liam Neeson", "Maya Angelou", "Noah Webster", "Olivia Wilde",
                "Paul McCartney", "Quinn Fabray", "Rose Tyler", "Sam Smith", "Tina Turner"
            };

            for (int i = 0; i < 20; i++)
            {
                users.Add(new ApplicationUser
                {
                    Id = $"artist-{i + 1:D3}",
                    UserName = $"{artistNames[i].ToLower().Replace(" ", ".")}@email.com",
                    NormalizedUserName = $"{artistNames[i].ToUpper().Replace(" ", ".")}@EMAIL.COM",
                    Email = $"{artistNames[i].ToLower().Replace(" ", ".")}@email.com",
                    NormalizedEmail = $"{artistNames[i].ToUpper().Replace(" ", ".")}@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Artist123!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DisplayName = artistNames[i],
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    IsActive = true
                });
            }

            // Customers (30 customers)
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
                users.Add(new ApplicationUser
                {
                    Id = $"customer-{i + 1:D3}",
                    UserName = $"{customerNames[i].ToLower().Replace(" ", ".")}@email.com",
                    NormalizedUserName = $"{customerNames[i].ToUpper().Replace(" ", ".")}@EMAIL.COM",
                    Email = $"{customerNames[i].ToLower().Replace(" ", ".")}@email.com",
                    NormalizedEmail = $"{customerNames[i].ToUpper().Replace(" ", ".")}@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Customer123!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DisplayName = customerNames[i],
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
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

            // Artist roles (20 artists)
            for (int i = 1; i <= 20; i++)
            {
                userRoles.Add(new IdentityUserRole<string> { UserId = $"artist-{i:D3}", RoleId = "2" });
            }

            // Customer roles (30 customers)
            for (int i = 1; i <= 30; i++)
            {
                userRoles.Add(new IdentityUserRole<string> { UserId = $"customer-{i:D3}", RoleId = "3" });
            }

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }

        private static void SeedAddresses(ModelBuilder modelBuilder)
        {
            var addresses = new List<Address>();

            // Sample addresses for customers
            string[] countries = { "United States", "Canada", "United Kingdom", "Australia", "Germany", "France" };
            string[] cities = { "New York", "Toronto", "London", "Sydney", "Berlin", "Paris" };
            string[] streets = { "Main Street", "Oak Avenue", "Elm Drive", "Pine Road", "Maple Lane", "Cedar Way" };

            for (int i = 1; i <= 30; i++)
            {
                var random = new Random(i);
                addresses.Add(new Address
                {
                    Id = i,
                    FirstName = $"Customer{i}",
                    LastName = $"LastName{i}",
                    Country = countries[random.Next(countries.Length)],
                    City = cities[random.Next(cities.Length)],
                    Street = $"{random.Next(100, 999)} {streets[random.Next(streets.Length)]}",
                    ApplicationUserId = $"customer-{i:D3}"
                });
            }

            modelBuilder.Entity<Address>().HasData(addresses);
        }

        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            var categories = new List<Category>();

            // Main Categories (like RedBubble)
            var mainCategories = new[]
            {
                new { Id = 1, Name = "Clothing", Desc = "Apparel and wearable items" },
                new { Id = 2, Name = "Accessories", Desc = "Fashion and lifestyle accessories" },
                new { Id = 3, Name = "Home & Living", Desc = "Home decor and lifestyle items" },
                new { Id = 4, Name = "Stickers", Desc = "Decorative stickers and decals" },
                new { Id = 5, Name = "Wall Art", Desc = "Prints, posters, and wall decorations" },
                new { Id = 6, Name = "Stationery", Desc = "Notebooks, cards, and office supplies" },
                new { Id = 7, Name = "Bags", Desc = "Tote bags, backpacks, and purses" },
                new { Id = 8, Name = "Tech", Desc = "Phone cases and tech accessories" }
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
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow
                });
            }

            // SubCategories for Clothing
            var clothingSubcategories = new[]
            {
                new { Id = 9, Name = "T-Shirts", Desc = "Classic and graphic t-shirts" },
                new { Id = 10, Name = "Tank Tops", Desc = "Sleeveless tank tops" },
                new { Id = 11, Name = "Long Sleeve Shirts", Desc = "Long sleeve t-shirts" },
                new { Id = 12, Name = "Hoodies", Desc = "Comfortable hoodies and sweatshirts" },
                new { Id = 13, Name = "Zip Hoodies", Desc = "Zip-up hoodies and jackets" },
                new { Id = 14, Name = "Crewneck Sweatshirts", Desc = "Classic crewneck sweatshirts" },
                new { Id = 15, Name = "Dresses", Desc = "Casual and formal dresses" },
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
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow
                });
            }

            // SubCategories for Accessories
            var accessorySubcategories = new[]
            {
                new { Id = 17, Name = "Hats", Desc = "Baseball caps, beanies, and hats" },
                new { Id = 18, Name = "Scarves", Desc = "Fashion scarves and wraps" },
                new { Id = 19, Name = "Socks", Desc = "Fun and colorful socks" },
                new { Id = 20, Name = "Masks", Desc = "Face masks and coverings" },
                new { Id = 21, Name = "Jewelry", Desc = "Pins, badges, and jewelry" }
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
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow
                });
            }

            // SubCategories for Home & Living
            var homeSubcategories = new[]
            {
                new { Id = 22, Name = "Mugs", Desc = "Coffee mugs and drinkware" },
                new { Id = 23, Name = "Travel Mugs", Desc = "Insulated travel mugs" },
                new { Id = 24, Name = "Water Bottles", Desc = "Reusable water bottles" },
                new { Id = 25, Name = "Throw Pillows", Desc = "Decorative throw pillows" },
                new { Id = 26, Name = "Blankets", Desc = "Cozy blankets and throws" },
                new { Id = 27, Name = "Tapestries", Desc = "Wall tapestries and fabric art" },
                new { Id = 28, Name = "Clocks", Desc = "Wall clocks and desk clocks" },
                new { Id = 29, Name = "Candles", Desc = "Scented candles and holders" }
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
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow
                });
            }

            // SubCategories for Tech
            var techSubcategories = new[]
            {
                new { Id = 30, Name = "iPhone Cases", Desc = "iPhone protective cases" },
                new { Id = 31, Name = "Samsung Cases", Desc = "Samsung phone cases" },
                new { Id = 32, Name = "Laptop Sleeves", Desc = "Laptop bags and sleeves" },
                new { Id = 33, Name = "Mouse Pads", Desc = "Computer mouse pads" }
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
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = "admin-001",
                    LastModifiedOn = DateTime.UtcNow
                });
            }

            modelBuilder.Entity<Category>().HasData(categories);
        }

        private static void SeedColors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>().HasData(
                new Color { Id = 1, ColorName = "Black", ColorCode = "#000000", IsActive = true },
                new Color { Id = 2, ColorName = "White", ColorCode = "#FFFFFF", IsActive = true },
                new Color { Id = 3, ColorName = "Navy", ColorCode = "#000080", IsActive = true },
                new Color { Id = 4, ColorName = "Gray", ColorCode = "#808080", IsActive = true },
                new Color { Id = 5, ColorName = "Red", ColorCode = "#FF0000", IsActive = true },
                new Color { Id = 6, ColorName = "Green", ColorCode = "#008000", IsActive = true },
                new Color { Id = 7, ColorName = "Blue", ColorCode = "#0000FF", IsActive = true },
                new Color { Id = 8, ColorName = "Yellow", ColorCode = "#FFFF00", IsActive = true },
                new Color { Id = 9, ColorName = "Purple", ColorCode = "#800080", IsActive = true },
                new Color { Id = 10, ColorName = "Pink", ColorCode = "#FFC0CB", IsActive = true },
                new Color { Id = 11, ColorName = "Orange", ColorCode = "#FFA500", IsActive = true },
                new Color { Id = 12, ColorName = "Brown", ColorCode = "#A52A2A", IsActive = true },
                new Color { Id = 13, ColorName = "Light Blue", ColorCode = "#ADD8E6", IsActive = true },
                new Color { Id = 14, ColorName = "Dark Green", ColorCode = "#006400", IsActive = true },
                new Color { Id = 15, ColorName = "Maroon", ColorCode = "#800000", IsActive = true }
            );
        }

        private static void SeedSizes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Size>().HasData(
                new Size { Id = 1, SizeName = "XS", Description = "Extra Small", IsActive = true },
                new Size { Id = 2, SizeName = "S", Description = "Small", IsActive = true },
                new Size { Id = 3, SizeName = "M", Description = "Medium", IsActive = true },
                new Size { Id = 4, SizeName = "L", Description = "Large", IsActive = true },
                new Size { Id = 5, SizeName = "XL", Description = "Extra Large", IsActive = true },
                new Size { Id = 6, SizeName = "XXL", Description = "Double Extra Large", IsActive = true },
                new Size { Id = 7, SizeName = "3XL", Description = "Triple Extra Large", IsActive = true },
                new Size { Id = 8, SizeName = "One Size", Description = "Universal Size", IsActive = true }
            );
        }

        private static void SeedBaseProducts(ModelBuilder modelBuilder)
        {
            var products = new List<BaseProduct>();

            // T-Shirts
            products.AddRange(new[]
            {
                new BaseProduct { Id = 1, Name = "Classic T-Shirt", Description = "100% cotton classic fit", BasePrice = 19.99m, CategoryId = 9, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 2, Name = "Premium T-Shirt", Description = "Premium soft cotton blend", BasePrice = 24.99m, CategoryId = 9, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 3, Name = "Fitted T-Shirt", Description = "Slim fit cotton t-shirt", BasePrice = 22.99m, CategoryId = 9, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow }
            });

            // Hoodies
            products.AddRange(new[]
            {
                new BaseProduct { Id = 4, Name = "Pullover Hoodie", Description = "Cotton blend pullover hoodie", BasePrice = 39.99m, CategoryId = 12, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 5, Name = "Zip Hoodie", Description = "Full zip cotton hoodie", BasePrice = 44.99m, CategoryId = 13, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow }
            });

            // Phone Cases
            products.AddRange(new[]
            {
                new BaseProduct { Id = 6, Name = "iPhone 14 Case", Description = "Protective iPhone 14 case", BasePrice = 14.99m, CategoryId = 30, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 7, Name = "iPhone 15 Case", Description = "Protective iPhone 15 case", BasePrice = 16.99m, CategoryId = 30, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 8, Name = "Samsung S24 Case", Description = "Samsung Galaxy S24 case", BasePrice = 15.99m, CategoryId = 31, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow }
            });

            // Home Items
            products.AddRange(new[]
            {
                new BaseProduct { Id = 9, Name = "Ceramic Mug", Description = "11oz ceramic coffee mug", BasePrice = 12.99m, CategoryId = 22, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 10, Name = "Travel Mug", Description = "15oz insulated travel mug", BasePrice = 18.99m, CategoryId = 23, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 11, Name = "Art Print", Description = "High quality art print", BasePrice = 16.99m, CategoryId = 5, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 12, Name = "Canvas Print", Description = "Gallery wrapped canvas", BasePrice = 29.99m, CategoryId = 5, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 13, Name = "Throw Pillow", Description = "16x16 inch throw pillow", BasePrice = 19.99m, CategoryId = 25, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 14, Name = "Sticker Pack", Description = "Pack of 3 vinyl stickers", BasePrice = 4.99m, CategoryId = 4, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow },
                new BaseProduct { Id = 15, Name = "Tote Bag", Description = "Cotton canvas tote bag", BasePrice = 14.99m, CategoryId = 7, CreatedBy = "admin-001", CreatedOn = DateTime.UtcNow, LastModifiedBy = "admin-001", LastModifiedOn = DateTime.UtcNow }
            });

            modelBuilder.Entity<BaseProduct>().HasData(products);
        }

        private static void SeedDesigns(ModelBuilder modelBuilder)
        {
            var designs = new List<Design>();
            var random = new Random(42);

            // Design themes like RedBubble
            string[] designTitles = {
                "Sunset Mountains", "Abstract Geometry", "Cute Cat Illustration", "Coffee Lover Quote", "Vintage Floral",
                "Space Galaxy", "Minimalist Lines", "Watercolor Flowers", "Retro Waves", "Mandala Art",
                "Typography Quote", "Nature Forest", "Ocean Waves", "City Skyline", "Botanical Leaves",
                "Geometric Patterns", "Animal Portrait", "Music Notes", "Travel Adventure", "Food Illustration",
                "Inspirational Quote", "Cartoon Character", "Art Deco Design", "Hand Lettering", "Digital Art",
                "Photo Collage", "Sketch Drawing", "Pop Art Style", "Watercolor Paint", "Vector Graphics",
                "Street Art", "Fantasy Theme", "Science Fiction", "Horror Gothic", "Romance Love",
                "Fitness Motivation", "Tech Gaming", "Sports Team", "Holiday Christmas", "Halloween Spooky",
                "Summer Beach", "Winter Snow", "Spring Garden", "Autumn Leaves", "Zen Meditation",
                "Business Professional", "Educational Learning", "Kids Children", "Pets Animals", "Food Cooking",
                "Music Band", "Movie Film", "TV Series", "Book Literature", "Art History",
                "Photography", "Architecture", "Fashion Style", "Beauty Makeup", "Health Wellness",
                "Environment Green", "Social Cause", "Political Statement", "Cultural Heritage", "Religious Spiritual",
                "Hobby Crafts", "Games Puzzle", "Magic Fantasy", "Space Cosmic", "Ocean Marine",
                "Mountain Adventure", "Desert Landscape", "Forest Wildlife", "Garden Botanical", "Urban City",
                "Vintage Retro", "Modern Contemporary", "Classic Traditional", "Futuristic Sci-Fi", "Medieval Historical",
                "Tribal Ethnic", "Japanese Anime", "Korean K-Pop", "European Classic", "American Patriotic",
                "African Culture", "Asian Zen", "Latin Fiesta", "Nordic Viking", "Celtic Irish",
                "Steampunk Gear", "Cyberpunk Neon", "Gothic Dark", "Pastel Soft", "Bold Bright",
                "Monochrome Black", "Rainbow Colorful", "Sunset Orange", "Ocean Blue", "Forest Green",
                "Royal Purple", "Golden Yellow", "Rose Pink", "Silver Gray", "Copper Bronze",
                "Crystal Gem", "Fire Flame", "Ice Frost", "Lightning Storm", "Star Constellation"
            };

            string[] designDescriptions = {
                "Beautiful landscape artwork", "Modern artistic design", "Cute and adorable illustration", "Inspirational typography",
                "Classic vintage pattern", "Cosmic space theme", "Clean minimalist style", "Delicate watercolor art",
                "Retro nostalgic design", "Intricate mandala pattern", "Motivational text design", "Natural scenery art",
                "Flowing water design", "Urban cityscape", "Botanical nature art", "Mathematical patterns",
                "Realistic animal art", "Musical themed design", "Adventure travel art", "Delicious food illustration"
            };

            // Generate 120 designs
            for (int i = 1; i <= 120; i++)
            {
                var artistId = $"artist-{random.Next(1, 21):D3}";
                var isApproved = random.NextDouble() > 0.15; // 85% approval rate
                var status = isApproved ? DesignStatus.Approved : (random.NextDouble() > 0.5 ? DesignStatus.Pending : DesignStatus.Rejected);

                designs.Add(new Design
                {
                    Id = i,
                    Title = $"{designTitles[random.Next(designTitles.Length)]} {i}",
                    Description = designDescriptions[random.Next(designDescriptions.Length)],
                    Price = Math.Round((decimal)(random.NextDouble() * 8 + 2), 2), // $2-10
                    IsActive = true,
                    Status = status,
                    UploadedAt = DateTime.UtcNow.AddDays(-random.Next(1, 90)),
                    ReviewedAt = status != DesignStatus.Pending ? DateTime.UtcNow.AddDays(-random.Next(1, 85)) : default,
                    RejectionReason = status == DesignStatus.Rejected ? "Does not meet quality standards" : null,
                    ArtistId = artistId,
                    AdminId = status != DesignStatus.Pending ? "admin-001" : null,
                    CreatedBy = artistId,
                    CreatedOn = DateTime.UtcNow.AddDays(-random.Next(1, 90)),
                    LastModifiedBy = status != DesignStatus.Pending ? "admin-001" : artistId,
                    LastModifiedOn = DateTime.UtcNow.AddDays(-random.Next(1, 85))
                });
            }

            modelBuilder.Entity<Design>().HasData(designs);
        }

        private static void SeedDesignImages(ModelBuilder modelBuilder)
        {
            var designImages = new List<DesignImage>();
            var random = new Random(123);

            // Expanded list with more than 20 images from Picsum, Unsplash, Pexels, Pixabay (using Picsum for variety and reliability)
            string[] imageUrls = new string[50];
            for (int k = 0; k < 50; k++)
            {
                imageUrls[k] = $"https://picsum.photos/seed/design{k + 1}/800/600";
            }

            // Generate images for all 120 designs
            for (int i = 1; i <= 120; i++)
            {
                var artistId = $"artist-{random.Next(1, 21):D3}";

                designImages.Add(new DesignImage
                {
                    Id = i,
                    ImageUrl = imageUrls[random.Next(imageUrls.Length)],
                    FileName = $"design_{i}.jpg",
                    AltText = $"Design artwork {i}",
                    IsPrimary = true,
                    IsActive = true,
                    DsignId = i,
                    CreatedBy = artistId,
                    CreatedOn = DateTime.UtcNow.AddDays(-random.Next(1, 90)),
                    LastModifiedBy = artistId,
                    LastModifiedOn = DateTime.UtcNow.AddDays(-random.Next(1, 90))
                });
            }

            modelBuilder.Entity<DesignImage>().HasData(designImages);
        }

        private static void SeedProductVariants(ModelBuilder modelBuilder)
        {
            var productVariants = new List<ProductVariant>();
            var random = new Random(456);
            int variantId = 1;

            // Generate 250 product variants (combinations of products, designs, colors, sizes)
            // Only use approved designs (first 102 designs are approved based on 85% approval rate)
            var approvedDesigns = Enumerable.Range(1, 102).ToList();

            foreach (var productId in Enumerable.Range(1, 15))
            {
                foreach (var designId in approvedDesigns.Take(8)) // 8 designs per product
                {
                    foreach (var colorId in Enumerable.Range(1, 5)) // 5 colors per design
                    {
                        var sizeIds = productId <= 5 ? new[] { 1, 2, 3, 4, 5, 6 } : new[] { 8 }; // Clothing gets multiple sizes, accessories get one size

                        foreach (var sizeId in sizeIds)
                        {
                            if (variantId > 250) break; // Limit to 250 variants

                            var basePrice = GetBaseProductPrice(productId);
                            var designPrice = Math.Round((decimal)(random.NextDouble() * 8 + 2), 2);

                            productVariants.Add(new ProductVariant
                            {
                                Id = variantId++,
                                Price = basePrice + designPrice,
                                StockQuantity = random.Next(50, 200),
                                IsActive = true,
                                BaseProductId = productId,
                                DesignId = designId,
                                ColorId = colorId,
                                SizeId = sizeId,
                                CreatedBy = "admin-001",
                                CreatedOn = DateTime.UtcNow.AddDays(-random.Next(1, 30)),
                                LastModifiedBy = "admin-001",
                                LastModifiedOn = DateTime.UtcNow.AddDays(-random.Next(1, 30))
                            });
                        }
                    }
                }
            }

            modelBuilder.Entity<ProductVariant>().HasData(productVariants.Take(250));
        }

        private static decimal GetBaseProductPrice(int productId)
        {
            var basePrices = new Dictionary<int, decimal>
            {
                { 1, 19.99m }, { 2, 24.99m }, { 3, 22.99m }, { 4, 39.99m }, { 5, 44.99m },
                { 6, 14.99m }, { 7, 16.99m }, { 8, 15.99m }, { 9, 12.99m }, { 10, 18.99m },
                { 11, 16.99m }, { 12, 29.99m }, { 13, 19.99m }, { 14, 4.99m }, { 15, 14.99m }
            };
            return basePrices.GetValueOrDefault(productId, 19.99m);
        }

        private static void SeedProductVariantImages(ModelBuilder modelBuilder)
        {
            var images = new List<ProductVariantImages>();
            var random = new Random(789);

            // Expanded list with more than 20 mockup images from Unsplash (t-shirt mockups and others)
            string[] mockupUrls = {
                "https://images.unsplash.com/photo-VQLdvHWikBI?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-lMcxXplVycA?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-x8Vg7Up6TUc?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-fTDWpCxLA0k?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-9ShY-Tq70Mc?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-6Nub980bI3I?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-7WE1LbSc4zM?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-KeJkQ5mVvvk?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-WWesmHEgXDs?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-kkj9iKxsdhY?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-mks2xvUYGnc?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop",
                "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", // Mug mockup example
                "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", // Art print
                "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", // Pillow
                "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", // Sticker
                "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", // Tote bag
                "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", // Canvas
                "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", // Travel mug
                "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", // T-shirt
                "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", // Hoodie
                "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", // Phone case
                // Add more Picsum for variety if needed
                "https://picsum.photos/seed/mockup1/800/600",
                "https://picsum.photos/seed/mockup2/800/600",
                "https://picsum.photos/seed/mockup3/800/600",
                "https://picsum.photos/seed/mockup4/800/600",
                "https://picsum.photos/seed/mockup5/800/600",
                "https://picsum.photos/seed/mockup6/800/600",
                "https://picsum.photos/seed/mockup7/800/600",
                "https://picsum.photos/seed/mockup8/800/600",
                "https://picsum.photos/seed/mockup9/800/600",
                "https://picsum.photos/seed/mockup10/800/600",
                "https://picsum.photos/seed/mockup11/800/600",
                "https://picsum.photos/seed/mockup12/800/600",
                "https://picsum.photos/seed/mockup13/800/600",
                "https://picsum.photos/seed/mockup14/800/600",
                "https://picsum.photos/seed/mockup15/800/600",
                "https://picsum.photos/seed/mockup16/800/600",
                "https://picsum.photos/seed/mockup17/800/600",
                "https://picsum.photos/seed/mockup18/800/600",
                "https://picsum.photos/seed/mockup19/800/600",
                "https://picsum.photos/seed/mockup20/800/600",
                "https://picsum.photos/seed/mockup21/800/600",
                "https://picsum.photos/seed/mockup22/800/600",
                "https://picsum.photos/seed/mockup23/800/600",
                "https://picsum.photos/seed/mockup24/800/600",
                "https://picsum.photos/seed/mockup25/800/600",
                "https://picsum.photos/seed/mockup26/800/600",
                "https://picsum.photos/seed/mockup27/800/600",
                "https://picsum.photos/seed/mockup28/800/600",
                "https://picsum.photos/seed/mockup29/800/600",
                "https://picsum.photos/seed/mockup30/800/600"
            };

            // Generate 3-5 images per product variant (first 100 variants)
            for (int variantId = 1; variantId <= 100; variantId++)
            {
                int imageCount = random.Next(3, 6); // 3-5 images per variant

                for (int j = 0; j < imageCount; j++)
                {
                    images.Add(new ProductVariantImages
                    {
                        Id = (variantId - 1) * 5 + j + 1,
                        ImageUrl = mockupUrls[random.Next(mockupUrls.Length)],
                        FileName = $"variant_{variantId}_image_{j + 1}.jpg",
                        AltText = $"Product variant {variantId} mockup image {j + 1}",
                        IsPrimary = j == 0, // First image is primary
                        IsActive = true,
                        ProductVariantId = variantId,
                        CreatedBy = "admin-001",
                        CreatedOn = DateTime.UtcNow.AddDays(-random.Next(1, 30)),
                        LastModifiedBy = "admin-001",
                        LastModifiedOn = DateTime.UtcNow.AddDays(-random.Next(1, 30))
                    });
                }
            }

            modelBuilder.Entity<ProductVariantImages>().HasData(images);
        }

        private static void SeedOrders(ModelBuilder modelBuilder)
        {
            var orders = new List<Order>();
            var random = new Random(999);

            string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio", "San Diego", "Dallas", "San Jose" };
            string[] countries = { "United States", "Canada", "United Kingdom", "Australia", "Germany" };
            string[] streets = { "Main St", "Oak Ave", "Pine Rd", "Elm Dr", "Maple Ln", "Cedar Way", "Park Blvd", "First St", "Second Ave", "Third Dr" };

            // Generate 50 orders
            for (int i = 1; i <= 50; i++)
            {
                var customerId = $"customer-{random.Next(1, 31):D3}";
                var orderDate = DateTime.UtcNow.AddDays(-random.Next(1, 180));
                var status = (OrderStatus)random.Next(0, 5);

                orders.Add(new Order
                {
                    Id = i,
                    TotalAmount = 0, // Will be calculated from order items
                    Status = status,
                    ShippingAddress = $"{random.Next(100, 999)} {streets[random.Next(streets.Length)]}",
                    ShippingCity = cities[random.Next(cities.Length)],
                    ShippingCountry = countries[random.Next(countries.Length)],
                    ShippingPostalCode = $"{random.Next(10000, 99999)}",
                    CustomerId = customerId,
                    CreatedBy = customerId,
                    CreatedOn = orderDate,
                    LastModifiedBy = customerId,
                    LastModifiedOn = orderDate.AddHours(random.Next(1, 48))
                });
            }

            modelBuilder.Entity<Order>().HasData(orders);
        }

        private static void SeedOrderItems(ModelBuilder modelBuilder)
        {
            var orderItems = new List<OrderItem>();
            var random = new Random(777);

            int itemId = 1;

            // Generate 2-5 items per order
            for (int orderId = 1; orderId <= 50; orderId++)
            {
                int itemCount = random.Next(2, 6);
                decimal orderTotal = 0;

                for (int j = 0; j < itemCount; j++)
                {
                    var productVariantId = random.Next(1, 101); // Random variant from first 100
                    var quantity = random.Next(1, 4);
                    var unitPrice = Math.Round((decimal)(random.NextDouble() * 30 + 15), 2); // $15-45
                    var totalPrice = unitPrice * quantity;
                    orderTotal += totalPrice;

                    orderItems.Add(new OrderItem
                    {
                        Id = itemId++,
                        UnitPrice = unitPrice,
                        TotalPrice = totalPrice,
                        Quantity = quantity,
                        OrderId = orderId,
                        ProductVariantId = productVariantId
                    });
                }

                // Update order total (would be handled by business logic in real app)
                // Note: This is simplified for seeding - in real app, calculate from items
            }

            modelBuilder.Entity<OrderItem>().HasData(orderItems);

        }
    }
}