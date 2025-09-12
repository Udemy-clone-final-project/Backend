using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_ParentCategory",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Designs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AltText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AdminId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designs_AspNetUsers_AdminId",
                        column: x => x.AdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Designs_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Designs_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaseProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    StockQuantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    BaseProductId = table.Column<int>(type: "int", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_BaseProducts_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "BaseProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariantImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AltText = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariantImages_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2025, 9, 2, 19, 39, 21, 24, DateTimeKind.Utc).AddTicks(4988), "System Administrator with full access to manage products and designs", true, "Admin", "ADMIN" },
                    { "2", null, new DateTime(2025, 9, 2, 19, 39, 21, 24, DateTimeKind.Utc).AddTicks(4996), "Customer who can browse and purchase products", true, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "admin-001", 0, "06bf3e1b-aa38-4e6a-8eeb-e53f737c6e26", new DateTime(2025, 9, 2, 19, 39, 21, 192, DateTimeKind.Utc).AddTicks(7322), "System Administrator", "admin@redbubble.com", true, true, false, null, "ADMIN@REDBUBBLE.COM", "ADMIN@REDBUBBLE.COM", "AQAAAAIAAYagAAAAELKNY/vzwGFGBckeaQuPGxIhH94NJDn8B7dL14NImAo83jGSPZNBOImfuXo4z63PPQ==", null, false, "0802df45-ec27-435c-b8dc-787991f54c76", false, new DateTime(2025, 9, 2, 19, 39, 21, 192, DateTimeKind.Utc).AddTicks(7332), "admin@redbubble.com" },
                    { "customer-001", 0, "10320a7d-046b-4c1a-960d-c50e1bb7a2b4", new DateTime(2024, 12, 11, 19, 39, 21, 361, DateTimeKind.Utc).AddTicks(3656), "John Doe", "john.doe@email.com", true, true, false, null, "JOHN.DOE@EMAIL.COM", "JOHN.DOE@EMAIL.COM", "AQAAAAIAAYagAAAAEBM2EDBYTdohYi9SYYpZOUHe0UpaqWtpI+dmufGW4ykXyNFD/GT0WplhQOW4le5fuA==", null, false, "4fc8ecb5-daf3-41e3-9e32-9627ed60dbc6", false, new DateTime(2025, 8, 11, 19, 39, 21, 361, DateTimeKind.Utc).AddTicks(3713), "john.doe@email.com" },
                    { "customer-002", 0, "5c491b98-f490-4154-89cb-61a063ca97a8", new DateTime(2025, 6, 3, 19, 39, 21, 539, DateTimeKind.Utc).AddTicks(1081), "Jane Smith", "jane.smith@email.com", true, true, false, null, "JANE.SMITH@EMAIL.COM", "JANE.SMITH@EMAIL.COM", "AQAAAAIAAYagAAAAEHELv/Y9HL+MbRxqYk0vejHHD9XdC8ycg6PrjCoyN5yeHSnhR8Ea/PskWbqiq3CPaQ==", null, false, "d5e4f296-93f9-4eee-be0d-bc58e3276eae", false, new DateTime(2025, 8, 25, 19, 39, 21, 539, DateTimeKind.Utc).AddTicks(1141), "jane.smith@email.com" },
                    { "customer-003", 0, "37902b5a-8bff-4b2b-87b0-34d4f110be95", new DateTime(2024, 11, 25, 19, 39, 21, 715, DateTimeKind.Utc).AddTicks(5234), "Michael Johnson", "michael.johnson@email.com", true, true, false, null, "MICHAEL.JOHNSON@EMAIL.COM", "MICHAEL.JOHNSON@EMAIL.COM", "AQAAAAIAAYagAAAAEAFvIABEpQKtJWbmotFwsCM0OIYtAmTHRegV+KA3YzXL+Lf72za5r4naxPbX+5nv0w==", null, false, "85318b2f-07a6-46bd-87ae-5d9e04809290", false, new DateTime(2025, 8, 10, 19, 39, 21, 715, DateTimeKind.Utc).AddTicks(5304), "michael.johnson@email.com" },
                    { "customer-004", 0, "e924fe0b-bcc3-4c7d-b884-b6e43baa6e46", new DateTime(2025, 5, 18, 19, 39, 21, 929, DateTimeKind.Utc).AddTicks(8869), "Sarah Williams", "sarah.williams@email.com", true, true, false, null, "SARAH.WILLIAMS@EMAIL.COM", "SARAH.WILLIAMS@EMAIL.COM", "AQAAAAIAAYagAAAAECUCK6gOeLDn3R6Irm0TYvLyb72Yh39RNOi/YhhBm5MprRRX/vSy+Elru1ZY1lc/qg==", null, false, "9fef9706-d723-449e-8a5e-31cd73b038ff", false, new DateTime(2025, 8, 24, 19, 39, 21, 929, DateTimeKind.Utc).AddTicks(8930), "sarah.williams@email.com" },
                    { "customer-005", 0, "3af8945f-ea7a-46be-8831-77ee44161b59", new DateTime(2024, 11, 8, 19, 39, 22, 316, DateTimeKind.Utc).AddTicks(6655), "David Brown", "david.brown@email.com", true, true, false, null, "DAVID.BROWN@EMAIL.COM", "DAVID.BROWN@EMAIL.COM", "AQAAAAIAAYagAAAAEBys3guL4ZSo8vFd+iuMnc1l203dghiSukep4+iPbaWoc8ovsHE/C5rSVsru8QK3kw==", null, false, "22fc32c2-d389-4da6-b590-113a92c2137e", false, new DateTime(2025, 8, 9, 19, 39, 22, 316, DateTimeKind.Utc).AddTicks(6724), "david.brown@email.com" },
                    { "customer-006", 0, "3207593d-575a-43af-85a0-68e32365b972", new DateTime(2025, 5, 1, 19, 39, 22, 575, DateTimeKind.Utc).AddTicks(7603), "Emily Davis", "emily.davis@email.com", true, true, false, null, "EMILY.DAVIS@EMAIL.COM", "EMILY.DAVIS@EMAIL.COM", "AQAAAAIAAYagAAAAEGE75o9qPp2+DqU2LhHNwKKv//sBhIzkDvcSzKUJZh2VizPKwX/l1wp7QZLBhtjBSA==", null, false, "21b69db6-6a12-467f-b7ad-2d6c89cf693e", false, new DateTime(2025, 8, 23, 19, 39, 22, 575, DateTimeKind.Utc).AddTicks(7660), "emily.davis@email.com" },
                    { "customer-007", 0, "ba9d92f0-c09b-4366-94d4-92375030143f", new DateTime(2024, 10, 23, 19, 39, 22, 837, DateTimeKind.Utc).AddTicks(8260), "James Miller", "james.miller@email.com", true, true, false, null, "JAMES.MILLER@EMAIL.COM", "JAMES.MILLER@EMAIL.COM", "AQAAAAIAAYagAAAAEFI8X7CjKNLpi4F/xH2WNAi6+KMhykIRYvEICulLJ0f5yP9yfoDENEGROh8lfhIo/g==", null, false, "54927c3b-a082-4ce7-b91a-aebd61c58998", false, new DateTime(2025, 8, 8, 19, 39, 22, 837, DateTimeKind.Utc).AddTicks(8322), "james.miller@email.com" },
                    { "customer-008", 0, "19f3ffa5-7873-4db2-8021-17197a0c6bef", new DateTime(2025, 4, 15, 19, 39, 23, 98, DateTimeKind.Utc).AddTicks(6972), "Jessica Wilson", "jessica.wilson@email.com", true, true, false, null, "JESSICA.WILSON@EMAIL.COM", "JESSICA.WILSON@EMAIL.COM", "AQAAAAIAAYagAAAAEKfvG5TmxPmaiqCxkiW1seFopdQCo8Ls/8r1HOx579Dcw45yrwupDMSod8NaIVbwOg==", null, false, "ac41a45a-d470-4d8c-89a1-946d368fe8b4", false, new DateTime(2025, 8, 21, 19, 39, 23, 98, DateTimeKind.Utc).AddTicks(7035), "jessica.wilson@email.com" },
                    { "customer-009", 0, "202a7e32-e9a7-4d03-8012-aff5779b145c", new DateTime(2024, 10, 7, 19, 39, 23, 365, DateTimeKind.Utc).AddTicks(5866), "Robert Moore", "robert.moore@email.com", true, true, false, null, "ROBERT.MOORE@EMAIL.COM", "ROBERT.MOORE@EMAIL.COM", "AQAAAAIAAYagAAAAEHMprXrrHxaXvuWcNGWudlnsDQwt/RKvOzjAgQRZHIGccoj2JcxRDL7Q8JKgtzIjSA==", null, false, "f70e1ae1-de9c-4043-a025-9193a4d08345", false, new DateTime(2025, 8, 6, 19, 39, 23, 365, DateTimeKind.Utc).AddTicks(5927), "robert.moore@email.com" },
                    { "customer-010", 0, "5cf4fed3-3cba-4dfa-82dd-766f075593e4", new DateTime(2025, 3, 30, 19, 39, 23, 549, DateTimeKind.Utc).AddTicks(834), "Ashley Taylor", "ashley.taylor@email.com", true, true, false, null, "ASHLEY.TAYLOR@EMAIL.COM", "ASHLEY.TAYLOR@EMAIL.COM", "AQAAAAIAAYagAAAAEOOOZKMqew6rTznN4p2pIfL4wCKk4sgrsrMrgSkPYC/VNurqgrOtl9vJTbJf/d5TCw==", null, false, "e3a1335a-9e23-4ade-be96-ac5c45b8cf70", false, new DateTime(2025, 8, 20, 19, 39, 23, 549, DateTimeKind.Utc).AddTicks(900), "ashley.taylor@email.com" },
                    { "customer-011", 0, "5a259d28-2a52-4f4d-aadd-cdd4dede2137", new DateTime(2024, 9, 21, 19, 39, 23, 764, DateTimeKind.Utc).AddTicks(7701), "Christopher Anderson", "christopher.anderson@email.com", true, true, false, null, "CHRISTOPHER.ANDERSON@EMAIL.COM", "CHRISTOPHER.ANDERSON@EMAIL.COM", "AQAAAAIAAYagAAAAEJIfPANmGsZ5lfBxEdNxITNxY9bQMPpLnwIDC1k+lIbHFm2pgYGLdsQ//r8LopYZFg==", null, false, "fbda607d-74ac-4a04-8e17-e59c58d1abaf", false, new DateTime(2025, 8, 5, 19, 39, 23, 764, DateTimeKind.Utc).AddTicks(7762), "christopher.anderson@email.com" },
                    { "customer-012", 0, "2352949d-135d-4e9f-99ad-db7e7142cc62", new DateTime(2025, 3, 13, 19, 39, 23, 995, DateTimeKind.Utc).AddTicks(175), "Amanda Thomas", "amanda.thomas@email.com", true, true, false, null, "AMANDA.THOMAS@EMAIL.COM", "AMANDA.THOMAS@EMAIL.COM", "AQAAAAIAAYagAAAAEEWBOCB1R9MAoiEE8erp981ycmEiCsNRAUxCp5/SutxLiGrcyv69LiA69BOu1rfA/Q==", null, false, "0bd17640-8d97-48cb-b075-a4a9bb0fde16", false, new DateTime(2025, 8, 19, 19, 39, 23, 995, DateTimeKind.Utc).AddTicks(239), "amanda.thomas@email.com" },
                    { "customer-013", 0, "2a24ea84-4bad-426f-9600-4ce6915915f3", new DateTime(2024, 9, 4, 19, 39, 24, 210, DateTimeKind.Utc).AddTicks(1787), "Matthew Jackson", "matthew.jackson@email.com", true, true, false, null, "MATTHEW.JACKSON@EMAIL.COM", "MATTHEW.JACKSON@EMAIL.COM", "AQAAAAIAAYagAAAAEAWfUKeB/HCtW/SZua2QXjs7kUAjnXzCpO23HZoXSUPenIF6VQMc+QwHBYq90VeepQ==", null, false, "071adf2e-2802-4635-a629-19e79a191507", false, new DateTime(2025, 8, 4, 19, 39, 24, 210, DateTimeKind.Utc).AddTicks(1852), "matthew.jackson@email.com" },
                    { "customer-014", 0, "2b80d37e-c221-4540-85fa-e0cadd33caae", new DateTime(2025, 2, 25, 19, 39, 24, 387, DateTimeKind.Utc).AddTicks(5430), "Melissa White", "melissa.white@email.com", true, true, false, null, "MELISSA.WHITE@EMAIL.COM", "MELISSA.WHITE@EMAIL.COM", "AQAAAAIAAYagAAAAEGNBfkpcQSTxpDYBhWzZrJ3K0kWfCg2/TvMBtXhacd74QFY1pP+5HXs83Vyl2CMajA==", null, false, "e7f5d6c8-6328-4e6b-b158-f84ab905ec9c", false, new DateTime(2025, 8, 17, 19, 39, 24, 387, DateTimeKind.Utc).AddTicks(5488), "melissa.white@email.com" },
                    { "customer-015", 0, "a17f717d-b829-401c-8396-5da5cb744da1", new DateTime(2025, 8, 18, 19, 39, 24, 568, DateTimeKind.Utc).AddTicks(5662), "Anthony Harris", "anthony.harris@email.com", true, true, false, null, "ANTHONY.HARRIS@EMAIL.COM", "ANTHONY.HARRIS@EMAIL.COM", "AQAAAAIAAYagAAAAEELeSHz+GlZVS5iplGn2gX9yeaBaXHylX4sX9LWctzHlqp4VZUCdPQ77XP63TTukgg==", null, false, "2cd97a07-fda0-4051-a0a6-c2e993756c24", false, new DateTime(2025, 8, 31, 19, 39, 24, 568, DateTimeKind.Utc).AddTicks(5718), "anthony.harris@email.com" },
                    { "customer-016", 0, "ad9049b3-34f1-4ef0-a84d-d2c414bcd1ba", new DateTime(2025, 2, 9, 19, 39, 24, 731, DateTimeKind.Utc).AddTicks(7623), "Stephanie Martin", "stephanie.martin@email.com", true, true, false, null, "STEPHANIE.MARTIN@EMAIL.COM", "STEPHANIE.MARTIN@EMAIL.COM", "AQAAAAIAAYagAAAAEE9906M1NS0pW7nicyWqYfAqcM4bX6yAT1+Ax2ItaCwvbSZwd2WMsZs0BOJ+7c6dfQ==", null, false, "79ee0abc-4766-49e4-ad72-be916958e390", false, new DateTime(2025, 8, 16, 19, 39, 24, 731, DateTimeKind.Utc).AddTicks(7684), "stephanie.martin@email.com" },
                    { "customer-017", 0, "fdd7aa0f-1d80-4bac-98bb-fe33f0948499", new DateTime(2025, 8, 2, 19, 39, 24, 923, DateTimeKind.Utc).AddTicks(4005), "Mark Thompson", "mark.thompson@email.com", true, true, false, null, "MARK.THOMPSON@EMAIL.COM", "MARK.THOMPSON@EMAIL.COM", "AQAAAAIAAYagAAAAEL8XtfwkWuQOA8B1srZMfgG4v68qBo6+S+043EJtPdBqDfVpiSv41z4Cz63FeHWoaA==", null, false, "ede5849a-dc4a-43e8-8c81-c838fbfdb223", false, new DateTime(2025, 8, 30, 19, 39, 24, 923, DateTimeKind.Utc).AddTicks(4070), "mark.thompson@email.com" },
                    { "customer-018", 0, "71ba39cd-c959-4d2b-8925-97f2aa093e81", new DateTime(2025, 1, 23, 19, 39, 25, 97, DateTimeKind.Utc).AddTicks(5947), "Laura Garcia", "laura.garcia@email.com", true, true, false, null, "LAURA.GARCIA@EMAIL.COM", "LAURA.GARCIA@EMAIL.COM", "AQAAAAIAAYagAAAAECve1jhopsMKvOTaibkASSrsi35/y7Jt6kwhRCnsZXe+vEzR2HxHYac6AXMKSLhTvw==", null, false, "8c55a5e4-ccd8-496b-b5d1-cabd52374c8c", false, new DateTime(2025, 8, 15, 19, 39, 25, 97, DateTimeKind.Utc).AddTicks(6005), "laura.garcia@email.com" },
                    { "customer-019", 0, "8b22e07c-aa48-48f4-8416-6943dc843a76", new DateTime(2025, 7, 16, 19, 39, 25, 243, DateTimeKind.Utc).AddTicks(4642), "Steven Martinez", "steven.martinez@email.com", true, true, false, null, "STEVEN.MARTINEZ@EMAIL.COM", "STEVEN.MARTINEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEEjjyBP4y4QsgCD4hbai5x87HpflMICqJFtAaGnCV+XVyk+vxSY7uKDfm1i4kVoq+Q==", null, false, "ac22619e-309f-41d2-be98-8aea4cdbca3d", false, new DateTime(2025, 8, 29, 19, 39, 25, 243, DateTimeKind.Utc).AddTicks(4694), "steven.martinez@email.com" },
                    { "customer-020", 0, "37b25123-decc-42b0-aa67-23c7c87789e0", new DateTime(2025, 1, 7, 19, 39, 25, 392, DateTimeKind.Utc).AddTicks(2564), "Michelle Robinson", "michelle.robinson@email.com", true, true, false, null, "MICHELLE.ROBINSON@EMAIL.COM", "MICHELLE.ROBINSON@EMAIL.COM", "AQAAAAIAAYagAAAAEDXe/3vv73EZEqEsV38eqNAjkUVqsYjUUgiTpwKntC33vXtd3HypT+Am++IJry7ylQ==", null, false, "d71d530d-c6eb-44b5-9940-85e924972a63", false, new DateTime(2025, 8, 14, 19, 39, 25, 392, DateTimeKind.Utc).AddTicks(2619), "michelle.robinson@email.com" },
                    { "customer-021", 0, "3e6e3d56-f1a9-4c17-8665-383c7e44d5b0", new DateTime(2025, 6, 30, 19, 39, 25, 532, DateTimeKind.Utc).AddTicks(7715), "Kevin Clark", "kevin.clark@email.com", true, true, false, null, "KEVIN.CLARK@EMAIL.COM", "KEVIN.CLARK@EMAIL.COM", "AQAAAAIAAYagAAAAEP+8XhOXN+9ZIRbKEGteiWsKcOYYxr8C1catcmfbCZJb/s1fH+hR6njmrLsoYK1GWA==", null, false, "9e0c8ea6-b47e-4497-abeb-c8010ef0c4ec", false, new DateTime(2025, 8, 27, 19, 39, 25, 532, DateTimeKind.Utc).AddTicks(7768), "kevin.clark@email.com" },
                    { "customer-022", 0, "68b5df19-30b0-46e8-bfec-8683fd468673", new DateTime(2024, 12, 22, 19, 39, 25, 677, DateTimeKind.Utc).AddTicks(6785), "Kimberly Rodriguez", "kimberly.rodriguez@email.com", true, true, false, null, "KIMBERLY.RODRIGUEZ@EMAIL.COM", "KIMBERLY.RODRIGUEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEOQ6+pxfsUU4QNqiAmKghruyy7yiGWCTLG4Kf1clvr6hrxC4jhsRXR8XHf+7LsNMFQ==", null, false, "33434a91-441d-488d-b251-3473f9d504a4", false, new DateTime(2025, 8, 12, 19, 39, 25, 677, DateTimeKind.Utc).AddTicks(6837), "kimberly.rodriguez@email.com" },
                    { "customer-023", 0, "23106810-22a2-4e13-b3e6-dcd9baa40c51", new DateTime(2025, 6, 14, 19, 39, 25, 829, DateTimeKind.Utc).AddTicks(6799), "Joshua Lewis", "joshua.lewis@email.com", true, true, false, null, "JOSHUA.LEWIS@EMAIL.COM", "JOSHUA.LEWIS@EMAIL.COM", "AQAAAAIAAYagAAAAEPwHb8eXNvK+4XxlNdmlrj5bC3D0azR1mKHe3y1eC+SHl5v72mx4E09WRimL7APIcg==", null, false, "0ce4aa66-b0f8-4846-9169-4cc08a28a729", false, new DateTime(2025, 8, 26, 19, 39, 25, 829, DateTimeKind.Utc).AddTicks(6852), "joshua.lewis@email.com" },
                    { "customer-024", 0, "31bab74f-4590-44ea-96bd-0ba5f11efbec", new DateTime(2024, 12, 5, 19, 39, 25, 980, DateTimeKind.Utc).AddTicks(1422), "Lisa Lee", "lisa.lee@email.com", true, true, false, null, "LISA.LEE@EMAIL.COM", "LISA.LEE@EMAIL.COM", "AQAAAAIAAYagAAAAEGQzvznmHaglQsNk6vrTpLFpRkrEjft+wti5DEC3dMI5HhqGqPv/2ZQmPsFkiFvZLg==", null, false, "d9b2189c-a404-476d-837b-26c5b86de77b", false, new DateTime(2025, 8, 11, 19, 39, 25, 980, DateTimeKind.Utc).AddTicks(1475), "lisa.lee@email.com" },
                    { "customer-025", 0, "ba4b41bf-bea1-409e-9ea9-ead02fb3f3e4", new DateTime(2025, 5, 28, 19, 39, 26, 135, DateTimeKind.Utc).AddTicks(5631), "Andrew Walker", "andrew.walker@email.com", true, true, false, null, "ANDREW.WALKER@EMAIL.COM", "ANDREW.WALKER@EMAIL.COM", "AQAAAAIAAYagAAAAEISvtWvraTWQpOhzf7oCTbvQb2JZ2OqaNtlSqU4zun6ye8Fy1n1RRpMFpim5Ke7OWQ==", null, false, "95a4df77-585d-4960-b9aa-1b50ce95e754", false, new DateTime(2025, 8, 25, 19, 39, 26, 135, DateTimeKind.Utc).AddTicks(5696), "andrew.walker@email.com" },
                    { "customer-026", 0, "82ea7004-a7c1-4fa9-a54d-9e3c13fb88de", new DateTime(2024, 11, 19, 19, 39, 26, 301, DateTimeKind.Utc).AddTicks(4750), "Nancy Hall", "nancy.hall@email.com", true, true, false, null, "NANCY.HALL@EMAIL.COM", "NANCY.HALL@EMAIL.COM", "AQAAAAIAAYagAAAAELW1xRGiKCNPN8jZ+6QwnxpcP/7GGdHXRz5qRKnRrvfJPcdktBJZn4cIFDQBM8f+cg==", null, false, "cd26f51d-fe21-45a8-80cd-eb2bc0d8d4c1", false, new DateTime(2025, 8, 10, 19, 39, 26, 301, DateTimeKind.Utc).AddTicks(4820), "nancy.hall@email.com" },
                    { "customer-027", 0, "b4ecddff-7299-4028-bb00-71b4f5374aa0", new DateTime(2025, 5, 12, 19, 39, 26, 469, DateTimeKind.Utc).AddTicks(4580), "Brian Allen", "brian.allen@email.com", true, true, false, null, "BRIAN.ALLEN@EMAIL.COM", "BRIAN.ALLEN@EMAIL.COM", "AQAAAAIAAYagAAAAEO4dVMyVner4/zdvJ0UWYMDx8yAweUSaIy2C5V0CbwOQZh1tpGz3M8L1KAk09JWJLQ==", null, false, "2279341a-d1a2-4bf2-9511-a6c199b393dd", false, new DateTime(2025, 8, 24, 19, 39, 26, 469, DateTimeKind.Utc).AddTicks(4642), "brian.allen@email.com" },
                    { "customer-028", 0, "be3dcef2-91c9-41c5-97b9-7b33274ad20f", new DateTime(2024, 11, 3, 19, 39, 26, 633, DateTimeKind.Utc).AddTicks(598), "Betty Young", "betty.young@email.com", true, true, false, null, "BETTY.YOUNG@EMAIL.COM", "BETTY.YOUNG@EMAIL.COM", "AQAAAAIAAYagAAAAEPIgCkitMnnV7HldXPI8hVx9Zjb4nCJM3u0td4nqGrnwX1FNHD7TAagflzO1tBQtPw==", null, false, "17f4502f-cb19-4b50-8777-78adb7b97784", false, new DateTime(2025, 8, 8, 19, 39, 26, 633, DateTimeKind.Utc).AddTicks(652), "betty.young@email.com" },
                    { "customer-029", 0, "bcefe828-3daa-4fe3-b3a6-594c49ab7fc1", new DateTime(2025, 4, 26, 19, 39, 26, 780, DateTimeKind.Utc).AddTicks(4676), "Gary Hernandez", "gary.hernandez@email.com", true, true, false, null, "GARY.HERNANDEZ@EMAIL.COM", "GARY.HERNANDEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEAV55YD6EqrG1uej+VHbi7PW3veOgrBrn9JClAcgehmu9RjgYMbvBszIiWdkbBjqRA==", null, false, "0a96e0ee-9072-4065-a0cd-41d10fd4efd0", false, new DateTime(2025, 8, 22, 19, 39, 26, 780, DateTimeKind.Utc).AddTicks(4736), "gary.hernandez@email.com" },
                    { "customer-030", 0, "8fdf4a55-bb12-4361-9e1d-cb851980aa50", new DateTime(2024, 10, 17, 19, 39, 26, 941, DateTimeKind.Utc).AddTicks(5893), "Helen King", "helen.king@email.com", true, true, false, null, "HELEN.KING@EMAIL.COM", "HELEN.KING@EMAIL.COM", "AQAAAAIAAYagAAAAEL2sFMy5d6w7gBE7pGJaJkoHNIL4vKPATFlHnTlFbRmkz6hQ1HQKSMxKi/58XTSkqA==", null, false, "81c453ca-c62d-4fc1-b9a0-163ae4be50ea", false, new DateTime(2025, 8, 7, 19, 39, 26, 941, DateTimeKind.Utc).AddTicks(5947), "helen.king@email.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Clothing", "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2292), "Apparel and wearable items for all ages", true, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2296), null },
                    { 2, "Accessories", "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2304), "Fashion and lifestyle accessories", true, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2305), null },
                    { 3, "Home & Living", "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2307), "Home decor and lifestyle items", true, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2308), null },
                    { 4, "Stickers & Decals", "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2312), "Decorative stickers and decals", true, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2313), null },
                    { 5, "Wall Art", "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2315), "Prints, posters, and wall decorations", true, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2316), null },
                    { 6, "Stationery & Office", "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2321), "Notebooks, cards, and office supplies", true, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2322), null },
                    { 7, "Bags & Purses", "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2324), "Tote bags, backpacks, and purses", true, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2326), null },
                    { 8, "Tech Accessories", "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2328), "Phone cases and tech accessories", true, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2329), null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorCode", "ColorName", "IsActive" },
                values: new object[,]
                {
                    { 1, "#000000", "Black", true },
                    { 2, "#FFFFFF", "White", true },
                    { 3, "#000080", "Navy Blue", true },
                    { 4, "#808080", "Heather Gray", true },
                    { 5, "#DC143C", "Crimson Red", true },
                    { 6, "#228B22", "Forest Green", true },
                    { 7, "#4169E1", "Royal Blue", true },
                    { 8, "#FFD700", "Sunshine Yellow", true },
                    { 9, "#663399", "Deep Purple", true },
                    { 10, "#FF69B4", "Rose Pink", true },
                    { 11, "#FF4500", "Sunset Orange", true },
                    { 12, "#8B4513", "Chocolate Brown", true },
                    { 13, "#87CEEB", "Sky Blue", true },
                    { 14, "#50C878", "Emerald Green", true },
                    { 15, "#800020", "Burgundy", true }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Description", "IsActive", "SizeName" },
                values: new object[,]
                {
                    { 1, "Extra Small", true, "XS" },
                    { 2, "Small", true, "S" },
                    { 3, "Medium", true, "M" },
                    { 4, "Large", true, "L" },
                    { 5, "Extra Large", true, "XL" },
                    { 6, "Double Extra Large", true, "XXL" },
                    { 7, "Triple Extra Large", true, "3XL" },
                    { 8, "Universal Size", true, "One Size" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApplicationUserId", "City", "Country", "FirstName", "LastName", "Street" },
                values: new object[,]
                {
                    { 1, "admin-001", "San Francisco", "United States", "System", "Administrator", "123 Admin Plaza" },
                    { 2, "customer-001", "Hamburg", "Germany", "Customer1First", "Customer1Last", "3721 Oak Avenue" },
                    { 3, "customer-002", "Houston", "United States", "Customer2First", "Customer2Last", "741 Elm Drive" },
                    { 4, "customer-003", "Paris", "France", "Customer3First", "Customer3Last", "7660 Cedar Way" },
                    { 5, "customer-004", "Los Angeles", "United States", "Customer4First", "Customer4Last", "4680 First Street" },
                    { 6, "customer-005", "Toulouse", "France", "Customer5First", "Customer5Last", "1701 Market Street" },
                    { 7, "customer-006", "Ottawa", "Canada", "Customer6First", "Customer6Last", "8620 Oak Avenue" },
                    { 8, "customer-007", "Osaka", "Japan", "Customer7First", "Customer7Last", "5640 Elm Drive" },
                    { 9, "customer-008", "Montreal", "Canada", "Customer8First", "Customer8Last", "2661 Park Boulevard" },
                    { 10, "customer-009", "Yokohama", "Japan", "Customer9First", "Customer9Last", "9580 Second Avenue" },
                    { 11, "customer-010", "Toronto", "Canada", "Customer10First", "Customer10Last", "6600 Main Street" },
                    { 12, "customer-011", "Rotterdam", "Netherlands", "Customer11First", "Customer11Last", "3620 Pine Road" },
                    { 13, "customer-012", "Liverpool", "United Kingdom", "Customer12First", "Customer12Last", "641 Maple Lane" },
                    { 14, "customer-013", "Eindhoven", "Netherlands", "Customer13First", "Customer13Last", "7560 Park Boulevard" },
                    { 15, "customer-014", "Manchester", "United Kingdom", "Customer14First", "Customer14Last", "4580 Second Avenue" },
                    { 16, "customer-015", "Malmö", "Sweden", "Customer15First", "Customer15Last", "1601 Oak Avenue" },
                    { 17, "customer-016", "Adelaide", "Australia", "Customer16First", "Customer16Last", "8520 Elm Drive" },
                    { 18, "customer-017", "Stockholm", "Sweden", "Customer17First", "Customer17Last", "5540 Cedar Way" },
                    { 19, "customer-018", "Brisbane", "Australia", "Customer18First", "Customer18Last", "2560 First Street" },
                    { 20, "customer-019", "Uppsala", "Sweden", "Customer19First", "Customer19Last", "9480 Market Street" },
                    { 21, "customer-020", "Berlin", "Germany", "Customer20First", "Customer20Last", "6500 Oak Avenue" },
                    { 22, "customer-021", "Bergen", "Norway", "Customer21First", "Customer21Last", "3520 Elm Drive" },
                    { 23, "customer-022", "Cologne", "Germany", "Customer22First", "Customer22Last", "541 Cedar Way" },
                    { 24, "customer-023", "Drammen", "Norway", "Customer23First", "Customer23Last", "7460 Second Avenue" },
                    { 25, "customer-024", "Lyon", "France", "Customer24First", "Customer24Last", "4480 Main Street" },
                    { 26, "customer-025", "Chicago", "United States", "Customer25First", "Customer25Last", "1500 Pine Road" },
                    { 27, "customer-026", "Toulouse", "France", "Customer26First", "Customer26Last", "8420 Maple Lane" },
                    { 28, "customer-027", "New York", "United States", "Customer27First", "Customer27Last", "5440 Park Boulevard" },
                    { 29, "customer-028", "Lyon", "France", "Customer28First", "Customer28Last", "2460 Second Avenue" },
                    { 30, "customer-029", "Calgary", "Canada", "Customer29First", "Customer29Last", "9380 Main Street" },
                    { 31, "customer-030", "Nagoya", "Japan", "Customer30First", "Customer30Last", "6400 Elm Drive" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "admin-001" },
                    { "2", "customer-001" },
                    { "2", "customer-002" },
                    { "2", "customer-003" },
                    { "2", "customer-004" },
                    { "2", "customer-005" },
                    { "2", "customer-006" },
                    { "2", "customer-007" },
                    { "2", "customer-008" },
                    { "2", "customer-009" },
                    { "2", "customer-010" },
                    { "2", "customer-011" },
                    { "2", "customer-012" },
                    { "2", "customer-013" },
                    { "2", "customer-014" },
                    { "2", "customer-015" },
                    { "2", "customer-016" },
                    { "2", "customer-017" },
                    { "2", "customer-018" },
                    { "2", "customer-019" },
                    { "2", "customer-020" },
                    { "2", "customer-021" },
                    { "2", "customer-022" },
                    { "2", "customer-023" },
                    { "2", "customer-024" },
                    { "2", "customer-025" },
                    { "2", "customer-026" },
                    { "2", "customer-027" },
                    { "2", "customer-028" },
                    { "2", "customer-029" },
                    { "2", "customer-030" }
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 11, 16.99m, 5, "admin-001", new DateTime(2025, 6, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Museum-quality giclée art print on archival paper", "admin-001", new DateTime(2025, 7, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Premium Art Print" },
                    { 12, 32.99m, 5, "admin-001", new DateTime(2025, 6, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Gallery-wrapped canvas print with 1.5 inch depth", "admin-001", new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Gallery Canvas Print" },
                    { 14, 4.99m, 4, "admin-001", new DateTime(2025, 5, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Pack of 3 durable vinyl stickers, weather resistant", "admin-001", new DateTime(2025, 6, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Vinyl Sticker Set" },
                    { 15, 14.99m, 7, "admin-001", new DateTime(2025, 5, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Eco-friendly 100% cotton canvas tote bag with reinforced handles", "admin-001", new DateTime(2025, 6, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Canvas Tote Bag" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 9, "T-Shirts", "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2343), "Classic and graphic t-shirts for all occasions", true, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2345), 1 },
                    { 10, "Tank Tops", "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2349), "Comfortable sleeveless tank tops", true, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2350), 1 },
                    { 11, "Long Sleeve Shirts", "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2353), "Cozy long sleeve t-shirts", true, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2354), 1 },
                    { 12, "Hoodies & Sweatshirts", "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2357), "Warm pullover hoodies and sweatshirts", true, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2358), 1 },
                    { 13, "Zip Hoodies", "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2361), "Full-zip hoodies and jackets", true, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2362), 1 },
                    { 14, "Crewneck Sweatshirts", "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2365), "Classic crewneck style sweatshirts", true, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2366), 1 },
                    { 15, "Dresses", "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2369), "Casual and dressy options for all styles", true, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2370), 1 },
                    { 16, "Skirts", "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2372), "Mini, midi, and maxi skirts", true, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2374), 1 },
                    { 17, "Hats & Caps", "admin-001", new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2383), "Baseball caps, beanies, and fashion hats", true, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2384), 2 },
                    { 18, "Scarves", "admin-001", new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2388), "Fashionable scarves and wraps", true, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2390), 2 },
                    { 19, "Socks", "admin-001", new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2392), "Fun and colorful socks with unique designs", true, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2393), 2 },
                    { 20, "Face Masks", "admin-001", new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2396), "Stylish and protective face coverings", true, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2397), 2 },
                    { 21, "Pins & Badges", "admin-001", new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2400), "Enamel pins and collectible badges", true, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2401), 2 },
                    { 22, "Coffee Mugs", "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2518), "Ceramic mugs for your favorite beverages", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2520), 3 },
                    { 23, "Travel Mugs", "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2524), "Insulated travel mugs for on-the-go", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2525), 3 },
                    { 24, "Water Bottles", "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2527), "Reusable water bottles with custom designs", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2529), 3 },
                    { 25, "Throw Pillows", "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2531), "Decorative pillows to enhance your space", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2532), 3 },
                    { 26, "Blankets & Throws", "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2535), "Cozy blankets with artistic designs", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2536), 3 },
                    { 27, "Wall Tapestries", "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2539), "Large fabric wall art and tapestries", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2540), 3 },
                    { 28, "Wall Clocks", "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2543), "Functional art for keeping time", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2544), 3 },
                    { 29, "Candles", "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2547), "Scented candles with custom labels", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2548), 3 },
                    { 30, "iPhone Cases", "admin-001", new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2557), "Protective cases for iPhone models", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2559), 8 },
                    { 31, "Samsung Cases", "admin-001", new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2562), "Samsung Galaxy phone protection", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2563), 8 },
                    { 32, "Laptop Sleeves", "admin-001", new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2566), "Padded laptop bags and sleeves", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2567), 8 },
                    { 33, "Mouse Pads", "admin-001", new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2570), "Gaming and office mouse pads", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2571), 8 },
                    { 34, "Tablet Cases", "admin-001", new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2575), "iPad and tablet protective cases", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(2576), 8 }
                });

            migrationBuilder.InsertData(
                table: "Designs",
                columns: new[] { "Id", "AdminId", "AltText", "ApplicationUserId", "ApplicationUserId1", "CreatedBy", "CreatedOn", "Description", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "admin-001", "Majestic Wolf design artwork", null, null, "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4303), "Realistic wolf portrait in natural setting - Animals themed artwork", "design_1.jpg", "https://picsum.photos/seed/design1/800/600", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4303), 3.00m, "Majestic Wolf #1" },
                    { 2, "admin-001", "Tropical Paradise design artwork", null, null, "admin-001", new DateTime(2025, 7, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4420), "Exotic tropical beach scene with palm trees - Nature themed artwork", "design_2.jpg", "https://picsum.photos/seed/design2/800/600", true, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4420), 7.80m, "Tropical Paradise #2" },
                    { 3, "admin-001", "Tropical Paradise design artwork", null, null, "admin-001", new DateTime(2025, 4, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4444), "Exotic tropical beach scene with palm trees - Nature themed artwork", "design_3.jpg", "https://picsum.photos/seed/design3/800/600", true, "admin-001", new DateTime(2025, 4, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4444), 3.88m, "Tropical Paradise #3" },
                    { 4, "admin-001", "Good Vibes Only design artwork", null, null, "admin-001", new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4460), "Positive mindset typography art - Typography themed artwork", "design_4.jpg", "https://picsum.photos/seed/design4/800/600", true, "admin-001", new DateTime(2025, 7, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4460), 5.05m, "Good Vibes Only #4" },
                    { 5, "admin-001", "Good Vibes Only design artwork", null, null, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4587), "Positive mindset typography art - Typography themed artwork", "design_5.jpg", "https://picsum.photos/seed/design5/800/600", true, "admin-001", new DateTime(2025, 9, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4587), 8.51m, "Good Vibes Only #5" },
                    { 6, "admin-001", "Galaxy Swirl design artwork", null, null, "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4606), "Cosmic galaxy with swirling nebula - Space themed artwork", "design_6.jpg", "https://picsum.photos/seed/design6/800/600", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4606), 2.72m, "Galaxy Swirl #6" },
                    { 7, "admin-001", "Rose Garden design artwork", null, null, "admin-001", new DateTime(2025, 5, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4623), "Elegant vintage rose pattern - Floral themed artwork", "design_7.jpg", "https://picsum.photos/seed/design7/800/600", true, "admin-001", new DateTime(2025, 6, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4623), 2.35m, "Rose Garden #7" },
                    { 8, "admin-001", "Desert Sunset design artwork", null, null, "admin-001", new DateTime(2025, 3, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4639), "Vibrant desert landscape at golden hour - Nature themed artwork", "design_8.jpg", "https://picsum.photos/seed/design8/800/600", true, "admin-001", new DateTime(2025, 4, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4639), 7.54m, "Desert Sunset #8" },
                    { 9, "admin-001", "Tropical Paradise design artwork", null, null, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4653), "Exotic tropical beach scene with palm trees - Nature themed artwork", "design_9.jpg", "https://picsum.photos/seed/design9/800/600", true, "admin-001", new DateTime(2025, 9, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4653), 4.47m, "Tropical Paradise #9" },
                    { 10, "admin-001", "Rose Garden design artwork", null, null, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4668), "Elegant vintage rose pattern - Floral themed artwork", "design_10.jpg", "https://picsum.photos/seed/design10/800/600", true, "admin-001", new DateTime(2025, 9, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4668), 6.29m, "Rose Garden #10" },
                    { 11, "admin-001", "Colorful Butterfly design artwork", null, null, "admin-001", new DateTime(2025, 6, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4685), "Vibrant butterfly with rainbow wings - Animals themed artwork", "design_11.jpg", "https://picsum.photos/seed/design11/800/600", true, "admin-001", new DateTime(2025, 6, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4685), 3.19m, "Colorful Butterfly #11" },
                    { 12, "admin-001", "Ocean Waves design artwork", null, null, "admin-001", new DateTime(2025, 4, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4700), "Peaceful ocean waves in watercolor style - Nature themed artwork", "design_12.jpg", "https://picsum.photos/seed/design12/800/600", true, "admin-001", new DateTime(2025, 4, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4700), 7.01m, "Ocean Waves #12" },
                    { 13, "admin-001", "Marble Texture design artwork", null, null, "admin-001", new DateTime(2025, 4, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4714), "Elegant marble texture with gold veins - Abstract themed artwork", "design_13.jpg", "https://picsum.photos/seed/design13/800/600", true, "admin-001", new DateTime(2025, 5, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4714), 4.32m, "Marble Texture #13" },
                    { 14, "admin-001", "Desert Sunset design artwork", null, null, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4730), "Vibrant desert landscape at golden hour - Nature themed artwork", "design_14.jpg", "https://picsum.photos/seed/design14/800/600", true, "admin-001", new DateTime(2025, 9, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4730), 6.84m, "Desert Sunset #14" },
                    { 15, "admin-001", "Ocean Waves design artwork", null, null, "admin-001", new DateTime(2025, 6, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4744), "Peaceful ocean waves in watercolor style - Nature themed artwork", "design_15.jpg", "https://picsum.photos/seed/design15/800/600", true, "admin-001", new DateTime(2025, 7, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4744), 7.65m, "Ocean Waves #15" },
                    { 16, "admin-001", "Geometric Harmony design artwork", null, null, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4851), "Modern geometric patterns in pastel colors - Abstract themed artwork", "design_16.jpg", "https://picsum.photos/seed/design16/800/600", true, "admin-001", new DateTime(2025, 9, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4851), 4.92m, "Geometric Harmony #16" },
                    { 17, "admin-001", "Ocean Waves design artwork", null, null, "admin-001", new DateTime(2025, 4, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4868), "Peaceful ocean waves in watercolor style - Nature themed artwork", "design_17.jpg", "https://picsum.photos/seed/design17/800/600", true, "admin-001", new DateTime(2025, 5, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4868), 2.57m, "Ocean Waves #17" },
                    { 18, "admin-001", "Mountain Sunrise design artwork", null, null, "admin-001", new DateTime(2025, 4, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4884), "Majestic mountain landscape with golden sunrise - Nature themed artwork", "design_18.jpg", "https://picsum.photos/seed/design18/800/600", true, "admin-001", new DateTime(2025, 4, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4884), 5.51m, "Mountain Sunrise #18" },
                    { 19, "admin-001", "Good Vibes Only design artwork", null, null, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4901), "Positive mindset typography art - Typography themed artwork", "design_19.jpg", "https://picsum.photos/seed/design19/800/600", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4901), 8.63m, "Good Vibes Only #19" },
                    { 20, "admin-001", "Mountain Sunrise design artwork", null, null, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4915), "Majestic mountain landscape with golden sunrise - Nature themed artwork", "design_20.jpg", "https://picsum.photos/seed/design20/800/600", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4915), 7.23m, "Mountain Sunrise #20" },
                    { 21, "admin-001", "Wildflower Meadow design artwork", null, null, "admin-001", new DateTime(2025, 3, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4929), "Delicate wildflower illustration - Floral themed artwork", "design_21.jpg", "https://picsum.photos/seed/design21/800/600", true, "admin-001", new DateTime(2025, 3, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4929), 5.69m, "Wildflower Meadow #21" },
                    { 22, "admin-001", "Cute Cat Face design artwork", null, null, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4943), "Adorable cartoon cat illustration - Animals themed artwork", "design_22.jpg", "https://picsum.photos/seed/design22/800/600", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4943), 4.98m, "Cute Cat Face #22" },
                    { 23, "admin-001", "Coffee First design artwork", null, null, "admin-001", new DateTime(2025, 4, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4958), "Motivational coffee-themed typography - Typography themed artwork", "design_23.jpg", "https://picsum.photos/seed/design23/800/600", true, "admin-001", new DateTime(2025, 4, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4958), 6.26m, "Coffee First #23" },
                    { 24, "admin-001", "Watercolor Splash design artwork", null, null, "admin-001", new DateTime(2025, 3, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4973), "Vibrant watercolor paint splashes - Abstract themed artwork", "design_24.jpg", "https://picsum.photos/seed/design24/800/600", true, "admin-001", new DateTime(2025, 4, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4973), 6.69m, "Watercolor Splash #24" },
                    { 25, "admin-001", "Mountain Sunrise design artwork", null, null, "admin-001", new DateTime(2025, 3, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4988), "Majestic mountain landscape with golden sunrise - Nature themed artwork", "design_25.jpg", "https://picsum.photos/seed/design25/800/600", true, "admin-001", new DateTime(2025, 4, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(4988), 9.66m, "Mountain Sunrise #25" },
                    { 26, "admin-001", "Lazy Panda design artwork", null, null, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5001), "Sleepy panda bear cartoon character - Animals themed artwork", "design_26.jpg", "https://picsum.photos/seed/design26/800/600", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5001), 2.83m, "Lazy Panda #26" },
                    { 27, "admin-001", "Minimalist Lines design artwork", null, null, "admin-001", new DateTime(2025, 4, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5064), "Clean geometric lines and shapes - Abstract themed artwork", "design_27.jpg", "https://picsum.photos/seed/design27/800/600", true, "admin-001", new DateTime(2025, 4, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5064), 3.19m, "Minimalist Lines #27" },
                    { 28, "admin-001", "Geometric Harmony design artwork", null, null, "admin-001", new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5081), "Modern geometric patterns in pastel colors - Abstract themed artwork", "design_28.jpg", "https://picsum.photos/seed/design28/800/600", true, "admin-001", new DateTime(2025, 6, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5081), 6.10m, "Geometric Harmony #28" },
                    { 29, "admin-001", "Ocean Whale design artwork", null, null, "admin-001", new DateTime(2025, 5, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5095), "Graceful whale swimming in deep blue - Animals themed artwork", "design_29.jpg", "https://picsum.photos/seed/design29/800/600", true, "admin-001", new DateTime(2025, 5, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5095), 7.72m, "Ocean Whale #29" },
                    { 30, "admin-001", "Dream Big design artwork", null, null, "admin-001", new DateTime(2025, 3, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5109), "Motivational quote in elegant script - Typography themed artwork", "design_30.jpg", "https://picsum.photos/seed/design30/800/600", true, "admin-001", new DateTime(2025, 3, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5109), 7.21m, "Dream Big #30" },
                    { 31, "admin-001", "Minimalist Lines design artwork", null, null, "admin-001", new DateTime(2025, 3, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5277), "Clean geometric lines and shapes - Abstract themed artwork", "design_31.jpg", "https://picsum.photos/seed/design31/800/600", true, "admin-001", new DateTime(2025, 3, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5277), 2.22m, "Minimalist Lines #31" },
                    { 32, "admin-001", "Marble Texture design artwork", null, null, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5294), "Elegant marble texture with gold veins - Abstract themed artwork", "design_32.jpg", "https://picsum.photos/seed/design32/800/600", true, "admin-001", new DateTime(2025, 9, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5294), 3.73m, "Marble Texture #32" },
                    { 33, "admin-001", "Coffee First design artwork", null, null, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5310), "Motivational coffee-themed typography - Typography themed artwork", "design_33.jpg", "https://picsum.photos/seed/design33/800/600", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5310), 9.95m, "Coffee First #33" },
                    { 34, "admin-001", "Forest Silhouette design artwork", null, null, "admin-001", new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5328), "Minimalist forest treeline silhouette - Nature themed artwork", "design_34.jpg", "https://picsum.photos/seed/design34/800/600", true, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5328), 4.59m, "Forest Silhouette #34" },
                    { 35, "admin-001", "Rose Garden design artwork", null, null, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5342), "Elegant vintage rose pattern - Floral themed artwork", "design_35.jpg", "https://picsum.photos/seed/design35/800/600", true, "admin-001", new DateTime(2025, 9, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5342), 2.34m, "Rose Garden #35" },
                    { 36, "admin-001", "Wildflower Meadow design artwork", null, null, "admin-001", new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5356), "Delicate wildflower illustration - Floral themed artwork", "design_36.jpg", "https://picsum.photos/seed/design36/800/600", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5356), 9.41m, "Wildflower Meadow #36" },
                    { 37, "admin-001", "Marble Texture design artwork", null, null, "admin-001", new DateTime(2025, 5, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5371), "Elegant marble texture with gold veins - Abstract themed artwork", "design_37.jpg", "https://picsum.photos/seed/design37/800/600", true, "admin-001", new DateTime(2025, 6, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5371), 7.08m, "Marble Texture #37" },
                    { 38, "admin-001", "Tropical Paradise design artwork", null, null, "admin-001", new DateTime(2025, 7, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5569), "Exotic tropical beach scene with palm trees - Nature themed artwork", "design_38.jpg", "https://picsum.photos/seed/design38/800/600", true, "admin-001", new DateTime(2025, 7, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5569), 3.46m, "Tropical Paradise #38" },
                    { 39, "admin-001", "Geometric Harmony design artwork", null, null, "admin-001", new DateTime(2025, 3, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5588), "Modern geometric patterns in pastel colors - Abstract themed artwork", "design_39.jpg", "https://picsum.photos/seed/design39/800/600", true, "admin-001", new DateTime(2025, 4, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5588), 9.90m, "Geometric Harmony #39" },
                    { 40, "admin-001", "Desert Sunset design artwork", null, null, "admin-001", new DateTime(2025, 3, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5603), "Vibrant desert landscape at golden hour - Nature themed artwork", "design_40.jpg", "https://picsum.photos/seed/design40/800/600", true, "admin-001", new DateTime(2025, 4, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5603), 3.49m, "Desert Sunset #40" },
                    { 41, "admin-001", "Dream Big design artwork", null, null, "admin-001", new DateTime(2025, 5, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5618), "Motivational quote in elegant script - Typography themed artwork", "design_41.jpg", "https://picsum.photos/seed/design41/800/600", true, "admin-001", new DateTime(2025, 5, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5618), 7.70m, "Dream Big #41" },
                    { 42, "admin-001", "Stay Wild design artwork", null, null, "admin-001", new DateTime(2025, 6, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5633), "Nature-inspired motivational text - Typography themed artwork", "design_42.jpg", "https://picsum.photos/seed/design42/800/600", true, "admin-001", new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5633), 9.05m, "Stay Wild #42" },
                    { 43, "admin-001", "Minimalist Lines design artwork", null, null, "admin-001", new DateTime(2025, 3, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5647), "Clean geometric lines and shapes - Abstract themed artwork", "design_43.jpg", "https://picsum.photos/seed/design43/800/600", true, "admin-001", new DateTime(2025, 3, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5647), 5.71m, "Minimalist Lines #43" },
                    { 44, "admin-001", "Succulent Collection design artwork", null, null, "admin-001", new DateTime(2025, 4, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5661), "Cute succulent plant arrangement - Floral themed artwork", "design_44.jpg", "https://picsum.photos/seed/design44/800/600", true, "admin-001", new DateTime(2025, 4, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5661), 3.03m, "Succulent Collection #44" },
                    { 45, "admin-001", "Mountain Sunrise design artwork", null, null, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5675), "Majestic mountain landscape with golden sunrise - Nature themed artwork", "design_45.jpg", "https://picsum.photos/seed/design45/800/600", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5675), 9.52m, "Mountain Sunrise #45" },
                    { 46, "admin-001", "Coffee First design artwork", null, null, "admin-001", new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5689), "Motivational coffee-themed typography - Typography themed artwork", "design_46.jpg", "https://picsum.photos/seed/design46/800/600", true, "admin-001", new DateTime(2025, 5, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5689), 5.20m, "Coffee First #46" },
                    { 47, "admin-001", "Wildflower Meadow design artwork", null, null, "admin-001", new DateTime(2025, 3, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5703), "Delicate wildflower illustration - Floral themed artwork", "design_47.jpg", "https://picsum.photos/seed/design47/800/600", true, "admin-001", new DateTime(2025, 3, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5703), 9.12m, "Wildflower Meadow #47" },
                    { 48, "admin-001", "Minimalist Lines design artwork", null, null, "admin-001", new DateTime(2025, 5, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5719), "Clean geometric lines and shapes - Abstract themed artwork", "design_48.jpg", "https://picsum.photos/seed/design48/800/600", true, "admin-001", new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5719), 6.93m, "Minimalist Lines #48" },
                    { 49, "admin-001", "Rose Garden design artwork", null, null, "admin-001", new DateTime(2025, 4, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5831), "Elegant vintage rose pattern - Floral themed artwork", "design_49.jpg", "https://picsum.photos/seed/design49/800/600", true, "admin-001", new DateTime(2025, 5, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5831), 4.24m, "Rose Garden #49" },
                    { 50, "admin-001", "Dream Big design artwork", null, null, "admin-001", new DateTime(2025, 4, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5852), "Motivational quote in elegant script - Typography themed artwork", "design_50.jpg", "https://picsum.photos/seed/design50/800/600", true, "admin-001", new DateTime(2025, 5, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5852), 3.98m, "Dream Big #50" },
                    { 51, "admin-001", "Majestic Wolf design artwork", null, null, "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5866), "Realistic wolf portrait in natural setting - Animals themed artwork", "design_51.jpg", "https://picsum.photos/seed/design51/800/600", true, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5866), 4.22m, "Majestic Wolf #51" },
                    { 52, "admin-001", "Rose Garden design artwork", null, null, "admin-001", new DateTime(2025, 5, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5881), "Elegant vintage rose pattern - Floral themed artwork", "design_52.jpg", "https://picsum.photos/seed/design52/800/600", true, "admin-001", new DateTime(2025, 5, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5881), 2.65m, "Rose Garden #52" },
                    { 53, "admin-001", "Rose Garden design artwork", null, null, "admin-001", new DateTime(2025, 3, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5895), "Elegant vintage rose pattern - Floral themed artwork", "design_53.jpg", "https://picsum.photos/seed/design53/800/600", true, "admin-001", new DateTime(2025, 4, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5895), 8.23m, "Rose Garden #53" },
                    { 54, "admin-001", "Succulent Collection design artwork", null, null, "admin-001", new DateTime(2025, 6, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5909), "Cute succulent plant arrangement - Floral themed artwork", "design_54.jpg", "https://picsum.photos/seed/design54/800/600", true, "admin-001", new DateTime(2025, 7, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5909), 9.13m, "Succulent Collection #54" },
                    { 55, "admin-001", "Desert Sunset design artwork", null, null, "admin-001", new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5924), "Vibrant desert landscape at golden hour - Nature themed artwork", "design_55.jpg", "https://picsum.photos/seed/design55/800/600", true, "admin-001", new DateTime(2025, 6, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5924), 3.69m, "Desert Sunset #55" },
                    { 56, "admin-001", "Good Vibes Only design artwork", null, null, "admin-001", new DateTime(2025, 4, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5937), "Positive mindset typography art - Typography themed artwork", "design_56.jpg", "https://picsum.photos/seed/design56/800/600", true, "admin-001", new DateTime(2025, 5, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5937), 2.89m, "Good Vibes Only #56" },
                    { 57, "admin-001", "Minimalist Lines design artwork", null, null, "admin-001", new DateTime(2025, 5, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5952), "Clean geometric lines and shapes - Abstract themed artwork", "design_57.jpg", "https://picsum.photos/seed/design57/800/600", true, "admin-001", new DateTime(2025, 6, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5952), 7.77m, "Minimalist Lines #57" },
                    { 58, "admin-001", "Dream Big design artwork", null, null, "admin-001", new DateTime(2025, 4, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5966), "Motivational quote in elegant script - Typography themed artwork", "design_58.jpg", "https://picsum.photos/seed/design58/800/600", true, "admin-001", new DateTime(2025, 4, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5966), 6.65m, "Dream Big #58" },
                    { 59, "admin-001", "Succulent Collection design artwork", null, null, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5980), "Cute succulent plant arrangement - Floral themed artwork", "design_59.jpg", "https://picsum.photos/seed/design59/800/600", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5980), 2.45m, "Succulent Collection #59" },
                    { 60, "admin-001", "Watercolor Splash design artwork", null, null, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5994), "Vibrant watercolor paint splashes - Abstract themed artwork", "design_60.jpg", "https://picsum.photos/seed/design60/800/600", true, "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(5994), 4.33m, "Watercolor Splash #60" },
                    { 61, "admin-001", "Wildflower Meadow design artwork", null, null, "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6083), "Delicate wildflower illustration - Floral themed artwork", "design_61.jpg", "https://picsum.photos/seed/design61/800/600", true, "admin-001", new DateTime(2025, 6, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6083), 4.94m, "Wildflower Meadow #61" },
                    { 62, "admin-001", "Ocean Whale design artwork", null, null, "admin-001", new DateTime(2025, 5, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6098), "Graceful whale swimming in deep blue - Animals themed artwork", "design_62.jpg", "https://picsum.photos/seed/design62/800/600", true, "admin-001", new DateTime(2025, 5, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6098), 9.99m, "Ocean Whale #62" },
                    { 63, "admin-001", "Tropical Leaves design artwork", null, null, "admin-001", new DateTime(2025, 7, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6114), "Modern monstera leaf pattern - Floral themed artwork", "design_63.jpg", "https://picsum.photos/seed/design63/800/600", true, "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6114), 3.47m, "Tropical Leaves #63" },
                    { 64, "admin-001", "Stay Wild design artwork", null, null, "admin-001", new DateTime(2025, 5, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6128), "Nature-inspired motivational text - Typography themed artwork", "design_64.jpg", "https://picsum.photos/seed/design64/800/600", true, "admin-001", new DateTime(2025, 6, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6128), 5.10m, "Stay Wild #64" },
                    { 65, "admin-001", "Ocean Waves design artwork", null, null, "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6142), "Peaceful ocean waves in watercolor style - Nature themed artwork", "design_65.jpg", "https://picsum.photos/seed/design65/800/600", true, "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6142), 9.05m, "Ocean Waves #65" },
                    { 66, "admin-001", "Wildflower Meadow design artwork", null, null, "admin-001", new DateTime(2025, 3, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6160), "Delicate wildflower illustration - Floral themed artwork", "design_66.jpg", "https://picsum.photos/seed/design66/800/600", true, "admin-001", new DateTime(2025, 3, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6160), 9.13m, "Wildflower Meadow #66" },
                    { 67, "admin-001", "Watercolor Splash design artwork", null, null, "admin-001", new DateTime(2025, 5, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6174), "Vibrant watercolor paint splashes - Abstract themed artwork", "design_67.jpg", "https://picsum.photos/seed/design67/800/600", true, "admin-001", new DateTime(2025, 6, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6174), 2.15m, "Watercolor Splash #67" },
                    { 68, "admin-001", "Coffee First design artwork", null, null, "admin-001", new DateTime(2025, 5, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6187), "Motivational coffee-themed typography - Typography themed artwork", "design_68.jpg", "https://picsum.photos/seed/design68/800/600", true, "admin-001", new DateTime(2025, 6, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6187), 7.24m, "Coffee First #68" },
                    { 69, "admin-001", "Watercolor Splash design artwork", null, null, "admin-001", new DateTime(2025, 3, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6202), "Vibrant watercolor paint splashes - Abstract themed artwork", "design_69.jpg", "https://picsum.photos/seed/design69/800/600", true, "admin-001", new DateTime(2025, 3, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6202), 8.02m, "Watercolor Splash #69" },
                    { 70, "admin-001", "Minimalist Lines design artwork", null, null, "admin-001", new DateTime(2025, 5, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6215), "Clean geometric lines and shapes - Abstract themed artwork", "design_70.jpg", "https://picsum.photos/seed/design70/800/600", true, "admin-001", new DateTime(2025, 5, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6215), 2.34m, "Minimalist Lines #70" },
                    { 71, "admin-001", "Dream Big design artwork", null, null, "admin-001", new DateTime(2025, 6, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6229), "Motivational quote in elegant script - Typography themed artwork", "design_71.jpg", "https://picsum.photos/seed/design71/800/600", true, "admin-001", new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6229), 4.75m, "Dream Big #71" },
                    { 72, "admin-001", "Cute Cat Face design artwork", null, null, "admin-001", new DateTime(2025, 5, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6319), "Adorable cartoon cat illustration - Animals themed artwork", "design_72.jpg", "https://picsum.photos/seed/design72/800/600", true, "admin-001", new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6319), 6.84m, "Cute Cat Face #72" },
                    { 73, "admin-001", "Majestic Wolf design artwork", null, null, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6335), "Realistic wolf portrait in natural setting - Animals themed artwork", "design_73.jpg", "https://picsum.photos/seed/design73/800/600", true, "admin-001", new DateTime(2025, 9, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6335), 3.09m, "Majestic Wolf #73" },
                    { 74, "admin-001", "Watercolor Splash design artwork", null, null, "admin-001", new DateTime(2025, 3, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6349), "Vibrant watercolor paint splashes - Abstract themed artwork", "design_74.jpg", "https://picsum.photos/seed/design74/800/600", true, "admin-001", new DateTime(2025, 3, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6349), 4.81m, "Watercolor Splash #74" },
                    { 75, "admin-001", "Stay Wild design artwork", null, null, "admin-001", new DateTime(2025, 7, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6363), "Nature-inspired motivational text - Typography themed artwork", "design_75.jpg", "https://picsum.photos/seed/design75/800/600", true, "admin-001", new DateTime(2025, 7, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6363), 3.24m, "Stay Wild #75" },
                    { 76, "admin-001", "Majestic Wolf design artwork", null, null, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6376), "Realistic wolf portrait in natural setting - Animals themed artwork", "design_76.jpg", "https://picsum.photos/seed/design76/800/600", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6376), 9.56m, "Majestic Wolf #76" },
                    { 77, "admin-001", "Majestic Wolf design artwork", null, null, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6391), "Realistic wolf portrait in natural setting - Animals themed artwork", "design_77.jpg", "https://picsum.photos/seed/design77/800/600", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6391), 7.13m, "Majestic Wolf #77" },
                    { 78, "admin-001", "Tropical Leaves design artwork", null, null, "admin-001", new DateTime(2025, 6, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6404), "Modern monstera leaf pattern - Floral themed artwork", "design_78.jpg", "https://picsum.photos/seed/design78/800/600", true, "admin-001", new DateTime(2025, 7, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6404), 6.92m, "Tropical Leaves #78" },
                    { 79, "admin-001", "Coffee First design artwork", null, null, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6418), "Motivational coffee-themed typography - Typography themed artwork", "design_79.jpg", "https://picsum.photos/seed/design79/800/600", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6418), 8.32m, "Coffee First #79" },
                    { 80, "admin-001", "Dream Big design artwork", null, null, "admin-001", new DateTime(2025, 5, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6433), "Motivational quote in elegant script - Typography themed artwork", "design_80.jpg", "https://picsum.photos/seed/design80/800/600", true, "admin-001", new DateTime(2025, 5, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6433), 5.29m, "Dream Big #80" },
                    { 81, "admin-001", "Cherry Blossoms design artwork", null, null, "admin-001", new DateTime(2025, 4, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6446), "Japanese cherry blossom branch in soft pink - Floral themed artwork", "design_81.jpg", "https://picsum.photos/seed/design81/800/600", true, "admin-001", new DateTime(2025, 5, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6446), 3.80m, "Cherry Blossoms #81" },
                    { 82, "admin-001", "Dream Big design artwork", null, null, "admin-001", new DateTime(2025, 4, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6460), "Motivational quote in elegant script - Typography themed artwork", "design_82.jpg", "https://picsum.photos/seed/design82/800/600", true, "admin-001", new DateTime(2025, 4, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6460), 7.55m, "Dream Big #82" },
                    { 83, "admin-001", "Stay Wild design artwork", null, null, "admin-001", new DateTime(2025, 4, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6547), "Nature-inspired motivational text - Typography themed artwork", "design_83.jpg", "https://picsum.photos/seed/design83/800/600", true, "admin-001", new DateTime(2025, 5, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6547), 5.61m, "Stay Wild #83" },
                    { 84, "admin-001", "Good Vibes Only design artwork", null, null, "admin-001", new DateTime(2025, 4, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6573), "Positive mindset typography art - Typography themed artwork", "design_84.jpg", "https://picsum.photos/seed/design84/800/600", true, "admin-001", new DateTime(2025, 4, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6573), 2.33m, "Good Vibes Only #84" },
                    { 85, "admin-001", "Coffee First design artwork", null, null, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6589), "Motivational coffee-themed typography - Typography themed artwork", "design_85.jpg", "https://picsum.photos/seed/design85/800/600", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6589), 6.50m, "Coffee First #85" },
                    { 86, "admin-001", "Mountain Sunrise design artwork", null, null, "admin-001", new DateTime(2025, 3, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6604), "Majestic mountain landscape with golden sunrise - Nature themed artwork", "design_86.jpg", "https://picsum.photos/seed/design86/800/600", true, "admin-001", new DateTime(2025, 3, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6604), 5.69m, "Mountain Sunrise #86" },
                    { 87, "admin-001", "Good Vibes Only design artwork", null, null, "admin-001", new DateTime(2025, 4, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6623), "Positive mindset typography art - Typography themed artwork", "design_87.jpg", "https://picsum.photos/seed/design87/800/600", true, "admin-001", new DateTime(2025, 4, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6623), 5.31m, "Good Vibes Only #87" },
                    { 88, "admin-001", "Tropical Paradise design artwork", null, null, "admin-001", new DateTime(2025, 4, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6640), "Exotic tropical beach scene with palm trees - Nature themed artwork", "design_88.jpg", "https://picsum.photos/seed/design88/800/600", true, "admin-001", new DateTime(2025, 5, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6640), 5.70m, "Tropical Paradise #88" },
                    { 89, "admin-001", "Succulent Collection design artwork", null, null, "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6655), "Cute succulent plant arrangement - Floral themed artwork", "design_89.jpg", "https://picsum.photos/seed/design89/800/600", true, "admin-001", new DateTime(2025, 7, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6655), 3.67m, "Succulent Collection #89" },
                    { 90, "admin-001", "Wildflower Meadow design artwork", null, null, "admin-001", new DateTime(2025, 5, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6672), "Delicate wildflower illustration - Floral themed artwork", "design_90.jpg", "https://picsum.photos/seed/design90/800/600", true, "admin-001", new DateTime(2025, 6, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6672), 7.12m, "Wildflower Meadow #90" },
                    { 91, "admin-001", "Good Vibes Only design artwork", null, null, "admin-001", new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6688), "Positive mindset typography art - Typography themed artwork", "design_91.jpg", "https://picsum.photos/seed/design91/800/600", true, "admin-001", new DateTime(2025, 7, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6688), 2.51m, "Good Vibes Only #91" },
                    { 92, "admin-001", "Wildflower Meadow design artwork", null, null, "admin-001", new DateTime(2025, 5, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6704), "Delicate wildflower illustration - Floral themed artwork", "design_92.jpg", "https://picsum.photos/seed/design92/800/600", true, "admin-001", new DateTime(2025, 5, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6704), 9.36m, "Wildflower Meadow #92" },
                    { 93, "admin-001", "Desert Sunset design artwork", null, null, "admin-001", new DateTime(2025, 6, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6719), "Vibrant desert landscape at golden hour - Nature themed artwork", "design_93.jpg", "https://picsum.photos/seed/design93/800/600", true, "admin-001", new DateTime(2025, 7, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6719), 3.07m, "Desert Sunset #93" },
                    { 94, "admin-001", "Forest Silhouette design artwork", null, null, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6734), "Minimalist forest treeline silhouette - Nature themed artwork", "design_94.jpg", "https://picsum.photos/seed/design94/800/600", true, "admin-001", new DateTime(2025, 9, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6734), 7.22m, "Forest Silhouette #94" },
                    { 95, "admin-001", "Geometric Harmony design artwork", null, null, "admin-001", new DateTime(2025, 3, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6835), "Modern geometric patterns in pastel colors - Abstract themed artwork", "design_95.jpg", "https://picsum.photos/seed/design95/800/600", true, "admin-001", new DateTime(2025, 4, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6835), 8.62m, "Geometric Harmony #95" },
                    { 96, "admin-001", "Galaxy Swirl design artwork", null, null, "admin-001", new DateTime(2025, 5, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6856), "Cosmic galaxy with swirling nebula - Space themed artwork", "design_96.jpg", "https://picsum.photos/seed/design96/800/600", true, "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6856), 3.03m, "Galaxy Swirl #96" },
                    { 97, "admin-001", "Watercolor Splash design artwork", null, null, "admin-001", new DateTime(2025, 5, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6873), "Vibrant watercolor paint splashes - Abstract themed artwork", "design_97.jpg", "https://picsum.photos/seed/design97/800/600", true, "admin-001", new DateTime(2025, 5, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6873), 2.40m, "Watercolor Splash #97" },
                    { 98, "admin-001", "Majestic Wolf design artwork", null, null, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6887), "Realistic wolf portrait in natural setting - Animals themed artwork", "design_98.jpg", "https://picsum.photos/seed/design98/800/600", true, "admin-001", new DateTime(2025, 9, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6887), 6.24m, "Majestic Wolf #98" },
                    { 99, "admin-001", "Dream Big design artwork", null, null, "admin-001", new DateTime(2025, 4, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6903), "Motivational quote in elegant script - Typography themed artwork", "design_99.jpg", "https://picsum.photos/seed/design99/800/600", true, "admin-001", new DateTime(2025, 5, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6903), 9.21m, "Dream Big #99" },
                    { 100, "admin-001", "Wildflower Meadow design artwork", null, null, "admin-001", new DateTime(2025, 6, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6919), "Delicate wildflower illustration - Floral themed artwork", "design_100.jpg", "https://picsum.photos/seed/design100/800/600", true, "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(6919), 5.23m, "Wildflower Meadow #100" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "CustomerId", "LastModifiedBy", "LastModifiedOn", "ShippingAddress", "ShippingCity", "ShippingCountry", "ShippingPostalCode", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "customer-019", new DateTime(2024, 9, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(816), "customer-019", "customer-019", new DateTime(2024, 9, 25, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(816), "5869 Cedar Way", "Melbourne", "Australia", "6623", 0, 0m },
                    { 2, "customer-020", new DateTime(2025, 5, 21, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(894), "customer-020", "customer-020", new DateTime(2025, 5, 24, 6, 39, 26, 945, DateTimeKind.Utc).AddTicks(894), "2614 Broadway", "Vancouver", "Canada", "U3S 1N8", 2, 0m },
                    { 3, "customer-001", new DateTime(2025, 1, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(923), "customer-001", "customer-001", new DateTime(2025, 1, 25, 14, 39, 26, 945, DateTimeKind.Utc).AddTicks(923), "4887 Park Blvd", "Cologne", "Germany", "99610", 0, 0m },
                    { 4, "customer-001", new DateTime(2025, 8, 20, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(941), "customer-001", "customer-001", new DateTime(2025, 8, 22, 2, 39, 26, 945, DateTimeKind.Utc).AddTicks(941), "2063 Maple Ln", "Chicago", "United States", "27345", 2, 0m },
                    { 5, "customer-008", new DateTime(2024, 12, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(956), "customer-008", "customer-008", new DateTime(2024, 12, 24, 14, 39, 26, 945, DateTimeKind.Utc).AddTicks(956), "2260 Oak Ave", "Brisbane", "Australia", "7684", 1, 0m },
                    { 6, "customer-015", new DateTime(2024, 9, 14, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(973), "customer-015", "customer-015", new DateTime(2024, 9, 15, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(973), "6927 Oak Ave", "Los Angeles", "United States", "12507", 3, 0m },
                    { 7, "customer-006", new DateTime(2024, 12, 5, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(987), "customer-006", "customer-006", new DateTime(2024, 12, 6, 21, 39, 26, 945, DateTimeKind.Utc).AddTicks(987), "6636 Park Blvd", "Phoenix", "United States", "44382", 4, 0m },
                    { 8, "customer-022", new DateTime(2025, 6, 22, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1001), "customer-022", "customer-022", new DateTime(2025, 6, 23, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1001), "5324 Park Blvd", "Adelaide", "Australia", "3633", 1, 0m },
                    { 9, "customer-016", new DateTime(2025, 4, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1013), "customer-016", "customer-016", new DateTime(2025, 4, 4, 21, 39, 26, 945, DateTimeKind.Utc).AddTicks(1013), "9337 Pine Rd", "Cologne", "Germany", "24587", 0, 0m },
                    { 10, "customer-029", new DateTime(2025, 8, 30, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1102), "customer-029", "customer-029", new DateTime(2025, 9, 1, 3, 39, 26, 945, DateTimeKind.Utc).AddTicks(1102), "5281 Main St", "Adelaide", "Australia", "3246", 4, 0m },
                    { 11, "customer-018", new DateTime(2025, 7, 20, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1117), "customer-018", "customer-018", new DateTime(2025, 7, 22, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(1117), "1802 Second Ave", "Adelaide", "Australia", "4375", 3, 0m },
                    { 12, "customer-027", new DateTime(2024, 10, 20, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1130), "customer-027", "customer-027", new DateTime(2024, 10, 22, 15, 39, 26, 945, DateTimeKind.Utc).AddTicks(1130), "9323 Maple Ln", "Los Angeles", "United States", "64989", 0, 0m },
                    { 13, "customer-004", new DateTime(2025, 5, 6, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1143), "customer-004", "customer-004", new DateTime(2025, 5, 7, 22, 39, 26, 945, DateTimeKind.Utc).AddTicks(1143), "7753 Park Blvd", "Frankfurt", "Germany", "76853", 0, 0m },
                    { 14, "customer-017", new DateTime(2024, 9, 21, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1158), "customer-017", "customer-017", new DateTime(2024, 9, 22, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(1158), "7041 Main St", "Hamburg", "Germany", "19378", 1, 0m },
                    { 15, "customer-015", new DateTime(2024, 10, 31, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1171), "customer-015", "customer-015", new DateTime(2024, 11, 1, 16, 39, 26, 945, DateTimeKind.Utc).AddTicks(1171), "3631 Elm Dr", "Frankfurt", "Germany", "40775", 2, 0m },
                    { 16, "customer-001", new DateTime(2024, 11, 6, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1186), "customer-001", "customer-001", new DateTime(2024, 11, 9, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1186), "3386 Broadway", "Munich", "Germany", "90271", 3, 0m },
                    { 17, "customer-014", new DateTime(2024, 12, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1200), "customer-014", "customer-014", new DateTime(2024, 12, 27, 2, 39, 26, 945, DateTimeKind.Utc).AddTicks(1200), "1921 First St", "Berlin", "Germany", "37331", 1, 0m },
                    { 18, "customer-009", new DateTime(2025, 8, 21, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1215), "customer-009", "customer-009", new DateTime(2025, 8, 23, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(1215), "2159 First St", "Toronto", "Canada", "X6D 2I5", 1, 0m },
                    { 19, "customer-018", new DateTime(2025, 3, 10, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1231), "customer-018", "customer-018", new DateTime(2025, 3, 13, 14, 39, 26, 945, DateTimeKind.Utc).AddTicks(1231), "6776 Park Blvd", "Cologne", "Germany", "92920", 3, 0m },
                    { 20, "customer-021", new DateTime(2024, 11, 22, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1245), "customer-021", "customer-021", new DateTime(2024, 11, 22, 20, 39, 26, 945, DateTimeKind.Utc).AddTicks(1245), "5073 Second Ave", "Bristol", "United Kingdom", "HC6 8CH", 3, 0m },
                    { 21, "customer-021", new DateTime(2024, 11, 22, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1261), "customer-021", "customer-021", new DateTime(2024, 11, 24, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1261), "5650 First St", "Los Angeles", "United States", "68234", 2, 0m },
                    { 22, "customer-024", new DateTime(2025, 7, 2, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1273), "customer-024", "customer-024", new DateTime(2025, 7, 4, 0, 39, 26, 945, DateTimeKind.Utc).AddTicks(1273), "2718 Oak Ave", "Birmingham", "United Kingdom", "PU3 0ON", 3, 0m },
                    { 23, "customer-024", new DateTime(2024, 11, 17, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1289), "customer-024", "customer-024", new DateTime(2024, 11, 19, 2, 39, 26, 945, DateTimeKind.Utc).AddTicks(1289), "1695 Park Blvd", "Frankfurt", "Germany", "75108", 2, 0m },
                    { 24, "customer-008", new DateTime(2025, 3, 12, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1302), "customer-008", "customer-008", new DateTime(2025, 3, 13, 7, 39, 26, 945, DateTimeKind.Utc).AddTicks(1302), "5606 Pine Rd", "New York", "United States", "42455", 4, 0m },
                    { 25, "customer-002", new DateTime(2025, 6, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1314), "customer-002", "customer-002", new DateTime(2025, 6, 27, 1, 39, 26, 945, DateTimeKind.Utc).AddTicks(1314), "9986 Maple Ln", "Vancouver", "Canada", "A8B 1S2", 4, 0m },
                    { 26, "customer-005", new DateTime(2025, 4, 18, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1329), "customer-005", "customer-005", new DateTime(2025, 4, 20, 5, 39, 26, 945, DateTimeKind.Utc).AddTicks(1329), "6022 Broadway", "Ottawa", "Canada", "M8B 6J0", 3, 0m },
                    { 27, "customer-004", new DateTime(2024, 9, 29, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1344), "customer-004", "customer-004", new DateTime(2024, 10, 2, 3, 39, 26, 945, DateTimeKind.Utc).AddTicks(1344), "9267 Cedar Way", "London", "United Kingdom", "IN4 4LO", 0, 0m },
                    { 28, "customer-006", new DateTime(2025, 1, 31, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1360), "customer-006", "customer-006", new DateTime(2025, 2, 2, 7, 39, 26, 945, DateTimeKind.Utc).AddTicks(1360), "734 First St", "Sydney", "Australia", "7878", 3, 0m },
                    { 29, "customer-007", new DateTime(2025, 5, 15, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1372), "customer-007", "customer-007", new DateTime(2025, 5, 18, 17, 39, 26, 945, DateTimeKind.Utc).AddTicks(1372), "2546 Second Ave", "Montreal", "Canada", "M8Y 8W0", 3, 0m },
                    { 30, "customer-016", new DateTime(2024, 12, 17, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1387), "customer-016", "customer-016", new DateTime(2024, 12, 19, 5, 39, 26, 945, DateTimeKind.Utc).AddTicks(1387), "8337 Oak Ave", "Frankfurt", "Germany", "88343", 1, 0m },
                    { 31, "customer-002", new DateTime(2025, 7, 3, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1452), "customer-002", "customer-002", new DateTime(2025, 7, 4, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1452), "512 Elm Dr", "Montreal", "Canada", "Y6I 3V2", 1, 0m },
                    { 32, "customer-022", new DateTime(2024, 9, 7, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1490), "customer-022", "customer-022", new DateTime(2024, 9, 10, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(1490), "4897 Maple Ln", "Sydney", "Australia", "6722", 0, 0m },
                    { 33, "customer-005", new DateTime(2025, 1, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1504), "customer-005", "customer-005", new DateTime(2025, 1, 26, 20, 39, 26, 945, DateTimeKind.Utc).AddTicks(1504), "2081 Broadway", "Cologne", "Germany", "93897", 0, 0m },
                    { 34, "customer-011", new DateTime(2024, 11, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1578), "customer-011", "customer-011", new DateTime(2024, 11, 6, 17, 39, 26, 945, DateTimeKind.Utc).AddTicks(1578), "8937 Elm Dr", "Los Angeles", "United States", "51231", 3, 0m },
                    { 35, "customer-001", new DateTime(2025, 6, 12, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1592), "customer-001", "customer-001", new DateTime(2025, 6, 15, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(1592), "2563 Maple Ln", "Sydney", "Australia", "6195", 2, 0m },
                    { 36, "customer-022", new DateTime(2025, 7, 31, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1606), "customer-022", "customer-022", new DateTime(2025, 8, 2, 23, 39, 26, 945, DateTimeKind.Utc).AddTicks(1606), "4077 Pine Rd", "Ottawa", "Canada", "D6J 0O6", 0, 0m },
                    { 37, "customer-013", new DateTime(2025, 8, 3, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1622), "customer-013", "customer-013", new DateTime(2025, 8, 4, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(1622), "6824 First St", "Birmingham", "United Kingdom", "FJ5 7LK", 2, 0m },
                    { 38, "customer-017", new DateTime(2025, 3, 19, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1638), "customer-017", "customer-017", new DateTime(2025, 3, 20, 6, 39, 26, 945, DateTimeKind.Utc).AddTicks(1638), "3315 Pine Rd", "London", "United Kingdom", "VG8 7IS", 4, 0m },
                    { 39, "customer-005", new DateTime(2024, 9, 15, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1653), "customer-005", "customer-005", new DateTime(2024, 9, 17, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(1653), "4965 Oak Ave", "Los Angeles", "United States", "57026", 2, 0m },
                    { 40, "customer-024", new DateTime(2024, 9, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1668), "customer-024", "customer-024", new DateTime(2024, 9, 27, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(1668), "6941 Cedar Way", "Chicago", "United States", "59136", 4, 0m },
                    { 41, "customer-030", new DateTime(2024, 9, 12, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1680), "customer-030", "customer-030", new DateTime(2024, 9, 13, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(1680), "5235 Maple Ln", "Montreal", "Canada", "K4O 7M5", 2, 0m },
                    { 42, "customer-028", new DateTime(2025, 2, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1695), "customer-028", "customer-028", new DateTime(2025, 2, 5, 15, 39, 26, 945, DateTimeKind.Utc).AddTicks(1695), "7781 Pine Rd", "London", "United Kingdom", "XE0 7AO", 0, 0m },
                    { 43, "customer-006", new DateTime(2024, 11, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1709), "customer-006", "customer-006", new DateTime(2024, 11, 27, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(1709), "3317 Elm Dr", "Brisbane", "Australia", "7964", 0, 0m },
                    { 44, "customer-026", new DateTime(2025, 4, 6, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1721), "customer-026", "customer-026", new DateTime(2025, 4, 7, 6, 39, 26, 945, DateTimeKind.Utc).AddTicks(1721), "352 Cedar Way", "Adelaide", "Australia", "7232", 4, 0m },
                    { 45, "customer-006", new DateTime(2024, 12, 7, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1733), "customer-006", "customer-006", new DateTime(2024, 12, 9, 9, 39, 26, 945, DateTimeKind.Utc).AddTicks(1733), "2674 Elm Dr", "Birmingham", "United Kingdom", "TH0 7NM", 4, 0m },
                    { 46, "customer-028", new DateTime(2025, 7, 11, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1747), "customer-028", "customer-028", new DateTime(2025, 7, 14, 9, 39, 26, 945, DateTimeKind.Utc).AddTicks(1747), "952 Main St", "Brisbane", "Australia", "3649", 1, 0m },
                    { 47, "customer-005", new DateTime(2025, 8, 30, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1759), "customer-005", "customer-005", new DateTime(2025, 9, 1, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(1759), "1345 Maple Ln", "Los Angeles", "United States", "90602", 1, 0m },
                    { 48, "customer-011", new DateTime(2025, 1, 10, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1771), "customer-011", "customer-011", new DateTime(2025, 1, 12, 1, 39, 26, 945, DateTimeKind.Utc).AddTicks(1771), "5907 Elm Dr", "Munich", "Germany", "90349", 4, 0m },
                    { 49, "customer-020", new DateTime(2025, 8, 16, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1784), "customer-020", "customer-020", new DateTime(2025, 8, 18, 7, 39, 26, 945, DateTimeKind.Utc).AddTicks(1784), "3560 Second Ave", "Berlin", "Germany", "96753", 1, 0m },
                    { 50, "customer-017", new DateTime(2025, 5, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1796), "customer-017", "customer-017", new DateTime(2025, 5, 6, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(1796), "8788 Second Ave", "Sydney", "Australia", "8261", 0, 0m },
                    { 51, "customer-007", new DateTime(2025, 6, 7, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1808), "customer-007", "customer-007", new DateTime(2025, 6, 10, 8, 39, 26, 945, DateTimeKind.Utc).AddTicks(1808), "1807 Oak Ave", "Adelaide", "Australia", "2775", 0, 0m },
                    { 52, "customer-020", new DateTime(2025, 8, 7, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1820), "customer-020", "customer-020", new DateTime(2025, 8, 8, 13, 39, 26, 945, DateTimeKind.Utc).AddTicks(1820), "5425 Park Blvd", "Melbourne", "Australia", "4791", 4, 0m },
                    { 53, "customer-019", new DateTime(2025, 7, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1831), "customer-019", "customer-019", new DateTime(2025, 7, 6, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(1831), "3338 Park Blvd", "Berlin", "Germany", "90290", 4, 0m },
                    { 54, "customer-017", new DateTime(2024, 12, 8, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1844), "customer-017", "customer-017", new DateTime(2024, 12, 10, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(1844), "5018 Main St", "Frankfurt", "Germany", "22805", 2, 0m },
                    { 55, "customer-012", new DateTime(2025, 8, 27, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1856), "customer-012", "customer-012", new DateTime(2025, 8, 30, 11, 39, 26, 945, DateTimeKind.Utc).AddTicks(1856), "8353 Maple Ln", "Phoenix", "United States", "29616", 0, 0m },
                    { 56, "customer-020", new DateTime(2024, 10, 27, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(1868), "customer-020", "customer-020", new DateTime(2024, 10, 27, 21, 39, 26, 945, DateTimeKind.Utc).AddTicks(1868), "6555 Park Blvd", "Bristol", "United Kingdom", "GQ5 2CR", 4, 0m },
                    { 57, "customer-029", new DateTime(2025, 1, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2032), "customer-029", "customer-029", new DateTime(2025, 1, 24, 0, 39, 26, 945, DateTimeKind.Utc).AddTicks(2032), "6862 Main St", "Manchester", "United Kingdom", "IQ1 7HK", 2, 0m },
                    { 58, "customer-016", new DateTime(2025, 5, 17, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2048), "customer-016", "customer-016", new DateTime(2025, 5, 19, 23, 39, 26, 945, DateTimeKind.Utc).AddTicks(2048), "4390 Broadway", "Ottawa", "Canada", "B5Y 7W3", 0, 0m },
                    { 59, "customer-026", new DateTime(2025, 4, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2063), "customer-026", "customer-026", new DateTime(2025, 4, 5, 18, 39, 26, 945, DateTimeKind.Utc).AddTicks(2063), "9898 Pine Rd", "Liverpool", "United Kingdom", "MG3 1NU", 4, 0m },
                    { 60, "customer-006", new DateTime(2024, 11, 24, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2079), "customer-006", "customer-006", new DateTime(2024, 11, 26, 4, 39, 26, 945, DateTimeKind.Utc).AddTicks(2079), "5740 First St", "Melbourne", "Australia", "4123", 3, 0m },
                    { 61, "customer-029", new DateTime(2025, 6, 29, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2092), "customer-029", "customer-029", new DateTime(2025, 6, 30, 21, 39, 26, 945, DateTimeKind.Utc).AddTicks(2092), "341 Park Blvd", "Phoenix", "United States", "69858", 1, 0m },
                    { 62, "customer-010", new DateTime(2025, 4, 23, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2104), "customer-010", "customer-010", new DateTime(2025, 4, 24, 23, 39, 26, 945, DateTimeKind.Utc).AddTicks(2104), "3326 Park Blvd", "Vancouver", "Canada", "K7A 0T1", 2, 0m },
                    { 63, "customer-019", new DateTime(2025, 1, 14, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2120), "customer-019", "customer-019", new DateTime(2025, 1, 17, 16, 39, 26, 945, DateTimeKind.Utc).AddTicks(2120), "1561 Park Blvd", "Munich", "Germany", "80597", 4, 0m },
                    { 64, "customer-016", new DateTime(2024, 9, 18, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2135), "customer-016", "customer-016", new DateTime(2024, 9, 21, 7, 39, 26, 945, DateTimeKind.Utc).AddTicks(2135), "9208 Elm Dr", "Vancouver", "Canada", "L5R 7F4", 4, 0m },
                    { 65, "customer-028", new DateTime(2025, 4, 16, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2152), "customer-028", "customer-028", new DateTime(2025, 4, 18, 20, 39, 26, 945, DateTimeKind.Utc).AddTicks(2152), "7441 First St", "Phoenix", "United States", "39656", 1, 0m },
                    { 66, "customer-024", new DateTime(2024, 11, 18, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2169), "customer-024", "customer-024", new DateTime(2024, 11, 20, 10, 39, 26, 945, DateTimeKind.Utc).AddTicks(2169), "2235 Elm Dr", "London", "United Kingdom", "MR4 3YH", 3, 0m },
                    { 67, "customer-029", new DateTime(2025, 6, 15, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2187), "customer-029", "customer-029", new DateTime(2025, 6, 18, 12, 39, 26, 945, DateTimeKind.Utc).AddTicks(2187), "3682 Main St", "Birmingham", "United Kingdom", "HE1 7XK", 2, 0m },
                    { 68, "customer-004", new DateTime(2024, 10, 28, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2202), "customer-004", "customer-004", new DateTime(2024, 10, 29, 9, 39, 26, 945, DateTimeKind.Utc).AddTicks(2202), "2776 Main St", "Toronto", "Canada", "O6M 2G2", 0, 0m },
                    { 69, "customer-005", new DateTime(2025, 1, 4, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2220), "customer-005", "customer-005", new DateTime(2025, 1, 5, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2220), "8439 Maple Ln", "Cologne", "Germany", "83668", 0, 0m },
                    { 70, "customer-007", new DateTime(2025, 7, 1, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2235), "customer-007", "customer-007", new DateTime(2025, 7, 2, 4, 39, 26, 945, DateTimeKind.Utc).AddTicks(2235), "6141 Maple Ln", "Brisbane", "Australia", "6713", 4, 0m },
                    { 71, "customer-024", new DateTime(2025, 3, 25, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2247), "customer-024", "customer-024", new DateTime(2025, 3, 27, 5, 39, 26, 945, DateTimeKind.Utc).AddTicks(2247), "1807 Second Ave", "Hamburg", "Germany", "12802", 2, 0m },
                    { 72, "customer-011", new DateTime(2025, 3, 14, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2259), "customer-011", "customer-011", new DateTime(2025, 3, 16, 6, 39, 26, 945, DateTimeKind.Utc).AddTicks(2259), "644 Second Ave", "Vancouver", "Canada", "D4D 8I5", 0, 0m },
                    { 73, "customer-009", new DateTime(2025, 2, 26, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2276), "customer-009", "customer-009", new DateTime(2025, 2, 27, 14, 39, 26, 945, DateTimeKind.Utc).AddTicks(2276), "6519 Cedar Way", "Los Angeles", "United States", "98049", 4, 0m },
                    { 74, "customer-026", new DateTime(2025, 7, 13, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2289), "customer-026", "customer-026", new DateTime(2025, 7, 13, 22, 39, 26, 945, DateTimeKind.Utc).AddTicks(2289), "3249 Oak Ave", "Cologne", "Germany", "88801", 2, 0m },
                    { 75, "customer-018", new DateTime(2025, 4, 20, 19, 39, 26, 945, DateTimeKind.Utc).AddTicks(2302), "customer-018", "customer-018", new DateTime(2025, 4, 23, 4, 39, 26, 945, DateTimeKind.Utc).AddTicks(2302), "9602 Second Ave", "Vancouver", "Canada", "W6I 0I6", 0, 0m }
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, 19.99m, 9, "admin-001", new DateTime(2025, 7, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "100% cotton classic fit t-shirt, perfect for everyday wear", "admin-001", new DateTime(2025, 7, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Classic Unisex T-Shirt" },
                    { 2, 24.99m, 9, "admin-001", new DateTime(2025, 7, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Premium soft cotton blend with modern fitted cut", "admin-001", new DateTime(2025, 7, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Premium Fitted T-Shirt" },
                    { 3, 22.99m, 9, "admin-001", new DateTime(2025, 6, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Retro-inspired slim fit cotton t-shirt", "admin-001", new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Vintage Style T-Shirt" },
                    { 4, 39.99m, 12, "admin-001", new DateTime(2025, 6, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Ultra-soft cotton blend pullover hoodie with kangaroo pocket", "admin-001", new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Cozy Pullover Hoodie" },
                    { 5, 44.99m, 13, "admin-001", new DateTime(2025, 6, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Versatile full-zip cotton hoodie with front pockets", "admin-001", new DateTime(2025, 7, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Full-Zip Hoodie" },
                    { 6, 14.99m, 30, "admin-001", new DateTime(2025, 6, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Durable iPhone 14 case with shock absorption", "admin-001", new DateTime(2025, 7, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "iPhone 14 Protective Case" },
                    { 7, 18.99m, 30, "admin-001", new DateTime(2025, 6, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Premium iPhone 15 Pro case with wireless charging support", "admin-001", new DateTime(2025, 7, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "iPhone 15 Pro Case" },
                    { 8, 16.99m, 31, "admin-001", new DateTime(2025, 6, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Protective Samsung Galaxy S24 case with camera protection", "admin-001", new DateTime(2025, 7, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Samsung Galaxy S24 Case" },
                    { 9, 12.99m, 22, "admin-001", new DateTime(2025, 6, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "High-quality 11oz ceramic mug, dishwasher and microwave safe", "admin-001", new DateTime(2025, 6, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Ceramic Coffee Mug" },
                    { 10, 18.99m, 23, "admin-001", new DateTime(2025, 6, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "15oz double-wall insulated travel mug with spill-proof lid", "admin-001", new DateTime(2025, 7, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Insulated Travel Mug" },
                    { 13, 19.99m, 25, "admin-001", new DateTime(2025, 6, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "16x16 inch throw pillow with hidden zipper and machine washable cover", "admin-001", new DateTime(2025, 7, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(3283), "Square Throw Pillow" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "BaseProductId", "ColorId", "CreatedBy", "CreatedOn", "DesignId", "IsActive", "LastModifiedBy", "LastModifiedOn", "Price", "SizeId", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7549), 1, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7551), 27.70m, 1, 102 },
                    { 2, 1, 1, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7669), 1, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7674), 22.49m, 2, 32 },
                    { 3, 1, 1, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7686), 1, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7687), 24.34m, 3, 78 },
                    { 4, 1, 1, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7693), 1, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7694), 22.65m, 4, 113 },
                    { 5, 1, 1, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7702), 1, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7703), 25.27m, 5, 114 },
                    { 6, 1, 1, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7713), 1, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7715), 24.43m, 6, 115 },
                    { 7, 1, 2, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7735), 1, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7737), 24.33m, 1, 127 },
                    { 8, 1, 2, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7743), 1, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7744), 24.99m, 2, 65 },
                    { 9, 1, 2, "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7749), 1, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7751), 25.98m, 3, 77 },
                    { 10, 1, 2, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7759), 1, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7761), 26.54m, 4, 43 },
                    { 11, 1, 2, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7766), 1, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7767), 25.44m, 5, 75 },
                    { 12, 1, 2, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7773), 1, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7774), 23.95m, 6, 70 },
                    { 13, 1, 3, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7789), 1, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7791), 26.16m, 1, 86 },
                    { 14, 1, 3, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7797), 1, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7798), 22.12m, 2, 73 },
                    { 15, 1, 3, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7805), 1, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7806), 25.34m, 3, 46 },
                    { 16, 1, 3, "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7812), 1, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7813), 22.41m, 4, 148 },
                    { 17, 1, 3, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7818), 1, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7820), 27.34m, 5, 109 },
                    { 18, 1, 3, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7828), 1, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7830), 27.02m, 6, 105 },
                    { 19, 1, 4, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7844), 1, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7845), 23.68m, 1, 43 },
                    { 20, 1, 4, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7851), 1, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7852), 26.21m, 2, 47 },
                    { 21, 1, 4, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7857), 1, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7859), 24.03m, 3, 73 },
                    { 22, 1, 4, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7864), 1, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7866), 27.61m, 4, 61 },
                    { 23, 1, 4, "admin-001", new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7872), 1, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7873), 27.52m, 5, 104 },
                    { 24, 1, 4, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7878), 1, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7879), 25.87m, 6, 46 },
                    { 25, 1, 5, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7892), 1, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7894), 26.15m, 1, 143 },
                    { 26, 1, 5, "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7899), 1, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7901), 25.35m, 2, 123 },
                    { 27, 1, 5, "admin-001", new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7953), 1, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7954), 24.61m, 3, 148 },
                    { 28, 1, 5, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7962), 1, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7963), 22.48m, 4, 87 },
                    { 29, 1, 5, "admin-001", new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7969), 1, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(7970), 22.98m, 5, 84 },
                    { 30, 1, 5, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8008), 1, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8010), 24.73m, 6, 112 },
                    { 31, 1, 6, "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8026), 1, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8027), 22.76m, 1, 91 },
                    { 32, 1, 6, "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8034), 1, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8035), 26.05m, 2, 83 },
                    { 33, 1, 6, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8041), 1, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8042), 24.03m, 3, 115 },
                    { 34, 1, 6, "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8051), 1, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8053), 23.18m, 4, 69 },
                    { 35, 1, 6, "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8059), 1, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8060), 25.73m, 5, 85 },
                    { 36, 1, 6, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8066), 1, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8068), 24.01m, 6, 108 },
                    { 37, 1, 7, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8083), 1, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8084), 22.65m, 1, 98 },
                    { 38, 1, 7, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8090), 1, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8091), 23.44m, 2, 40 },
                    { 39, 1, 7, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8096), 1, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8097), 26.91m, 3, 73 },
                    { 40, 1, 7, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8102), 1, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8104), 22.11m, 4, 95 },
                    { 41, 1, 7, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8109), 1, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8111), 23.38m, 5, 130 },
                    { 42, 1, 7, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8115), 1, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8117), 23.12m, 6, 121 },
                    { 43, 1, 8, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8132), 1, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8133), 22.04m, 1, 71 },
                    { 44, 1, 8, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8139), 1, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8141), 22.76m, 2, 47 },
                    { 45, 1, 8, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8147), 1, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8148), 23.99m, 3, 68 },
                    { 46, 1, 8, "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8153), 1, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8155), 22.28m, 4, 97 },
                    { 47, 1, 8, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8160), 1, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8161), 25.57m, 5, 64 },
                    { 48, 1, 8, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8166), 1, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8168), 26.98m, 6, 79 },
                    { 49, 1, 1, "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8198), 2, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8199), 22.64m, 1, 100 },
                    { 50, 1, 1, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8206), 2, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8208), 22.79m, 2, 129 },
                    { 51, 1, 1, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8329), 2, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8331), 24.47m, 3, 101 },
                    { 52, 1, 1, "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8341), 2, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8343), 22.36m, 4, 43 },
                    { 53, 1, 1, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8348), 2, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8349), 22.74m, 5, 33 },
                    { 54, 1, 1, "admin-001", new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8354), 2, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8356), 24.83m, 6, 60 },
                    { 55, 1, 2, "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8372), 2, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8373), 27.83m, 1, 64 },
                    { 56, 1, 2, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8379), 2, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8381), 27.04m, 2, 70 },
                    { 57, 1, 2, "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8387), 2, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8388), 27.05m, 3, 25 },
                    { 58, 1, 2, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8393), 2, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8394), 24.75m, 4, 121 },
                    { 59, 1, 2, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8400), 2, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8401), 22.65m, 5, 119 },
                    { 60, 1, 2, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8406), 2, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8408), 24.49m, 6, 25 },
                    { 61, 1, 3, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8421), 2, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8423), 24.70m, 1, 61 },
                    { 62, 1, 3, "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8428), 2, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8430), 26.42m, 2, 131 },
                    { 63, 1, 3, "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8435), 2, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8436), 26.10m, 3, 33 },
                    { 64, 1, 3, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8441), 2, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8443), 22.43m, 4, 70 },
                    { 65, 1, 3, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8448), 2, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8449), 25.79m, 5, 98 },
                    { 66, 1, 3, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8457), 2, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8459), 23.71m, 6, 67 },
                    { 67, 1, 4, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8471), 2, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8473), 26.43m, 1, 50 },
                    { 68, 1, 4, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8479), 2, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8480), 25.67m, 2, 85 },
                    { 69, 1, 4, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8486), 2, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8487), 22.98m, 3, 64 },
                    { 70, 1, 4, "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8492), 2, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8494), 26.07m, 4, 51 },
                    { 71, 1, 4, "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8498), 2, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8500), 24.47m, 5, 30 },
                    { 72, 1, 4, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8505), 2, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8507), 23.49m, 6, 88 },
                    { 73, 1, 5, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8520), 2, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8521), 23.53m, 1, 103 },
                    { 74, 1, 5, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8619), 2, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8621), 27.87m, 2, 36 },
                    { 75, 1, 5, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8628), 2, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8630), 22.65m, 3, 66 },
                    { 76, 1, 5, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8636), 2, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8637), 23.73m, 4, 133 },
                    { 77, 1, 5, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8643), 2, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8644), 27.01m, 5, 93 },
                    { 78, 1, 5, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8649), 2, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8651), 27.65m, 6, 143 },
                    { 79, 1, 6, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8665), 2, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8666), 26.51m, 1, 29 },
                    { 80, 1, 6, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8672), 2, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8673), 25.02m, 2, 123 },
                    { 81, 1, 6, "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8679), 2, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8680), 26.65m, 3, 127 },
                    { 82, 1, 6, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8685), 2, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8686), 26.07m, 4, 75 },
                    { 83, 1, 6, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8692), 2, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8693), 22.96m, 5, 63 },
                    { 84, 1, 6, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8699), 2, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8700), 23.11m, 6, 62 },
                    { 85, 1, 7, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8713), 2, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8714), 27.01m, 1, 104 },
                    { 86, 1, 7, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8720), 2, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8722), 27.16m, 2, 108 },
                    { 87, 1, 7, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8727), 2, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8728), 23.56m, 3, 72 },
                    { 88, 1, 7, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8734), 2, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8735), 24.66m, 4, 139 },
                    { 89, 1, 7, "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8740), 2, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8742), 23.32m, 5, 124 },
                    { 90, 1, 7, "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8747), 2, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8748), 24.40m, 6, 52 },
                    { 91, 1, 8, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8764), 2, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8765), 25.35m, 1, 97 },
                    { 92, 1, 8, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8770), 2, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8772), 25.02m, 2, 26 },
                    { 93, 1, 8, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8777), 2, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8778), 24.02m, 3, 37 },
                    { 94, 1, 8, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8784), 2, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8785), 23.42m, 4, 75 },
                    { 95, 1, 8, "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8791), 2, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8793), 22.09m, 5, 44 },
                    { 96, 1, 8, "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8798), 2, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8800), 23.99m, 6, 30 },
                    { 97, 1, 1, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8828), 3, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8830), 26.22m, 1, 40 },
                    { 98, 1, 1, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8836), 3, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8837), 25.24m, 2, 53 },
                    { 99, 1, 1, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8842), 3, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8844), 22.67m, 3, 40 },
                    { 100, 1, 1, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8849), 3, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8851), 22.46m, 4, 46 },
                    { 101, 1, 1, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8928), 3, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8930), 22.87m, 5, 102 },
                    { 102, 1, 1, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8937), 3, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8939), 25.06m, 6, 116 },
                    { 103, 1, 2, "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8955), 3, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8956), 24.56m, 1, 106 },
                    { 104, 1, 2, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8962), 3, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8963), 24.97m, 2, 52 },
                    { 105, 1, 2, "admin-001", new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8969), 3, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8971), 27.69m, 3, 68 },
                    { 106, 1, 2, "admin-001", new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8976), 3, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8977), 27.31m, 4, 130 },
                    { 107, 1, 2, "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8983), 3, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8984), 27.71m, 5, 123 },
                    { 108, 1, 2, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8990), 3, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(8991), 23.59m, 6, 35 },
                    { 109, 1, 3, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9004), 3, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9006), 24.08m, 1, 84 },
                    { 110, 1, 3, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9012), 3, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9014), 24.61m, 2, 60 },
                    { 111, 1, 3, "admin-001", new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9020), 3, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9021), 22.26m, 3, 64 },
                    { 112, 1, 3, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9026), 3, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9027), 26.62m, 4, 137 },
                    { 113, 1, 3, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9032), 3, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9034), 22.14m, 5, 103 },
                    { 114, 1, 3, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9039), 3, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9040), 23.44m, 6, 77 },
                    { 115, 1, 4, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9053), 3, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9055), 26.23m, 1, 87 },
                    { 116, 1, 4, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9060), 3, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9061), 27.84m, 2, 145 },
                    { 117, 1, 4, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9066), 3, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9068), 25.72m, 3, 101 },
                    { 118, 1, 4, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9072), 3, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9074), 22.42m, 4, 72 },
                    { 119, 1, 4, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9079), 3, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9080), 25.69m, 5, 144 },
                    { 120, 1, 4, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9086), 3, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9087), 27.29m, 6, 27 },
                    { 121, 1, 5, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9098), 3, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9100), 26.00m, 1, 133 },
                    { 122, 1, 5, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9106), 3, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9107), 26.46m, 2, 62 },
                    { 123, 1, 5, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9112), 3, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9114), 22.68m, 3, 131 },
                    { 124, 1, 5, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9119), 3, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9121), 27.33m, 4, 26 },
                    { 125, 1, 5, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9127), 3, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9128), 26.58m, 5, 101 },
                    { 126, 1, 5, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9133), 3, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9135), 27.98m, 6, 37 },
                    { 127, 1, 6, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9218), 3, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9221), 25.27m, 1, 108 },
                    { 128, 1, 6, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9229), 3, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9231), 22.50m, 2, 123 },
                    { 129, 1, 6, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9237), 3, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9238), 22.93m, 3, 67 },
                    { 130, 1, 6, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9247), 3, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9248), 27.22m, 4, 138 },
                    { 131, 1, 6, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9254), 3, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9255), 22.02m, 5, 146 },
                    { 132, 1, 6, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9260), 3, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9262), 24.24m, 6, 42 },
                    { 133, 1, 7, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9278), 3, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9279), 27.74m, 1, 56 },
                    { 134, 1, 7, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9286), 3, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9287), 26.53m, 2, 46 },
                    { 135, 1, 7, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9292), 3, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9294), 22.30m, 3, 81 },
                    { 136, 1, 7, "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9298), 3, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9300), 23.11m, 4, 64 },
                    { 137, 1, 7, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9306), 3, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9307), 24.57m, 5, 65 },
                    { 138, 1, 7, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9312), 3, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9314), 27.71m, 6, 136 },
                    { 139, 1, 8, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9326), 3, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9328), 22.06m, 1, 143 },
                    { 140, 1, 8, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9333), 3, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9335), 23.16m, 2, 99 },
                    { 141, 1, 8, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9340), 3, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9342), 27.34m, 3, 88 },
                    { 142, 1, 8, "admin-001", new DateTime(2025, 7, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9347), 3, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9349), 27.88m, 4, 43 },
                    { 143, 1, 8, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9354), 3, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9355), 23.67m, 5, 85 },
                    { 144, 1, 8, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9360), 3, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9362), 26.86m, 6, 90 },
                    { 145, 1, 1, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9389), 4, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9390), 22.78m, 1, 97 },
                    { 146, 1, 1, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9396), 4, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9398), 24.12m, 2, 52 },
                    { 147, 1, 1, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9491), 4, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9492), 22.26m, 3, 143 },
                    { 148, 1, 1, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9501), 4, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9503), 22.09m, 4, 28 },
                    { 149, 1, 1, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9508), 4, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9509), 23.08m, 5, 110 },
                    { 150, 1, 1, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9515), 4, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9517), 27.92m, 6, 26 },
                    { 151, 1, 2, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9533), 4, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9534), 24.38m, 1, 125 },
                    { 152, 1, 2, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9540), 4, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9541), 27.02m, 2, 123 },
                    { 153, 1, 2, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9547), 4, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9548), 26.85m, 3, 83 },
                    { 154, 1, 2, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9554), 4, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9555), 26.79m, 4, 51 },
                    { 155, 1, 2, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9561), 4, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9562), 27.08m, 5, 57 },
                    { 156, 1, 2, "admin-001", new DateTime(2025, 7, 21, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9567), 4, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9569), 27.33m, 6, 39 },
                    { 157, 1, 3, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9582), 4, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9584), 22.67m, 1, 99 },
                    { 158, 1, 3, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9589), 4, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9591), 24.03m, 2, 81 },
                    { 159, 1, 3, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9596), 4, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9597), 23.40m, 3, 88 },
                    { 160, 1, 3, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9603), 4, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9605), 27.68m, 4, 48 },
                    { 161, 1, 3, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9610), 4, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9611), 27.40m, 5, 121 },
                    { 162, 1, 3, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9617), 4, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9618), 22.82m, 6, 119 },
                    { 163, 1, 4, "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9632), 4, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9633), 25.78m, 1, 89 },
                    { 164, 1, 4, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9638), 4, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9640), 23.36m, 2, 63 },
                    { 165, 1, 4, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9645), 4, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9646), 27.01m, 3, 28 },
                    { 166, 1, 4, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9652), 4, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9653), 25.26m, 4, 140 },
                    { 167, 1, 4, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9658), 4, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9660), 26.61m, 5, 121 },
                    { 168, 1, 4, "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9665), 4, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9666), 25.37m, 6, 87 },
                    { 169, 1, 5, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9683), 4, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9685), 22.20m, 1, 90 },
                    { 170, 1, 5, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9690), 4, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9691), 22.68m, 2, 77 },
                    { 171, 1, 5, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9697), 4, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9698), 27.60m, 3, 59 },
                    { 172, 1, 5, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9704), 4, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9706), 25.70m, 4, 146 },
                    { 173, 1, 5, "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9711), 4, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9712), 22.70m, 5, 71 },
                    { 174, 1, 5, "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9808), 4, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9810), 27.01m, 6, 148 },
                    { 175, 1, 6, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9829), 4, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9830), 25.73m, 1, 105 },
                    { 176, 1, 6, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9837), 4, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9839), 24.24m, 2, 71 },
                    { 177, 1, 6, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9844), 4, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9845), 26.75m, 3, 46 },
                    { 178, 1, 6, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9851), 4, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9852), 23.05m, 4, 59 },
                    { 179, 1, 6, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9858), 4, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9859), 27.48m, 5, 149 },
                    { 180, 1, 6, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9864), 4, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9865), 24.56m, 6, 65 },
                    { 181, 1, 7, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9877), 4, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9878), 27.29m, 1, 82 },
                    { 182, 1, 7, "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9885), 4, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9886), 26.70m, 2, 124 },
                    { 183, 1, 7, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9891), 4, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9893), 26.85m, 3, 44 },
                    { 184, 1, 7, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9898), 4, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9900), 25.84m, 4, 118 },
                    { 185, 1, 7, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9905), 4, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9907), 27.22m, 5, 70 },
                    { 186, 1, 7, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9912), 4, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9914), 23.70m, 6, 48 },
                    { 187, 1, 8, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9926), 4, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9927), 23.21m, 1, 62 },
                    { 188, 1, 8, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9940), 4, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9942), 26.04m, 2, 80 },
                    { 189, 1, 8, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9948), 4, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9950), 27.42m, 3, 147 },
                    { 190, 1, 8, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9955), 4, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9957), 23.18m, 4, 51 },
                    { 191, 1, 8, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9962), 4, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9963), 24.10m, 5, 104 },
                    { 192, 1, 8, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 942, DateTimeKind.Utc).AddTicks(9969), 4, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(91), 26.67m, 6, 112 },
                    { 193, 1, 1, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(128), 5, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(129), 22.06m, 1, 117 },
                    { 194, 1, 1, "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(135), 5, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(137), 23.73m, 2, 61 },
                    { 195, 1, 1, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(142), 5, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(143), 26.25m, 3, 66 },
                    { 196, 1, 1, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(148), 5, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(150), 26.74m, 4, 147 },
                    { 197, 1, 1, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(155), 5, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(157), 25.60m, 5, 48 },
                    { 198, 1, 1, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(162), 5, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(163), 23.59m, 6, 33 },
                    { 199, 1, 2, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(177), 5, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(178), 22.07m, 1, 29 },
                    { 200, 1, 2, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(335), 5, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(336), 23.74m, 2, 115 },
                    { 201, 1, 2, "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(346), 5, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(347), 25.11m, 3, 129 },
                    { 202, 1, 2, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(352), 5, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(354), 22.27m, 4, 85 },
                    { 203, 1, 2, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(359), 5, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(361), 24.82m, 5, 122 },
                    { 204, 1, 2, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(366), 5, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(368), 23.33m, 6, 132 },
                    { 205, 1, 3, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(383), 5, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(385), 23.58m, 1, 90 },
                    { 206, 1, 3, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(391), 5, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(392), 22.78m, 2, 39 },
                    { 207, 1, 3, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(397), 5, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(399), 24.23m, 3, 117 },
                    { 208, 1, 3, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(405), 5, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(406), 23.19m, 4, 132 },
                    { 209, 1, 3, "admin-001", new DateTime(2025, 7, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(412), 5, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(414), 23.58m, 5, 85 },
                    { 210, 1, 3, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(419), 5, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(421), 22.88m, 6, 80 },
                    { 211, 1, 4, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(434), 5, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(435), 23.07m, 1, 144 },
                    { 212, 1, 4, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(440), 5, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(442), 27.14m, 2, 87 },
                    { 213, 1, 4, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(447), 5, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(448), 26.99m, 3, 115 },
                    { 214, 1, 4, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(453), 5, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(455), 23.79m, 4, 84 },
                    { 215, 1, 4, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(460), 5, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(462), 27.62m, 5, 135 },
                    { 216, 1, 4, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(467), 5, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(469), 24.59m, 6, 119 },
                    { 217, 1, 5, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(481), 5, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(483), 24.25m, 1, 52 },
                    { 218, 1, 5, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(487), 5, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(489), 27.34m, 2, 56 },
                    { 219, 1, 5, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(495), 5, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(497), 23.24m, 3, 63 },
                    { 220, 1, 5, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(502), 5, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(504), 27.57m, 4, 77 },
                    { 221, 1, 5, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(509), 5, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(510), 23.79m, 5, 137 },
                    { 222, 1, 5, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(516), 5, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(517), 24.88m, 6, 105 },
                    { 223, 1, 6, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(531), 5, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(532), 22.64m, 1, 95 },
                    { 224, 1, 6, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(538), 5, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(539), 27.29m, 2, 26 },
                    { 225, 1, 6, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(545), 5, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(546), 25.25m, 3, 97 },
                    { 226, 1, 6, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(641), 5, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(643), 27.36m, 4, 111 },
                    { 227, 1, 6, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(650), 5, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(652), 24.99m, 5, 94 },
                    { 228, 1, 6, "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(657), 5, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(658), 22.38m, 6, 49 },
                    { 229, 1, 7, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(674), 5, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(676), 26.77m, 1, 110 },
                    { 230, 1, 7, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(682), 5, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(684), 24.03m, 2, 141 },
                    { 231, 1, 7, "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(689), 5, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(690), 25.20m, 3, 126 },
                    { 232, 1, 7, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(696), 5, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(698), 23.42m, 4, 144 },
                    { 233, 1, 7, "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(703), 5, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(704), 25.74m, 5, 148 },
                    { 234, 1, 7, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(710), 5, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(711), 23.84m, 6, 81 },
                    { 235, 1, 8, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(724), 5, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(726), 25.80m, 1, 129 },
                    { 236, 1, 8, "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(733), 5, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(734), 22.50m, 2, 111 },
                    { 237, 1, 8, "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(740), 5, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(742), 22.55m, 3, 86 },
                    { 238, 1, 8, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(749), 5, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(750), 21.99m, 4, 43 },
                    { 239, 1, 8, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(756), 5, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(757), 24.71m, 5, 71 },
                    { 240, 1, 8, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(762), 5, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(764), 22.36m, 6, 142 },
                    { 241, 1, 1, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(795), 6, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(797), 25.71m, 1, 69 },
                    { 242, 1, 1, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(802), 6, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(804), 25.38m, 2, 40 },
                    { 243, 1, 1, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(810), 6, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(812), 26.20m, 3, 75 },
                    { 244, 1, 1, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(818), 6, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(819), 27.71m, 4, 50 },
                    { 245, 1, 1, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(825), 6, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(826), 22.51m, 5, 115 },
                    { 246, 1, 1, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(831), 6, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(833), 24.95m, 6, 117 },
                    { 247, 1, 2, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(847), 6, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(848), 27.46m, 1, 27 },
                    { 248, 1, 2, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(853), 6, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(855), 24.10m, 2, 137 },
                    { 249, 1, 2, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(860), 6, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(861), 24.95m, 3, 79 },
                    { 250, 1, 2, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(867), 6, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(868), 23.97m, 4, 106 },
                    { 251, 1, 2, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(874), 6, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(876), 23.65m, 5, 40 },
                    { 252, 1, 2, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(882), 6, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(884), 23.49m, 6, 96 },
                    { 253, 1, 3, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(994), 6, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(995), 26.32m, 1, 57 },
                    { 254, 1, 3, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1001), 6, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1002), 26.23m, 2, 99 },
                    { 255, 1, 3, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1007), 6, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1009), 22.95m, 3, 136 },
                    { 256, 1, 3, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1014), 6, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1015), 23.34m, 4, 59 },
                    { 257, 1, 3, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1021), 6, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1022), 27.15m, 5, 50 },
                    { 258, 1, 3, "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1035), 6, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1037), 27.39m, 6, 140 },
                    { 259, 1, 4, "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1052), 6, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1054), 24.25m, 1, 57 },
                    { 260, 1, 4, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1060), 6, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1061), 23.45m, 2, 100 },
                    { 261, 1, 4, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1066), 6, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1068), 24.18m, 3, 106 },
                    { 262, 1, 4, "admin-001", new DateTime(2025, 7, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1073), 6, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1074), 27.42m, 4, 50 },
                    { 263, 1, 4, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1079), 6, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1081), 24.35m, 5, 78 },
                    { 264, 1, 4, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1086), 6, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1088), 24.92m, 6, 125 },
                    { 265, 1, 5, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1101), 6, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1102), 22.76m, 1, 111 },
                    { 266, 1, 5, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1166), 6, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1168), 25.39m, 2, 42 },
                    { 267, 1, 5, "admin-001", new DateTime(2025, 7, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1177), 6, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1179), 26.50m, 3, 94 },
                    { 268, 1, 5, "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1184), 6, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1186), 22.73m, 4, 109 },
                    { 269, 1, 5, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1191), 6, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1193), 25.95m, 5, 128 },
                    { 270, 1, 5, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1198), 6, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1199), 22.37m, 6, 137 },
                    { 271, 1, 6, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1216), 6, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1217), 23.24m, 1, 38 },
                    { 272, 1, 6, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1222), 6, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1224), 24.13m, 2, 33 },
                    { 273, 1, 6, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1229), 6, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1230), 25.07m, 3, 83 },
                    { 274, 1, 6, "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1235), 6, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1237), 27.17m, 4, 47 },
                    { 275, 1, 6, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1242), 6, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1243), 23.78m, 5, 76 },
                    { 276, 1, 6, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1248), 6, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1250), 23.44m, 6, 93 },
                    { 277, 1, 7, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1261), 6, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1262), 26.72m, 1, 25 },
                    { 278, 1, 7, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1268), 6, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1269), 25.74m, 2, 46 },
                    { 279, 1, 7, "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1274), 6, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1276), 26.79m, 3, 35 },
                    { 280, 1, 7, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1281), 6, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1283), 22.11m, 4, 134 },
                    { 281, 1, 7, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1288), 6, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1289), 25.67m, 5, 73 },
                    { 282, 1, 7, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1295), 6, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1296), 24.56m, 6, 36 },
                    { 283, 1, 8, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1307), 6, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1309), 22.35m, 1, 144 },
                    { 284, 1, 8, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1314), 6, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1316), 25.36m, 2, 93 },
                    { 285, 1, 8, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1321), 6, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1322), 24.00m, 3, 75 },
                    { 286, 1, 8, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1328), 6, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1329), 23.71m, 4, 60 },
                    { 287, 1, 8, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1334), 6, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1335), 25.20m, 5, 27 },
                    { 288, 1, 8, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1341), 6, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1342), 24.03m, 6, 64 },
                    { 289, 1, 1, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1370), 7, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1372), 27.84m, 1, 107 },
                    { 290, 1, 1, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1377), 7, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1379), 25.66m, 2, 40 },
                    { 291, 1, 1, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1516), 7, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1518), 23.86m, 3, 62 },
                    { 292, 1, 1, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1525), 7, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1526), 27.34m, 4, 61 },
                    { 293, 1, 1, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1531), 7, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1533), 25.99m, 5, 47 },
                    { 294, 1, 1, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1538), 7, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1540), 23.13m, 6, 36 },
                    { 295, 1, 2, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1557), 7, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1558), 24.63m, 1, 98 },
                    { 296, 1, 2, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1563), 7, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1565), 24.04m, 2, 139 },
                    { 297, 1, 2, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1569), 7, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1571), 26.51m, 3, 131 },
                    { 298, 1, 2, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1576), 7, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1577), 26.90m, 4, 95 },
                    { 299, 1, 2, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1582), 7, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1584), 22.67m, 5, 148 },
                    { 300, 1, 2, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1589), 7, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1590), 26.11m, 6, 60 },
                    { 301, 1, 3, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1602), 7, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1603), 24.12m, 1, 87 },
                    { 302, 1, 3, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1608), 7, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1610), 23.13m, 2, 98 },
                    { 303, 1, 3, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1615), 7, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1616), 23.55m, 3, 75 },
                    { 304, 1, 3, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1622), 7, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1623), 22.03m, 4, 135 },
                    { 305, 1, 3, "admin-001", new DateTime(2025, 7, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1628), 7, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1630), 22.94m, 5, 131 },
                    { 306, 1, 3, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1635), 7, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1636), 25.68m, 6, 119 },
                    { 307, 1, 4, "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1647), 7, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1649), 22.75m, 1, 138 },
                    { 308, 1, 4, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1654), 7, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1656), 22.30m, 2, 76 },
                    { 309, 1, 4, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1661), 7, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1662), 22.83m, 3, 133 },
                    { 310, 1, 4, "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1668), 7, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1669), 26.77m, 4, 147 },
                    { 311, 1, 4, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1674), 7, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1676), 25.72m, 5, 123 },
                    { 312, 1, 4, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1680), 7, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1682), 22.89m, 6, 28 },
                    { 313, 1, 5, "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1693), 7, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1694), 25.75m, 1, 105 },
                    { 314, 1, 5, "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1699), 7, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1701), 24.18m, 2, 76 },
                    { 315, 1, 5, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1706), 7, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1707), 22.39m, 3, 26 },
                    { 316, 1, 5, "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1713), 7, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1714), 22.49m, 4, 28 },
                    { 317, 1, 5, "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1719), 7, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1721), 26.58m, 5, 56 },
                    { 318, 1, 5, "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1837), 7, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1839), 26.95m, 6, 89 },
                    { 319, 1, 6, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1865), 7, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1866), 23.77m, 1, 118 },
                    { 320, 1, 6, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1872), 7, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1873), 22.66m, 2, 27 },
                    { 321, 1, 6, "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1879), 7, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1880), 26.23m, 3, 59 },
                    { 322, 1, 6, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1885), 7, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1887), 25.47m, 4, 125 },
                    { 323, 1, 6, "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1892), 7, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1894), 23.42m, 5, 82 },
                    { 324, 1, 6, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1900), 7, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1901), 27.64m, 6, 59 },
                    { 325, 1, 7, "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1914), 7, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1915), 27.73m, 1, 124 },
                    { 326, 1, 7, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1920), 7, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1922), 22.88m, 2, 33 },
                    { 327, 1, 7, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1927), 7, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1929), 22.24m, 3, 105 },
                    { 328, 1, 7, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1933), 7, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1935), 27.96m, 4, 125 },
                    { 329, 1, 7, "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1940), 7, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1941), 22.35m, 5, 142 },
                    { 330, 1, 7, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1947), 7, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1948), 24.70m, 6, 77 },
                    { 331, 1, 8, "admin-001", new DateTime(2025, 7, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1960), 7, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1962), 24.75m, 1, 44 },
                    { 332, 1, 8, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1967), 7, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1969), 26.41m, 2, 127 },
                    { 333, 1, 8, "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1975), 7, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1976), 25.98m, 3, 128 },
                    { 334, 1, 8, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1982), 7, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1983), 24.22m, 4, 31 },
                    { 335, 1, 8, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1989), 7, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1990), 27.20m, 5, 83 },
                    { 336, 1, 8, "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1995), 7, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(1997), 23.62m, 6, 47 },
                    { 337, 1, 1, "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2025), 8, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2026), 27.81m, 1, 116 },
                    { 338, 1, 1, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2032), 8, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2033), 26.21m, 2, 59 },
                    { 339, 1, 1, "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2039), 8, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2040), 25.12m, 3, 111 },
                    { 340, 1, 1, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2046), 8, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2047), 22.99m, 4, 29 },
                    { 341, 1, 1, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2052), 8, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2054), 24.43m, 5, 89 },
                    { 342, 1, 1, "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2059), 8, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2060), 27.60m, 6, 45 },
                    { 343, 1, 2, "admin-001", new DateTime(2025, 7, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2073), 8, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2074), 27.94m, 1, 141 },
                    { 344, 1, 2, "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2191), 8, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2193), 22.31m, 2, 67 },
                    { 345, 1, 2, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2201), 8, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2203), 24.51m, 3, 83 },
                    { 346, 1, 2, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2208), 8, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2209), 22.56m, 4, 54 },
                    { 347, 1, 2, "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2215), 8, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2216), 26.10m, 5, 66 },
                    { 348, 1, 2, "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2221), 8, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2223), 25.70m, 6, 144 },
                    { 349, 1, 3, "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2240), 8, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2241), 22.53m, 1, 43 },
                    { 350, 1, 3, "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2247), 8, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(2249), 23.33m, 2, 95 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductVariantId", "Quantity", "TotalPrice", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 180, 1, 46.72m, 46.72m },
                    { 2, 1, 190, 3, 96.45m, 32.15m },
                    { 3, 1, 63, 2, 97.16m, 48.58m },
                    { 4, 2, 150, 3, 91.80m, 30.60m },
                    { 5, 2, 17, 1, 42.75m, 42.75m },
                    { 6, 2, 109, 1, 33.71m, 33.71m },
                    { 7, 2, 177, 1, 29.16m, 29.16m },
                    { 8, 3, 100, 2, 96.46m, 48.23m },
                    { 9, 3, 49, 1, 26.34m, 26.34m },
                    { 10, 3, 126, 3, 90.54m, 30.18m },
                    { 11, 3, 184, 2, 56.72m, 28.36m },
                    { 12, 3, 158, 3, 75.60m, 25.20m },
                    { 13, 4, 88, 3, 73.32m, 24.44m },
                    { 14, 4, 71, 1, 20.00m, 20.00m },
                    { 15, 4, 13, 2, 35.98m, 17.99m },
                    { 16, 4, 113, 3, 63.51m, 21.17m },
                    { 17, 4, 188, 2, 55.76m, 27.88m },
                    { 18, 4, 82, 2, 39.66m, 19.83m },
                    { 19, 5, 126, 2, 24.70m, 12.35m },
                    { 20, 5, 20, 2, 21.92m, 10.96m },
                    { 21, 5, 174, 1, 37.18m, 37.18m },
                    { 22, 5, 145, 3, 22.02m, 7.34m },
                    { 23, 6, 113, 1, 26.19m, 26.19m },
                    { 24, 6, 72, 2, 28.38m, 14.19m },
                    { 25, 6, 171, 1, 44.32m, 44.32m },
                    { 26, 6, 96, 3, 94.20m, 31.40m },
                    { 27, 7, 146, 2, 27.30m, 13.65m },
                    { 28, 7, 194, 3, 42.12m, 14.04m },
                    { 29, 7, 139, 3, 113.97m, 37.99m },
                    { 30, 8, 124, 2, 41.82m, 20.91m },
                    { 31, 8, 179, 3, 118.11m, 39.37m },
                    { 32, 8, 54, 1, 53.16m, 53.16m },
                    { 33, 9, 78, 1, 33.14m, 33.14m },
                    { 34, 9, 16, 1, 32.91m, 32.91m },
                    { 35, 9, 33, 2, 89.38m, 44.69m },
                    { 36, 10, 76, 2, 84.68m, 42.34m },
                    { 37, 10, 147, 2, 84.26m, 42.13m },
                    { 38, 10, 117, 2, 49.80m, 24.90m },
                    { 39, 10, 18, 2, 37.02m, 18.51m },
                    { 40, 11, 115, 1, 19.83m, 19.83m },
                    { 41, 11, 111, 3, 34.14m, 11.38m },
                    { 42, 11, 158, 3, 134.37m, 44.79m },
                    { 43, 11, 91, 1, 22.22m, 22.22m },
                    { 44, 12, 118, 2, 45.62m, 22.81m },
                    { 45, 12, 56, 2, 31.60m, 15.80m },
                    { 46, 12, 162, 3, 66.72m, 22.24m },
                    { 47, 13, 78, 2, 29.32m, 14.66m },
                    { 48, 13, 173, 3, 71.73m, 23.91m },
                    { 49, 13, 165, 2, 75.90m, 37.95m },
                    { 50, 13, 190, 3, 157.05m, 52.35m },
                    { 51, 13, 27, 2, 19.36m, 9.68m },
                    { 52, 13, 158, 1, 39.29m, 39.29m },
                    { 53, 14, 59, 2, 20.06m, 10.03m },
                    { 54, 14, 150, 3, 129.42m, 43.14m },
                    { 55, 14, 160, 1, 29.38m, 29.38m },
                    { 56, 14, 149, 1, 33.02m, 33.02m },
                    { 57, 14, 88, 3, 139.41m, 46.47m },
                    { 58, 14, 47, 1, 39.98m, 39.98m },
                    { 59, 15, 136, 2, 39.12m, 19.56m },
                    { 60, 15, 40, 2, 56.24m, 28.12m },
                    { 61, 15, 171, 2, 19.34m, 9.67m },
                    { 62, 15, 148, 1, 37.19m, 37.19m },
                    { 63, 15, 171, 1, 28.59m, 28.59m },
                    { 64, 15, 200, 2, 36.10m, 18.05m },
                    { 65, 16, 70, 1, 47.81m, 47.81m },
                    { 66, 16, 125, 3, 142.62m, 47.54m },
                    { 67, 17, 14, 2, 77.16m, 38.58m },
                    { 68, 17, 120, 3, 144.81m, 48.27m },
                    { 69, 17, 179, 2, 76.70m, 38.35m },
                    { 70, 18, 138, 1, 36.05m, 36.05m },
                    { 71, 18, 36, 2, 68.98m, 34.49m },
                    { 72, 18, 58, 1, 42.90m, 42.90m },
                    { 73, 18, 171, 1, 35.30m, 35.30m },
                    { 74, 18, 46, 2, 32.26m, 16.13m },
                    { 75, 19, 2, 1, 25.23m, 25.23m },
                    { 76, 19, 111, 2, 71.40m, 35.70m },
                    { 77, 19, 100, 2, 76.62m, 38.31m },
                    { 78, 19, 130, 2, 77.06m, 38.53m },
                    { 79, 20, 158, 2, 52.18m, 26.09m },
                    { 80, 20, 156, 1, 41.68m, 41.68m },
                    { 81, 20, 150, 3, 56.91m, 18.97m },
                    { 82, 21, 197, 2, 70.64m, 35.32m },
                    { 83, 21, 137, 1, 25.82m, 25.82m },
                    { 84, 21, 126, 3, 137.37m, 45.79m },
                    { 85, 21, 159, 2, 23.18m, 11.59m },
                    { 86, 21, 41, 2, 103.54m, 51.77m },
                    { 87, 22, 164, 3, 144.66m, 48.22m },
                    { 88, 22, 46, 3, 88.65m, 29.55m },
                    { 89, 22, 161, 2, 61.46m, 30.73m },
                    { 90, 22, 168, 2, 48.18m, 24.09m },
                    { 91, 22, 72, 3, 79.50m, 26.50m },
                    { 92, 22, 153, 1, 34.31m, 34.31m },
                    { 93, 23, 198, 2, 74.18m, 37.09m },
                    { 94, 23, 109, 2, 44.38m, 22.19m },
                    { 95, 23, 135, 1, 41.25m, 41.25m },
                    { 96, 23, 78, 2, 54.18m, 27.09m },
                    { 97, 23, 7, 3, 67.44m, 22.48m },
                    { 98, 23, 127, 3, 38.07m, 12.69m },
                    { 99, 24, 170, 2, 62.54m, 31.27m },
                    { 100, 24, 45, 2, 27.32m, 13.66m },
                    { 101, 24, 198, 1, 25.05m, 25.05m },
                    { 102, 24, 62, 1, 13.04m, 13.04m },
                    { 103, 24, 89, 1, 30.11m, 30.11m },
                    { 104, 24, 146, 3, 76.74m, 25.58m },
                    { 105, 25, 146, 2, 37.64m, 18.82m },
                    { 106, 25, 56, 1, 28.18m, 28.18m },
                    { 107, 25, 65, 3, 143.46m, 47.82m },
                    { 108, 25, 49, 2, 63.32m, 31.66m },
                    { 109, 26, 80, 1, 9.04m, 9.04m },
                    { 110, 26, 146, 2, 30.90m, 15.45m },
                    { 111, 26, 39, 3, 85.77m, 28.59m },
                    { 112, 26, 17, 3, 44.79m, 14.93m },
                    { 113, 27, 99, 1, 41.84m, 41.84m },
                    { 114, 27, 143, 1, 42.87m, 42.87m },
                    { 115, 27, 197, 2, 40.42m, 20.21m },
                    { 116, 27, 41, 3, 136.35m, 45.45m },
                    { 117, 27, 57, 2, 32.46m, 16.23m },
                    { 118, 28, 1, 3, 52.14m, 17.38m },
                    { 119, 28, 18, 1, 14.60m, 14.60m },
                    { 120, 28, 48, 3, 119.70m, 39.90m },
                    { 121, 28, 102, 3, 59.76m, 19.92m },
                    { 122, 29, 138, 1, 21.17m, 21.17m },
                    { 123, 29, 149, 1, 50.23m, 50.23m },
                    { 124, 29, 198, 1, 30.14m, 30.14m },
                    { 125, 30, 62, 3, 82.47m, 27.49m },
                    { 126, 30, 99, 2, 78.92m, 39.46m },
                    { 127, 30, 125, 3, 126.81m, 42.27m },
                    { 128, 30, 150, 3, 81.96m, 27.32m },
                    { 129, 30, 139, 3, 121.59m, 40.53m },
                    { 130, 30, 13, 3, 65.67m, 21.89m },
                    { 131, 31, 52, 3, 66.42m, 22.14m },
                    { 132, 31, 20, 1, 30.45m, 30.45m },
                    { 133, 32, 102, 3, 115.74m, 38.58m },
                    { 134, 32, 93, 2, 26.58m, 13.29m },
                    { 135, 32, 14, 1, 32.89m, 32.89m },
                    { 136, 32, 200, 1, 28.92m, 28.92m },
                    { 137, 33, 67, 3, 122.82m, 40.94m },
                    { 138, 33, 85, 2, 76.58m, 38.29m },
                    { 139, 33, 47, 3, 93.96m, 31.32m },
                    { 140, 34, 167, 1, 43.50m, 43.50m },
                    { 141, 34, 48, 2, 51.94m, 25.97m },
                    { 142, 34, 59, 1, 21.20m, 21.20m },
                    { 143, 34, 164, 1, 17.31m, 17.31m },
                    { 144, 35, 100, 3, 58.29m, 19.43m },
                    { 145, 35, 164, 2, 43.06m, 21.53m },
                    { 146, 35, 17, 1, 15.29m, 15.29m },
                    { 147, 36, 165, 2, 40.72m, 20.36m },
                    { 148, 36, 40, 1, 42.47m, 42.47m },
                    { 149, 36, 6, 3, 79.20m, 26.40m },
                    { 150, 37, 132, 2, 59.70m, 29.85m },
                    { 151, 37, 87, 2, 97.54m, 48.77m },
                    { 152, 38, 145, 2, 70.22m, 35.11m },
                    { 153, 38, 145, 2, 64.44m, 32.22m },
                    { 154, 38, 62, 2, 60.98m, 30.49m },
                    { 155, 39, 162, 1, 17.05m, 17.05m },
                    { 156, 39, 197, 2, 67.54m, 33.77m },
                    { 157, 39, 192, 3, 39.66m, 13.22m },
                    { 158, 40, 167, 1, 32.73m, 32.73m },
                    { 159, 40, 104, 1, 21.14m, 21.14m },
                    { 160, 40, 155, 3, 124.41m, 41.47m },
                    { 161, 40, 98, 1, 15.99m, 15.99m },
                    { 162, 40, 107, 1, 22.83m, 22.83m },
                    { 163, 40, 66, 2, 53.32m, 26.66m },
                    { 164, 41, 111, 1, 28.67m, 28.67m },
                    { 165, 41, 154, 2, 73.78m, 36.89m },
                    { 166, 41, 155, 3, 82.17m, 27.39m },
                    { 167, 41, 94, 3, 103.26m, 34.42m },
                    { 168, 42, 7, 1, 30.58m, 30.58m },
                    { 169, 42, 100, 2, 63.56m, 31.78m },
                    { 170, 42, 85, 3, 133.17m, 44.39m },
                    { 171, 42, 126, 1, 39.17m, 39.17m },
                    { 172, 42, 84, 3, 137.82m, 45.94m },
                    { 173, 42, 137, 1, 17.91m, 17.91m },
                    { 174, 43, 143, 2, 69.20m, 34.60m },
                    { 175, 43, 14, 1, 34.41m, 34.41m },
                    { 176, 43, 103, 2, 48.18m, 24.09m },
                    { 177, 43, 121, 1, 41.99m, 41.99m },
                    { 178, 43, 48, 2, 90.78m, 45.39m },
                    { 179, 43, 88, 1, 32.94m, 32.94m },
                    { 180, 44, 10, 3, 127.44m, 42.48m },
                    { 181, 44, 26, 1, 44.66m, 44.66m },
                    { 182, 44, 176, 3, 59.55m, 19.85m },
                    { 183, 44, 80, 2, 63.92m, 31.96m },
                    { 184, 45, 23, 3, 87.24m, 29.08m },
                    { 185, 45, 163, 3, 56.85m, 18.95m },
                    { 186, 45, 90, 2, 55.04m, 27.52m },
                    { 187, 45, 102, 2, 76.72m, 38.36m },
                    { 188, 45, 135, 1, 26.56m, 26.56m },
                    { 189, 46, 78, 2, 52.86m, 26.43m },
                    { 190, 46, 146, 1, 28.14m, 28.14m },
                    { 191, 46, 168, 3, 61.29m, 20.43m },
                    { 192, 47, 7, 3, 39.42m, 13.14m },
                    { 193, 47, 48, 3, 115.59m, 38.53m },
                    { 194, 47, 136, 2, 48.28m, 24.14m },
                    { 195, 47, 74, 1, 27.49m, 27.49m },
                    { 196, 47, 146, 2, 38.80m, 19.40m },
                    { 197, 47, 77, 3, 42.27m, 14.09m },
                    { 198, 48, 18, 2, 75.62m, 37.81m },
                    { 199, 48, 123, 3, 66.27m, 22.09m },
                    { 200, 48, 140, 2, 103.04m, 51.52m },
                    { 201, 48, 81, 3, 71.19m, 23.73m },
                    { 202, 48, 60, 3, 62.16m, 20.72m },
                    { 203, 49, 73, 1, 14.65m, 14.65m },
                    { 204, 49, 23, 2, 94.06m, 47.03m },
                    { 205, 49, 87, 1, 42.75m, 42.75m },
                    { 206, 49, 113, 1, 19.12m, 19.12m },
                    { 207, 50, 14, 3, 51.12m, 17.04m },
                    { 208, 50, 135, 3, 92.91m, 30.97m },
                    { 209, 50, 65, 2, 101.34m, 50.67m },
                    { 210, 50, 17, 1, 47.37m, 47.37m },
                    { 211, 50, 59, 3, 100.26m, 33.42m },
                    { 212, 50, 154, 2, 22.80m, 11.40m },
                    { 213, 51, 53, 1, 22.76m, 22.76m },
                    { 214, 51, 169, 2, 21.20m, 10.60m },
                    { 215, 51, 67, 2, 65.82m, 32.91m },
                    { 216, 51, 132, 3, 83.43m, 27.81m },
                    { 217, 51, 68, 3, 52.92m, 17.64m },
                    { 218, 52, 70, 1, 42.39m, 42.39m },
                    { 219, 52, 54, 2, 81.40m, 40.70m },
                    { 220, 52, 40, 2, 76.82m, 38.41m },
                    { 221, 52, 200, 2, 53.40m, 26.70m },
                    { 222, 52, 181, 2, 102.12m, 51.06m },
                    { 223, 53, 150, 2, 56.92m, 28.46m },
                    { 224, 53, 128, 1, 20.61m, 20.61m },
                    { 225, 53, 87, 3, 143.28m, 47.76m },
                    { 226, 53, 193, 3, 143.67m, 47.89m },
                    { 227, 54, 116, 1, 24.90m, 24.90m },
                    { 228, 54, 28, 1, 41.49m, 41.49m },
                    { 229, 55, 57, 3, 91.41m, 30.47m },
                    { 230, 55, 62, 1, 11.29m, 11.29m },
                    { 231, 55, 121, 3, 59.79m, 19.93m },
                    { 232, 55, 126, 2, 70.18m, 35.09m },
                    { 233, 55, 153, 3, 109.95m, 36.65m },
                    { 234, 56, 99, 2, 83.66m, 41.83m },
                    { 235, 56, 181, 3, 108.51m, 36.17m },
                    { 236, 57, 63, 2, 37.70m, 18.85m },
                    { 237, 57, 151, 1, 22.00m, 22.00m },
                    { 238, 57, 81, 3, 82.20m, 27.40m },
                    { 239, 57, 63, 1, 21.45m, 21.45m },
                    { 240, 57, 190, 3, 131.40m, 43.80m },
                    { 241, 58, 44, 1, 50.97m, 50.97m },
                    { 242, 58, 159, 2, 87.28m, 43.64m },
                    { 243, 58, 82, 2, 60.26m, 30.13m },
                    { 244, 59, 118, 2, 52.34m, 26.17m },
                    { 245, 59, 128, 1, 41.10m, 41.10m },
                    { 246, 59, 91, 3, 125.67m, 41.89m },
                    { 247, 59, 36, 2, 52.76m, 26.38m },
                    { 248, 59, 191, 3, 139.08m, 46.36m },
                    { 249, 59, 47, 1, 28.12m, 28.12m },
                    { 250, 60, 193, 3, 73.08m, 24.36m },
                    { 251, 60, 200, 2, 88.56m, 44.28m },
                    { 252, 60, 65, 2, 68.98m, 34.49m },
                    { 253, 61, 36, 2, 35.84m, 17.92m },
                    { 254, 61, 154, 1, 15.08m, 15.08m },
                    { 255, 61, 123, 3, 72.75m, 24.25m },
                    { 256, 62, 105, 3, 108.18m, 36.06m },
                    { 257, 62, 98, 1, 18.29m, 18.29m },
                    { 258, 62, 136, 2, 45.46m, 22.73m },
                    { 259, 62, 91, 2, 89.22m, 44.61m },
                    { 260, 63, 198, 3, 123.57m, 41.19m },
                    { 261, 63, 147, 1, 41.95m, 41.95m },
                    { 262, 63, 67, 1, 45.79m, 45.79m },
                    { 263, 63, 71, 3, 45.33m, 15.11m },
                    { 264, 63, 110, 3, 61.53m, 20.51m },
                    { 265, 63, 114, 3, 88.95m, 29.65m },
                    { 266, 64, 101, 1, 41.18m, 41.18m },
                    { 267, 64, 63, 2, 34.94m, 17.47m },
                    { 268, 65, 197, 2, 98.86m, 49.43m },
                    { 269, 65, 158, 2, 80.22m, 40.11m },
                    { 270, 65, 32, 3, 55.50m, 18.50m },
                    { 271, 65, 65, 2, 43.26m, 21.63m },
                    { 272, 65, 182, 3, 114.30m, 38.10m },
                    { 273, 66, 3, 1, 38.06m, 38.06m },
                    { 274, 66, 47, 1, 46.76m, 46.76m },
                    { 275, 66, 4, 3, 105.96m, 35.32m },
                    { 276, 67, 179, 2, 81.86m, 40.93m },
                    { 277, 67, 9, 3, 118.26m, 39.42m },
                    { 278, 67, 164, 3, 136.92m, 45.64m },
                    { 279, 67, 36, 2, 69.12m, 34.56m },
                    { 280, 68, 177, 2, 53.52m, 26.76m },
                    { 281, 68, 195, 1, 18.37m, 18.37m },
                    { 282, 68, 112, 1, 48.35m, 48.35m },
                    { 283, 68, 28, 1, 30.17m, 30.17m },
                    { 284, 69, 131, 2, 24.66m, 12.33m },
                    { 285, 69, 141, 3, 146.64m, 48.88m },
                    { 286, 69, 39, 2, 92.84m, 46.42m },
                    { 287, 69, 11, 3, 57.63m, 19.21m },
                    { 288, 69, 123, 3, 47.85m, 15.95m },
                    { 289, 70, 185, 2, 59.12m, 29.56m },
                    { 290, 70, 97, 3, 138.21m, 46.07m },
                    { 291, 71, 153, 1, 37.56m, 37.56m },
                    { 292, 71, 176, 1, 16.92m, 16.92m },
                    { 293, 71, 37, 3, 95.64m, 31.88m },
                    { 294, 71, 156, 3, 80.88m, 26.96m },
                    { 295, 71, 101, 2, 72.30m, 36.15m },
                    { 296, 72, 49, 2, 65.74m, 32.87m },
                    { 297, 72, 146, 1, 37.77m, 37.77m },
                    { 298, 72, 44, 3, 29.43m, 9.81m },
                    { 299, 72, 103, 3, 92.85m, 30.95m },
                    { 300, 73, 170, 1, 46.98m, 46.98m },
                    { 301, 73, 126, 1, 14.11m, 14.11m },
                    { 302, 73, 30, 3, 28.80m, 9.60m },
                    { 303, 73, 196, 2, 33.84m, 16.92m },
                    { 304, 73, 31, 2, 80.50m, 40.25m },
                    { 305, 74, 30, 3, 102.45m, 34.15m },
                    { 306, 74, 193, 3, 87.18m, 29.06m },
                    { 307, 74, 53, 1, 43.01m, 43.01m },
                    { 308, 74, 180, 2, 57.24m, 28.62m },
                    { 309, 74, 31, 2, 32.90m, 16.45m },
                    { 310, 74, 20, 2, 50.04m, 25.02m },
                    { 311, 75, 49, 2, 95.78m, 47.89m },
                    { 312, 75, 72, 1, 45.70m, 45.70m },
                    { 313, 75, 155, 3, 54.30m, 18.10m }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 1, "Product variant 1 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9190), "variant_1_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9201), 1 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 2, "Product variant 1 mockup view 2", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9220), "variant_1_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9221), 1 },
                    { 3, "Product variant 1 mockup view 3", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9230), "variant_1_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9232), 1 },
                    { 4, "Product variant 1 mockup view 4", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9240), "variant_1_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9241), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 5, "Product variant 2 mockup view 1", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9250), "variant_2_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9251), 2 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 6, "Product variant 2 mockup view 2", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9262), "variant_2_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9263), 2 },
                    { 7, "Product variant 2 mockup view 3", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9271), "variant_2_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9273), 2 },
                    { 8, "Product variant 2 mockup view 4", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9282), "variant_2_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9283), 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 9, "Product variant 3 mockup view 1", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9292), "variant_3_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9294), 3 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 10, "Product variant 3 mockup view 2", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9303), "variant_3_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9304), 3 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 13, "Product variant 4 mockup view 1", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9313), "variant_4_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9315), 4 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 14, "Product variant 4 mockup view 2", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9322), "variant_4_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9324), 4 },
                    { 15, "Product variant 4 mockup view 3", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9332), "variant_4_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9333), 4 },
                    { 16, "Product variant 4 mockup view 4", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9340), "variant_4_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9342), 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 17, "Product variant 5 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9350), "variant_5_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9351), 5 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 18, "Product variant 5 mockup view 2", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9359), "variant_5_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9360), 5 },
                    { 19, "Product variant 5 mockup view 3", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9368), "variant_5_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9370), 5 },
                    { 20, "Product variant 5 mockup view 4", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9379), "variant_5_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9381), 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 21, "Product variant 6 mockup view 1", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9389), "variant_6_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9391), 6 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 22, "Product variant 6 mockup view 2", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9398), "variant_6_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9400), 6 },
                    { 23, "Product variant 6 mockup view 3", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9408), "variant_6_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9409), 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 25, "Product variant 7 mockup view 1", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9519), "variant_7_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9521), 7 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 26, "Product variant 7 mockup view 2", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9532), "variant_7_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9534), 7 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 29, "Product variant 8 mockup view 1", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9544), "variant_8_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9546), 8 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 30, "Product variant 8 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9556), "variant_8_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9557), 8 },
                    { 31, "Product variant 8 mockup view 3", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9564), "variant_8_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9566), 8 },
                    { 32, "Product variant 8 mockup view 4", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9573), "variant_8_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9575), 8 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 33, "Product variant 9 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9583), "variant_9_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9584), 9 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 34, "Product variant 9 mockup view 2", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9592), "variant_9_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9593), 9 },
                    { 35, "Product variant 9 mockup view 3", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9601), "variant_9_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9602), 9 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 37, "Product variant 10 mockup view 1", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9615), "variant_10_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9616), 10 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 38, "Product variant 10 mockup view 2", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9625), "variant_10_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9626), 10 },
                    { 39, "Product variant 10 mockup view 3", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9634), "variant_10_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9636), 10 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 41, "Product variant 11 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9648), "variant_11_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9650), 11 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 42, "Product variant 11 mockup view 2", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9658), "variant_11_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9659), 11 },
                    { 43, "Product variant 11 mockup view 3", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9668), "variant_11_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9670), 11 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 45, "Product variant 12 mockup view 1", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9679), "variant_12_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9680), 12 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 46, "Product variant 12 mockup view 2", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9688), "variant_12_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9689), 12 },
                    { 47, "Product variant 12 mockup view 3", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9697), "variant_12_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9698), 12 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 49, "Product variant 13 mockup view 1", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9706), "variant_13_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9708), 13 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 50, "Product variant 13 mockup view 2", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9716), "variant_13_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9717), 13 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 53, "Product variant 14 mockup view 1", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9726), "variant_14_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9728), 14 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 54, "Product variant 14 mockup view 2", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9735), "variant_14_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9737), 14 },
                    { 55, "Product variant 14 mockup view 3", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9846), "variant_14_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9848), 14 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 57, "Product variant 15 mockup view 1", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9858), "variant_15_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9859), 15 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 58, "Product variant 15 mockup view 2", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9867), "variant_15_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9868), 15 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 61, "Product variant 16 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9877), "variant_16_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9878), 16 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 62, "Product variant 16 mockup view 2", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9886), "variant_16_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9887), 16 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 65, "Product variant 17 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9896), "variant_17_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9897), 17 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 66, "Product variant 17 mockup view 2", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9905), "variant_17_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9906), 17 },
                    { 67, "Product variant 17 mockup view 3", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9915), "variant_17_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9917), 17 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 69, "Product variant 18 mockup view 1", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9924), "variant_18_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9926), 18 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 70, "Product variant 18 mockup view 2", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9933), "variant_18_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9934), 18 },
                    { 71, "Product variant 18 mockup view 3", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9942), "variant_18_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9943), 18 },
                    { 72, "Product variant 18 mockup view 4", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9951), "variant_18_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9952), 18 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 73, "Product variant 19 mockup view 1", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9960), "variant_19_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9962), 19 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 74, "Product variant 19 mockup view 2", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9970), "variant_19_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9971), 19 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 77, "Product variant 20 mockup view 1", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9979), "variant_20_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9980), 20 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 78, "Product variant 20 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9989), "variant_20_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9990), 20 },
                    { 79, "Product variant 20 mockup view 3", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9998), "variant_20_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 943, DateTimeKind.Utc).AddTicks(9999), 20 },
                    { 80, "Product variant 20 mockup view 4", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7), "variant_20_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8), 20 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 81, "Product variant 21 mockup view 1", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(16), "variant_21_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(18), 21 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 82, "Product variant 21 mockup view 2", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(26), "variant_21_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(27), 21 },
                    { 83, "Product variant 21 mockup view 3", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(39), "variant_21_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(40), 21 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 85, "Product variant 22 mockup view 1", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(49), "variant_22_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(50), 22 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 86, "Product variant 22 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(373), "variant_22_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(375), 22 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 89, "Product variant 23 mockup view 1", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(384), "variant_23_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(386), 23 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 90, "Product variant 23 mockup view 2", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(394), "variant_23_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(396), 23 },
                    { 91, "Product variant 23 mockup view 3", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(404), "variant_23_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(405), 23 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 93, "Product variant 24 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(414), "variant_24_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(415), 24 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 94, "Product variant 24 mockup view 2", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(424), "variant_24_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(426), 24 },
                    { 95, "Product variant 24 mockup view 3", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(434), "variant_24_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(435), 24 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 97, "Product variant 25 mockup view 1", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(443), "variant_25_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(445), 25 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 98, "Product variant 25 mockup view 2", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(453), "variant_25_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(454), 25 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 101, "Product variant 26 mockup view 1", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(463), "variant_26_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(464), 26 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 102, "Product variant 26 mockup view 2", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(472), "variant_26_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(473), 26 },
                    { 103, "Product variant 26 mockup view 3", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(481), "variant_26_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(482), 26 },
                    { 104, "Product variant 26 mockup view 4", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(490), "variant_26_mockup_4.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(491), 26 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 105, "Product variant 27 mockup view 1", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(499), "variant_27_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(501), 27 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 106, "Product variant 27 mockup view 2", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(508), "variant_27_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(510), 27 },
                    { 107, "Product variant 27 mockup view 3", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(517), "variant_27_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(519), 27 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 109, "Product variant 28 mockup view 1", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(527), "variant_28_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(528), 28 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 110, "Product variant 28 mockup view 2", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(536), "variant_28_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(537), 28 },
                    { 111, "Product variant 28 mockup view 3", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(545), "variant_28_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(546), 28 },
                    { 112, "Product variant 28 mockup view 4", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(554), "variant_28_mockup_4.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(555), 28 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 113, "Product variant 29 mockup view 1", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(563), "variant_29_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(565), 29 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 114, "Product variant 29 mockup view 2", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(573), "variant_29_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(574), 29 },
                    { 115, "Product variant 29 mockup view 3", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(692), "variant_29_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(694), 29 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 117, "Product variant 30 mockup view 1", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(704), "variant_30_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(705), 30 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 118, "Product variant 30 mockup view 2", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(712), "variant_30_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(714), 30 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 121, "Product variant 31 mockup view 1", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(722), "variant_31_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(723), 31 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 122, "Product variant 31 mockup view 2", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(731), "variant_31_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(732), 31 },
                    { 123, "Product variant 31 mockup view 3", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(740), "variant_31_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(742), 31 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 125, "Product variant 32 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(750), "variant_32_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(752), 32 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 126, "Product variant 32 mockup view 2", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(760), "variant_32_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(761), 32 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 129, "Product variant 33 mockup view 1", "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(770), "variant_33_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(771), 33 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 130, "Product variant 33 mockup view 2", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(780), "variant_33_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(781), 33 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 133, "Product variant 34 mockup view 1", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(789), "variant_34_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(791), 34 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 134, "Product variant 34 mockup view 2", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(798), "variant_34_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(800), 34 },
                    { 135, "Product variant 34 mockup view 3", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(808), "variant_34_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(809), 34 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 137, "Product variant 35 mockup view 1", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(817), "variant_35_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(818), 35 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 138, "Product variant 35 mockup view 2", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(826), "variant_35_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(827), 35 },
                    { 139, "Product variant 35 mockup view 3", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(835), "variant_35_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(837), 35 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 141, "Product variant 36 mockup view 1", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(845), "variant_36_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(846), 36 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 142, "Product variant 36 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(854), "variant_36_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(855), 36 },
                    { 143, "Product variant 36 mockup view 3", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(863), "variant_36_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(865), 36 },
                    { 144, "Product variant 36 mockup view 4", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(872), "variant_36_mockup_4.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(874), 36 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 145, "Product variant 37 mockup view 1", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(882), "variant_37_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(883), 37 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 146, "Product variant 37 mockup view 2", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(892), "variant_37_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(894), 37 },
                    { 147, "Product variant 37 mockup view 3", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(902), "variant_37_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(904), 37 },
                    { 148, "Product variant 37 mockup view 4", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1020), "variant_37_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1022), 37 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 149, "Product variant 38 mockup view 1", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1033), "variant_38_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1034), 38 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 150, "Product variant 38 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1042), "variant_38_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1044), 38 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 153, "Product variant 39 mockup view 1", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1052), "variant_39_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1053), 39 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 154, "Product variant 39 mockup view 2", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1061), "variant_39_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1062), 39 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 157, "Product variant 40 mockup view 1", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1071), "variant_40_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1072), 40 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 158, "Product variant 40 mockup view 2", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1079), "variant_40_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1081), 40 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 161, "Product variant 41 mockup view 1", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1090), "variant_41_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1092), 41 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 162, "Product variant 41 mockup view 2", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1099), "variant_41_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1100), 41 },
                    { 163, "Product variant 41 mockup view 3", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1108), "variant_41_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1110), 41 },
                    { 164, "Product variant 41 mockup view 4", "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1118), "variant_41_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1119), 41 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 165, "Product variant 42 mockup view 1", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1128), "variant_42_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1129), 42 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 166, "Product variant 42 mockup view 2", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1137), "variant_42_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1139), 42 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 169, "Product variant 43 mockup view 1", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1147), "variant_43_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1148), 43 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 170, "Product variant 43 mockup view 2", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1156), "variant_43_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1158), 43 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 173, "Product variant 44 mockup view 1", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1168), "variant_44_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1169), 44 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 174, "Product variant 44 mockup view 2", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1177), "variant_44_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1178), 44 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 177, "Product variant 45 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1188), "variant_45_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1190), 45 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 178, "Product variant 45 mockup view 2", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1197), "variant_45_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1199), 45 },
                    { 179, "Product variant 45 mockup view 3", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1273), "variant_45_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1275), 45 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 181, "Product variant 46 mockup view 1", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1283), "variant_46_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1285), 46 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 182, "Product variant 46 mockup view 2", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1293), "variant_46_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1294), 46 },
                    { 183, "Product variant 46 mockup view 3", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1301), "variant_46_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1303), 46 },
                    { 184, "Product variant 46 mockup view 4", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1311), "variant_46_mockup_4.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1312), 46 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 185, "Product variant 47 mockup view 1", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1320), "variant_47_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1322), 47 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 186, "Product variant 47 mockup view 2", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1329), "variant_47_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1331), 47 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 189, "Product variant 48 mockup view 1", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1339), "variant_48_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1341), 48 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 190, "Product variant 48 mockup view 2", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1348), "variant_48_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1350), 48 },
                    { 191, "Product variant 48 mockup view 3", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1357), "variant_48_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1359), 48 },
                    { 192, "Product variant 48 mockup view 4", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1367), "variant_48_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1369), 48 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 193, "Product variant 49 mockup view 1", "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1377), "variant_49_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1378), 49 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 194, "Product variant 49 mockup view 2", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1386), "variant_49_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1387), 49 },
                    { 195, "Product variant 49 mockup view 3", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1395), "variant_49_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1396), 49 },
                    { 196, "Product variant 49 mockup view 4", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1404), "variant_49_mockup_4.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1406), 49 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 197, "Product variant 50 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1415), "variant_50_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1416), 50 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 198, "Product variant 50 mockup view 2", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1424), "variant_50_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1425), 50 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 201, "Product variant 51 mockup view 1", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1434), "variant_51_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1435), 51 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 202, "Product variant 51 mockup view 2", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1443), "variant_51_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1444), 51 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 205, "Product variant 52 mockup view 1", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1452), "variant_52_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1454), 52 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 206, "Product variant 52 mockup view 2", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1461), "variant_52_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1463), 52 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 209, "Product variant 53 mockup view 1", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1616), "variant_53_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1618), 53 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 210, "Product variant 53 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1628), "variant_53_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1629), 53 },
                    { 211, "Product variant 53 mockup view 3", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1638), "variant_53_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1639), 53 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 213, "Product variant 54 mockup view 1", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1648), "variant_54_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1650), 54 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 214, "Product variant 54 mockup view 2", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1658), "variant_54_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1660), 54 },
                    { 215, "Product variant 54 mockup view 3", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1667), "variant_54_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1669), 54 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 217, "Product variant 55 mockup view 1", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1678), "variant_55_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1679), 55 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 218, "Product variant 55 mockup view 2", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1688), "variant_55_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1690), 55 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 221, "Product variant 56 mockup view 1", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1698), "variant_56_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1699), 56 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 222, "Product variant 56 mockup view 2", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1707), "variant_56_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1708), 56 },
                    { 223, "Product variant 56 mockup view 3", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1716), "variant_56_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1717), 56 },
                    { 224, "Product variant 56 mockup view 4", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1725), "variant_56_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1726), 56 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 225, "Product variant 57 mockup view 1", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1735), "variant_57_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1736), 57 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 226, "Product variant 57 mockup view 2", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1744), "variant_57_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1746), 57 },
                    { 227, "Product variant 57 mockup view 3", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1754), "variant_57_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1755), 57 },
                    { 228, "Product variant 57 mockup view 4", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1763), "variant_57_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1764), 57 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 229, "Product variant 58 mockup view 1", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1772), "variant_58_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1774), 58 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 230, "Product variant 58 mockup view 2", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1781), "variant_58_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1783), 58 },
                    { 231, "Product variant 58 mockup view 3", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1791), "variant_58_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1792), 58 },
                    { 232, "Product variant 58 mockup view 4", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1801), "variant_58_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1802), 58 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 233, "Product variant 59 mockup view 1", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1811), "variant_59_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1813), 59 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 234, "Product variant 59 mockup view 2", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1820), "variant_59_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1822), 59 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 237, "Product variant 60 mockup view 1", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1830), "variant_60_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1832), 60 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 238, "Product variant 60 mockup view 2", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1974), "variant_60_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1976), 60 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 241, "Product variant 61 mockup view 1", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1987), "variant_61_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1988), 61 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 242, "Product variant 61 mockup view 2", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1996), "variant_61_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(1998), 61 },
                    { 243, "Product variant 61 mockup view 3", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2005), "variant_61_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2007), 61 },
                    { 244, "Product variant 61 mockup view 4", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2017), "variant_61_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2018), 61 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 245, "Product variant 62 mockup view 1", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2027), "variant_62_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2029), 62 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 246, "Product variant 62 mockup view 2", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2036), "variant_62_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2038), 62 },
                    { 247, "Product variant 62 mockup view 3", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2046), "variant_62_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2048), 62 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 249, "Product variant 63 mockup view 1", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2056), "variant_63_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2057), 63 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 250, "Product variant 63 mockup view 2", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2065), "variant_63_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2066), 63 },
                    { 251, "Product variant 63 mockup view 3", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2075), "variant_63_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2076), 63 },
                    { 252, "Product variant 63 mockup view 4", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2084), "variant_63_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2085), 63 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 253, "Product variant 64 mockup view 1", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2094), "variant_64_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2095), 64 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 254, "Product variant 64 mockup view 2", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2103), "variant_64_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2105), 64 },
                    { 255, "Product variant 64 mockup view 3", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2112), "variant_64_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2114), 64 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 257, "Product variant 65 mockup view 1", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2123), "variant_65_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2124), 65 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 258, "Product variant 65 mockup view 2", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2132), "variant_65_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2134), 65 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 261, "Product variant 66 mockup view 1", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2142), "variant_66_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2144), 66 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 262, "Product variant 66 mockup view 2", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2152), "variant_66_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2154), 66 },
                    { 263, "Product variant 66 mockup view 3", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2162), "variant_66_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2163), 66 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 265, "Product variant 67 mockup view 1", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2171), "variant_67_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2173), 67 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 266, "Product variant 67 mockup view 2", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2181), "variant_67_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2182), 67 },
                    { 267, "Product variant 67 mockup view 3", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2190), "variant_67_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2192), 67 },
                    { 268, "Product variant 67 mockup view 4", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2200), "variant_67_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2201), 67 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 269, "Product variant 68 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2309), "variant_68_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2311), 68 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 270, "Product variant 68 mockup view 2", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2319), "variant_68_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2320), 68 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 273, "Product variant 69 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2329), "variant_69_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2330), 69 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 274, "Product variant 69 mockup view 2", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2338), "variant_69_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2340), 69 },
                    { 275, "Product variant 69 mockup view 3", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2347), "variant_69_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2349), 69 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 277, "Product variant 70 mockup view 1", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2357), "variant_70_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2358), 70 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 278, "Product variant 70 mockup view 2", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2366), "variant_70_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2368), 70 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 281, "Product variant 71 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2376), "variant_71_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2378), 71 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 282, "Product variant 71 mockup view 2", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2386), "variant_71_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2387), 71 },
                    { 283, "Product variant 71 mockup view 3", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2396), "variant_71_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2397), 71 },
                    { 284, "Product variant 71 mockup view 4", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2405), "variant_71_mockup_4.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2407), 71 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 285, "Product variant 72 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2415), "variant_72_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2417), 72 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 286, "Product variant 72 mockup view 2", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2424), "variant_72_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2426), 72 },
                    { 287, "Product variant 72 mockup view 3", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2434), "variant_72_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2435), 72 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 289, "Product variant 73 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2444), "variant_73_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2445), 73 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 290, "Product variant 73 mockup view 2", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2453), "variant_73_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2454), 73 },
                    { 291, "Product variant 73 mockup view 3", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2462), "variant_73_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2463), 73 },
                    { 292, "Product variant 73 mockup view 4", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2471), "variant_73_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2473), 73 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 293, "Product variant 74 mockup view 1", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2481), "variant_74_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2482), 74 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 294, "Product variant 74 mockup view 2", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2490), "variant_74_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2492), 74 },
                    { 295, "Product variant 74 mockup view 3", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2499), "variant_74_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2501), 74 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 297, "Product variant 75 mockup view 1", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2511), "variant_75_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2512), 75 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 298, "Product variant 75 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2520), "variant_75_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2521), 75 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 301, "Product variant 76 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2632), "variant_76_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2634), 76 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 302, "Product variant 76 mockup view 2", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2643), "variant_76_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2644), 76 },
                    { 303, "Product variant 76 mockup view 3", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2653), "variant_76_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2654), 76 },
                    { 304, "Product variant 76 mockup view 4", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2663), "variant_76_mockup_4.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2664), 76 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 305, "Product variant 77 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2673), "variant_77_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2674), 77 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 306, "Product variant 77 mockup view 2", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2681), "variant_77_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2683), 77 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 309, "Product variant 78 mockup view 1", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2691), "variant_78_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2693), 78 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 310, "Product variant 78 mockup view 2", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2700), "variant_78_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2702), 78 },
                    { 311, "Product variant 78 mockup view 3", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2710), "variant_78_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2711), 78 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 313, "Product variant 79 mockup view 1", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2719), "variant_79_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2721), 79 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 314, "Product variant 79 mockup view 2", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2728), "variant_79_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2730), 79 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 317, "Product variant 80 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2738), "variant_80_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2739), 80 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 318, "Product variant 80 mockup view 2", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2747), "variant_80_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2748), 80 },
                    { 319, "Product variant 80 mockup view 3", "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2756), "variant_80_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2758), 80 },
                    { 320, "Product variant 80 mockup view 4", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2767), "variant_80_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2768), 80 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 321, "Product variant 81 mockup view 1", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2776), "variant_81_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2778), 81 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 322, "Product variant 81 mockup view 2", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2786), "variant_81_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2788), 81 },
                    { 323, "Product variant 81 mockup view 3", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2795), "variant_81_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2797), 81 },
                    { 324, "Product variant 81 mockup view 4", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2805), "variant_81_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2806), 81 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 325, "Product variant 82 mockup view 1", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2815), "variant_82_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2817), 82 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 326, "Product variant 82 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2825), "variant_82_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2826), 82 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 329, "Product variant 83 mockup view 1", "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2835), "variant_83_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2836), 83 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 330, "Product variant 83 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2844), "variant_83_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2846), 83 },
                    { 331, "Product variant 83 mockup view 3", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2951), "variant_83_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2952), 83 },
                    { 332, "Product variant 83 mockup view 4", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2961), "variant_83_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2963), 83 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 333, "Product variant 84 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2971), "variant_84_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2972), 84 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 334, "Product variant 84 mockup view 2", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2980), "variant_84_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2982), 84 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 337, "Product variant 85 mockup view 1", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2990), "variant_85_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(2991), 85 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 338, "Product variant 85 mockup view 2", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3000), "variant_85_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3001), 85 },
                    { 339, "Product variant 85 mockup view 3", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3009), "variant_85_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3010), 85 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 341, "Product variant 86 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3018), "variant_86_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3020), 86 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 342, "Product variant 86 mockup view 2", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3027), "variant_86_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3029), 86 },
                    { 343, "Product variant 86 mockup view 3", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3037), "variant_86_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3038), 86 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 345, "Product variant 87 mockup view 1", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3046), "variant_87_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3048), 87 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 346, "Product variant 87 mockup view 2", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3056), "variant_87_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3057), 87 },
                    { 347, "Product variant 87 mockup view 3", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3065), "variant_87_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3067), 87 },
                    { 348, "Product variant 87 mockup view 4", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3074), "variant_87_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3076), 87 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 349, "Product variant 88 mockup view 1", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3199), "variant_88_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3201), 88 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 350, "Product variant 88 mockup view 2", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3209), "variant_88_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3211), 88 },
                    { 351, "Product variant 88 mockup view 3", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3219), "variant_88_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3220), 88 },
                    { 352, "Product variant 88 mockup view 4", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3230), "variant_88_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3231), 88 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 353, "Product variant 89 mockup view 1", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3239), "variant_89_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3241), 89 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 354, "Product variant 89 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3249), "variant_89_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3250), 89 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 357, "Product variant 90 mockup view 1", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3259), "variant_90_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3261), 90 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 358, "Product variant 90 mockup view 2", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3268), "variant_90_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3270), 90 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 361, "Product variant 91 mockup view 1", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3278), "variant_91_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3279), 91 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 362, "Product variant 91 mockup view 2", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3288), "variant_91_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3289), 91 },
                    { 363, "Product variant 91 mockup view 3", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3298), "variant_91_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3299), 91 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 365, "Product variant 92 mockup view 1", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3309), "variant_92_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3310), 92 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 366, "Product variant 92 mockup view 2", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3318), "variant_92_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3320), 92 },
                    { 367, "Product variant 92 mockup view 3", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3327), "variant_92_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3329), 92 },
                    { 368, "Product variant 92 mockup view 4", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3336), "variant_92_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3337), 92 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 369, "Product variant 93 mockup view 1", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3345), "variant_93_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3347), 93 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 370, "Product variant 93 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3354), "variant_93_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3356), 93 },
                    { 371, "Product variant 93 mockup view 3", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3364), "variant_93_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3365), 93 },
                    { 372, "Product variant 93 mockup view 4", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3373), "variant_93_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3374), 93 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 373, "Product variant 94 mockup view 1", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3383), "variant_94_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3384), 94 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 374, "Product variant 94 mockup view 2", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3392), "variant_94_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3393), 94 },
                    { 375, "Product variant 94 mockup view 3", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3567), "variant_94_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3569), 94 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 377, "Product variant 95 mockup view 1", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3582), "variant_95_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3583), 95 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 378, "Product variant 95 mockup view 2", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3592), "variant_95_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3593), 95 },
                    { 379, "Product variant 95 mockup view 3", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3601), "variant_95_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3602), 95 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 381, "Product variant 96 mockup view 1", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3611), "variant_96_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3612), 96 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 382, "Product variant 96 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3620), "variant_96_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3622), 96 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 385, "Product variant 97 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3631), "variant_97_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3632), 97 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 386, "Product variant 97 mockup view 2", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3640), "variant_97_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3641), 97 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 389, "Product variant 98 mockup view 1", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3649), "variant_98_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3650), 98 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 390, "Product variant 98 mockup view 2", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3658), "variant_98_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3660), 98 },
                    { 391, "Product variant 98 mockup view 3", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3667), "variant_98_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3669), 98 },
                    { 392, "Product variant 98 mockup view 4", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3677), "variant_98_mockup_4.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3679), 98 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 393, "Product variant 99 mockup view 1", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3687), "variant_99_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3688), 99 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 394, "Product variant 99 mockup view 2", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3696), "variant_99_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3698), 99 },
                    { 395, "Product variant 99 mockup view 3", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3705), "variant_99_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3706), 99 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 397, "Product variant 100 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3715), "variant_100_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3716), 100 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 398, "Product variant 100 mockup view 2", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3725), "variant_100_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3726), 100 },
                    { 399, "Product variant 100 mockup view 3", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3735), "variant_100_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3736), 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 401, "Product variant 101 mockup view 1", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3745), "variant_101_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3746), 101 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 402, "Product variant 101 mockup view 2", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3754), "variant_101_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3755), 101 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 405, "Product variant 102 mockup view 1", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3764), "variant_102_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3765), 102 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 406, "Product variant 102 mockup view 2", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3774), "variant_102_mockup_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3775), 102 },
                    { 407, "Product variant 102 mockup view 3", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3783), "variant_102_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3784), 102 },
                    { 408, "Product variant 102 mockup view 4", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3806), "variant_102_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3808), 102 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 409, "Product variant 103 mockup view 1", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3817), "variant_103_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3818), 103 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 410, "Product variant 103 mockup view 2", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3828), "variant_103_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3829), 103 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 413, "Product variant 104 mockup view 1", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3839), "variant_104_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3841), 104 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 414, "Product variant 104 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3850), "variant_104_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3852), 104 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 417, "Product variant 105 mockup view 1", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3860), "variant_105_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3862), 105 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 418, "Product variant 105 mockup view 2", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3869), "variant_105_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3871), 105 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 421, "Product variant 106 mockup view 1", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3878), "variant_106_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3880), 106 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 422, "Product variant 106 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3888), "variant_106_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3889), 106 },
                    { 423, "Product variant 106 mockup view 3", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3897), "variant_106_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3899), 106 },
                    { 424, "Product variant 106 mockup view 4", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3907), "variant_106_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(3908), 106 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 425, "Product variant 107 mockup view 1", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4219), "variant_107_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4221), 107 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 426, "Product variant 107 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4232), "variant_107_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4233), 107 },
                    { 427, "Product variant 107 mockup view 3", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4242), "variant_107_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4244), 107 },
                    { 428, "Product variant 107 mockup view 4", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4252), "variant_107_mockup_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4253), 107 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 429, "Product variant 108 mockup view 1", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4263), "variant_108_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4264), 108 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 430, "Product variant 108 mockup view 2", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4272), "variant_108_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4273), 108 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 433, "Product variant 109 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4281), "variant_109_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4283), 109 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 434, "Product variant 109 mockup view 2", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4291), "variant_109_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4292), 109 },
                    { 435, "Product variant 109 mockup view 3", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4300), "variant_109_mockup_3.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4301), 109 },
                    { 436, "Product variant 109 mockup view 4", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4308), "variant_109_mockup_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4310), 109 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 437, "Product variant 110 mockup view 1", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4317), "variant_110_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4319), 110 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 438, "Product variant 110 mockup view 2", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4326), "variant_110_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4328), 110 },
                    { 439, "Product variant 110 mockup view 3", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4504), "variant_110_mockup_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4506), 110 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 441, "Product variant 111 mockup view 1", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4517), "variant_111_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4518), 111 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 442, "Product variant 111 mockup view 2", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4526), "variant_111_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4527), 111 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 445, "Product variant 112 mockup view 1", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4536), "variant_112_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4537), 112 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 446, "Product variant 112 mockup view 2", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4547), "variant_112_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4548), 112 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 449, "Product variant 113 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4557), "variant_113_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4558), 113 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 450, "Product variant 113 mockup view 2", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4567), "variant_113_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4568), 113 },
                    { 451, "Product variant 113 mockup view 3", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4580), "variant_113_mockup_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4581), 113 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 453, "Product variant 114 mockup view 1", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4590), "variant_114_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4592), 114 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 454, "Product variant 114 mockup view 2", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4599), "variant_114_mockup_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4601), 114 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 457, "Product variant 115 mockup view 1", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4609), "variant_115_mockup_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4611), 115 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 458, "Product variant 115 mockup view 2", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4620), "variant_115_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4622), 115 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 461, "Product variant 116 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4630), "variant_116_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4632), 116 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 462, "Product variant 116 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4640), "variant_116_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4642), 116 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 465, "Product variant 117 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4650), "variant_117_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4651), 117 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 466, "Product variant 117 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4660), "variant_117_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4661), 117 },
                    { 467, "Product variant 117 mockup view 3", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4669), "variant_117_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4671), 117 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 469, "Product variant 118 mockup view 1", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4680), "variant_118_mockup_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4682), 118 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 470, "Product variant 118 mockup view 2", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4690), "variant_118_mockup_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4691), 118 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 473, "Product variant 119 mockup view 1", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4700), "variant_119_mockup_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4702), 119 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 474, "Product variant 119 mockup view 2", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4710), "variant_119_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4711), 119 },
                    { 475, "Product variant 119 mockup view 3", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4720), "variant_119_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4721), 119 },
                    { 476, "Product variant 119 mockup view 4", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4730), "variant_119_mockup_4.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4731), 119 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 477, "Product variant 120 mockup view 1", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4877), "variant_120_mockup_1.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4878), 120 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 478, "Product variant 120 mockup view 2", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4887), "variant_120_mockup_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4888), 120 },
                    { 479, "Product variant 120 mockup view 3", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4897), "variant_120_mockup_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4898), 120 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 481, "Product variant 121 mockup view 1", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4907), "variant_121_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4908), 121 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 482, "Product variant 121 mockup view 2", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4917), "variant_121_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4918), 121 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 485, "Product variant 122 mockup view 1", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4928), "variant_122_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4930), 122 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 486, "Product variant 122 mockup view 2", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4937), "variant_122_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4939), 122 },
                    { 487, "Product variant 122 mockup view 3", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4948), "variant_122_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4949), 122 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 489, "Product variant 123 mockup view 1", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4957), "variant_123_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4959), 123 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 490, "Product variant 123 mockup view 2", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4967), "variant_123_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4968), 123 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 493, "Product variant 124 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4976), "variant_124_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4978), 124 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 494, "Product variant 124 mockup view 2", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4986), "variant_124_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4987), 124 },
                    { 495, "Product variant 124 mockup view 3", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(4998), "variant_124_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5000), 124 },
                    { 496, "Product variant 124 mockup view 4", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5008), "variant_124_mockup_4.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5009), 124 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 497, "Product variant 125 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5017), "variant_125_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5018), 125 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 498, "Product variant 125 mockup view 2", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5027), "variant_125_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5028), 125 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 501, "Product variant 126 mockup view 1", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5036), "variant_126_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5038), 126 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 502, "Product variant 126 mockup view 2", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5046), "variant_126_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5047), 126 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 505, "Product variant 127 mockup view 1", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5056), "variant_127_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5057), 127 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 506, "Product variant 127 mockup view 2", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5065), "variant_127_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5067), 127 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 509, "Product variant 128 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5076), "variant_128_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5077), 128 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 510, "Product variant 128 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5085), "variant_128_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5087), 128 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 513, "Product variant 129 mockup view 1", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5095), "variant_129_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5096), 129 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 514, "Product variant 129 mockup view 2", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5185), "variant_129_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5187), 129 },
                    { 515, "Product variant 129 mockup view 3", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5197), "variant_129_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5199), 129 },
                    { 516, "Product variant 129 mockup view 4", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5206), "variant_129_mockup_4.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5208), 129 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 517, "Product variant 130 mockup view 1", "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5217), "variant_130_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5219), 130 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 518, "Product variant 130 mockup view 2", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5228), "variant_130_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5229), 130 },
                    { 519, "Product variant 130 mockup view 3", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5239), "variant_130_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5241), 130 },
                    { 520, "Product variant 130 mockup view 4", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5249), "variant_130_mockup_4.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5250), 130 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 521, "Product variant 131 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5261), "variant_131_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5262), 131 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 522, "Product variant 131 mockup view 2", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5273), "variant_131_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5274), 131 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 525, "Product variant 132 mockup view 1", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5283), "variant_132_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5284), 132 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 526, "Product variant 132 mockup view 2", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5293), "variant_132_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5294), 132 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 529, "Product variant 133 mockup view 1", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5303), "variant_133_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5304), 133 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 530, "Product variant 133 mockup view 2", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5312), "variant_133_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5313), 133 },
                    { 531, "Product variant 133 mockup view 3", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5321), "variant_133_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5323), 133 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 533, "Product variant 134 mockup view 1", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5331), "variant_134_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5332), 134 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 534, "Product variant 134 mockup view 2", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5340), "variant_134_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5342), 134 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 537, "Product variant 135 mockup view 1", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5351), "variant_135_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5352), 135 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 538, "Product variant 135 mockup view 2", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5360), "variant_135_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5362), 135 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 541, "Product variant 136 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5371), "variant_136_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5372), 136 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 542, "Product variant 136 mockup view 2", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5380), "variant_136_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5381), 136 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 545, "Product variant 137 mockup view 1", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5390), "variant_137_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5391), 137 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 546, "Product variant 137 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5399), "variant_137_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5400), 137 },
                    { 547, "Product variant 137 mockup view 3", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5409), "variant_137_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5410), 137 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 549, "Product variant 138 mockup view 1", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5509), "variant_138_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5511), 138 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 550, "Product variant 138 mockup view 2", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5522), "variant_138_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5523), 138 },
                    { 551, "Product variant 138 mockup view 3", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5532), "variant_138_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5533), 138 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 553, "Product variant 139 mockup view 1", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5542), "variant_139_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5543), 139 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 554, "Product variant 139 mockup view 2", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5551), "variant_139_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5552), 139 },
                    { 555, "Product variant 139 mockup view 3", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5560), "variant_139_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5562), 139 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 557, "Product variant 140 mockup view 1", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5570), "variant_140_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5572), 140 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 558, "Product variant 140 mockup view 2", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5579), "variant_140_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5580), 140 },
                    { 559, "Product variant 140 mockup view 3", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5589), "variant_140_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5590), 140 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 561, "Product variant 141 mockup view 1", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5598), "variant_141_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5600), 141 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 562, "Product variant 141 mockup view 2", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5607), "variant_141_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5609), 141 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 565, "Product variant 142 mockup view 1", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5618), "variant_142_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5620), 142 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 566, "Product variant 142 mockup view 2", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5627), "variant_142_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5629), 142 },
                    { 567, "Product variant 142 mockup view 3", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5637), "variant_142_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5638), 142 },
                    { 568, "Product variant 142 mockup view 4", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5646), "variant_142_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5647), 142 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 569, "Product variant 143 mockup view 1", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5655), "variant_143_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5657), 143 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 570, "Product variant 143 mockup view 2", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5664), "variant_143_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5666), 143 },
                    { 571, "Product variant 143 mockup view 3", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5674), "variant_143_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5675), 143 },
                    { 572, "Product variant 143 mockup view 4", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5683), "variant_143_mockup_4.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5684), 143 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 573, "Product variant 144 mockup view 1", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5692), "variant_144_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5694), 144 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 574, "Product variant 144 mockup view 2", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5702), "variant_144_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5703), 144 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 577, "Product variant 145 mockup view 1", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5711), "variant_145_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5713), 145 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 578, "Product variant 145 mockup view 2", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5721), "variant_145_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5722), 145 },
                    { 579, "Product variant 145 mockup view 3", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5731), "variant_145_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5732), 145 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 581, "Product variant 146 mockup view 1", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5829), "variant_146_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5831), 146 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 582, "Product variant 146 mockup view 2", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5839), "variant_146_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5841), 146 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 585, "Product variant 147 mockup view 1", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5848), "variant_147_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5850), 147 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 586, "Product variant 147 mockup view 2", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5857), "variant_147_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5859), 147 },
                    { 587, "Product variant 147 mockup view 3", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5867), "variant_147_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5868), 147 },
                    { 588, "Product variant 147 mockup view 4", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5876), "variant_147_mockup_4.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5877), 147 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 589, "Product variant 148 mockup view 1", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5886), "variant_148_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5887), 148 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 590, "Product variant 148 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5895), "variant_148_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5896), 148 },
                    { 591, "Product variant 148 mockup view 3", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5904), "variant_148_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5905), 148 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 593, "Product variant 149 mockup view 1", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5913), "variant_149_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5915), 149 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 594, "Product variant 149 mockup view 2", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5923), "variant_149_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5924), 149 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 597, "Product variant 150 mockup view 1", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5932), "variant_150_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5934), 150 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 598, "Product variant 150 mockup view 2", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5941), "variant_150_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5943), 150 },
                    { 599, "Product variant 150 mockup view 3", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5951), "variant_150_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5952), 150 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 601, "Product variant 151 mockup view 1", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5960), "variant_151_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5962), 151 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 602, "Product variant 151 mockup view 2", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5970), "variant_151_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5971), 151 },
                    { 603, "Product variant 151 mockup view 3", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5979), "variant_151_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5980), 151 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 605, "Product variant 152 mockup view 1", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5989), "variant_152_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(5990), 152 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 606, "Product variant 152 mockup view 2", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6001), "variant_152_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6003), 152 },
                    { 607, "Product variant 152 mockup view 3", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6014), "variant_152_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6015), 152 },
                    { 608, "Product variant 152 mockup view 4", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6023), "variant_152_mockup_4.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6025), 152 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 609, "Product variant 153 mockup view 1", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6034), "variant_153_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6035), 153 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 610, "Product variant 153 mockup view 2", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6043), "variant_153_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6045), 153 },
                    { 611, "Product variant 153 mockup view 3", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6152), "variant_153_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6154), 153 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 613, "Product variant 154 mockup view 1", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6163), "variant_154_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6165), 154 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 614, "Product variant 154 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6173), "variant_154_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6174), 154 },
                    { 615, "Product variant 154 mockup view 3", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6182), "variant_154_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6183), 154 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 617, "Product variant 155 mockup view 1", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6192), "variant_155_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6193), 155 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 618, "Product variant 155 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6201), "variant_155_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6203), 155 },
                    { 619, "Product variant 155 mockup view 3", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6211), "variant_155_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6213), 155 },
                    { 620, "Product variant 155 mockup view 4", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6221), "variant_155_mockup_4.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6222), 155 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 621, "Product variant 156 mockup view 1", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6231), "variant_156_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6232), 156 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 622, "Product variant 156 mockup view 2", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6240), "variant_156_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6242), 156 },
                    { 623, "Product variant 156 mockup view 3", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6250), "variant_156_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6251), 156 },
                    { 624, "Product variant 156 mockup view 4", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6259), "variant_156_mockup_4.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6260), 156 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 625, "Product variant 157 mockup view 1", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6269), "variant_157_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6270), 157 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 626, "Product variant 157 mockup view 2", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6279), "variant_157_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6280), 157 },
                    { 627, "Product variant 157 mockup view 3", "admin-001", new DateTime(2025, 8, 8, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6288), "variant_157_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6290), 157 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 629, "Product variant 158 mockup view 1", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6298), "variant_158_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6300), 158 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 630, "Product variant 158 mockup view 2", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6307), "variant_158_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6309), 158 },
                    { 631, "Product variant 158 mockup view 3", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6317), "variant_158_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6318), 158 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 633, "Product variant 159 mockup view 1", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6327), "variant_159_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6328), 159 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 634, "Product variant 159 mockup view 2", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6336), "variant_159_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6338), 159 },
                    { 635, "Product variant 159 mockup view 3", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6345), "variant_159_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6347), 159 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 637, "Product variant 160 mockup view 1", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6355), "variant_160_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6356), 160 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 638, "Product variant 160 mockup view 2", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6364), "variant_160_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6366), 160 },
                    { 639, "Product variant 160 mockup view 3", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6464), "variant_160_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6466), 160 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 641, "Product variant 161 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6477), "variant_161_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6479), 161 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 642, "Product variant 161 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6487), "variant_161_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6488), 161 },
                    { 643, "Product variant 161 mockup view 3", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6496), "variant_161_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6498), 161 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 645, "Product variant 162 mockup view 1", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6506), "variant_162_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6508), 162 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 646, "Product variant 162 mockup view 2", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6516), "variant_162_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6517), 162 },
                    { 647, "Product variant 162 mockup view 3", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6526), "variant_162_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6527), 162 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 649, "Product variant 163 mockup view 1", "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6536), "variant_163_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6537), 163 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 650, "Product variant 163 mockup view 2", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6545), "variant_163_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6547), 163 },
                    { 651, "Product variant 163 mockup view 3", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6555), "variant_163_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6556), 163 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 653, "Product variant 164 mockup view 1", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6565), "variant_164_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6566), 164 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 654, "Product variant 164 mockup view 2", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6575), "variant_164_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6576), 164 },
                    { 655, "Product variant 164 mockup view 3", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6584), "variant_164_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6586), 164 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 657, "Product variant 165 mockup view 1", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6594), "variant_165_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6596), 165 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 658, "Product variant 165 mockup view 2", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6604), "variant_165_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6605), 165 },
                    { 659, "Product variant 165 mockup view 3", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6613), "variant_165_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6614), 165 },
                    { 660, "Product variant 165 mockup view 4", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6622), "variant_165_mockup_4.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6623), 165 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 661, "Product variant 166 mockup view 1", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6633), "variant_166_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6634), 166 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 662, "Product variant 166 mockup view 2", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6642), "variant_166_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6643), 166 },
                    { 663, "Product variant 166 mockup view 3", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6651), "variant_166_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6653), 166 },
                    { 664, "Product variant 166 mockup view 4", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6661), "variant_166_mockup_4.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6662), 166 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 665, "Product variant 167 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6670), "variant_167_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6672), 167 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 666, "Product variant 167 mockup view 2", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6680), "variant_167_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6681), 167 },
                    { 667, "Product variant 167 mockup view 3", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6690), "variant_167_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6691), 167 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 669, "Product variant 168 mockup view 1", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6762), "variant_168_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6763), 168 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 670, "Product variant 168 mockup view 2", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6772), "variant_168_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6774), 168 },
                    { 671, "Product variant 168 mockup view 3", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6782), "variant_168_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6783), 168 },
                    { 672, "Product variant 168 mockup view 4", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6791), "variant_168_mockup_4.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6793), 168 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 673, "Product variant 169 mockup view 1", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6802), "variant_169_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6803), 169 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 674, "Product variant 169 mockup view 2", "admin-001", new DateTime(2025, 7, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6811), "variant_169_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6813), 169 },
                    { 675, "Product variant 169 mockup view 3", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6820), "variant_169_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6822), 169 },
                    { 676, "Product variant 169 mockup view 4", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6830), "variant_169_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6831), 169 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 677, "Product variant 170 mockup view 1", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6840), "variant_170_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6841), 170 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 678, "Product variant 170 mockup view 2", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6849), "variant_170_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6850), 170 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 681, "Product variant 171 mockup view 1", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6859), "variant_171_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6860), 171 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 682, "Product variant 171 mockup view 2", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6869), "variant_171_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6870), 171 },
                    { 683, "Product variant 171 mockup view 3", "admin-001", new DateTime(2025, 7, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6879), "variant_171_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6880), 171 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 685, "Product variant 172 mockup view 1", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6889), "variant_172_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6890), 172 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 686, "Product variant 172 mockup view 2", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6898), "variant_172_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6900), 172 },
                    { 687, "Product variant 172 mockup view 3", "admin-001", new DateTime(2025, 8, 5, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6908), "variant_172_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6909), 172 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 689, "Product variant 173 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6918), "variant_173_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6920), 173 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 690, "Product variant 173 mockup view 2", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6928), "variant_173_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6929), 173 },
                    { 691, "Product variant 173 mockup view 3", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6937), "variant_173_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6938), 173 },
                    { 692, "Product variant 173 mockup view 4", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6946), "variant_173_mockup_4.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6948), 173 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 693, "Product variant 174 mockup view 1", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6957), "variant_174_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6959), 174 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 694, "Product variant 174 mockup view 2", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6967), "variant_174_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(6968), 174 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 697, "Product variant 175 mockup view 1", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7108), "variant_175_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7110), 175 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 698, "Product variant 175 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7120), "variant_175_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7121), 175 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 701, "Product variant 176 mockup view 1", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7131), "variant_176_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7133), 176 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 702, "Product variant 176 mockup view 2", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7142), "variant_176_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7143), 176 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 705, "Product variant 177 mockup view 1", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7295), "variant_177_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7296), 177 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 706, "Product variant 177 mockup view 2", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7305), "variant_177_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7306), 177 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 709, "Product variant 178 mockup view 1", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7315), "variant_178_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7317), 178 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 710, "Product variant 178 mockup view 2", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7325), "variant_178_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7326), 178 },
                    { 711, "Product variant 178 mockup view 3", "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7334), "variant_178_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7336), 178 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 713, "Product variant 179 mockup view 1", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7345), "variant_179_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7346), 179 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 714, "Product variant 179 mockup view 2", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7354), "variant_179_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7355), 179 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 717, "Product variant 180 mockup view 1", "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7365), "variant_180_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7366), 180 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 718, "Product variant 180 mockup view 2", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7375), "variant_180_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7376), 180 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 721, "Product variant 181 mockup view 1", "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7385), "variant_181_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7386), 181 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 722, "Product variant 181 mockup view 2", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7394), "variant_181_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7395), 181 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 725, "Product variant 182 mockup view 1", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7404), "variant_182_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7406), 182 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 726, "Product variant 182 mockup view 2", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7414), "variant_182_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7415), 182 },
                    { 727, "Product variant 182 mockup view 3", "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7423), "variant_182_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7425), 182 },
                    { 728, "Product variant 182 mockup view 4", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7433), "variant_182_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7434), 182 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 729, "Product variant 183 mockup view 1", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7443), "variant_183_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7444), 183 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 730, "Product variant 183 mockup view 2", "admin-001", new DateTime(2025, 8, 11, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7452), "variant_183_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7454), 183 },
                    { 731, "Product variant 183 mockup view 3", "admin-001", new DateTime(2025, 7, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7462), "variant_183_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7464), 183 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 733, "Product variant 184 mockup view 1", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7472), "variant_184_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7474), 184 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 734, "Product variant 184 mockup view 2", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7591), "variant_184_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7593), 184 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 737, "Product variant 185 mockup view 1", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7604), "variant_185_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7606), 185 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 738, "Product variant 185 mockup view 2", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7614), "variant_185_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7615), 185 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 741, "Product variant 186 mockup view 1", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7624), "variant_186_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7625), 186 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 742, "Product variant 186 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7634), "variant_186_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7635), 186 },
                    { 743, "Product variant 186 mockup view 3", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7643), "variant_186_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7645), 186 },
                    { 744, "Product variant 186 mockup view 4", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7653), "variant_186_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7654), 186 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 745, "Product variant 187 mockup view 1", "admin-001", new DateTime(2025, 7, 28, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7662), "variant_187_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7664), 187 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 746, "Product variant 187 mockup view 2", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7672), "variant_187_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7673), 187 },
                    { 747, "Product variant 187 mockup view 3", "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7681), "variant_187_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7682), 187 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 749, "Product variant 188 mockup view 1", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7691), "variant_188_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7692), 188 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 750, "Product variant 188 mockup view 2", "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7700), "variant_188_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7702), 188 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 753, "Product variant 189 mockup view 1", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7711), "variant_189_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7712), 189 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 754, "Product variant 189 mockup view 2", "admin-001", new DateTime(2025, 8, 18, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7720), "variant_189_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7721), 189 },
                    { 755, "Product variant 189 mockup view 3", "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7729), "variant_189_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7730), 189 },
                    { 756, "Product variant 189 mockup view 4", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7738), "variant_189_mockup_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7739), 189 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 757, "Product variant 190 mockup view 1", "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7748), "variant_190_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7750), 190 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 758, "Product variant 190 mockup view 2", "admin-001", new DateTime(2025, 7, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7757), "variant_190_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7759), 190 },
                    { 759, "Product variant 190 mockup view 3", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7767), "variant_190_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7768), 190 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 761, "Product variant 191 mockup view 1", "admin-001", new DateTime(2025, 8, 7, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7776), "variant_191_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7778), 191 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 762, "Product variant 191 mockup view 2", "admin-001", new DateTime(2025, 8, 13, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7786), "variant_191_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7787), 191 },
                    { 763, "Product variant 191 mockup view 3", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7795), "variant_191_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7796), 191 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 765, "Product variant 192 mockup view 1", "admin-001", new DateTime(2025, 8, 9, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7805), "variant_192_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7806), 192 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 766, "Product variant 192 mockup view 2", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7815), "variant_192_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7816), 192 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 769, "Product variant 193 mockup view 1", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7925), "variant_193_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7926), 193 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 770, "Product variant 193 mockup view 2", "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7937), "variant_193_mockup_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7938), 193 },
                    { 771, "Product variant 193 mockup view 3", "admin-001", new DateTime(2025, 8, 2, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7946), "variant_193_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7948), 193 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 773, "Product variant 194 mockup view 1", "admin-001", new DateTime(2025, 8, 29, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7958), "variant_194_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7959), 194 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 774, "Product variant 194 mockup view 2", "admin-001", new DateTime(2025, 8, 12, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7967), "variant_194_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7969), 194 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 777, "Product variant 195 mockup view 1", "admin-001", new DateTime(2025, 8, 26, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7978), "variant_195_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7979), 195 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 778, "Product variant 195 mockup view 2", "admin-001", new DateTime(2025, 8, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7987), "variant_195_mockup_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7989), 195 },
                    { 779, "Product variant 195 mockup view 3", "admin-001", new DateTime(2025, 8, 10, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7996), "variant_195_mockup_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(7998), 195 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 781, "Product variant 196 mockup view 1", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8006), "variant_196_mockup_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8008), 196 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 782, "Product variant 196 mockup view 2", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8016), "variant_196_mockup_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8017), 196 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 785, "Product variant 197 mockup view 1", "admin-001", new DateTime(2025, 7, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8026), "variant_197_mockup_1.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8028), 197 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 786, "Product variant 197 mockup view 2", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8036), "variant_197_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8037), 197 },
                    { 787, "Product variant 197 mockup view 3", "admin-001", new DateTime(2025, 8, 27, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8046), "variant_197_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8047), 197 },
                    { 788, "Product variant 197 mockup view 4", "admin-001", new DateTime(2025, 7, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8055), "variant_197_mockup_4.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8056), 197 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 789, "Product variant 198 mockup view 1", "admin-001", new DateTime(2025, 8, 3, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8064), "variant_198_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8065), 198 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 790, "Product variant 198 mockup view 2", "admin-001", new DateTime(2025, 8, 17, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8073), "variant_198_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8074), 198 },
                    { 791, "Product variant 198 mockup view 3", "admin-001", new DateTime(2025, 8, 4, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8083), "variant_198_mockup_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8425), 198 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 793, "Product variant 199 mockup view 1", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8448), "variant_199_mockup_1.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8449), 199 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 794, "Product variant 199 mockup view 2", "admin-001", new DateTime(2025, 8, 6, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8459), "variant_199_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 9, 1, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8461), 199 },
                    { 795, "Product variant 199 mockup view 3", "admin-001", new DateTime(2025, 8, 21, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8469), "variant_199_mockup_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 31, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8470), 199 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 797, "Product variant 200 mockup view 1", "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8480), "variant_200_mockup_1.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8482), 200 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 798, "Product variant 200 mockup view 2", "admin-001", new DateTime(2025, 8, 25, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8490), "variant_200_mockup_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 30, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8491), 200 },
                    { 799, "Product variant 200 mockup view 3", "admin-001", new DateTime(2025, 8, 15, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8499), "variant_200_mockup_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8500), 200 },
                    { 800, "Product variant 200 mockup view 4", "admin-001", new DateTime(2025, 8, 14, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8648), "variant_200_mockup_4.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 19, 39, 26, 944, DateTimeKind.Utc).AddTicks(8650), 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ApplicationUserId",
                table: "Addresses",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BaseProducts_CategoryId",
                table: "BaseProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Designs_AdminId",
                table: "Designs",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Designs_ApplicationUserId",
                table: "Designs",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Designs_ApplicationUserId1",
                table: "Designs",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductVariantId",
                table: "OrderItems",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantImages_ProductVariantId",
                table: "ProductVariantImages",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_BaseProductId",
                table: "ProductVariants",
                column: "BaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ColorId",
                table: "ProductVariants",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_DesignId",
                table: "ProductVariants",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_SizeId",
                table: "ProductVariants",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductVariantImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "BaseProducts");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Designs");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
