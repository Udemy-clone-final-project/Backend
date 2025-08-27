using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Status = table.Column<int>(type: "int", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Designs_AspNetUsers_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "DesignImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DsignId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignImages_Designs_DsignId",
                        column: x => x.DsignId,
                        principalTable: "Designs",
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
                    DesignId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { "1", null, new DateTime(2025, 8, 26, 15, 35, 40, 129, DateTimeKind.Utc).AddTicks(1353), "System Administrator with full access", true, "Admin", "ADMIN" },
                    { "2", null, new DateTime(2025, 8, 26, 15, 35, 40, 129, DateTimeKind.Utc).AddTicks(1359), "Artist who can upload and manage designs", true, "Artist", "ARTIST" },
                    { "3", null, new DateTime(2025, 8, 26, 15, 35, 40, 129, DateTimeKind.Utc).AddTicks(1364), "Customer who can purchase products", true, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "admin-001", 0, "6968ae04-c33a-4ecf-9a5a-115f90fed14f", new DateTime(2025, 8, 26, 15, 35, 40, 260, DateTimeKind.Utc).AddTicks(1076), "System Admin", "admin@redbubble.com", true, true, false, null, "ADMIN@REDBUBBLE.COM", "ADMIN@REDBUBBLE.COM", "AQAAAAIAAYagAAAAECozp18smo5FtWlWb49feFRfi4LDcWiGyyPuCHniejFUSCmn9l3TZw4IlIbq82lgoQ==", null, false, "d881de99-e083-4ecb-8725-b51d8541e62d", false, new DateTime(2025, 8, 26, 15, 35, 40, 260, DateTimeKind.Utc).AddTicks(1085), "admin@redbubble.com" },
                    { "artist-001", 0, "2a085660-05f2-468c-aef3-626661468260", new DateTime(2025, 8, 26, 15, 35, 40, 388, DateTimeKind.Utc).AddTicks(706), "Alice Cooper", "alice.cooper@email.com", true, true, false, null, "ALICE.COOPER@EMAIL.COM", "ALICE.COOPER@EMAIL.COM", "AQAAAAIAAYagAAAAEMTHp5Mr58zi6F83LTP9LUUV6e+fTFdP6WauDRvDHd/l9UUf5+pzKk32/F9ckPScJw==", null, false, "48492663-33ca-44d4-9254-a78aba9de3cf", false, new DateTime(2025, 8, 26, 15, 35, 40, 388, DateTimeKind.Utc).AddTicks(718), "alice.cooper@email.com" },
                    { "artist-002", 0, "01efe899-5572-4cb0-b9fd-9f3b53959338", new DateTime(2025, 8, 26, 15, 35, 40, 522, DateTimeKind.Utc).AddTicks(8436), "Bob Wilson", "bob.wilson@email.com", true, true, false, null, "BOB.WILSON@EMAIL.COM", "BOB.WILSON@EMAIL.COM", "AQAAAAIAAYagAAAAEKj16EY+a2mKRBQHWw2HMXNZdVLJUzfOC5Tq1GDS+8T32ZnCRhSveW40BF9j7BasAw==", null, false, "5cd9dd5e-23e4-4294-a9de-dad5e423fec5", false, new DateTime(2025, 8, 26, 15, 35, 40, 522, DateTimeKind.Utc).AddTicks(8442), "bob.wilson@email.com" },
                    { "artist-003", 0, "290391ff-d79e-4f22-8cac-c64bf19e640f", new DateTime(2025, 8, 26, 15, 35, 40, 657, DateTimeKind.Utc).AddTicks(7296), "Charlie Brown", "charlie.brown@email.com", true, true, false, null, "CHARLIE.BROWN@EMAIL.COM", "CHARLIE.BROWN@EMAIL.COM", "AQAAAAIAAYagAAAAEAYNUrwRuYNPLH666/mGFIv/6LP1VyscxMEcxEgrB1uMm5w8ib48wB9nJFwTbQn7sg==", null, false, "4674669d-bf19-4560-9d6b-d87ad6d93e51", false, new DateTime(2025, 8, 26, 15, 35, 40, 657, DateTimeKind.Utc).AddTicks(7302), "charlie.brown@email.com" },
                    { "artist-004", 0, "4c05af40-e6ee-4899-a4e8-c0a61357968e", new DateTime(2025, 8, 26, 15, 35, 40, 788, DateTimeKind.Utc).AddTicks(7467), "Diana Prince", "diana.prince@email.com", true, true, false, null, "DIANA.PRINCE@EMAIL.COM", "DIANA.PRINCE@EMAIL.COM", "AQAAAAIAAYagAAAAENV/4Ph4uDBGqKX+43v8SgQulXGtStSdIJbBSPLTyHx8kWcciy0iM1LcHzkA5qN40g==", null, false, "b6acf3f8-fbef-49fe-b9b3-fa1f26397d88", false, new DateTime(2025, 8, 26, 15, 35, 40, 788, DateTimeKind.Utc).AddTicks(7474), "diana.prince@email.com" },
                    { "artist-005", 0, "8f58433d-17c2-444a-8fd3-643c567e4942", new DateTime(2025, 8, 26, 15, 35, 40, 917, DateTimeKind.Utc).AddTicks(5538), "Emma Stone", "emma.stone@email.com", true, true, false, null, "EMMA.STONE@EMAIL.COM", "EMMA.STONE@EMAIL.COM", "AQAAAAIAAYagAAAAEO74GJzLm7qVDQiX9KyDu4cEYHrhMVWkcWOJ8bstYxfL2HmzxN4c4D5FaB7ks0Lmhg==", null, false, "a53571ac-3da4-4b48-a262-128a38e069a7", false, new DateTime(2025, 8, 26, 15, 35, 40, 917, DateTimeKind.Utc).AddTicks(5546), "emma.stone@email.com" },
                    { "artist-006", 0, "85cba22e-9d7b-46f2-9c65-fdfc739be275", new DateTime(2025, 8, 26, 15, 35, 41, 45, DateTimeKind.Utc).AddTicks(2471), "Frank Ocean", "frank.ocean@email.com", true, true, false, null, "FRANK.OCEAN@EMAIL.COM", "FRANK.OCEAN@EMAIL.COM", "AQAAAAIAAYagAAAAEJ1LPnxN/eanxwMcj6Kw+uQuBe2pwegIlgtg5LhKi0IHYzbm6aUqzWIWbZl29fVkHQ==", null, false, "a2668b1b-4073-4e1a-8fba-058c3a6b2688", false, new DateTime(2025, 8, 26, 15, 35, 41, 45, DateTimeKind.Utc).AddTicks(2478), "frank.ocean@email.com" },
                    { "artist-007", 0, "3c1e6ceb-8e6c-44b5-a501-45d99bd82357", new DateTime(2025, 8, 26, 15, 35, 41, 179, DateTimeKind.Utc).AddTicks(3806), "Grace Kelly", "grace.kelly@email.com", true, true, false, null, "GRACE.KELLY@EMAIL.COM", "GRACE.KELLY@EMAIL.COM", "AQAAAAIAAYagAAAAEIAviUdDxU4hzS0h7WWLOUeXmfLjMsSgrxt4DokmmUOZV6TBuRFYitBHd+NIEsWO7Q==", null, false, "a4bf1ea4-abae-4fe3-a1b6-6d89aec39674", false, new DateTime(2025, 8, 26, 15, 35, 41, 179, DateTimeKind.Utc).AddTicks(3816), "grace.kelly@email.com" },
                    { "artist-008", 0, "c37539bd-bfff-4333-9e48-de1c9370e93d", new DateTime(2025, 8, 26, 15, 35, 41, 308, DateTimeKind.Utc).AddTicks(1054), "Henry Ford", "henry.ford@email.com", true, true, false, null, "HENRY.FORD@EMAIL.COM", "HENRY.FORD@EMAIL.COM", "AQAAAAIAAYagAAAAEIJiVO8bFHsU+BXIa85V1Dq75UDwmGQuP5p44e9g7UxVzY3GgN3m6x/Sxd9zfjjsPg==", null, false, "7f1a990d-4f9f-447a-8d0a-c6250161dd3e", false, new DateTime(2025, 8, 26, 15, 35, 41, 308, DateTimeKind.Utc).AddTicks(1062), "henry.ford@email.com" },
                    { "artist-009", 0, "80b43d1a-eebf-4906-8f92-3174a2424893", new DateTime(2025, 8, 26, 15, 35, 41, 435, DateTimeKind.Utc).AddTicks(4947), "Iris West", "iris.west@email.com", true, true, false, null, "IRIS.WEST@EMAIL.COM", "IRIS.WEST@EMAIL.COM", "AQAAAAIAAYagAAAAEJcP4padICbFuxPgpJgeZ1lziG7K4wGdluN4qU5wgNNu0apbzfrV1cZ819aVEA4Nog==", null, false, "f03f9675-4d28-4735-a59d-2419a526e43b", false, new DateTime(2025, 8, 26, 15, 35, 41, 435, DateTimeKind.Utc).AddTicks(4954), "iris.west@email.com" },
                    { "artist-010", 0, "1c1d546b-954a-45f7-9a29-8388733838b1", new DateTime(2025, 8, 26, 15, 35, 41, 558, DateTimeKind.Utc).AddTicks(2558), "Jack Sparrow", "jack.sparrow@email.com", true, true, false, null, "JACK.SPARROW@EMAIL.COM", "JACK.SPARROW@EMAIL.COM", "AQAAAAIAAYagAAAAEACENOjELqB4YSeOwZLG7zGmfaWLsgCVA6a+/pSZ8NNMsP/QlJ8sSxxrJmaIzdaGjg==", null, false, "1aec2d0f-9285-4fca-8b86-1a19224d5c3e", false, new DateTime(2025, 8, 26, 15, 35, 41, 558, DateTimeKind.Utc).AddTicks(2565), "jack.sparrow@email.com" },
                    { "artist-011", 0, "7799ab3a-d4f9-483d-a7dd-caf679932bde", new DateTime(2025, 8, 26, 15, 35, 41, 680, DateTimeKind.Utc).AddTicks(5773), "Kate Winslet", "kate.winslet@email.com", true, true, false, null, "KATE.WINSLET@EMAIL.COM", "KATE.WINSLET@EMAIL.COM", "AQAAAAIAAYagAAAAEMoAi0qV+h45qcDAz/HOfwNSr1dfN78rm2/rTWNymbh8YqIZJU2nNjbBVfJmxvncyg==", null, false, "5f7ec0ed-da4b-4e1d-8705-92ae905eb022", false, new DateTime(2025, 8, 26, 15, 35, 41, 680, DateTimeKind.Utc).AddTicks(5779), "kate.winslet@email.com" },
                    { "artist-012", 0, "31922cc1-e479-4672-b670-c94aea366734", new DateTime(2025, 8, 26, 15, 35, 41, 783, DateTimeKind.Utc).AddTicks(6172), "Liam Neeson", "liam.neeson@email.com", true, true, false, null, "LIAM.NEESON@EMAIL.COM", "LIAM.NEESON@EMAIL.COM", "AQAAAAIAAYagAAAAEMDX95ZSLL2y0UWBbkJHTpr9qMzUh2KuRx4wGG3PtKyUPV3GWrZzMdldhOCIM3o1/w==", null, false, "7e18eb9e-a28e-412d-8d18-dad7c0703189", false, new DateTime(2025, 8, 26, 15, 35, 41, 783, DateTimeKind.Utc).AddTicks(6178), "liam.neeson@email.com" },
                    { "artist-013", 0, "4d0a805d-9968-4d92-8529-edbc2ab3092c", new DateTime(2025, 8, 26, 15, 35, 41, 882, DateTimeKind.Utc).AddTicks(2967), "Maya Angelou", "maya.angelou@email.com", true, true, false, null, "MAYA.ANGELOU@EMAIL.COM", "MAYA.ANGELOU@EMAIL.COM", "AQAAAAIAAYagAAAAEKrzAOFzloaZutOYGqAmfj8M3FEoH3AwWIhcN8WosFXmhkwcJjGu+sz3YeX7jotiyA==", null, false, "b85e9730-6b93-483a-9f00-f992c3cd29d5", false, new DateTime(2025, 8, 26, 15, 35, 41, 882, DateTimeKind.Utc).AddTicks(2972), "maya.angelou@email.com" },
                    { "artist-014", 0, "85c3c30d-6f0d-49f1-ab19-0a63f488d74d", new DateTime(2025, 8, 26, 15, 35, 41, 981, DateTimeKind.Utc).AddTicks(2883), "Noah Webster", "noah.webster@email.com", true, true, false, null, "NOAH.WEBSTER@EMAIL.COM", "NOAH.WEBSTER@EMAIL.COM", "AQAAAAIAAYagAAAAEPSAoj0WMJMxFBAVs1QlvWGgc4Z++8O1ZIX6IDUGS2kjTmbDYCCraj86sId2lm4nQw==", null, false, "a8ee0215-d38f-4464-85b1-de9020e5937d", false, new DateTime(2025, 8, 26, 15, 35, 41, 981, DateTimeKind.Utc).AddTicks(2889), "noah.webster@email.com" },
                    { "artist-015", 0, "f3802ff1-cc0e-4d28-8b5a-103ed88adc41", new DateTime(2025, 8, 26, 15, 35, 42, 93, DateTimeKind.Utc).AddTicks(2660), "Olivia Wilde", "olivia.wilde@email.com", true, true, false, null, "OLIVIA.WILDE@EMAIL.COM", "OLIVIA.WILDE@EMAIL.COM", "AQAAAAIAAYagAAAAEHROT+DCEfX/GPlqCi+R5XBzNfjB9tmAkFFnZUC8gQqnggpm7ROa66w6BjKFA47M5Q==", null, false, "b809ad88-2c8e-4682-8a58-d04ba69588b3", false, new DateTime(2025, 8, 26, 15, 35, 42, 93, DateTimeKind.Utc).AddTicks(2666), "olivia.wilde@email.com" },
                    { "artist-016", 0, "e809de23-8c38-4e78-967a-95ba4fb9ee6b", new DateTime(2025, 8, 26, 15, 35, 42, 207, DateTimeKind.Utc).AddTicks(7921), "Paul McCartney", "paul.mccartney@email.com", true, true, false, null, "PAUL.MCCARTNEY@EMAIL.COM", "PAUL.MCCARTNEY@EMAIL.COM", "AQAAAAIAAYagAAAAEKnR45YkPS8xjwr9ChFAJK1leks21w4SEMLe5p+XW3ujkHwqEm2CVzl3RZwqrcAx1Q==", null, false, "73943960-097f-4f4c-a654-1cb8bcb17342", false, new DateTime(2025, 8, 26, 15, 35, 42, 207, DateTimeKind.Utc).AddTicks(7930), "paul.mccartney@email.com" },
                    { "artist-017", 0, "036ee998-ba2b-4d92-b9f8-467dcfb40449", new DateTime(2025, 8, 26, 15, 35, 42, 317, DateTimeKind.Utc).AddTicks(108), "Quinn Fabray", "quinn.fabray@email.com", true, true, false, null, "QUINN.FABRAY@EMAIL.COM", "QUINN.FABRAY@EMAIL.COM", "AQAAAAIAAYagAAAAEAvhSwm7V4kx3WWVn+1nRe+Y++eeRac3s1zC69dog+whou2m5Q0s8PmLIjKp8DfrJQ==", null, false, "31310bd7-efd4-4001-a441-17241da0e714", false, new DateTime(2025, 8, 26, 15, 35, 42, 317, DateTimeKind.Utc).AddTicks(114), "quinn.fabray@email.com" },
                    { "artist-018", 0, "0877b087-e924-4bed-a69c-711d614096b2", new DateTime(2025, 8, 26, 15, 35, 42, 418, DateTimeKind.Utc).AddTicks(4581), "Rose Tyler", "rose.tyler@email.com", true, true, false, null, "ROSE.TYLER@EMAIL.COM", "ROSE.TYLER@EMAIL.COM", "AQAAAAIAAYagAAAAEIQ6xK/iG/VFus32R5I2/Xm2XXcD0zcaEeE6jiM9sy74+DnExZWbPD0qgM6G8BbMlQ==", null, false, "9b06fa7a-d157-4474-ba61-5568e1ab7924", false, new DateTime(2025, 8, 26, 15, 35, 42, 418, DateTimeKind.Utc).AddTicks(4589), "rose.tyler@email.com" },
                    { "artist-019", 0, "68ca956d-0b85-46bd-8047-4669ca138e49", new DateTime(2025, 8, 26, 15, 35, 42, 520, DateTimeKind.Utc).AddTicks(7929), "Sam Smith", "sam.smith@email.com", true, true, false, null, "SAM.SMITH@EMAIL.COM", "SAM.SMITH@EMAIL.COM", "AQAAAAIAAYagAAAAEKw5h/k6cOXZXRbr7Htb58A8HretuDrSgZv+aCZ0X/9qW+4CtZgt0C1YwcLRsn+lCQ==", null, false, "a05e4029-c620-4e29-af44-fd4226cc15dd", false, new DateTime(2025, 8, 26, 15, 35, 42, 520, DateTimeKind.Utc).AddTicks(7936), "sam.smith@email.com" },
                    { "artist-020", 0, "354319c2-b9e8-4e83-b37c-c7ef0186bf13", new DateTime(2025, 8, 26, 15, 35, 42, 632, DateTimeKind.Utc).AddTicks(8464), "Tina Turner", "tina.turner@email.com", true, true, false, null, "TINA.TURNER@EMAIL.COM", "TINA.TURNER@EMAIL.COM", "AQAAAAIAAYagAAAAEBCGlUXjbn6bPh6mAPxBe4Ly9VISjlwVPO3zjKDl0QoD1ZzK+ss3GeA5XdtHJarZeg==", null, false, "214f7f4f-683e-441b-a9be-5d1cc6b9a3a0", false, new DateTime(2025, 8, 26, 15, 35, 42, 632, DateTimeKind.Utc).AddTicks(8470), "tina.turner@email.com" },
                    { "customer-001", 0, "f6c9a6f1-88e5-469f-8257-da4e77483c4f", new DateTime(2025, 8, 26, 15, 35, 42, 750, DateTimeKind.Utc).AddTicks(4560), "John Doe", "john.doe@email.com", true, true, false, null, "JOHN.DOE@EMAIL.COM", "JOHN.DOE@EMAIL.COM", "AQAAAAIAAYagAAAAEO9QAXhC81SVBN2MAYgIRi20pLcA1Fx003mlPtecYkYvPN6T5gXh+dcCY4wsbHw3/g==", null, false, "77a869a8-d17c-4fa5-8810-205db391c8a9", false, new DateTime(2025, 8, 26, 15, 35, 42, 750, DateTimeKind.Utc).AddTicks(4568), "john.doe@email.com" },
                    { "customer-002", 0, "a36b59b9-974f-4309-9c9e-66676ce285b3", new DateTime(2025, 8, 26, 15, 35, 42, 860, DateTimeKind.Utc).AddTicks(3749), "Jane Smith", "jane.smith@email.com", true, true, false, null, "JANE.SMITH@EMAIL.COM", "JANE.SMITH@EMAIL.COM", "AQAAAAIAAYagAAAAEGyqctngx7FBypcCLWL//ibPFB1kh4A+DqAolYXIL66agqSUqwQ7uHjBk1/ioKorJA==", null, false, "af358d1a-142f-4ca1-bd68-5b0edd44718a", false, new DateTime(2025, 8, 26, 15, 35, 42, 860, DateTimeKind.Utc).AddTicks(3755), "jane.smith@email.com" },
                    { "customer-003", 0, "f1f0b488-ecdb-4b89-9595-1dff9624c2ce", new DateTime(2025, 8, 26, 15, 35, 42, 956, DateTimeKind.Utc).AddTicks(7743), "Michael Johnson", "michael.johnson@email.com", true, true, false, null, "MICHAEL.JOHNSON@EMAIL.COM", "MICHAEL.JOHNSON@EMAIL.COM", "AQAAAAIAAYagAAAAEJjn7f9AWrT2aSu2PckCG8YwNIZ9S4WpL1b6/+tFvuQZWmjSPeCN/gRDWcnhJSqQjQ==", null, false, "7ad201a3-1c6a-493f-98dd-dced6845388e", false, new DateTime(2025, 8, 26, 15, 35, 42, 956, DateTimeKind.Utc).AddTicks(7750), "michael.johnson@email.com" },
                    { "customer-004", 0, "07838324-8049-4bcf-95bc-104688387d12", new DateTime(2025, 8, 26, 15, 35, 43, 56, DateTimeKind.Utc).AddTicks(6569), "Sarah Williams", "sarah.williams@email.com", true, true, false, null, "SARAH.WILLIAMS@EMAIL.COM", "SARAH.WILLIAMS@EMAIL.COM", "AQAAAAIAAYagAAAAEMGjtTacIFdC5GvIY48FNFQV3zQc6Bab+DUnzlMxRBX3Pcrt4b1E6aZUrxZ75JpFzg==", null, false, "58c6d34b-31d4-4582-8214-a6b3043cf7bf", false, new DateTime(2025, 8, 26, 15, 35, 43, 56, DateTimeKind.Utc).AddTicks(6575), "sarah.williams@email.com" },
                    { "customer-005", 0, "83e861da-b9d4-4280-9362-ec86d7a72964", new DateTime(2025, 8, 26, 15, 35, 43, 156, DateTimeKind.Utc).AddTicks(254), "David Brown", "david.brown@email.com", true, true, false, null, "DAVID.BROWN@EMAIL.COM", "DAVID.BROWN@EMAIL.COM", "AQAAAAIAAYagAAAAEGKp+WUmZiqkIKcmcK2EBubo4kOMwAbcCV684l8CA1NnlCKzCr2M0RBvx5VveRxKiQ==", null, false, "202737e1-1dbb-4472-b494-00b798a3e640", false, new DateTime(2025, 8, 26, 15, 35, 43, 156, DateTimeKind.Utc).AddTicks(260), "david.brown@email.com" },
                    { "customer-006", 0, "6a9eaf04-643b-4e08-9c85-8060c64d4a06", new DateTime(2025, 8, 26, 15, 35, 43, 255, DateTimeKind.Utc).AddTicks(9530), "Emily Davis", "emily.davis@email.com", true, true, false, null, "EMILY.DAVIS@EMAIL.COM", "EMILY.DAVIS@EMAIL.COM", "AQAAAAIAAYagAAAAEOU1VRMUArqBnTbZ7kbk/ALwbAZ1xoa0Cfo+1JDbrwSGoGw8FzTD7Lu6s8NJVHFf7w==", null, false, "91fc731f-8300-42d0-a902-8f5734b6588a", false, new DateTime(2025, 8, 26, 15, 35, 43, 255, DateTimeKind.Utc).AddTicks(9536), "emily.davis@email.com" },
                    { "customer-007", 0, "184000d5-08f3-4205-81ed-74bce464a58b", new DateTime(2025, 8, 26, 15, 35, 43, 359, DateTimeKind.Utc).AddTicks(258), "James Miller", "james.miller@email.com", true, true, false, null, "JAMES.MILLER@EMAIL.COM", "JAMES.MILLER@EMAIL.COM", "AQAAAAIAAYagAAAAEDdtNW9HCrS7oG+aXgR2SxZaBcB9AI0eMQ75es93bvY0nfNNKF5aoN7HOJyCFSyeGA==", null, false, "394a8c21-7557-4fae-aa6f-17838eac0890", false, new DateTime(2025, 8, 26, 15, 35, 43, 359, DateTimeKind.Utc).AddTicks(264), "james.miller@email.com" },
                    { "customer-008", 0, "f845bf40-a0b4-48c5-aa54-18733d10f4f5", new DateTime(2025, 8, 26, 15, 35, 43, 460, DateTimeKind.Utc).AddTicks(2141), "Jessica Wilson", "jessica.wilson@email.com", true, true, false, null, "JESSICA.WILSON@EMAIL.COM", "JESSICA.WILSON@EMAIL.COM", "AQAAAAIAAYagAAAAEHK+58uWEEVvU+uOUtHfLcUg39GSmrerSbc09Ie7IdlXZYzst+OpXn4C3l6deueZ8A==", null, false, "e1655fb1-4e76-4ac4-b8b5-cb53e5fbcdd0", false, new DateTime(2025, 8, 26, 15, 35, 43, 460, DateTimeKind.Utc).AddTicks(2147), "jessica.wilson@email.com" },
                    { "customer-009", 0, "e3a212be-7703-4f47-804e-197088c8e160", new DateTime(2025, 8, 26, 15, 35, 43, 560, DateTimeKind.Utc).AddTicks(1913), "Robert Moore", "robert.moore@email.com", true, true, false, null, "ROBERT.MOORE@EMAIL.COM", "ROBERT.MOORE@EMAIL.COM", "AQAAAAIAAYagAAAAEEOcnj5qjt3wKstUXQFeaQ6YLliilNoZs3NCAKIBcpn9TL6esf1xLj7h5I7UW6m1kw==", null, false, "6fe68f61-beb9-4b95-a2fd-d3ec1132c285", false, new DateTime(2025, 8, 26, 15, 35, 43, 560, DateTimeKind.Utc).AddTicks(1919), "robert.moore@email.com" },
                    { "customer-010", 0, "8667314e-d58c-40bd-a533-6568b080c8e6", new DateTime(2025, 8, 26, 15, 35, 43, 660, DateTimeKind.Utc).AddTicks(412), "Ashley Taylor", "ashley.taylor@email.com", true, true, false, null, "ASHLEY.TAYLOR@EMAIL.COM", "ASHLEY.TAYLOR@EMAIL.COM", "AQAAAAIAAYagAAAAEA1BBFPVY2G2S+HGNvjzWplfULgLUeDiXC/LxPzmt73+slX51kaTQz2sVY0uWAU/xQ==", null, false, "5a2e1ccd-ca38-4b8c-a60f-71b22834a3ac", false, new DateTime(2025, 8, 26, 15, 35, 43, 660, DateTimeKind.Utc).AddTicks(418), "ashley.taylor@email.com" },
                    { "customer-011", 0, "eb6fdefb-ff90-4d5b-8d39-8cc93dd32f59", new DateTime(2025, 8, 26, 15, 35, 43, 761, DateTimeKind.Utc).AddTicks(9603), "Christopher Anderson", "christopher.anderson@email.com", true, true, false, null, "CHRISTOPHER.ANDERSON@EMAIL.COM", "CHRISTOPHER.ANDERSON@EMAIL.COM", "AQAAAAIAAYagAAAAEH6g0kqWgt30S61NBbWCfq6ztyMy6ZV1QNe7950RQF66NIaECqYVA2Gf19Bf+ebUoA==", null, false, "3a5870b0-8043-49f1-92c0-565de9ef2afe", false, new DateTime(2025, 8, 26, 15, 35, 43, 761, DateTimeKind.Utc).AddTicks(9609), "christopher.anderson@email.com" },
                    { "customer-012", 0, "55bc7d6d-7328-49f0-9b15-89eff91e3292", new DateTime(2025, 8, 26, 15, 35, 43, 875, DateTimeKind.Utc).AddTicks(3075), "Amanda Thomas", "amanda.thomas@email.com", true, true, false, null, "AMANDA.THOMAS@EMAIL.COM", "AMANDA.THOMAS@EMAIL.COM", "AQAAAAIAAYagAAAAEF2BvFz51QaiFygxyj2fBlo7+XRNIYo28gUomZa79eVveX4f/0Wk9nl9PCQcEXJIFQ==", null, false, "41a65dc5-6266-4941-a86d-37a03732ebba", false, new DateTime(2025, 8, 26, 15, 35, 43, 875, DateTimeKind.Utc).AddTicks(3081), "amanda.thomas@email.com" },
                    { "customer-013", 0, "0b2fd67e-3622-4983-b4e3-63dd5300c6fb", new DateTime(2025, 8, 26, 15, 35, 43, 993, DateTimeKind.Utc).AddTicks(3253), "Matthew Jackson", "matthew.jackson@email.com", true, true, false, null, "MATTHEW.JACKSON@EMAIL.COM", "MATTHEW.JACKSON@EMAIL.COM", "AQAAAAIAAYagAAAAEMSFd/GVc6ZR87FiDXIeG57w3SYsK9zfOvXYrNjJcwtrpUC5oaZrY6GFVhcoToJHPQ==", null, false, "da462f3a-1102-417a-a3a0-76c666f7be08", false, new DateTime(2025, 8, 26, 15, 35, 43, 993, DateTimeKind.Utc).AddTicks(3255), "matthew.jackson@email.com" },
                    { "customer-014", 0, "790556b6-447e-48bb-8da6-eae167ecde19", new DateTime(2025, 8, 26, 15, 35, 44, 100, DateTimeKind.Utc).AddTicks(9155), "Melissa White", "melissa.white@email.com", true, true, false, null, "MELISSA.WHITE@EMAIL.COM", "MELISSA.WHITE@EMAIL.COM", "AQAAAAIAAYagAAAAELKRJRtkSMk+GZrh9Ik2gqOluCGU+ur3B9dABZpDr3CHJESk20rleC6gD5MgVxWoSw==", null, false, "18a829b9-1b40-4af8-8231-08e0982c87cc", false, new DateTime(2025, 8, 26, 15, 35, 44, 100, DateTimeKind.Utc).AddTicks(9164), "melissa.white@email.com" },
                    { "customer-015", 0, "d88811c3-8ad6-49ca-a0ab-b2756d3c6b52", new DateTime(2025, 8, 26, 15, 35, 44, 201, DateTimeKind.Utc).AddTicks(550), "Anthony Harris", "anthony.harris@email.com", true, true, false, null, "ANTHONY.HARRIS@EMAIL.COM", "ANTHONY.HARRIS@EMAIL.COM", "AQAAAAIAAYagAAAAEBaOIgrALETCTD+m36T2TMbBJWbWtwSdYgzjZPFK++48vS0rE0OJD4wcQiowrY0L4Q==", null, false, "23dca20a-b590-45c8-b206-1e50f8d2b708", false, new DateTime(2025, 8, 26, 15, 35, 44, 201, DateTimeKind.Utc).AddTicks(556), "anthony.harris@email.com" },
                    { "customer-016", 0, "96a11484-6034-46de-acc4-e35fee0292e9", new DateTime(2025, 8, 26, 15, 35, 44, 300, DateTimeKind.Utc).AddTicks(6054), "Stephanie Martin", "stephanie.martin@email.com", true, true, false, null, "STEPHANIE.MARTIN@EMAIL.COM", "STEPHANIE.MARTIN@EMAIL.COM", "AQAAAAIAAYagAAAAEJ3gTY+7YTQ0yJOBjiLTUx/cr8Ssg2GfH0A77/hj9r7KxPbYrwBUdyzzqloChyT6LA==", null, false, "2cf193e0-0145-4bc8-aa91-454e055f8d4c", false, new DateTime(2025, 8, 26, 15, 35, 44, 300, DateTimeKind.Utc).AddTicks(6059), "stephanie.martin@email.com" },
                    { "customer-017", 0, "5a376b50-db56-4ede-9bf2-78055d753cdc", new DateTime(2025, 8, 26, 15, 35, 44, 402, DateTimeKind.Utc).AddTicks(7370), "Mark Thompson", "mark.thompson@email.com", true, true, false, null, "MARK.THOMPSON@EMAIL.COM", "MARK.THOMPSON@EMAIL.COM", "AQAAAAIAAYagAAAAEIw0mFRycxZwVIKwp1sWNyWU2J7luuvPV72ud/epSDjsMrCH7sZw6M8//WycURzQHg==", null, false, "fdc195c9-0ad6-4f00-b6f5-b65207b1faa0", false, new DateTime(2025, 8, 26, 15, 35, 44, 402, DateTimeKind.Utc).AddTicks(7374), "mark.thompson@email.com" },
                    { "customer-018", 0, "f2516b57-3b63-4eba-b3d7-7f1317c9e2a7", new DateTime(2025, 8, 26, 15, 35, 44, 502, DateTimeKind.Utc).AddTicks(8030), "Laura Garcia", "laura.garcia@email.com", true, true, false, null, "LAURA.GARCIA@EMAIL.COM", "LAURA.GARCIA@EMAIL.COM", "AQAAAAIAAYagAAAAEJVwRRLpasCqQ9XAfDqPN2BZgxg8IEB5WKOMxVw85YAFk7Hlk+gvi+u3eiD8G+x0wQ==", null, false, "694a0e96-66d8-46ce-b5f7-c282361cee5b", false, new DateTime(2025, 8, 26, 15, 35, 44, 502, DateTimeKind.Utc).AddTicks(8039), "laura.garcia@email.com" },
                    { "customer-019", 0, "c086a028-5745-41f5-9c55-72214e7f613f", new DateTime(2025, 8, 26, 15, 35, 44, 602, DateTimeKind.Utc).AddTicks(8588), "Steven Martinez", "steven.martinez@email.com", true, true, false, null, "STEVEN.MARTINEZ@EMAIL.COM", "STEVEN.MARTINEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEKASAgGOFFxKWdnLCV6WeM+rrBuQBud/5T9eyh8Yf1ZnSYg93C4NZmoRS/iVnLdCGg==", null, false, "449652ea-c963-43e3-a0b3-15f8f3c0ab0f", false, new DateTime(2025, 8, 26, 15, 35, 44, 602, DateTimeKind.Utc).AddTicks(8594), "steven.martinez@email.com" },
                    { "customer-020", 0, "2984c887-d333-4762-bd34-e7456a6694b8", new DateTime(2025, 8, 26, 15, 35, 44, 702, DateTimeKind.Utc).AddTicks(6783), "Michelle Robinson", "michelle.robinson@email.com", true, true, false, null, "MICHELLE.ROBINSON@EMAIL.COM", "MICHELLE.ROBINSON@EMAIL.COM", "AQAAAAIAAYagAAAAEA/ah/kExEiVmeqJyTpkmtHtfW7ytH7WLylXv8QE9xK3bZKy4EEcQ/wAho+Bvx4eog==", null, false, "09a21525-99f7-4cfa-a7c7-78e391748012", false, new DateTime(2025, 8, 26, 15, 35, 44, 702, DateTimeKind.Utc).AddTicks(6788), "michelle.robinson@email.com" },
                    { "customer-021", 0, "e715e4e6-f9e5-4ab2-9dff-75795ddab37d", new DateTime(2025, 8, 26, 15, 35, 44, 804, DateTimeKind.Utc).AddTicks(1163), "Kevin Clark", "kevin.clark@email.com", true, true, false, null, "KEVIN.CLARK@EMAIL.COM", "KEVIN.CLARK@EMAIL.COM", "AQAAAAIAAYagAAAAEOeiyArYL6U8XX95nRfAsRaitS6qFxreUL4gbzyESGa75rlzX1bVn21qZrBQVAVHSw==", null, false, "e81341e2-1b63-4d78-aad7-1e7e52b54d95", false, new DateTime(2025, 8, 26, 15, 35, 44, 804, DateTimeKind.Utc).AddTicks(1168), "kevin.clark@email.com" },
                    { "customer-022", 0, "65281ed2-9917-42f4-a22b-5148ee26d871", new DateTime(2025, 8, 26, 15, 35, 44, 903, DateTimeKind.Utc).AddTicks(8554), "Kimberly Rodriguez", "kimberly.rodriguez@email.com", true, true, false, null, "KIMBERLY.RODRIGUEZ@EMAIL.COM", "KIMBERLY.RODRIGUEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEHnBEu0XeO0kp7pgXJXfIhQWfOk+eSpfHQUzp3QsIKdiGVSSkA+jlfnBqPAidwoh9g==", null, false, "1ff6abe8-3660-41e4-ba17-edd73a296cd0", false, new DateTime(2025, 8, 26, 15, 35, 44, 903, DateTimeKind.Utc).AddTicks(8562), "kimberly.rodriguez@email.com" },
                    { "customer-023", 0, "82f9561a-8f83-4d47-b19d-d228fceaf12e", new DateTime(2025, 8, 26, 15, 35, 45, 6, DateTimeKind.Utc).AddTicks(492), "Joshua Lewis", "joshua.lewis@email.com", true, true, false, null, "JOSHUA.LEWIS@EMAIL.COM", "JOSHUA.LEWIS@EMAIL.COM", "AQAAAAIAAYagAAAAEL3HgZqEC6LTtwu8gPzkaYugQVBv+Vck3wZUpiXlXQAyyZr2x125VZK3gPpK1CX+vg==", null, false, "1bbf21ab-3422-45ee-a981-eaae3da3ad9d", false, new DateTime(2025, 8, 26, 15, 35, 45, 6, DateTimeKind.Utc).AddTicks(498), "joshua.lewis@email.com" },
                    { "customer-024", 0, "808cfb3b-c813-47ab-b9ca-ac667db123bc", new DateTime(2025, 8, 26, 15, 35, 45, 106, DateTimeKind.Utc).AddTicks(3565), "Lisa Lee", "lisa.lee@email.com", true, true, false, null, "LISA.LEE@EMAIL.COM", "LISA.LEE@EMAIL.COM", "AQAAAAIAAYagAAAAELbbEnLjVZsnHPJ+ANx0uR1syffeZJWHkV64Up+ZTT3haknXBLAKcXA3XW1eY3mHVQ==", null, false, "b81a6365-7d9c-4c3d-a856-cf091d31de12", false, new DateTime(2025, 8, 26, 15, 35, 45, 106, DateTimeKind.Utc).AddTicks(3576), "lisa.lee@email.com" },
                    { "customer-025", 0, "262312d8-b3e7-42ec-9961-c822bd4224d3", new DateTime(2025, 8, 26, 15, 35, 45, 205, DateTimeKind.Utc).AddTicks(7874), "Andrew Walker", "andrew.walker@email.com", true, true, false, null, "ANDREW.WALKER@EMAIL.COM", "ANDREW.WALKER@EMAIL.COM", "AQAAAAIAAYagAAAAEOrPvHSoSVLrDiNzJdGADEb75J2S1gDmKEWIl2nWYEtYy6n1RP64420vm0FCu7NRbw==", null, false, "b2dfcc62-77ad-4bd3-966b-ccd5782aeea0", false, new DateTime(2025, 8, 26, 15, 35, 45, 205, DateTimeKind.Utc).AddTicks(7882), "andrew.walker@email.com" },
                    { "customer-026", 0, "04ae841e-da37-4359-85ef-2b0b6508ce20", new DateTime(2025, 8, 26, 15, 35, 45, 305, DateTimeKind.Utc).AddTicks(8876), "Nancy Hall", "nancy.hall@email.com", true, true, false, null, "NANCY.HALL@EMAIL.COM", "NANCY.HALL@EMAIL.COM", "AQAAAAIAAYagAAAAEBiLloELxrxuyZuJoAJO4yVTaeW/HvyplXKXbrg77gX8gfRumeT6pby2OdrgqonXRQ==", null, false, "c3feda86-e639-42c0-a445-396f3d71ea24", false, new DateTime(2025, 8, 26, 15, 35, 45, 305, DateTimeKind.Utc).AddTicks(8882), "nancy.hall@email.com" },
                    { "customer-027", 0, "ee676468-0449-4616-ae6c-a5dd517f7ec4", new DateTime(2025, 8, 26, 15, 35, 45, 405, DateTimeKind.Utc).AddTicks(9602), "Brian Allen", "brian.allen@email.com", true, true, false, null, "BRIAN.ALLEN@EMAIL.COM", "BRIAN.ALLEN@EMAIL.COM", "AQAAAAIAAYagAAAAEAkBdH7TuWmFLstFmY3CJin/cfvTLQKOqbHm0L5+t/yTTP/Hd1NHyIOEwEYGFp/+kQ==", null, false, "5480e785-db4c-4487-90c3-e1d83e146a41", false, new DateTime(2025, 8, 26, 15, 35, 45, 405, DateTimeKind.Utc).AddTicks(9611), "brian.allen@email.com" },
                    { "customer-028", 0, "456b330f-5abb-42e9-9e02-7e0bfdc5602f", new DateTime(2025, 8, 26, 15, 35, 45, 508, DateTimeKind.Utc).AddTicks(728), "Betty Young", "betty.young@email.com", true, true, false, null, "BETTY.YOUNG@EMAIL.COM", "BETTY.YOUNG@EMAIL.COM", "AQAAAAIAAYagAAAAEJMPRAkQSW2b4DPs97sENullSPkiyE/OLHmPAAkhho7AForuDSGRbZeSuIQ3yK67Mg==", null, false, "7c24de25-d9f8-4cfc-9aed-ca79cc46af23", false, new DateTime(2025, 8, 26, 15, 35, 45, 508, DateTimeKind.Utc).AddTicks(738), "betty.young@email.com" },
                    { "customer-029", 0, "8d63d070-5054-405e-ba48-2e20b2ec6905", new DateTime(2025, 8, 26, 15, 35, 45, 626, DateTimeKind.Utc).AddTicks(5442), "Gary Hernandez", "gary.hernandez@email.com", true, true, false, null, "GARY.HERNANDEZ@EMAIL.COM", "GARY.HERNANDEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEH955NRf5qEXfE9AD11cvVLr6UdHZ5+kApMIwFxsORRT0DZPAQZQ2aF/1V8xBbZWlQ==", null, false, "72671f46-e2ba-4192-bfbb-f6006cd6d792", false, new DateTime(2025, 8, 26, 15, 35, 45, 626, DateTimeKind.Utc).AddTicks(5448), "gary.hernandez@email.com" },
                    { "customer-030", 0, "bcf49aef-e32e-4d64-a342-a2d4955b7f1f", new DateTime(2025, 8, 26, 15, 35, 45, 760, DateTimeKind.Utc).AddTicks(5437), "Helen King", "helen.king@email.com", true, true, false, null, "HELEN.KING@EMAIL.COM", "HELEN.KING@EMAIL.COM", "AQAAAAIAAYagAAAAEI9Z/nmQM2zkBsRLfqcE2h3AOaLcqZUW43u/OTBEPft/LxWu+Du4YU3hjva8tOYvsQ==", null, false, "e44e37fd-c984-495f-b89b-26105e04aefb", false, new DateTime(2025, 8, 26, 15, 35, 45, 760, DateTimeKind.Utc).AddTicks(5445), "helen.king@email.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Clothing", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2258), "Apparel and wearable items", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2261), null },
                    { 2, "Accessories", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2279), "Fashion and lifestyle accessories", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2280), null },
                    { 3, "Home & Living", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2283), "Home decor and lifestyle items", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2284), null },
                    { 4, "Stickers", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2287), "Decorative stickers and decals", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2288), null },
                    { 5, "Wall Art", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2291), "Prints, posters, and wall decorations", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2291), null },
                    { 6, "Stationery", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2320), "Notebooks, cards, and office supplies", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2321), null },
                    { 7, "Bags", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2323), "Tote bags, backpacks, and purses", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2324), null },
                    { 8, "Tech", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2327), "Phone cases and tech accessories", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2328), null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorCode", "ColorName", "IsActive" },
                values: new object[,]
                {
                    { 1, "#000000", "Black", true },
                    { 2, "#FFFFFF", "White", true },
                    { 3, "#000080", "Navy", true },
                    { 4, "#808080", "Gray", true },
                    { 5, "#FF0000", "Red", true },
                    { 6, "#008000", "Green", true },
                    { 7, "#0000FF", "Blue", true },
                    { 8, "#FFFF00", "Yellow", true },
                    { 9, "#800080", "Purple", true },
                    { 10, "#FFC0CB", "Pink", true },
                    { 11, "#FFA500", "Orange", true },
                    { 12, "#A52A2A", "Brown", true },
                    { 13, "#ADD8E6", "Light Blue", true },
                    { 14, "#006400", "Dark Green", true },
                    { 15, "#800000", "Maroon", true }
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
                    { 1, "customer-001", "New York", "Canada", "Customer1", "LastName1", "519 Maple Lane" },
                    { 2, "customer-002", "London", "Germany", "Customer2", "LastName2", "249 Cedar Way" },
                    { 3, "customer-003", "Berlin", "Canada", "Customer3", "LastName3", "877 Oak Avenue" },
                    { 4, "customer-004", "Paris", "Germany", "Customer4", "LastName4", "607 Elm Drive" },
                    { 5, "customer-005", "Toronto", "United Kingdom", "Customer5", "LastName5", "336 Pine Road" },
                    { 6, "customer-006", "Sydney", "France", "Customer6", "LastName6", "964 Cedar Way" },
                    { 7, "customer-007", "Paris", "United Kingdom", "Customer7", "LastName7", "694 Main Street" },
                    { 8, "customer-008", "New York", "France", "Customer8", "LastName8", "423 Oak Avenue" },
                    { 9, "customer-009", "London", "United Kingdom", "Customer9", "LastName9", "152 Elm Drive" },
                    { 10, "customer-010", "Berlin", "France", "Customer10", "LastName10", "781 Maple Lane" },
                    { 11, "customer-011", "New York", "United Kingdom", "Customer11", "LastName11", "510 Cedar Way" },
                    { 12, "customer-012", "London", "France", "Customer12", "LastName12", "240 Main Street" },
                    { 13, "customer-013", "Sydney", "Australia", "Customer13", "LastName13", "868 Oak Avenue" },
                    { 14, "customer-014", "Paris", "United States", "Customer14", "LastName14", "597 Pine Road" },
                    { 15, "customer-015", "Toronto", "Australia", "Customer15", "LastName15", "327 Maple Lane" },
                    { 16, "customer-016", "Sydney", "United States", "Customer16", "LastName16", "955 Cedar Way" },
                    { 17, "customer-017", "Berlin", "Australia", "Customer17", "LastName17", "685 Oak Avenue" },
                    { 18, "customer-018", "New York", "United States", "Customer18", "LastName18", "414 Elm Drive" },
                    { 19, "customer-019", "London", "Australia", "Customer19", "LastName19", "143 Pine Road" },
                    { 20, "customer-020", "Berlin", "Canada", "Customer20", "LastName20", "772 Maple Lane" },
                    { 21, "customer-021", "Paris", "Germany", "Customer21", "LastName21", "501 Main Street" },
                    { 22, "customer-022", "Toronto", "Canada", "Customer22", "LastName22", "231 Oak Avenue" },
                    { 23, "customer-023", "Sydney", "Germany", "Customer23", "LastName23", "859 Elm Drive" },
                    { 24, "customer-024", "Paris", "Canada", "Customer24", "LastName24", "588 Maple Lane" },
                    { 25, "customer-025", "New York", "Germany", "Customer25", "LastName25", "318 Cedar Way" },
                    { 26, "customer-026", "London", "Canada", "Customer26", "LastName26", "946 Main Street" },
                    { 27, "customer-027", "Berlin", "Germany", "Customer27", "LastName27", "675 Oak Avenue" },
                    { 28, "customer-028", "New York", "United Kingdom", "Customer28", "LastName28", "405 Pine Road" },
                    { 29, "customer-029", "Toronto", "France", "Customer29", "LastName29", "134 Maple Lane" },
                    { 30, "customer-030", "Sydney", "United Kingdom", "Customer30", "LastName30", "763 Cedar Way" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "admin-001" },
                    { "2", "artist-001" },
                    { "2", "artist-002" },
                    { "2", "artist-003" },
                    { "2", "artist-004" },
                    { "2", "artist-005" },
                    { "2", "artist-006" },
                    { "2", "artist-007" },
                    { "2", "artist-008" },
                    { "2", "artist-009" },
                    { "2", "artist-010" },
                    { "2", "artist-011" },
                    { "2", "artist-012" },
                    { "2", "artist-013" },
                    { "2", "artist-014" },
                    { "2", "artist-015" },
                    { "2", "artist-016" },
                    { "2", "artist-017" },
                    { "2", "artist-018" },
                    { "2", "artist-019" },
                    { "2", "artist-020" },
                    { "3", "customer-001" },
                    { "3", "customer-002" },
                    { "3", "customer-003" },
                    { "3", "customer-004" },
                    { "3", "customer-005" },
                    { "3", "customer-006" },
                    { "3", "customer-007" },
                    { "3", "customer-008" },
                    { "3", "customer-009" },
                    { "3", "customer-010" },
                    { "3", "customer-011" },
                    { "3", "customer-012" },
                    { "3", "customer-013" },
                    { "3", "customer-014" },
                    { "3", "customer-015" },
                    { "3", "customer-016" },
                    { "3", "customer-017" },
                    { "3", "customer-018" },
                    { "3", "customer-019" },
                    { "3", "customer-020" },
                    { "3", "customer-021" },
                    { "3", "customer-022" },
                    { "3", "customer-023" },
                    { "3", "customer-024" },
                    { "3", "customer-025" },
                    { "3", "customer-026" },
                    { "3", "customer-027" },
                    { "3", "customer-028" },
                    { "3", "customer-029" },
                    { "3", "customer-030" }
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 11, 16.99m, 5, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5191), "High quality art print", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5193), "Art Print" },
                    { 12, 29.99m, 5, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5196), "Gallery wrapped canvas", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5197), "Canvas Print" },
                    { 14, 4.99m, 4, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5205), "Pack of 3 vinyl stickers", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5206), "Sticker Pack" },
                    { 15, 14.99m, 7, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5210), "Cotton canvas tote bag", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5211), "Tote Bag" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 9, "T-Shirts", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2340), "Classic and graphic t-shirts", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2341), 1 },
                    { 10, "Tank Tops", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2347), "Sleeveless tank tops", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2348), 1 },
                    { 11, "Long Sleeve Shirts", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2351), "Long sleeve t-shirts", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2352), 1 },
                    { 12, "Hoodies", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2355), "Comfortable hoodies and sweatshirts", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2356), 1 },
                    { 13, "Zip Hoodies", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2358), "Zip-up hoodies and jackets", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2359), 1 },
                    { 14, "Crewneck Sweatshirts", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2362), "Classic crewneck sweatshirts", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2363), 1 },
                    { 15, "Dresses", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2366), "Casual and formal dresses", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2367), 1 },
                    { 16, "Skirts", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2370), "Mini, midi, and maxi skirts", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2371), 1 },
                    { 17, "Hats", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2381), "Baseball caps, beanies, and hats", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2382), 2 },
                    { 18, "Scarves", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2387), "Fashion scarves and wraps", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2388), 2 },
                    { 19, "Socks", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2391), "Fun and colorful socks", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2392), 2 },
                    { 20, "Masks", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2395), "Face masks and coverings", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2396), 2 },
                    { 21, "Jewelry", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2398), "Pins, badges, and jewelry", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2399), 2 },
                    { 22, "Mugs", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2411), "Coffee mugs and drinkware", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2412), 3 },
                    { 23, "Travel Mugs", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2415), "Insulated travel mugs", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2416), 3 },
                    { 24, "Water Bottles", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2419), "Reusable water bottles", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2420), 3 },
                    { 25, "Throw Pillows", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2423), "Decorative throw pillows", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2423), 3 },
                    { 26, "Blankets", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2446), "Cozy blankets and throws", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2447), 3 },
                    { 27, "Tapestries", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2450), "Wall tapestries and fabric art", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2451), 3 },
                    { 28, "Clocks", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2453), "Wall clocks and desk clocks", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2454), 3 },
                    { 29, "Candles", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2457), "Scented candles and holders", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2458), 3 },
                    { 30, "iPhone Cases", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2466), "iPhone protective cases", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2468), 8 },
                    { 31, "Samsung Cases", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2471), "Samsung phone cases", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(2472), 8 },
                    { 32, "Laptop Sleeves", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(3366), "Laptop bags and sleeves", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(3367), 8 },
                    { 33, "Mouse Pads", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(3381), "Computer mouse pads", true, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(3382), 8 }
                });

            migrationBuilder.InsertData(
                table: "Designs",
                columns: new[] { "Id", "AdminId", "ApplicationUserId", "ApplicationUserId1", "ArtistId", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "Price", "RejectionReason", "ReviewedAt", "Status", "Title", "UploadedAt" },
                values: new object[,]
                {
                    { 1, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 8, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5773), "Inspirational typography", true, "admin-001", new DateTime(2025, 6, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5775), 4.10m, "Does not meet quality standards", new DateTime(2025, 7, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5766), 2, "Fashion Style 1", new DateTime(2025, 6, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5753) },
                    { 2, "admin-001", null, null, "artist-005", "artist-005", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5818), "Clean minimalist style", true, "admin-001", new DateTime(2025, 6, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5820), 5.05m, null, new DateTime(2025, 7, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5816), 1, "Photography 2", new DateTime(2025, 8, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5814) },
                    { 3, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5841), "Modern artistic design", true, "admin-001", new DateTime(2025, 6, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5843), 7.64m, null, new DateTime(2025, 7, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5839), 1, "Animal Portrait 3", new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5837) },
                    { 4, "admin-001", null, null, "artist-003", "artist-003", new DateTime(2025, 7, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5861), "Motivational text design", true, "admin-001", new DateTime(2025, 6, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5863), 3.49m, null, new DateTime(2025, 7, 31, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5859), 1, "Modern Contemporary 4", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5858) },
                    { 5, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 8, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5881), "Botanical nature art", true, "admin-001", new DateTime(2025, 6, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5883), 5.08m, null, new DateTime(2025, 8, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5879), 1, "Nordic Viking 5", new DateTime(2025, 8, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5877) },
                    { 6, "admin-001", null, null, "artist-013", "artist-013", new DateTime(2025, 7, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5910), "Cosmic space theme", true, "admin-001", new DateTime(2025, 7, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5911), 7.19m, "Does not meet quality standards", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5908), 2, "American Patriotic 6", new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5906) },
                    { 7, "admin-001", null, null, "artist-002", "artist-002", new DateTime(2025, 8, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5929), "Flowing water design", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5930), 3.75m, null, new DateTime(2025, 7, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5927), 1, "Classic Traditional 7", new DateTime(2025, 8, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5926) },
                    { 8, "admin-001", null, null, "artist-015", "artist-015", new DateTime(2025, 8, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5980), "Mathematical patterns", true, "admin-001", new DateTime(2025, 6, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5982), 5.51m, "Does not meet quality standards", new DateTime(2025, 7, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5946), 2, "Abstract Geometry 8", new DateTime(2025, 7, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5944) },
                    { 9, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6021), "Beautiful landscape artwork", true, "admin-001", new DateTime(2025, 7, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6022), 9.31m, "Does not meet quality standards", new DateTime(2025, 7, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6019), 2, "Desert Landscape 9", new DateTime(2025, 6, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6016) },
                    { 10, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6083), "Retro nostalgic design", true, "admin-001", new DateTime(2025, 6, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6085), 8.34m, null, new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6081), 1, "Geometric Patterns 10", new DateTime(2025, 7, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6079) },
                    { 11, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 8, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6106), "Musical themed design", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6107), 9.66m, null, new DateTime(2025, 6, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6104), 1, "Cute Cat Illustration 11", new DateTime(2025, 7, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6102) },
                    { 12, "admin-001", null, null, "artist-010", "artist-010", new DateTime(2025, 7, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6126), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 6, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6127), 3.08m, null, new DateTime(2025, 7, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6124), 1, "African Culture 12", new DateTime(2025, 8, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6122) },
                    { 13, "admin-001", null, null, "artist-016", "artist-016", new DateTime(2025, 8, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6163), "Cosmic space theme", true, "admin-001", new DateTime(2025, 7, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6165), 6.42m, null, new DateTime(2025, 7, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6162), 1, "Futuristic Sci-Fi 13", new DateTime(2025, 5, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6160) },
                    { 14, "admin-001", null, null, "artist-019", "artist-019", new DateTime(2025, 8, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6188), "Beautiful landscape artwork", true, "admin-001", new DateTime(2025, 6, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6189), 3.73m, "Does not meet quality standards", new DateTime(2025, 7, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6186), 2, "Vector Graphics 14", new DateTime(2025, 7, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6184) },
                    { 15, "admin-001", null, null, "artist-003", "artist-003", new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6207), "Mathematical patterns", true, "admin-001", new DateTime(2025, 6, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6209), 8.61m, "Does not meet quality standards", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6205), 2, "Fitness Motivation 15", new DateTime(2025, 8, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6204) },
                    { 16, "admin-001", null, null, "artist-005", "artist-005", new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6226), "Cosmic space theme", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6228), 6.36m, null, new DateTime(2025, 7, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6225), 1, "Gothic Dark 16", new DateTime(2025, 6, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6223) },
                    { 17, "admin-001", null, null, "artist-004", "artist-004", new DateTime(2025, 8, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6245), "Delicious food illustration", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6247), 8.25m, "Does not meet quality standards", new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6244), 2, "Rose Pink 17", new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6242) },
                    { 18, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 7, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6271), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 7, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6272), 6.79m, null, new DateTime(2025, 6, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6269), 1, "Futuristic Sci-Fi 18", new DateTime(2025, 7, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6267) },
                    { 19, "admin-001", null, null, "artist-020", "artist-020", new DateTime(2025, 8, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6289), "Adventure travel art", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6290), 8.48m, null, new DateTime(2025, 8, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6287), 1, "Health Wellness 19", new DateTime(2025, 8, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6286) },
                    { 20, "admin-001", null, null, "artist-019", "artist-019", new DateTime(2025, 6, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6306), "Natural scenery art", true, "admin-001", new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6308), 5.20m, null, new DateTime(2025, 6, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6305), 1, "Zen Meditation 20", new DateTime(2025, 8, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6303) },
                    { 21, "admin-001", null, null, "artist-004", "artist-004", new DateTime(2025, 8, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6325), "Flowing water design", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6326), 9.54m, null, new DateTime(2025, 6, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6323), 1, "Health Wellness 21", new DateTime(2025, 6, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6321) },
                    { 22, "admin-001", null, null, "artist-011", "artist-011", new DateTime(2025, 8, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6343), "Musical themed design", true, "admin-001", new DateTime(2025, 6, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6345), 7.32m, null, new DateTime(2025, 8, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6341), 1, "Pop Art Style 22", new DateTime(2025, 8, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6340) },
                    { 23, "admin-001", null, null, "artist-013", "artist-013", new DateTime(2025, 7, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6361), "Musical themed design", true, "admin-001", new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6363), 8.23m, "Does not meet quality standards", new DateTime(2025, 6, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6359), 2, "Nordic Viking 23", new DateTime(2025, 6, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6358) },
                    { 24, "admin-001", null, null, "artist-020", "artist-020", new DateTime(2025, 8, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6379), "Classic vintage pattern", true, "admin-001", new DateTime(2025, 6, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6380), 7.07m, null, new DateTime(2025, 6, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6377), 1, "Religious Spiritual 24", new DateTime(2025, 7, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6376) },
                    { 25, "admin-001", null, null, "artist-007", "artist-007", new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6396), "Classic vintage pattern", true, "admin-001", new DateTime(2025, 6, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6398), 6.24m, null, new DateTime(2025, 7, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6395), 1, "Medieval Historical 25", new DateTime(2025, 6, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6393) },
                    { 26, "admin-001", null, null, "artist-002", "artist-002", new DateTime(2025, 7, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6415), "Inspirational typography", true, "admin-001", new DateTime(2025, 7, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6416), 4.33m, "Does not meet quality standards", new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6413), 2, "Romance Love 26", new DateTime(2025, 8, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6411) },
                    { 27, "admin-001", null, null, "artist-010", "artist-010", new DateTime(2025, 8, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6434), "Delicious food illustration", true, "admin-001", new DateTime(2025, 6, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6435), 4.85m, null, new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6432), 1, "Forest Wildlife 27", new DateTime(2025, 6, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6430) },
                    { 28, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 7, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6452), "Delicious food illustration", true, "admin-001", new DateTime(2025, 6, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6453), 2.63m, null, new DateTime(2025, 6, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6450), 1, "Spring Garden 28", new DateTime(2025, 7, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6448) },
                    { 29, "admin-001", null, null, "artist-018", "artist-018", new DateTime(2025, 7, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6471), "Cosmic space theme", true, "admin-001", new DateTime(2025, 6, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6473), 6.64m, null, new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6469), 1, "Abstract Geometry 29", new DateTime(2025, 8, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6468) },
                    { 30, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 6, 28, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6553), "Adventure travel art", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6554), 8.02m, null, new DateTime(2025, 7, 28, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6551), 1, "Science Fiction 30", new DateTime(2025, 8, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6549) },
                    { 31, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 7, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6576), "Clean minimalist style", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6577), 3.75m, null, new DateTime(2025, 7, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6573), 1, "Summer Beach 31", new DateTime(2025, 7, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6572) },
                    { 32, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 7, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6621), "Cosmic space theme", true, "admin-001", new DateTime(2025, 7, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6623), 9.83m, "Does not meet quality standards", new DateTime(2025, 8, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6619), 2, "Gothic Dark 32", new DateTime(2025, 7, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6618) },
                    { 33, "admin-001", null, null, "artist-004", "artist-004", new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6641), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 7, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6643), 9.56m, null, new DateTime(2025, 7, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6640), 1, "Mountain Adventure 33", new DateTime(2025, 8, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6638) },
                    { 34, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 6, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6668), "Flowing water design", true, "admin-001", new DateTime(2025, 7, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6669), 5.37m, null, new DateTime(2025, 8, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6666), 1, "Halloween Spooky 34", new DateTime(2025, 7, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6664) },
                    { 35, "admin-001", null, null, "artist-011", "artist-011", new DateTime(2025, 7, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6687), "Urban cityscape", true, "admin-001", new DateTime(2025, 7, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6688), 9.80m, null, new DateTime(2025, 8, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6685), 1, "Business Professional 35", new DateTime(2025, 6, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6683) },
                    { 36, "admin-001", null, null, "artist-017", "artist-017", new DateTime(2025, 7, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6705), "Natural scenery art", true, "admin-001", new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6706), 8.01m, null, new DateTime(2025, 6, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6703), 1, "Romance Love 36", new DateTime(2025, 7, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6701) },
                    { 37, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 6, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6724), "Inspirational typography", true, "admin-001", new DateTime(2025, 7, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6726), 6.50m, null, new DateTime(2025, 8, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6722), 1, "Educational Learning 37", new DateTime(2025, 7, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6721) },
                    { 38, "admin-001", null, null, "artist-007", "artist-007", new DateTime(2025, 7, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6743), "Retro nostalgic design", true, "admin-001", new DateTime(2025, 6, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6745), 2.76m, null, new DateTime(2025, 6, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6741), 1, "Futuristic Sci-Fi 38", new DateTime(2025, 8, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6739) },
                    { 39, "admin-001", null, null, "artist-019", "artist-019", new DateTime(2025, 6, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6763), "Adventure travel art", true, "admin-001", new DateTime(2025, 7, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6765), 9.06m, null, new DateTime(2025, 7, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6761), 1, "Art Deco Design 39", new DateTime(2025, 6, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6760) },
                    { 40, "admin-001", null, null, "artist-007", "artist-007", new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6782), "Flowing water design", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6784), 9.36m, "Does not meet quality standards", new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6780), 2, "Forest Green 40", new DateTime(2025, 7, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6779) },
                    { 41, "admin-001", null, null, "artist-008", "artist-008", new DateTime(2025, 6, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6802), "Beautiful landscape artwork", true, "admin-001", new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6803), 3.88m, "Does not meet quality standards", new DateTime(2025, 6, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6800), 2, "Desert Landscape 41", new DateTime(2025, 6, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6798) },
                    { 42, null, null, null, "artist-012", "artist-012", new DateTime(2025, 6, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6821), "Motivational text design", true, "artist-012", new DateTime(2025, 8, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6823), 2.40m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Fantasy Theme 42", new DateTime(2025, 8, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6818) },
                    { 43, "admin-001", null, null, "artist-011", "artist-011", new DateTime(2025, 7, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6840), "Botanical nature art", true, "admin-001", new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6842), 9.21m, null, new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6838), 1, "Fashion Style 43", new DateTime(2025, 6, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6836) },
                    { 44, "admin-001", null, null, "artist-018", "artist-018", new DateTime(2025, 6, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6859), "Adventure travel art", true, "admin-001", new DateTime(2025, 6, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6860), 8.49m, null, new DateTime(2025, 8, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6857), 1, "Gothic Dark 44", new DateTime(2025, 6, 28, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6855) },
                    { 45, "admin-001", null, null, "artist-017", "artist-017", new DateTime(2025, 6, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6877), "Delicious food illustration", true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6878), 8.45m, null, new DateTime(2025, 7, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6875), 1, "Futuristic Sci-Fi 45", new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6873) },
                    { 46, "admin-001", null, null, "artist-006", "artist-006", new DateTime(2025, 6, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6896), "Natural scenery art", true, "admin-001", new DateTime(2025, 7, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6898), 9.35m, null, new DateTime(2025, 8, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6895), 1, "Halloween Spooky 46", new DateTime(2025, 6, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6893) },
                    { 47, "admin-001", null, null, "artist-018", "artist-018", new DateTime(2025, 5, 31, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6916), "Delicious food illustration", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6918), 3.06m, null, new DateTime(2025, 7, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6913), 1, "Nature Forest 47", new DateTime(2025, 6, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6912) },
                    { 48, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 8, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6936), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 7, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6938), 3.59m, null, new DateTime(2025, 8, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6934), 1, "Romance Love 48", new DateTime(2025, 6, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6933) },
                    { 49, "admin-001", null, null, "artist-008", "artist-008", new DateTime(2025, 7, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6956), "Botanical nature art", true, "admin-001", new DateTime(2025, 7, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6958), 4.21m, null, new DateTime(2025, 7, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6954), 1, "Ice Frost 49", new DateTime(2025, 5, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6953) },
                    { 50, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 8, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6977), "Adventure travel art", true, "admin-001", new DateTime(2025, 7, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6979), 9.05m, null, new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6976), 1, "Rainbow Colorful 50", new DateTime(2025, 6, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6973) },
                    { 51, "admin-001", null, null, "artist-017", "artist-017", new DateTime(2025, 6, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6996), "Realistic animal art", true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6997), 5.63m, null, new DateTime(2025, 6, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6994), 1, "Minimalist Lines 51", new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(6992) },
                    { 52, null, null, null, "artist-018", "artist-018", new DateTime(2025, 6, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7014), "Intricate mandala pattern", true, "artist-018", new DateTime(2025, 8, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7015), 8.12m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Magic Fantasy 52", new DateTime(2025, 7, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7011) },
                    { 53, "admin-001", null, null, "artist-008", "artist-008", new DateTime(2025, 6, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7061), "Intricate mandala pattern", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7063), 6.10m, "Does not meet quality standards", new DateTime(2025, 7, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7059), 2, "Ocean Waves 53", new DateTime(2025, 7, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7057) },
                    { 54, "admin-001", null, null, "artist-013", "artist-013", new DateTime(2025, 7, 31, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7081), "Realistic animal art", true, "admin-001", new DateTime(2025, 7, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7082), 9.68m, null, new DateTime(2025, 8, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7079), 1, "Holiday Christmas 54", new DateTime(2025, 7, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7077) },
                    { 55, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 6, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7103), "Delicate watercolor art", true, "admin-001", new DateTime(2025, 7, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7105), 7.95m, "Does not meet quality standards", new DateTime(2025, 7, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7101), 2, "Golden Yellow 55", new DateTime(2025, 7, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7099) },
                    { 56, "admin-001", null, null, "artist-017", "artist-017", new DateTime(2025, 6, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7123), "Urban cityscape", true, "admin-001", new DateTime(2025, 7, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7124), 9.58m, "Does not meet quality standards", new DateTime(2025, 8, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7121), 2, "Art Deco Design 56", new DateTime(2025, 8, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7119) },
                    { 57, "admin-001", null, null, "artist-011", "artist-011", new DateTime(2025, 7, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7142), "Inspirational typography", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7143), 7.04m, null, new DateTime(2025, 7, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7140), 1, "Lightning Storm 57", new DateTime(2025, 8, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7139) },
                    { 58, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 8, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7159), "Intricate mandala pattern", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7160), 2.35m, null, new DateTime(2025, 8, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7157), 1, "Food Illustration 58", new DateTime(2025, 8, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7156) },
                    { 59, "admin-001", null, null, "artist-015", "artist-015", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7176), "Beautiful landscape artwork", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7178), 5.53m, null, new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7175), 1, "Sunset Orange 59", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7173) },
                    { 60, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 6, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7194), "Musical themed design", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7195), 2.35m, null, new DateTime(2025, 6, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7192), 1, "Monochrome Black 60", new DateTime(2025, 7, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7191) },
                    { 61, "admin-001", null, null, "artist-003", "artist-003", new DateTime(2025, 8, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7212), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7213), 4.15m, null, new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7210), 1, "Science Fiction 61", new DateTime(2025, 8, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7208) },
                    { 62, "admin-001", null, null, "artist-013", "artist-013", new DateTime(2025, 7, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7229), "Modern artistic design", true, "admin-001", new DateTime(2025, 7, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7231), 6.07m, null, new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7228), 1, "Kids Children 62", new DateTime(2025, 6, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7226) },
                    { 63, "admin-001", null, null, "artist-010", "artist-010", new DateTime(2025, 6, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7250), "Adventure travel art", true, "admin-001", new DateTime(2025, 6, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7251), 4.33m, null, new DateTime(2025, 8, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7248), 1, "Coffee Lover Quote 63", new DateTime(2025, 7, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7246) },
                    { 64, "admin-001", null, null, "artist-010", "artist-010", new DateTime(2025, 8, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7268), "Flowing water design", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7269), 6.65m, null, new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7266), 1, "Photo Collage 64", new DateTime(2025, 8, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7264) },
                    { 65, "admin-001", null, null, "artist-019", "artist-019", new DateTime(2025, 8, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7289), "Realistic animal art", true, "admin-001", new DateTime(2025, 7, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7290), 9.07m, null, new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7286), 1, "Typography Quote 65", new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7285) },
                    { 66, "admin-001", null, null, "artist-015", "artist-015", new DateTime(2025, 7, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7314), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 7, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7315), 9.81m, null, new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7312), 1, "Music Notes 66", new DateTime(2025, 7, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7310) },
                    { 67, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 6, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7332), "Botanical nature art", true, "admin-001", new DateTime(2025, 7, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7334), 2.12m, null, new DateTime(2025, 8, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7331), 1, "Modern Contemporary 67", new DateTime(2025, 7, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7329) },
                    { 68, "admin-001", null, null, "artist-019", "artist-019", new DateTime(2025, 6, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7350), "Beautiful landscape artwork", true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7352), 5.69m, "Does not meet quality standards", new DateTime(2025, 6, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7349), 2, "Pop Art Style 68", new DateTime(2025, 7, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7347) },
                    { 69, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 7, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7369), "Modern artistic design", true, "admin-001", new DateTime(2025, 6, 28, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7370), 2.63m, null, new DateTime(2025, 7, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7367), 1, "Gothic Dark 69", new DateTime(2025, 8, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7365) },
                    { 70, "admin-001", null, null, "artist-007", "artist-007", new DateTime(2025, 6, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7388), "Retro nostalgic design", true, "admin-001", new DateTime(2025, 7, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7390), 3.33m, null, new DateTime(2025, 8, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7386), 1, "European Classic 70", new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7385) },
                    { 71, "admin-001", null, null, "artist-005", "artist-005", new DateTime(2025, 8, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7407), "Natural scenery art", true, "admin-001", new DateTime(2025, 7, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7409), 3.55m, null, new DateTime(2025, 6, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7406), 1, "Tribal Ethnic 71", new DateTime(2025, 6, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7404) },
                    { 72, "admin-001", null, null, "artist-010", "artist-010", new DateTime(2025, 6, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7448), "Urban cityscape", true, "admin-001", new DateTime(2025, 6, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7450), 2.07m, null, new DateTime(2025, 6, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7446), 1, "Classic Traditional 72", new DateTime(2025, 7, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7445) },
                    { 73, null, null, null, "artist-004", "artist-004", new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7469), "Flowing water design", true, "artist-004", new DateTime(2025, 7, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7470), 9.61m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Health Wellness 73", new DateTime(2025, 7, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7466) },
                    { 74, "admin-001", null, null, "artist-004", "artist-004", new DateTime(2025, 6, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7487), "Retro nostalgic design", true, "admin-001", new DateTime(2025, 7, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7488), 2.21m, null, new DateTime(2025, 6, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7485), 1, "Rainbow Colorful 74", new DateTime(2025, 7, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7484) },
                    { 75, "admin-001", null, null, "artist-011", "artist-011", new DateTime(2025, 6, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7505), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 6, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7507), 9.23m, "Does not meet quality standards", new DateTime(2025, 6, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7503), 2, "Typography Quote 75", new DateTime(2025, 6, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7502) },
                    { 76, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 6, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7522), "Intricate mandala pattern", true, "admin-001", new DateTime(2025, 6, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7524), 5.40m, null, new DateTime(2025, 6, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7521), 1, "Sketch Drawing 76", new DateTime(2025, 8, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7519) },
                    { 77, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 7, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7539), "Modern artistic design", true, "admin-001", new DateTime(2025, 7, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7541), 8.57m, null, new DateTime(2025, 6, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7538), 1, "African Culture 77", new DateTime(2025, 8, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7536) },
                    { 78, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 6, 28, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7557), "Botanical nature art", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7558), 3.98m, null, new DateTime(2025, 7, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7555), 1, "Ocean Waves 78", new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7554) },
                    { 79, null, null, null, "artist-002", "artist-002", new DateTime(2025, 6, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7575), "Botanical nature art", true, "artist-002", new DateTime(2025, 6, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7577), 9.97m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Japanese Anime 79", new DateTime(2025, 7, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7573) },
                    { 80, "admin-001", null, null, "artist-019", "artist-019", new DateTime(2025, 8, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7594), "Delicate watercolor art", true, "admin-001", new DateTime(2025, 7, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7596), 3.74m, null, new DateTime(2025, 8, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7592), 1, "Music Band 80", new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7591) },
                    { 81, null, null, null, "artist-016", "artist-016", new DateTime(2025, 6, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7612), "Clean minimalist style", true, "artist-016", new DateTime(2025, 7, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7613), 4.90m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ice Frost 81", new DateTime(2025, 7, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7609) },
                    { 82, "admin-001", null, null, "artist-018", "artist-018", new DateTime(2025, 6, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7628), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 6, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7630), 2.33m, null, new DateTime(2025, 6, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7627), 1, "Political Statement 82", new DateTime(2025, 6, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7625) },
                    { 83, "admin-001", null, null, "artist-005", "artist-005", new DateTime(2025, 6, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7646), "Mathematical patterns", true, "admin-001", new DateTime(2025, 7, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7648), 6.06m, null, new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7644), 1, "Photo Collage 83", new DateTime(2025, 8, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7643) },
                    { 84, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 6, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7667), "Cosmic space theme", true, "admin-001", new DateTime(2025, 7, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7668), 7.36m, null, new DateTime(2025, 6, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7665), 1, "Hand Lettering 84", new DateTime(2025, 8, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7663) },
                    { 85, null, null, null, "artist-015", "artist-015", new DateTime(2025, 6, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7686), "Retro nostalgic design", true, "artist-015", new DateTime(2025, 6, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7688), 8.80m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Holiday Christmas 85", new DateTime(2025, 7, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7684) },
                    { 86, "admin-001", null, null, "artist-005", "artist-005", new DateTime(2025, 6, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7705), "Urban cityscape", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7707), 6.74m, null, new DateTime(2025, 8, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7703), 1, "Botanical Leaves 86", new DateTime(2025, 7, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7702) },
                    { 87, "admin-001", null, null, "artist-004", "artist-004", new DateTime(2025, 8, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7723), "Intricate mandala pattern", true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7724), 7.36m, null, new DateTime(2025, 6, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7721), 1, "Fashion Style 87", new DateTime(2025, 7, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7720) },
                    { 88, "admin-001", null, null, "artist-007", "artist-007", new DateTime(2025, 8, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7740), "Retro nostalgic design", true, "admin-001", new DateTime(2025, 7, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7742), 5.09m, null, new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7738), 1, "Fantasy Theme 88", new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7737) },
                    { 89, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 8, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7759), "Delicate watercolor art", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7760), 4.48m, null, new DateTime(2025, 7, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7757), 1, "Photography 89", new DateTime(2025, 6, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7755) },
                    { 90, "admin-001", null, null, "artist-005", "artist-005", new DateTime(2025, 7, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7778), "Botanical nature art", true, "admin-001", new DateTime(2025, 6, 28, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7779), 3.49m, null, new DateTime(2025, 6, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7776), 1, "Mandala Art 90", new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7775) },
                    { 91, "admin-001", null, null, "artist-002", "artist-002", new DateTime(2025, 8, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7795), "Cosmic space theme", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7796), 4.83m, null, new DateTime(2025, 7, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7793), 1, "Food Cooking 91", new DateTime(2025, 8, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7792) },
                    { 92, "admin-001", null, null, "artist-010", "artist-010", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7811), "Mathematical patterns", true, "admin-001", new DateTime(2025, 6, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7813), 6.22m, null, new DateTime(2025, 6, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7809), 1, "Kids Children 92", new DateTime(2025, 7, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7808) },
                    { 93, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 6, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7828), "Urban cityscape", true, "admin-001", new DateTime(2025, 6, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7830), 3.09m, null, new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7827), 1, "Forest Wildlife 93", new DateTime(2025, 7, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7825) },
                    { 94, "admin-001", null, null, "artist-003", "artist-003", new DateTime(2025, 8, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7848), "Intricate mandala pattern", true, "admin-001", new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7849), 5.34m, null, new DateTime(2025, 6, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7846), 1, "Business Professional 94", new DateTime(2025, 6, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7844) },
                    { 95, "admin-001", null, null, "artist-003", "artist-003", new DateTime(2025, 6, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7893), "Delicate watercolor art", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7895), 7.84m, null, new DateTime(2025, 6, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7892), 1, "Art History 95", new DateTime(2025, 8, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7890) },
                    { 96, "admin-001", null, null, "artist-013", "artist-013", new DateTime(2025, 7, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7993), "Natural scenery art", true, "admin-001", new DateTime(2025, 6, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7994), 8.35m, null, new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7991), 1, "Steampunk Gear 96", new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(7989) },
                    { 97, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 7, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8010), "Realistic animal art", true, "admin-001", new DateTime(2025, 7, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8011), 8.82m, null, new DateTime(2025, 8, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8008), 1, "Watercolor Flowers 97", new DateTime(2025, 7, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8006) },
                    { 98, "admin-001", null, null, "artist-013", "artist-013", new DateTime(2025, 8, 3, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8029), "Modern artistic design", true, "admin-001", new DateTime(2025, 7, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8031), 5.71m, "Does not meet quality standards", new DateTime(2025, 6, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8027), 2, "Religious Spiritual 98", new DateTime(2025, 6, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8026) },
                    { 99, null, null, null, "artist-006", "artist-006", new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8046), "Classic vintage pattern", true, "artist-006", new DateTime(2025, 8, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8048), 4.87m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Forest Green 99", new DateTime(2025, 6, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8044) },
                    { 100, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 6, 28, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8068), "Natural scenery art", true, "admin-001", new DateTime(2025, 6, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8069), 2.58m, null, new DateTime(2025, 7, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8066), 1, "Street Art 100", new DateTime(2025, 8, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8064) },
                    { 101, "admin-001", null, null, "artist-007", "artist-007", new DateTime(2025, 6, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8085), "Cute and adorable illustration", true, "admin-001", new DateTime(2025, 6, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8086), 3.50m, null, new DateTime(2025, 8, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8083), 1, "Royal Purple 101", new DateTime(2025, 7, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8082) },
                    { 102, "admin-001", null, null, "artist-001", "artist-001", new DateTime(2025, 8, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8101), "Musical themed design", true, "admin-001", new DateTime(2025, 7, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8103), 2.22m, null, new DateTime(2025, 7, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8100), 1, "Halloween Spooky 102", new DateTime(2025, 6, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8098) },
                    { 103, "admin-001", null, null, "artist-011", "artist-011", new DateTime(2025, 5, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8119), "Intricate mandala pattern", true, "admin-001", new DateTime(2025, 6, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8121), 2.48m, null, new DateTime(2025, 8, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8118), 1, "Cyberpunk Neon 103", new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8116) },
                    { 104, "admin-001", null, null, "artist-008", "artist-008", new DateTime(2025, 7, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8140), "Intricate mandala pattern", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8141), 5.44m, null, new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8138), 1, "Sports Team 104", new DateTime(2025, 6, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8136) },
                    { 105, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 6, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8158), "Adventure travel art", true, "admin-001", new DateTime(2025, 6, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8159), 8.13m, null, new DateTime(2025, 7, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8156), 1, "Sunset Orange 105", new DateTime(2025, 7, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8154) },
                    { 106, "admin-001", null, null, "artist-015", "artist-015", new DateTime(2025, 8, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8174), "Delicate watercolor art", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8176), 3.63m, null, new DateTime(2025, 7, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8173), 1, "Asian Zen 106", new DateTime(2025, 8, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8171) },
                    { 107, "admin-001", null, null, "artist-020", "artist-020", new DateTime(2025, 6, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8191), "Flowing water design", true, "admin-001", new DateTime(2025, 7, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8192), 2.09m, null, new DateTime(2025, 6, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8189), 1, "Rainbow Colorful 107", new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8188) },
                    { 108, "admin-001", null, null, "artist-010", "artist-010", new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8208), "Natural scenery art", true, "admin-001", new DateTime(2025, 6, 11, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8209), 2.02m, null, new DateTime(2025, 7, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8205), 1, "Fire Flame 108", new DateTime(2025, 7, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8204) },
                    { 109, "admin-001", null, null, "artist-016", "artist-016", new DateTime(2025, 7, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8227), "Intricate mandala pattern", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8229), 9.68m, null, new DateTime(2025, 7, 23, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8225), 1, "Japanese Anime 109", new DateTime(2025, 7, 31, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8224) },
                    { 110, "admin-001", null, null, "artist-020", "artist-020", new DateTime(2025, 6, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8246), "Clean minimalist style", true, "admin-001", new DateTime(2025, 7, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8247), 2.09m, null, new DateTime(2025, 7, 2, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8244), 1, "Digital Art 110", new DateTime(2025, 7, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8242) },
                    { 111, "admin-001", null, null, "artist-009", "artist-009", new DateTime(2025, 8, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8263), "Urban cityscape", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8264), 2.63m, null, new DateTime(2025, 6, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8261), 1, "Geometric Patterns 111", new DateTime(2025, 8, 25, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8260) },
                    { 112, "admin-001", null, null, "artist-019", "artist-019", new DateTime(2025, 6, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8280), "Classic vintage pattern", true, "admin-001", new DateTime(2025, 7, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8281), 8.39m, null, new DateTime(2025, 8, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8278), 1, "Garden Botanical 112", new DateTime(2025, 7, 22, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8276) },
                    { 113, "admin-001", null, null, "artist-009", "artist-009", new DateTime(2025, 6, 9, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8298), "Natural scenery art", true, "admin-001", new DateTime(2025, 6, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8299), 3.80m, null, new DateTime(2025, 6, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8296), 1, "Pastel Soft 113", new DateTime(2025, 7, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8294) },
                    { 114, "admin-001", null, null, "artist-006", "artist-006", new DateTime(2025, 8, 12, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8315), "Urban cityscape", true, "admin-001", new DateTime(2025, 6, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8316), 9.23m, null, new DateTime(2025, 6, 10, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8313), 1, "Environment Green 114", new DateTime(2025, 8, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8312) },
                    { 115, null, null, null, "artist-016", "artist-016", new DateTime(2025, 7, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8335), "Flowing water design", true, "artist-016", new DateTime(2025, 8, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8337), 9.40m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Japanese Anime 115", new DateTime(2025, 8, 18, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8333) },
                    { 116, "admin-001", null, null, "artist-013", "artist-013", new DateTime(2025, 8, 5, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8354), "Realistic animal art", true, "admin-001", new DateTime(2025, 7, 17, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8356), 3.58m, null, new DateTime(2025, 6, 20, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8353), 1, "Inspirational Quote 116", new DateTime(2025, 7, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8351) },
                    { 117, "admin-001", null, null, "artist-016", "artist-016", new DateTime(2025, 7, 1, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8409), "Motivational text design", true, "admin-001", new DateTime(2025, 6, 14, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8410), 8.36m, null, new DateTime(2025, 8, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8406), 1, "Medieval Historical 117", new DateTime(2025, 8, 7, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8404) },
                    { 118, "admin-001", null, null, "artist-014", "artist-014", new DateTime(2025, 7, 24, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8432), "Natural scenery art", true, "admin-001", new DateTime(2025, 7, 8, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8433), 4.51m, null, new DateTime(2025, 7, 13, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8430), 1, "Street Art 118", new DateTime(2025, 6, 29, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8428) },
                    { 119, "admin-001", null, null, "artist-020", "artist-020", new DateTime(2025, 8, 4, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8450), "Adventure travel art", true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8451), 6.04m, null, new DateTime(2025, 7, 21, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8448), 1, "Gothic Dark 119", new DateTime(2025, 6, 19, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8446) },
                    { 120, "admin-001", null, null, "artist-012", "artist-012", new DateTime(2025, 8, 16, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8468), "Classic vintage pattern", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8469), 8.90m, null, new DateTime(2025, 7, 6, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8466), 1, "Ice Frost 120", new DateTime(2025, 6, 27, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(8464) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "CustomerId", "LastModifiedBy", "LastModifiedOn", "ShippingAddress", "ShippingCity", "ShippingCountry", "ShippingPostalCode", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "customer-019", new DateTime(2025, 3, 10, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(176), "customer-019", "customer-019", new DateTime(2025, 3, 11, 18, 35, 45, 766, DateTimeKind.Utc).AddTicks(176), "808 Pine Rd", "Philadelphia", "United Kingdom", "66240", 0, 0m },
                    { 2, "customer-020", new DateTime(2025, 7, 5, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(271), "customer-020", "customer-020", new DateTime(2025, 7, 6, 9, 35, 45, 766, DateTimeKind.Utc).AddTicks(271), "456 Pine Rd", "Chicago", "Germany", "82096", 2, 0m },
                    { 3, "customer-022", new DateTime(2025, 8, 2, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(294), "customer-022", "customer-022", new DateTime(2025, 8, 4, 7, 35, 45, 766, DateTimeKind.Utc).AddTicks(294), "944 Second Ave", "New York", "Australia", "15949", 2, 0m },
                    { 4, "customer-021", new DateTime(2025, 5, 31, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(313), "customer-021", "customer-021", new DateTime(2025, 5, 31, 18, 35, 45, 766, DateTimeKind.Utc).AddTicks(313), "995 Cedar Way", "New York", "United States", "52492", 3, 0m },
                    { 5, "customer-017", new DateTime(2025, 7, 21, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(331), "customer-017", "customer-017", new DateTime(2025, 7, 22, 20, 35, 45, 766, DateTimeKind.Utc).AddTicks(331), "273 Maple Ln", "Chicago", "Australia", "39185", 2, 0m },
                    { 6, "customer-017", new DateTime(2025, 7, 17, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(349), "customer-017", "customer-017", new DateTime(2025, 7, 17, 16, 35, 45, 766, DateTimeKind.Utc).AddTicks(349), "767 Pine Rd", "Phoenix", "Germany", "68553", 0, 0m },
                    { 7, "customer-007", new DateTime(2025, 4, 24, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(366), "customer-007", "customer-007", new DateTime(2025, 4, 24, 22, 35, 45, 766, DateTimeKind.Utc).AddTicks(366), "125 Oak Ave", "Los Angeles", "Australia", "85481", 0, 0m },
                    { 8, "customer-029", new DateTime(2025, 4, 29, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(383), "customer-029", "customer-029", new DateTime(2025, 4, 30, 20, 35, 45, 766, DateTimeKind.Utc).AddTicks(383), "443 Elm Dr", "San Diego", "United States", "43784", 3, 0m },
                    { 9, "customer-029", new DateTime(2025, 5, 23, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(398), "customer-029", "customer-029", new DateTime(2025, 5, 25, 7, 35, 45, 766, DateTimeKind.Utc).AddTicks(398), "363 Pine Rd", "Philadelphia", "United Kingdom", "14822", 3, 0m },
                    { 10, "customer-022", new DateTime(2025, 3, 11, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(417), "customer-022", "customer-022", new DateTime(2025, 3, 13, 4, 35, 45, 766, DateTimeKind.Utc).AddTicks(417), "245 Main St", "San Jose", "United States", "82876", 1, 0m },
                    { 11, "customer-029", new DateTime(2025, 5, 24, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(435), "customer-029", "customer-029", new DateTime(2025, 5, 25, 23, 35, 45, 766, DateTimeKind.Utc).AddTicks(435), "324 Maple Ln", "Philadelphia", "United States", "78247", 0, 0m },
                    { 12, "customer-028", new DateTime(2025, 7, 26, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(451), "customer-028", "customer-028", new DateTime(2025, 7, 26, 21, 35, 45, 766, DateTimeKind.Utc).AddTicks(451), "437 Cedar Way", "Dallas", "Germany", "11584", 4, 0m },
                    { 13, "customer-010", new DateTime(2025, 3, 12, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(471), "customer-010", "customer-010", new DateTime(2025, 3, 14, 10, 35, 45, 766, DateTimeKind.Utc).AddTicks(471), "649 Park Blvd", "Los Angeles", "Canada", "11061", 2, 0m },
                    { 14, "customer-028", new DateTime(2025, 4, 9, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(491), "customer-028", "customer-028", new DateTime(2025, 4, 11, 8, 35, 45, 766, DateTimeKind.Utc).AddTicks(491), "767 Elm Dr", "Philadelphia", "Germany", "32803", 3, 0m },
                    { 15, "customer-018", new DateTime(2025, 4, 22, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(508), "customer-018", "customer-018", new DateTime(2025, 4, 24, 9, 35, 45, 766, DateTimeKind.Utc).AddTicks(508), "193 Oak Ave", "Phoenix", "Germany", "53779", 0, 0m },
                    { 16, "customer-030", new DateTime(2025, 6, 23, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(525), "customer-030", "customer-030", new DateTime(2025, 6, 25, 9, 35, 45, 766, DateTimeKind.Utc).AddTicks(525), "407 Pine Rd", "New York", "Germany", "72603", 1, 0m },
                    { 17, "customer-011", new DateTime(2025, 6, 27, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(543), "customer-011", "customer-011", new DateTime(2025, 6, 29, 14, 35, 45, 766, DateTimeKind.Utc).AddTicks(543), "901 Third Dr", "Phoenix", "Australia", "28402", 4, 0m },
                    { 18, "customer-001", new DateTime(2025, 7, 24, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(566), "customer-001", "customer-001", new DateTime(2025, 7, 25, 6, 35, 45, 766, DateTimeKind.Utc).AddTicks(566), "373 Maple Ln", "Chicago", "United States", "35746", 3, 0m },
                    { 19, "customer-002", new DateTime(2025, 7, 19, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(584), "customer-002", "customer-002", new DateTime(2025, 7, 20, 22, 35, 45, 766, DateTimeKind.Utc).AddTicks(584), "959 First St", "Los Angeles", "Canada", "40113", 3, 0m },
                    { 20, "customer-016", new DateTime(2025, 5, 15, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(603), "customer-016", "customer-016", new DateTime(2025, 5, 17, 11, 35, 45, 766, DateTimeKind.Utc).AddTicks(603), "660 Third Dr", "San Antonio", "Australia", "65021", 2, 0m },
                    { 21, "customer-029", new DateTime(2025, 4, 24, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(621), "customer-029", "customer-029", new DateTime(2025, 4, 25, 6, 35, 45, 766, DateTimeKind.Utc).AddTicks(621), "676 Maple Ln", "San Jose", "United Kingdom", "82802", 3, 0m },
                    { 22, "customer-003", new DateTime(2025, 4, 24, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(638), "customer-003", "customer-003", new DateTime(2025, 4, 25, 14, 35, 45, 766, DateTimeKind.Utc).AddTicks(638), "184 Elm Dr", "New York", "Australia", "80116", 4, 0m },
                    { 23, "customer-004", new DateTime(2025, 6, 18, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(654), "customer-004", "customer-004", new DateTime(2025, 6, 19, 21, 35, 45, 766, DateTimeKind.Utc).AddTicks(654), "801 Park Blvd", "Philadelphia", "Australia", "25322", 2, 0m },
                    { 24, "customer-016", new DateTime(2025, 6, 14, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(700), "customer-016", "customer-016", new DateTime(2025, 6, 15, 19, 35, 45, 766, DateTimeKind.Utc).AddTicks(700), "207 Park Blvd", "Dallas", "Canada", "17942", 1, 0m },
                    { 25, "customer-017", new DateTime(2025, 6, 14, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(719), "customer-017", "customer-017", new DateTime(2025, 6, 15, 22, 35, 45, 766, DateTimeKind.Utc).AddTicks(719), "812 Maple Ln", "San Jose", "Germany", "24504", 3, 0m },
                    { 26, "customer-022", new DateTime(2025, 6, 10, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(737), "customer-022", "customer-022", new DateTime(2025, 6, 11, 2, 35, 45, 766, DateTimeKind.Utc).AddTicks(737), "527 Third Dr", "Los Angeles", "United States", "60065", 1, 0m },
                    { 27, "customer-011", new DateTime(2025, 7, 27, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(754), "customer-011", "customer-011", new DateTime(2025, 7, 28, 10, 35, 45, 766, DateTimeKind.Utc).AddTicks(754), "270 Second Ave", "Chicago", "Canada", "99882", 0, 0m },
                    { 28, "customer-002", new DateTime(2025, 3, 6, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(771), "customer-002", "customer-002", new DateTime(2025, 3, 7, 9, 35, 45, 766, DateTimeKind.Utc).AddTicks(771), "205 First St", "Chicago", "United Kingdom", "23937", 0, 0m },
                    { 29, "customer-021", new DateTime(2025, 6, 28, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(792), "customer-021", "customer-021", new DateTime(2025, 6, 30, 3, 35, 45, 766, DateTimeKind.Utc).AddTicks(792), "637 Third Dr", "Phoenix", "Germany", "15296", 4, 0m },
                    { 30, "customer-012", new DateTime(2025, 8, 21, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(811), "customer-012", "customer-012", new DateTime(2025, 8, 23, 11, 35, 45, 766, DateTimeKind.Utc).AddTicks(811), "211 Third Dr", "New York", "United Kingdom", "10997", 2, 0m },
                    { 31, "customer-017", new DateTime(2025, 6, 24, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(858), "customer-017", "customer-017", new DateTime(2025, 6, 25, 1, 35, 45, 766, DateTimeKind.Utc).AddTicks(858), "592 Maple Ln", "Phoenix", "United Kingdom", "80908", 2, 0m },
                    { 32, "customer-018", new DateTime(2025, 5, 9, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(878), "customer-018", "customer-018", new DateTime(2025, 5, 10, 2, 35, 45, 766, DateTimeKind.Utc).AddTicks(878), "136 Main St", "San Diego", "Australia", "54680", 3, 0m },
                    { 33, "customer-010", new DateTime(2025, 4, 11, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(897), "customer-010", "customer-010", new DateTime(2025, 4, 13, 13, 35, 45, 766, DateTimeKind.Utc).AddTicks(897), "603 Pine Rd", "Dallas", "United Kingdom", "97346", 1, 0m },
                    { 34, "customer-028", new DateTime(2025, 3, 15, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(918), "customer-028", "customer-028", new DateTime(2025, 3, 17, 5, 35, 45, 766, DateTimeKind.Utc).AddTicks(918), "986 Cedar Way", "San Diego", "Canada", "87747", 0, 0m },
                    { 35, "customer-025", new DateTime(2025, 7, 30, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(936), "customer-025", "customer-025", new DateTime(2025, 7, 31, 13, 35, 45, 766, DateTimeKind.Utc).AddTicks(936), "525 Main St", "Los Angeles", "Canada", "41893", 4, 0m },
                    { 36, "customer-002", new DateTime(2025, 6, 28, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(955), "customer-002", "customer-002", new DateTime(2025, 6, 29, 3, 35, 45, 766, DateTimeKind.Utc).AddTicks(955), "730 Elm Dr", "Phoenix", "Germany", "35587", 4, 0m },
                    { 37, "customer-022", new DateTime(2025, 3, 2, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(971), "customer-022", "customer-022", new DateTime(2025, 3, 4, 9, 35, 45, 766, DateTimeKind.Utc).AddTicks(971), "768 Main St", "Phoenix", "United Kingdom", "67229", 0, 0m },
                    { 38, "customer-005", new DateTime(2025, 5, 10, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(987), "customer-005", "customer-005", new DateTime(2025, 5, 11, 8, 35, 45, 766, DateTimeKind.Utc).AddTicks(987), "992 First St", "Chicago", "Germany", "93897", 0, 0m },
                    { 39, "customer-011", new DateTime(2025, 3, 30, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1005), "customer-011", "customer-011", new DateTime(2025, 3, 31, 22, 35, 45, 766, DateTimeKind.Utc).AddTicks(1005), "135 Pine Rd", "Dallas", "Canada", "51231", 3, 0m },
                    { 40, "customer-001", new DateTime(2025, 7, 17, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1019), "customer-001", "customer-001", new DateTime(2025, 7, 19, 9, 35, 45, 766, DateTimeKind.Utc).AddTicks(1019), "643 Oak Ave", "Chicago", "United Kingdom", "61956", 2, 0m },
                    { 41, "customer-022", new DateTime(2025, 8, 10, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1036), "customer-022", "customer-022", new DateTime(2025, 8, 12, 3, 35, 45, 766, DateTimeKind.Utc).AddTicks(1036), "446 Third Dr", "Phoenix", "Canada", "21568", 0, 0m },
                    { 42, "customer-012", new DateTime(2025, 8, 17, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1055), "customer-012", "customer-012", new DateTime(2025, 8, 18, 13, 35, 45, 766, DateTimeKind.Utc).AddTicks(1055), "786 First St", "Phoenix", "United States", "53405", 2, 0m },
                    { 43, "customer-016", new DateTime(2025, 4, 26, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1072), "customer-016", "customer-016", new DateTime(2025, 4, 27, 11, 35, 45, 766, DateTimeKind.Utc).AddTicks(1072), "288 Elm Dr", "Philadelphia", "Germany", "52892", 3, 0m },
                    { 44, "customer-010", new DateTime(2025, 5, 18, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1090), "customer-010", "customer-010", new DateTime(2025, 5, 20, 7, 35, 45, 766, DateTimeKind.Utc).AddTicks(1090), "840 Cedar Way", "Los Angeles", "Canada", "33926", 2, 0m },
                    { 45, "customer-008", new DateTime(2025, 3, 4, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1107), "customer-008", "customer-008", new DateTime(2025, 3, 5, 11, 35, 45, 766, DateTimeKind.Utc).AddTicks(1107), "390 First St", "Los Angeles", "United States", "96933", 4, 0m },
                    { 46, "customer-002", new DateTime(2025, 7, 13, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1124), "customer-002", "customer-002", new DateTime(2025, 7, 15, 10, 35, 45, 766, DateTimeKind.Utc).AddTicks(1124), "213 Cedar Way", "San Antonio", "Australia", "94405", 2, 0m },
                    { 47, "customer-005", new DateTime(2025, 5, 29, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1141), "customer-005", "customer-005", new DateTime(2025, 5, 30, 18, 35, 45, 766, DateTimeKind.Utc).AddTicks(1141), "556 Cedar Way", "Philadelphia", "Germany", "97553", 3, 0m },
                    { 48, "customer-009", new DateTime(2025, 5, 18, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1159), "customer-009", "customer-009", new DateTime(2025, 5, 19, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1159), "471 Maple Ln", "Phoenix", "United Kingdom", "84696", 2, 0m },
                    { 49, "customer-019", new DateTime(2025, 7, 20, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1209), "customer-019", "customer-019", new DateTime(2025, 7, 21, 2, 35, 45, 766, DateTimeKind.Utc).AddTicks(1209), "618 Main St", "Phoenix", "United States", "79837", 4, 0m },
                    { 50, "customer-028", new DateTime(2025, 7, 22, 15, 35, 45, 766, DateTimeKind.Utc).AddTicks(1227), "customer-028", "customer-028", new DateTime(2025, 7, 24, 4, 35, 45, 766, DateTimeKind.Utc).AddTicks(1227), "816 Main St", "Philadelphia", "Canada", "25087", 0, 0m }
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "BasePrice", "CategoryId", "CreatedBy", "CreatedOn", "Description", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, 19.99m, 9, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(4455), "100% cotton classic fit", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(4457), "Classic T-Shirt" },
                    { 2, 24.99m, 9, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(4462), "Premium soft cotton blend", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(4463), "Premium T-Shirt" },
                    { 3, 22.99m, 9, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(4467), "Slim fit cotton t-shirt", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(4468), "Fitted T-Shirt" },
                    { 4, 39.99m, 12, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5143), "Cotton blend pullover hoodie", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5144), "Pullover Hoodie" },
                    { 5, 44.99m, 13, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5148), "Full zip cotton hoodie", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5149), "Zip Hoodie" },
                    { 6, 14.99m, 30, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5164), "Protective iPhone 14 case", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5166), "iPhone 14 Case" },
                    { 7, 16.99m, 30, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5169), "Protective iPhone 15 case", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5170), "iPhone 15 Case" },
                    { 8, 15.99m, 31, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5173), "Samsung Galaxy S24 case", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5174), "Samsung S24 Case" },
                    { 9, 12.99m, 22, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5182), "11oz ceramic coffee mug", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5184), "Ceramic Mug" },
                    { 10, 18.99m, 23, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5187), "15oz insulated travel mug", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5188), "Travel Mug" },
                    { 13, 19.99m, 25, "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5200), "16x16 inch throw pillow", "admin-001", new DateTime(2025, 8, 26, 15, 35, 45, 761, DateTimeKind.Utc).AddTicks(5202), "Throw Pillow" }
                });

            migrationBuilder.InsertData(
                table: "DesignImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "DsignId", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { 1, "Design artwork 1", "artist-020", new DateTime(2025, 6, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6396), 1, "design_1.jpg", "https://picsum.photos/seed/design46/800/600", true, true, "artist-020", new DateTime(2025, 6, 14, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6411) },
                    { 2, "Design artwork 2", "artist-015", new DateTime(2025, 8, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6479), 2, "design_2.jpg", "https://picsum.photos/seed/design3/800/600", true, true, "artist-015", new DateTime(2025, 8, 12, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6480) },
                    { 3, "Design artwork 3", "artist-004", new DateTime(2025, 6, 6, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6492), 3, "design_3.jpg", "https://picsum.photos/seed/design32/800/600", true, true, "artist-004", new DateTime(2025, 7, 12, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6493) },
                    { 4, "Design artwork 4", "artist-004", new DateTime(2025, 8, 18, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6503), 4, "design_4.jpg", "https://picsum.photos/seed/design24/800/600", true, true, "artist-004", new DateTime(2025, 6, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6505) },
                    { 5, "Design artwork 5", "artist-012", new DateTime(2025, 8, 25, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6515), 5, "design_5.jpg", "https://picsum.photos/seed/design13/800/600", true, true, "artist-012", new DateTime(2025, 6, 3, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6516) },
                    { 6, "Design artwork 6", "artist-004", new DateTime(2025, 6, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6530), 6, "design_6.jpg", "https://picsum.photos/seed/design2/800/600", true, true, "artist-004", new DateTime(2025, 8, 25, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6531) },
                    { 7, "Design artwork 7", "artist-016", new DateTime(2025, 6, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6539), 7, "design_7.jpg", "https://picsum.photos/seed/design32/800/600", true, true, "artist-016", new DateTime(2025, 6, 6, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6541) },
                    { 8, "Design artwork 8", "artist-011", new DateTime(2025, 7, 3, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6549), 8, "design_8.jpg", "https://picsum.photos/seed/design8/800/600", true, true, "artist-011", new DateTime(2025, 6, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6550) },
                    { 9, "Design artwork 9", "artist-016", new DateTime(2025, 7, 4, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6559), 9, "design_9.jpg", "https://picsum.photos/seed/design4/800/600", true, true, "artist-016", new DateTime(2025, 8, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6560) },
                    { 10, "Design artwork 10", "artist-019", new DateTime(2025, 7, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6575), 10, "design_10.jpg", "https://picsum.photos/seed/design11/800/600", true, true, "artist-019", new DateTime(2025, 6, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6576) },
                    { 11, "Design artwork 11", "artist-019", new DateTime(2025, 7, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6587), 11, "design_11.jpg", "https://picsum.photos/seed/design45/800/600", true, true, "artist-019", new DateTime(2025, 8, 8, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6589) },
                    { 12, "Design artwork 12", "artist-016", new DateTime(2025, 8, 9, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6598), 12, "design_12.jpg", "https://picsum.photos/seed/design6/800/600", true, true, "artist-016", new DateTime(2025, 7, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6599) },
                    { 13, "Design artwork 13", "artist-004", new DateTime(2025, 6, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6608), 13, "design_13.jpg", "https://picsum.photos/seed/design24/800/600", true, true, "artist-004", new DateTime(2025, 8, 12, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6610) },
                    { 14, "Design artwork 14", "artist-001", new DateTime(2025, 6, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6619), 14, "design_14.jpg", "https://picsum.photos/seed/design28/800/600", true, true, "artist-001", new DateTime(2025, 6, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6620) },
                    { 15, "Design artwork 15", "artist-003", new DateTime(2025, 8, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6629), 15, "design_15.jpg", "https://picsum.photos/seed/design38/800/600", true, true, "artist-003", new DateTime(2025, 8, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6630) },
                    { 16, "Design artwork 16", "artist-008", new DateTime(2025, 7, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6638), 16, "design_16.jpg", "https://picsum.photos/seed/design6/800/600", true, true, "artist-008", new DateTime(2025, 8, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6639) },
                    { 17, "Design artwork 17", "artist-001", new DateTime(2025, 6, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6667), 17, "design_17.jpg", "https://picsum.photos/seed/design3/800/600", true, true, "artist-001", new DateTime(2025, 8, 15, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6669) },
                    { 18, "Design artwork 18", "artist-018", new DateTime(2025, 6, 4, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6682), 18, "design_18.jpg", "https://picsum.photos/seed/design50/800/600", true, true, "artist-018", new DateTime(2025, 7, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6684) },
                    { 19, "Design artwork 19", "artist-017", new DateTime(2025, 8, 25, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6693), 19, "design_19.jpg", "https://picsum.photos/seed/design11/800/600", true, true, "artist-017", new DateTime(2025, 8, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6695) },
                    { 20, "Design artwork 20", "artist-011", new DateTime(2025, 8, 4, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6705), 20, "design_20.jpg", "https://picsum.photos/seed/design30/800/600", true, true, "artist-011", new DateTime(2025, 6, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6706) },
                    { 21, "Design artwork 21", "artist-010", new DateTime(2025, 6, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6716), 21, "design_21.jpg", "https://picsum.photos/seed/design16/800/600", true, true, "artist-010", new DateTime(2025, 8, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6718) },
                    { 22, "Design artwork 22", "artist-009", new DateTime(2025, 6, 12, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6728), 22, "design_22.jpg", "https://picsum.photos/seed/design23/800/600", true, true, "artist-009", new DateTime(2025, 8, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6729) },
                    { 23, "Design artwork 23", "artist-005", new DateTime(2025, 6, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6738), 23, "design_23.jpg", "https://picsum.photos/seed/design32/800/600", true, true, "artist-005", new DateTime(2025, 8, 10, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6739) },
                    { 24, "Design artwork 24", "artist-003", new DateTime(2025, 7, 18, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6748), 24, "design_24.jpg", "https://picsum.photos/seed/design16/800/600", true, true, "artist-003", new DateTime(2025, 6, 14, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6750) },
                    { 25, "Design artwork 25", "artist-006", new DateTime(2025, 8, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6759), 25, "design_25.jpg", "https://picsum.photos/seed/design22/800/600", true, true, "artist-006", new DateTime(2025, 6, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6760) },
                    { 26, "Design artwork 26", "artist-008", new DateTime(2025, 7, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6769), 26, "design_26.jpg", "https://picsum.photos/seed/design4/800/600", true, true, "artist-008", new DateTime(2025, 8, 10, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6771) },
                    { 27, "Design artwork 27", "artist-011", new DateTime(2025, 7, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6782), 27, "design_27.jpg", "https://picsum.photos/seed/design17/800/600", true, true, "artist-011", new DateTime(2025, 6, 15, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6783) },
                    { 28, "Design artwork 28", "artist-011", new DateTime(2025, 7, 18, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6792), 28, "design_28.jpg", "https://picsum.photos/seed/design28/800/600", true, true, "artist-011", new DateTime(2025, 7, 8, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6793) },
                    { 29, "Design artwork 29", "artist-010", new DateTime(2025, 6, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6802), 29, "design_29.jpg", "https://picsum.photos/seed/design21/800/600", true, true, "artist-010", new DateTime(2025, 8, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6803) },
                    { 30, "Design artwork 30", "artist-008", new DateTime(2025, 7, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6812), 30, "design_30.jpg", "https://picsum.photos/seed/design30/800/600", true, true, "artist-008", new DateTime(2025, 7, 4, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6813) },
                    { 31, "Design artwork 31", "artist-005", new DateTime(2025, 6, 9, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6821), 31, "design_31.jpg", "https://picsum.photos/seed/design27/800/600", true, true, "artist-005", new DateTime(2025, 8, 4, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6823) },
                    { 32, "Design artwork 32", "artist-001", new DateTime(2025, 8, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6832), 32, "design_32.jpg", "https://picsum.photos/seed/design38/800/600", true, true, "artist-001", new DateTime(2025, 7, 8, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6833) },
                    { 33, "Design artwork 33", "artist-016", new DateTime(2025, 8, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6842), 33, "design_33.jpg", "https://picsum.photos/seed/design10/800/600", true, true, "artist-016", new DateTime(2025, 8, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6844) },
                    { 34, "Design artwork 34", "artist-009", new DateTime(2025, 8, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6856), 34, "design_34.jpg", "https://picsum.photos/seed/design28/800/600", true, true, "artist-009", new DateTime(2025, 7, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6857) },
                    { 35, "Design artwork 35", "artist-016", new DateTime(2025, 7, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6868), 35, "design_35.jpg", "https://picsum.photos/seed/design28/800/600", true, true, "artist-016", new DateTime(2025, 8, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6869) },
                    { 36, "Design artwork 36", "artist-003", new DateTime(2025, 6, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6878), 36, "design_36.jpg", "https://picsum.photos/seed/design2/800/600", true, true, "artist-003", new DateTime(2025, 6, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6879) },
                    { 37, "Design artwork 37", "artist-005", new DateTime(2025, 6, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6888), 37, "design_37.jpg", "https://picsum.photos/seed/design22/800/600", true, true, "artist-005", new DateTime(2025, 6, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6890) },
                    { 38, "Design artwork 38", "artist-014", new DateTime(2025, 7, 18, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6899), 38, "design_38.jpg", "https://picsum.photos/seed/design19/800/600", true, true, "artist-014", new DateTime(2025, 6, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6900) },
                    { 39, "Design artwork 39", "artist-017", new DateTime(2025, 7, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6909), 39, "design_39.jpg", "https://picsum.photos/seed/design29/800/600", true, true, "artist-017", new DateTime(2025, 6, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6911) },
                    { 40, "Design artwork 40", "artist-004", new DateTime(2025, 8, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6919), 40, "design_40.jpg", "https://picsum.photos/seed/design14/800/600", true, true, "artist-004", new DateTime(2025, 6, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6921) },
                    { 41, "Design artwork 41", "artist-003", new DateTime(2025, 8, 23, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6930), 41, "design_41.jpg", "https://picsum.photos/seed/design39/800/600", true, true, "artist-003", new DateTime(2025, 7, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6931) },
                    { 42, "Design artwork 42", "artist-011", new DateTime(2025, 8, 15, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6962), 42, "design_42.jpg", "https://picsum.photos/seed/design17/800/600", true, true, "artist-011", new DateTime(2025, 6, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6964) },
                    { 43, "Design artwork 43", "artist-004", new DateTime(2025, 8, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6973), 43, "design_43.jpg", "https://picsum.photos/seed/design14/800/600", true, true, "artist-004", new DateTime(2025, 6, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6975) },
                    { 44, "Design artwork 44", "artist-002", new DateTime(2025, 7, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6985), 44, "design_44.jpg", "https://picsum.photos/seed/design26/800/600", true, true, "artist-002", new DateTime(2025, 8, 10, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6986) },
                    { 45, "Design artwork 45", "artist-018", new DateTime(2025, 8, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6995), 45, "design_45.jpg", "https://picsum.photos/seed/design9/800/600", true, true, "artist-018", new DateTime(2025, 7, 3, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(6996) },
                    { 46, "Design artwork 46", "artist-002", new DateTime(2025, 6, 8, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7005), 46, "design_46.jpg", "https://picsum.photos/seed/design25/800/600", true, true, "artist-002", new DateTime(2025, 7, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7007) },
                    { 47, "Design artwork 47", "artist-016", new DateTime(2025, 8, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7015), 47, "design_47.jpg", "https://picsum.photos/seed/design17/800/600", true, true, "artist-016", new DateTime(2025, 6, 10, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7017) },
                    { 48, "Design artwork 48", "artist-002", new DateTime(2025, 8, 9, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7026), 48, "design_48.jpg", "https://picsum.photos/seed/design21/800/600", true, true, "artist-002", new DateTime(2025, 7, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7027) },
                    { 49, "Design artwork 49", "artist-009", new DateTime(2025, 5, 31, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7037), 49, "design_49.jpg", "https://picsum.photos/seed/design35/800/600", true, true, "artist-009", new DateTime(2025, 7, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7038) },
                    { 50, "Design artwork 50", "artist-001", new DateTime(2025, 8, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7046), 50, "design_50.jpg", "https://picsum.photos/seed/design17/800/600", true, true, "artist-001", new DateTime(2025, 6, 9, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7048) },
                    { 51, "Design artwork 51", "artist-007", new DateTime(2025, 7, 5, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7056), 51, "design_51.jpg", "https://picsum.photos/seed/design37/800/600", true, true, "artist-007", new DateTime(2025, 7, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7058) },
                    { 52, "Design artwork 52", "artist-002", new DateTime(2025, 7, 5, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7067), 52, "design_52.jpg", "https://picsum.photos/seed/design31/800/600", true, true, "artist-002", new DateTime(2025, 7, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7068) },
                    { 53, "Design artwork 53", "artist-003", new DateTime(2025, 8, 25, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7077), 53, "design_53.jpg", "https://picsum.photos/seed/design16/800/600", true, true, "artist-003", new DateTime(2025, 8, 23, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7078) },
                    { 54, "Design artwork 54", "artist-005", new DateTime(2025, 6, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7087), 54, "design_54.jpg", "https://picsum.photos/seed/design29/800/600", true, true, "artist-005", new DateTime(2025, 6, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7088) },
                    { 55, "Design artwork 55", "artist-018", new DateTime(2025, 7, 5, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7097), 55, "design_55.jpg", "https://picsum.photos/seed/design32/800/600", true, true, "artist-018", new DateTime(2025, 8, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7099) },
                    { 56, "Design artwork 56", "artist-002", new DateTime(2025, 6, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7109), 56, "design_56.jpg", "https://picsum.photos/seed/design13/800/600", true, true, "artist-002", new DateTime(2025, 6, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7110) },
                    { 57, "Design artwork 57", "artist-002", new DateTime(2025, 7, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7119), 57, "design_57.jpg", "https://picsum.photos/seed/design39/800/600", true, true, "artist-002", new DateTime(2025, 7, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7121) },
                    { 58, "Design artwork 58", "artist-011", new DateTime(2025, 8, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7129), 58, "design_58.jpg", "https://picsum.photos/seed/design5/800/600", true, true, "artist-011", new DateTime(2025, 7, 10, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7131) },
                    { 59, "Design artwork 59", "artist-001", new DateTime(2025, 7, 31, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7139), 59, "design_59.jpg", "https://picsum.photos/seed/design9/800/600", true, true, "artist-001", new DateTime(2025, 7, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7141) },
                    { 60, "Design artwork 60", "artist-018", new DateTime(2025, 7, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7150), 60, "design_60.jpg", "https://picsum.photos/seed/design25/800/600", true, true, "artist-018", new DateTime(2025, 8, 12, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7151) },
                    { 61, "Design artwork 61", "artist-016", new DateTime(2025, 6, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7161), 61, "design_61.jpg", "https://picsum.photos/seed/design48/800/600", true, true, "artist-016", new DateTime(2025, 6, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7162) },
                    { 62, "Design artwork 62", "artist-009", new DateTime(2025, 8, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7171), 62, "design_62.jpg", "https://picsum.photos/seed/design8/800/600", true, true, "artist-009", new DateTime(2025, 6, 12, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7172) },
                    { 63, "Design artwork 63", "artist-020", new DateTime(2025, 7, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7182), 63, "design_63.jpg", "https://picsum.photos/seed/design17/800/600", true, true, "artist-020", new DateTime(2025, 7, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7183) },
                    { 64, "Design artwork 64", "artist-016", new DateTime(2025, 6, 15, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7193), 64, "design_64.jpg", "https://picsum.photos/seed/design48/800/600", true, true, "artist-016", new DateTime(2025, 8, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7194) },
                    { 65, "Design artwork 65", "artist-017", new DateTime(2025, 7, 28, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7203), 65, "design_65.jpg", "https://picsum.photos/seed/design43/800/600", true, true, "artist-017", new DateTime(2025, 7, 27, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7205) },
                    { 66, "Design artwork 66", "artist-004", new DateTime(2025, 6, 18, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7238), 66, "design_66.jpg", "https://picsum.photos/seed/design10/800/600", true, true, "artist-004", new DateTime(2025, 8, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7240) },
                    { 67, "Design artwork 67", "artist-003", new DateTime(2025, 8, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7249), 67, "design_67.jpg", "https://picsum.photos/seed/design25/800/600", true, true, "artist-003", new DateTime(2025, 8, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7250) },
                    { 68, "Design artwork 68", "artist-006", new DateTime(2025, 6, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7259), 68, "design_68.jpg", "https://picsum.photos/seed/design19/800/600", true, true, "artist-006", new DateTime(2025, 7, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7261) },
                    { 69, "Design artwork 69", "artist-007", new DateTime(2025, 7, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7269), 69, "design_69.jpg", "https://picsum.photos/seed/design22/800/600", true, true, "artist-007", new DateTime(2025, 8, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7271) },
                    { 70, "Design artwork 70", "artist-010", new DateTime(2025, 7, 27, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7281), 70, "design_70.jpg", "https://picsum.photos/seed/design7/800/600", true, true, "artist-010", new DateTime(2025, 6, 5, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7282) },
                    { 71, "Design artwork 71", "artist-011", new DateTime(2025, 7, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7291), 71, "design_71.jpg", "https://picsum.photos/seed/design30/800/600", true, true, "artist-011", new DateTime(2025, 8, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7292) },
                    { 72, "Design artwork 72", "artist-013", new DateTime(2025, 6, 18, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7301), 72, "design_72.jpg", "https://picsum.photos/seed/design39/800/600", true, true, "artist-013", new DateTime(2025, 8, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7302) },
                    { 73, "Design artwork 73", "artist-008", new DateTime(2025, 7, 12, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7310), 73, "design_73.jpg", "https://picsum.photos/seed/design12/800/600", true, true, "artist-008", new DateTime(2025, 8, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7312) },
                    { 74, "Design artwork 74", "artist-004", new DateTime(2025, 6, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7320), 74, "design_74.jpg", "https://picsum.photos/seed/design49/800/600", true, true, "artist-004", new DateTime(2025, 7, 6, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7322) },
                    { 75, "Design artwork 75", "artist-004", new DateTime(2025, 7, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7330), 75, "design_75.jpg", "https://picsum.photos/seed/design37/800/600", true, true, "artist-004", new DateTime(2025, 6, 4, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7331) },
                    { 76, "Design artwork 76", "artist-003", new DateTime(2025, 7, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7340), 76, "design_76.jpg", "https://picsum.photos/seed/design10/800/600", true, true, "artist-003", new DateTime(2025, 7, 3, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7341) },
                    { 77, "Design artwork 77", "artist-012", new DateTime(2025, 8, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7351), 77, "design_77.jpg", "https://picsum.photos/seed/design5/800/600", true, true, "artist-012", new DateTime(2025, 7, 28, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7352) },
                    { 78, "Design artwork 78", "artist-011", new DateTime(2025, 7, 6, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7362), 78, "design_78.jpg", "https://picsum.photos/seed/design35/800/600", true, true, "artist-011", new DateTime(2025, 6, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7363) },
                    { 79, "Design artwork 79", "artist-011", new DateTime(2025, 6, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7371), 79, "design_79.jpg", "https://picsum.photos/seed/design21/800/600", true, true, "artist-011", new DateTime(2025, 7, 3, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7373) },
                    { 80, "Design artwork 80", "artist-016", new DateTime(2025, 7, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7382), 80, "design_80.jpg", "https://picsum.photos/seed/design29/800/600", true, true, "artist-016", new DateTime(2025, 7, 23, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7383) },
                    { 81, "Design artwork 81", "artist-015", new DateTime(2025, 6, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7392), 81, "design_81.jpg", "https://picsum.photos/seed/design48/800/600", true, true, "artist-015", new DateTime(2025, 8, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7393) },
                    { 82, "Design artwork 82", "artist-018", new DateTime(2025, 8, 5, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7402), 82, "design_82.jpg", "https://picsum.photos/seed/design35/800/600", true, true, "artist-018", new DateTime(2025, 7, 27, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7403) },
                    { 83, "Design artwork 83", "artist-010", new DateTime(2025, 6, 4, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7413), 83, "design_83.jpg", "https://picsum.photos/seed/design45/800/600", true, true, "artist-010", new DateTime(2025, 6, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7414) },
                    { 84, "Design artwork 84", "artist-011", new DateTime(2025, 6, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7423), 84, "design_84.jpg", "https://picsum.photos/seed/design21/800/600", true, true, "artist-011", new DateTime(2025, 7, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7424) },
                    { 85, "Design artwork 85", "artist-001", new DateTime(2025, 7, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7433), 85, "design_85.jpg", "https://picsum.photos/seed/design42/800/600", true, true, "artist-001", new DateTime(2025, 7, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7435) },
                    { 86, "Design artwork 86", "artist-014", new DateTime(2025, 7, 8, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7443), 86, "design_86.jpg", "https://picsum.photos/seed/design23/800/600", true, true, "artist-014", new DateTime(2025, 6, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7445) },
                    { 87, "Design artwork 87", "artist-014", new DateTime(2025, 7, 8, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7454), 87, "design_87.jpg", "https://picsum.photos/seed/design41/800/600", true, true, "artist-014", new DateTime(2025, 6, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7456) },
                    { 88, "Design artwork 88", "artist-004", new DateTime(2025, 6, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7466), 88, "design_88.jpg", "https://picsum.photos/seed/design19/800/600", true, true, "artist-004", new DateTime(2025, 7, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7467) },
                    { 89, "Design artwork 89", "artist-007", new DateTime(2025, 8, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7476), 89, "design_89.jpg", "https://picsum.photos/seed/design12/800/600", true, true, "artist-007", new DateTime(2025, 8, 9, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7477) },
                    { 90, "Design artwork 90", "artist-010", new DateTime(2025, 6, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7486), 90, "design_90.jpg", "https://picsum.photos/seed/design26/800/600", true, true, "artist-010", new DateTime(2025, 6, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7487) },
                    { 91, "Design artwork 91", "artist-018", new DateTime(2025, 6, 10, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7496), 91, "design_91.jpg", "https://picsum.photos/seed/design38/800/600", true, true, "artist-018", new DateTime(2025, 7, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7497) },
                    { 92, "Design artwork 92", "artist-016", new DateTime(2025, 8, 10, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7506), 92, "design_92.jpg", "https://picsum.photos/seed/design41/800/600", true, true, "artist-016", new DateTime(2025, 8, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7508) },
                    { 93, "Design artwork 93", "artist-013", new DateTime(2025, 7, 5, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7517), 93, "design_93.jpg", "https://picsum.photos/seed/design26/800/600", true, true, "artist-013", new DateTime(2025, 6, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7518) },
                    { 94, "Design artwork 94", "artist-019", new DateTime(2025, 6, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7555), 94, "design_94.jpg", "https://picsum.photos/seed/design46/800/600", true, true, "artist-019", new DateTime(2025, 8, 1, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7556) },
                    { 95, "Design artwork 95", "artist-009", new DateTime(2025, 7, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7565), 95, "design_95.jpg", "https://picsum.photos/seed/design2/800/600", true, true, "artist-009", new DateTime(2025, 8, 19, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7567) },
                    { 96, "Design artwork 96", "artist-003", new DateTime(2025, 8, 9, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7579), 96, "design_96.jpg", "https://picsum.photos/seed/design24/800/600", true, true, "artist-003", new DateTime(2025, 8, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7581) },
                    { 97, "Design artwork 97", "artist-002", new DateTime(2025, 7, 18, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7590), 97, "design_97.jpg", "https://picsum.photos/seed/design16/800/600", true, true, "artist-002", new DateTime(2025, 7, 30, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7591) },
                    { 98, "Design artwork 98", "artist-004", new DateTime(2025, 6, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7600), 98, "design_98.jpg", "https://picsum.photos/seed/design30/800/600", true, true, "artist-004", new DateTime(2025, 7, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7602) },
                    { 99, "Design artwork 99", "artist-002", new DateTime(2025, 6, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7610), 99, "design_99.jpg", "https://picsum.photos/seed/design37/800/600", true, true, "artist-002", new DateTime(2025, 6, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7612) },
                    { 100, "Design artwork 100", "artist-012", new DateTime(2025, 6, 5, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7624), 100, "design_100.jpg", "https://picsum.photos/seed/design47/800/600", true, true, "artist-012", new DateTime(2025, 6, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7625) },
                    { 101, "Design artwork 101", "artist-013", new DateTime(2025, 8, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7634), 101, "design_101.jpg", "https://picsum.photos/seed/design22/800/600", true, true, "artist-013", new DateTime(2025, 6, 30, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7638) },
                    { 102, "Design artwork 102", "artist-016", new DateTime(2025, 6, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7647), 102, "design_102.jpg", "https://picsum.photos/seed/design43/800/600", true, true, "artist-016", new DateTime(2025, 7, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7648) },
                    { 103, "Design artwork 103", "artist-011", new DateTime(2025, 6, 18, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7656), 103, "design_103.jpg", "https://picsum.photos/seed/design47/800/600", true, true, "artist-011", new DateTime(2025, 7, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7658) },
                    { 104, "Design artwork 104", "artist-003", new DateTime(2025, 6, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7667), 104, "design_104.jpg", "https://picsum.photos/seed/design33/800/600", true, true, "artist-003", new DateTime(2025, 7, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7668) },
                    { 105, "Design artwork 105", "artist-012", new DateTime(2025, 7, 9, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7677), 105, "design_105.jpg", "https://picsum.photos/seed/design39/800/600", true, true, "artist-012", new DateTime(2025, 7, 16, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7678) },
                    { 106, "Design artwork 106", "artist-008", new DateTime(2025, 6, 5, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7689), 106, "design_106.jpg", "https://picsum.photos/seed/design45/800/600", true, true, "artist-008", new DateTime(2025, 8, 23, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7690) },
                    { 107, "Design artwork 107", "artist-014", new DateTime(2025, 6, 11, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7699), 107, "design_107.jpg", "https://picsum.photos/seed/design4/800/600", true, true, "artist-014", new DateTime(2025, 8, 7, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7700) },
                    { 108, "Design artwork 108", "artist-006", new DateTime(2025, 6, 24, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7708), 108, "design_108.jpg", "https://picsum.photos/seed/design37/800/600", true, true, "artist-006", new DateTime(2025, 7, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7710) },
                    { 109, "Design artwork 109", "artist-003", new DateTime(2025, 7, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7718), 109, "design_109.jpg", "https://picsum.photos/seed/design28/800/600", true, true, "artist-003", new DateTime(2025, 6, 23, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7720) },
                    { 110, "Design artwork 110", "artist-007", new DateTime(2025, 7, 29, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7729), 110, "design_110.jpg", "https://picsum.photos/seed/design28/800/600", true, true, "artist-007", new DateTime(2025, 8, 4, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7730) },
                    { 111, "Design artwork 111", "artist-013", new DateTime(2025, 6, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7739), 111, "design_111.jpg", "https://picsum.photos/seed/design2/800/600", true, true, "artist-013", new DateTime(2025, 8, 2, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7741) },
                    { 112, "Design artwork 112", "artist-017", new DateTime(2025, 7, 21, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7749), 112, "design_112.jpg", "https://picsum.photos/seed/design19/800/600", true, true, "artist-017", new DateTime(2025, 7, 17, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7751) },
                    { 113, "Design artwork 113", "artist-020", new DateTime(2025, 7, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7760), 113, "design_113.jpg", "https://picsum.photos/seed/design13/800/600", true, true, "artist-020", new DateTime(2025, 6, 14, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7761) },
                    { 114, "Design artwork 114", "artist-008", new DateTime(2025, 7, 14, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7769), 114, "design_114.jpg", "https://picsum.photos/seed/design24/800/600", true, true, "artist-008", new DateTime(2025, 6, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7771) },
                    { 115, "Design artwork 115", "artist-011", new DateTime(2025, 6, 3, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7780), 115, "design_115.jpg", "https://picsum.photos/seed/design6/800/600", true, true, "artist-011", new DateTime(2025, 6, 22, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7781) },
                    { 116, "Design artwork 116", "artist-020", new DateTime(2025, 8, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7789), 116, "design_116.jpg", "https://picsum.photos/seed/design24/800/600", true, true, "artist-020", new DateTime(2025, 6, 14, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7790) },
                    { 117, "Design artwork 117", "artist-005", new DateTime(2025, 7, 26, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7799), 117, "design_117.jpg", "https://picsum.photos/seed/design15/800/600", true, true, "artist-005", new DateTime(2025, 7, 6, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7800) },
                    { 118, "Design artwork 118", "artist-005", new DateTime(2025, 8, 20, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7809), 118, "design_118.jpg", "https://picsum.photos/seed/design2/800/600", true, true, "artist-005", new DateTime(2025, 8, 25, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7810) },
                    { 119, "Design artwork 119", "artist-010", new DateTime(2025, 6, 13, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7819), 119, "design_119.jpg", "https://picsum.photos/seed/design15/800/600", true, true, "artist-010", new DateTime(2025, 7, 25, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7827) },
                    { 120, "Design artwork 120", "artist-003", new DateTime(2025, 8, 8, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7836), 120, "design_120.jpg", "https://picsum.photos/seed/design33/800/600", true, true, "artist-003", new DateTime(2025, 7, 28, 15, 35, 45, 762, DateTimeKind.Utc).AddTicks(7838) }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "BaseProductId", "ColorId", "CreatedBy", "CreatedOn", "DesignId", "IsActive", "LastModifiedBy", "LastModifiedOn", "Price", "SizeId", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1459), 1, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1478), 29.61m, 1, 142 },
                    { 2, 1, 1, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1629), 1, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1631), 22.66m, 2, 58 },
                    { 3, 1, 1, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1688), 1, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1690), 25.13m, 3, 113 },
                    { 4, 1, 1, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1805), 1, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1807), 22.87m, 4, 155 },
                    { 5, 1, 1, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1869), 1, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1871), 26.36m, 5, 157 },
                    { 6, 1, 1, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1933), 1, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(1935), 25.24m, 6, 158 },
                    { 7, 1, 2, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2010), 1, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2011), 25.11m, 1, 172 },
                    { 8, 1, 2, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2076), 1, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2078), 25.99m, 2, 98 },
                    { 9, 1, 2, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2158), 1, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2160), 27.32m, 3, 113 },
                    { 10, 1, 2, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2249), 1, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2251), 28.05m, 4, 71 },
                    { 11, 1, 2, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2305), 1, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2307), 26.59m, 5, 110 },
                    { 12, 1, 2, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2362), 1, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2363), 24.60m, 6, 104 },
                    { 13, 1, 3, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2428), 1, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2430), 27.55m, 1, 123 },
                    { 14, 1, 3, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2507), 1, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2509), 22.16m, 2, 108 },
                    { 15, 1, 3, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2613), 1, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2615), 26.45m, 3, 75 },
                    { 16, 1, 3, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2668), 1, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2670), 22.55m, 4, 198 },
                    { 17, 1, 3, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2722), 1, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2723), 29.13m, 5, 151 },
                    { 18, 1, 3, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2775), 1, true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2777), 28.69m, 6, 146 },
                    { 19, 1, 4, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2842), 1, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2844), 24.24m, 1, 71 },
                    { 20, 1, 4, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2924), 1, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2925), 27.62m, 2, 77 },
                    { 21, 1, 4, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2978), 1, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(2979), 24.71m, 3, 107 },
                    { 22, 1, 4, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3034), 1, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3035), 29.49m, 4, 94 },
                    { 23, 1, 4, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3091), 1, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3093), 29.36m, 5, 145 },
                    { 24, 1, 4, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3152), 1, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3153), 27.17m, 6, 75 },
                    { 25, 1, 5, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3248), 1, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3250), 27.54m, 1, 192 },
                    { 26, 1, 5, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3305), 1, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3307), 26.46m, 2, 168 },
                    { 27, 1, 5, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3357), 1, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3359), 25.48m, 3, 197 },
                    { 28, 1, 5, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3410), 1, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3412), 22.65m, 4, 124 },
                    { 29, 1, 5, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3462), 1, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3463), 23.31m, 5, 121 },
                    { 30, 1, 5, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3602), 1, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3603), 25.65m, 6, 155 },
                    { 31, 1, 1, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3709), 2, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3712), 23.02m, 1, 129 },
                    { 32, 1, 1, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3766), 2, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3768), 27.41m, 2, 120 },
                    { 33, 1, 1, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3821), 2, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3823), 24.71m, 3, 158 },
                    { 34, 1, 1, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3878), 2, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3880), 23.57m, 4, 103 },
                    { 35, 1, 1, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3926), 2, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(3927), 26.97m, 5, 122 },
                    { 36, 1, 1, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4001), 2, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4003), 24.69m, 6, 150 },
                    { 37, 1, 2, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4072), 2, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4073), 22.88m, 1, 138 },
                    { 38, 1, 2, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4121), 2, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4123), 23.93m, 2, 68 },
                    { 39, 1, 2, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4174), 2, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4175), 28.55m, 3, 107 },
                    { 40, 1, 2, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4223), 2, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4225), 22.15m, 4, 134 },
                    { 41, 1, 2, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4302), 2, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4304), 23.84m, 5, 176 },
                    { 42, 1, 2, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4356), 2, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4357), 23.50m, 6, 166 },
                    { 43, 1, 3, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4422), 2, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4424), 22.06m, 1, 106 },
                    { 44, 1, 3, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4477), 2, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4479), 23.01m, 2, 76 },
                    { 45, 1, 3, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4530), 2, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4532), 24.65m, 3, 101 },
                    { 46, 1, 3, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4585), 2, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4586), 22.37m, 4, 137 },
                    { 47, 1, 3, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4666), 2, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4668), 26.76m, 5, 97 },
                    { 48, 1, 3, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4720), 2, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4721), 28.64m, 6, 115 },
                    { 49, 1, 4, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4786), 2, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4787), 22.86m, 1, 140 },
                    { 50, 1, 4, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4836), 2, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4838), 23.06m, 2, 175 },
                    { 51, 1, 4, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4887), 2, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4888), 25.29m, 3, 141 },
                    { 52, 1, 4, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4974), 2, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(4976), 22.49m, 4, 72 },
                    { 53, 1, 4, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5029), 2, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5030), 22.99m, 5, 59 },
                    { 54, 1, 4, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5082), 2, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5084), 25.78m, 6, 93 },
                    { 55, 1, 5, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5152), 2, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5153), 29.78m, 1, 97 },
                    { 56, 1, 5, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5212), 2, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5213), 28.72m, 2, 105 },
                    { 57, 1, 5, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5265), 2, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5266), 28.74m, 3, 50 },
                    { 58, 1, 5, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5343), 2, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5345), 25.67m, 4, 165 },
                    { 59, 1, 5, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5398), 2, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5400), 22.87m, 5, 162 },
                    { 60, 1, 5, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5450), 2, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5451), 25.33m, 6, 50 },
                    { 61, 1, 1, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5527), 3, true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5528), 25.61m, 1, 93 },
                    { 62, 1, 1, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5582), 3, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5584), 27.89m, 2, 178 },
                    { 63, 1, 1, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5654), 3, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5656), 27.48m, 3, 60 },
                    { 64, 1, 1, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5706), 3, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5708), 22.57m, 4, 104 },
                    { 65, 1, 1, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5761), 3, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5762), 27.06m, 5, 138 },
                    { 66, 1, 1, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5817), 3, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5819), 24.28m, 6, 101 },
                    { 67, 1, 2, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5885), 3, true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5887), 27.91m, 1, 80 },
                    { 68, 1, 2, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5962), 3, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(5964), 26.90m, 2, 122 },
                    { 69, 1, 2, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6016), 3, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6018), 23.31m, 3, 97 },
                    { 70, 1, 2, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6067), 3, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6069), 27.43m, 4, 81 },
                    { 71, 1, 2, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6120), 3, true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6121), 25.30m, 5, 56 },
                    { 72, 1, 2, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6182), 3, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6183), 23.98m, 6, 126 },
                    { 73, 1, 3, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6272), 3, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6273), 24.04m, 1, 144 },
                    { 74, 1, 3, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6329), 3, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6331), 29.83m, 2, 63 },
                    { 75, 1, 3, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6391), 3, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6392), 22.86m, 3, 99 },
                    { 76, 1, 3, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6441), 3, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6442), 24.31m, 4, 179 },
                    { 77, 1, 3, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6489), 3, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6490), 28.68m, 5, 132 },
                    { 78, 1, 3, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6536), 3, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6538), 29.54m, 6, 191 },
                    { 79, 1, 4, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6622), 3, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6623), 28.02m, 1, 55 },
                    { 80, 1, 4, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6673), 3, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6675), 26.03m, 2, 168 },
                    { 81, 1, 4, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6723), 3, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6725), 28.21m, 3, 172 },
                    { 82, 1, 4, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6780), 3, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6781), 27.43m, 4, 110 },
                    { 83, 1, 4, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6832), 3, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6833), 23.28m, 5, 96 },
                    { 84, 1, 4, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6913), 3, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6915), 23.48m, 6, 95 },
                    { 85, 1, 5, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6984), 3, true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(6985), 28.69m, 1, 145 },
                    { 86, 1, 5, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7035), 3, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7037), 28.89m, 2, 150 },
                    { 87, 1, 5, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7083), 3, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7084), 24.09m, 3, 107 },
                    { 88, 1, 5, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7131), 3, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7132), 25.55m, 4, 187 },
                    { 89, 1, 5, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7180), 3, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7182), 23.77m, 5, 169 },
                    { 90, 1, 5, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7260), 3, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7262), 25.20m, 6, 83 },
                    { 91, 1, 1, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7338), 4, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7340), 26.47m, 1, 136 },
                    { 92, 1, 1, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7390), 4, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7391), 26.03m, 2, 52 },
                    { 93, 1, 1, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7441), 4, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7442), 24.69m, 3, 64 },
                    { 94, 1, 1, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7496), 4, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7497), 23.90m, 4, 111 },
                    { 95, 1, 1, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7571), 4, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7573), 22.12m, 5, 73 },
                    { 96, 1, 1, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7624), 4, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7626), 24.66m, 6, 56 },
                    { 97, 1, 2, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7694), 4, true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7696), 27.64m, 1, 68 },
                    { 98, 1, 2, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7748), 4, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7750), 26.32m, 2, 83 },
                    { 99, 1, 2, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7802), 4, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7803), 22.89m, 3, 68 },
                    { 100, 1, 2, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7856), 4, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(7858), 22.61m, 4, 75 },
                    { 101, 1, 2, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8515), 4, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8525), 23.17m, 5, 142 },
                    { 102, 1, 2, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8611), 4, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8613), 26.09m, 6, 160 },
                    { 103, 1, 3, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8695), 4, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8697), 25.42m, 1, 147 },
                    { 104, 1, 3, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8751), 4, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8753), 25.96m, 2, 83 },
                    { 105, 1, 3, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8808), 4, true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8811), 29.58m, 3, 102 },
                    { 106, 1, 3, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8894), 4, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8897), 29.08m, 4, 176 },
                    { 107, 1, 3, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8947), 4, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(8950), 29.62m, 5, 168 },
                    { 108, 1, 3, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9017), 4, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9019), 24.12m, 6, 62 },
                    { 109, 1, 4, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9089), 4, true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9091), 24.78m, 1, 121 },
                    { 110, 1, 4, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9140), 4, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9142), 25.49m, 2, 92 },
                    { 111, 1, 4, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9196), 4, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9199), 22.35m, 3, 97 },
                    { 112, 1, 4, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9279), 4, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9281), 28.16m, 4, 184 },
                    { 113, 1, 4, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9341), 4, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9344), 22.19m, 5, 143 },
                    { 114, 1, 4, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9398), 4, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9400), 23.93m, 6, 113 },
                    { 115, 1, 5, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9469), 4, true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9471), 27.64m, 1, 124 },
                    { 116, 1, 5, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9533), 4, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9535), 29.79m, 2, 194 },
                    { 117, 1, 5, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9613), 4, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9616), 26.97m, 3, 141 },
                    { 118, 1, 5, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9672), 4, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9674), 22.57m, 4, 107 },
                    { 119, 1, 5, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9735), 4, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9738), 26.92m, 5, 193 },
                    { 120, 1, 5, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9793), 4, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9795), 29.06m, 6, 53 },
                    { 121, 1, 1, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9882), 5, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9884), 27.34m, 1, 180 },
                    { 122, 1, 1, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9939), 5, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 763, DateTimeKind.Utc).AddTicks(9942), 27.96m, 2, 95 },
                    { 123, 1, 1, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(23), 5, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(25), 22.91m, 3, 177 },
                    { 124, 1, 1, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(81), 5, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(83), 29.11m, 4, 51 },
                    { 125, 1, 1, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(136), 5, true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(138), 28.11m, 5, 142 },
                    { 126, 1, 1, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(188), 5, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(189), 29.98m, 6, 65 },
                    { 127, 1, 2, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(251), 5, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(252), 26.36m, 1, 150 },
                    { 128, 1, 2, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(330), 5, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(332), 22.67m, 2, 168 },
                    { 129, 1, 2, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(383), 5, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(385), 23.25m, 3, 100 },
                    { 130, 1, 2, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(448), 5, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(450), 28.96m, 4, 185 },
                    { 131, 1, 2, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(497), 5, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(499), 22.03m, 5, 195 },
                    { 132, 1, 2, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(574), 5, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(576), 24.99m, 6, 70 },
                    { 133, 1, 3, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(644), 5, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(648), 29.65m, 1, 88 },
                    { 134, 1, 3, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(703), 5, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(705), 28.04m, 2, 76 },
                    { 135, 1, 3, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(760), 5, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(762), 22.41m, 3, 117 },
                    { 136, 1, 3, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(819), 5, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(822), 23.49m, 4, 97 },
                    { 137, 1, 3, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(874), 5, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(876), 25.43m, 5, 98 },
                    { 138, 1, 3, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(967), 5, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(971), 29.61m, 6, 183 },
                    { 139, 1, 4, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1058), 5, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1061), 22.09m, 1, 191 },
                    { 140, 1, 4, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1114), 5, true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1116), 23.55m, 2, 139 },
                    { 141, 1, 4, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1171), 5, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1174), 29.13m, 3, 125 },
                    { 142, 1, 4, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1229), 5, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1231), 29.85m, 4, 72 },
                    { 143, 1, 4, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1315), 5, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1317), 24.23m, 5, 123 },
                    { 144, 1, 4, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1374), 5, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1376), 28.48m, 6, 128 },
                    { 145, 1, 5, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1463), 5, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1466), 23.05m, 1, 136 },
                    { 146, 1, 5, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1530), 5, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1532), 24.83m, 2, 83 },
                    { 147, 1, 5, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1587), 5, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1588), 22.36m, 3, 192 },
                    { 148, 1, 5, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1644), 5, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1646), 22.13m, 4, 54 },
                    { 149, 1, 5, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1725), 5, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1728), 23.44m, 5, 152 },
                    { 150, 1, 5, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1783), 5, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1784), 29.89m, 6, 51 },
                    { 151, 1, 1, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1862), 6, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1865), 25.17m, 1, 170 },
                    { 152, 1, 1, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1922), 6, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1924), 28.70m, 2, 168 },
                    { 153, 1, 1, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1976), 6, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(1978), 28.47m, 3, 120 },
                    { 154, 1, 1, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2067), 6, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2069), 28.39m, 4, 82 },
                    { 155, 1, 1, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2123), 6, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2125), 28.78m, 5, 89 },
                    { 156, 1, 1, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2186), 6, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2188), 29.11m, 6, 67 },
                    { 157, 1, 2, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2256), 6, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2259), 22.90m, 1, 139 },
                    { 158, 1, 2, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2314), 6, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2317), 24.71m, 2, 117 },
                    { 159, 1, 2, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2394), 6, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2397), 23.87m, 3, 126 },
                    { 160, 1, 2, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2456), 6, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2458), 29.58m, 4, 78 },
                    { 161, 1, 2, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2521), 6, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2523), 29.20m, 5, 165 },
                    { 162, 1, 2, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2579), 6, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2581), 23.09m, 6, 163 },
                    { 163, 1, 3, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2658), 6, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2661), 27.05m, 1, 127 },
                    { 164, 1, 3, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2713), 6, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2715), 23.82m, 2, 96 },
                    { 165, 1, 3, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2801), 6, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2805), 28.69m, 3, 53 },
                    { 166, 1, 3, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2862), 6, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2864), 26.35m, 4, 188 },
                    { 167, 1, 3, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2920), 6, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2922), 28.15m, 5, 166 },
                    { 168, 1, 3, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2977), 6, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(2979), 26.49m, 6, 125 },
                    { 169, 1, 4, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3047), 6, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3050), 22.27m, 1, 128 },
                    { 170, 1, 4, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3124), 6, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3127), 22.90m, 2, 112 },
                    { 171, 1, 4, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3182), 6, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3185), 29.47m, 3, 91 },
                    { 172, 1, 4, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3240), 6, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3242), 26.94m, 4, 196 },
                    { 173, 1, 4, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3295), 6, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3298), 22.93m, 5, 105 },
                    { 174, 1, 4, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3355), 6, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3358), 28.69m, 6, 197 },
                    { 175, 1, 5, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3431), 6, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3433), 26.98m, 1, 146 },
                    { 176, 1, 5, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3516), 6, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3519), 24.98m, 2, 105 },
                    { 177, 1, 5, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3576), 6, true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3578), 28.34m, 3, 76 },
                    { 178, 1, 5, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3634), 6, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3637), 23.41m, 4, 91 },
                    { 179, 1, 5, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3694), 6, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3696), 29.31m, 5, 199 },
                    { 180, 1, 5, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3752), 6, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3755), 25.41m, 6, 98 },
                    { 181, 1, 1, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3864), 7, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3867), 29.06m, 1, 118 },
                    { 182, 1, 1, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3924), 7, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3926), 28.27m, 2, 169 },
                    { 183, 1, 1, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3979), 7, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(3981), 28.48m, 3, 72 },
                    { 184, 1, 1, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4037), 7, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4039), 27.12m, 4, 162 },
                    { 185, 1, 1, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4095), 7, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4097), 28.97m, 5, 104 },
                    { 186, 1, 1, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4152), 7, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4155), 24.27m, 6, 77 },
                    { 187, 1, 2, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4256), 7, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4258), 23.62m, 1, 94 },
                    { 188, 1, 2, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4311), 7, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4313), 27.39m, 2, 116 },
                    { 189, 1, 2, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4368), 7, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4371), 29.23m, 3, 197 },
                    { 190, 1, 2, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4428), 7, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4431), 23.57m, 4, 81 },
                    { 191, 1, 2, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4490), 7, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4492), 24.80m, 5, 145 },
                    { 192, 1, 2, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4577), 7, true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4580), 28.23m, 6, 154 },
                    { 193, 1, 3, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4649), 7, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4652), 22.08m, 1, 161 },
                    { 194, 1, 3, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4708), 7, true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4711), 24.31m, 2, 94 },
                    { 195, 1, 3, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4761), 7, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4763), 27.66m, 3, 99 },
                    { 196, 1, 3, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4818), 7, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4820), 28.32m, 4, 196 },
                    { 197, 1, 3, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4875), 7, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4878), 26.80m, 5, 78 },
                    { 198, 1, 3, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4965), 7, true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(4968), 24.13m, 6, 59 },
                    { 199, 1, 4, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5039), 7, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5041), 22.10m, 1, 55 },
                    { 200, 1, 4, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5096), 7, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5098), 24.33m, 2, 158 },
                    { 201, 1, 4, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5151), 7, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5154), 26.14m, 3, 175 },
                    { 202, 1, 4, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5209), 7, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5211), 22.37m, 4, 122 },
                    { 203, 1, 4, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5293), 7, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5295), 25.77m, 5, 167 },
                    { 204, 1, 4, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5351), 7, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5353), 23.78m, 6, 178 },
                    { 205, 1, 5, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5430), 7, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5432), 24.11m, 1, 129 },
                    { 206, 1, 5, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5492), 7, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5494), 23.04m, 2, 67 },
                    { 207, 1, 5, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5554), 7, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5556), 24.98m, 3, 160 },
                    { 208, 1, 5, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5612), 7, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5614), 23.59m, 4, 179 },
                    { 209, 1, 5, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5694), 7, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5696), 24.11m, 5, 122 },
                    { 210, 1, 5, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5753), 7, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5755), 23.18m, 6, 116 },
                    { 211, 1, 1, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5839), 8, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5843), 23.42m, 1, 193 },
                    { 212, 1, 1, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5897), 8, true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5899), 28.85m, 2, 124 },
                    { 213, 1, 1, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5954), 8, true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(5957), 28.66m, 3, 158 },
                    { 214, 1, 1, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6036), 8, true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6038), 24.38m, 4, 121 },
                    { 215, 1, 1, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6098), 8, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6100), 29.50m, 5, 182 },
                    { 216, 1, 1, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6156), 8, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6159), 25.45m, 6, 163 },
                    { 217, 1, 2, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6231), 8, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6233), 25.00m, 1, 83 },
                    { 218, 1, 2, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6285), 8, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6287), 29.12m, 2, 87 },
                    { 219, 1, 2, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6341), 8, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6343), 23.65m, 3, 96 },
                    { 220, 1, 2, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6427), 8, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6429), 29.43m, 4, 112 },
                    { 221, 1, 2, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6487), 8, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6489), 24.40m, 5, 184 },
                    { 222, 1, 2, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6541), 8, true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6543), 25.85m, 6, 146 },
                    { 223, 1, 3, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6615), 8, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6617), 22.85m, 1, 134 },
                    { 224, 1, 3, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6674), 8, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6676), 29.05m, 2, 51 },
                    { 225, 1, 3, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6763), 8, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6765), 26.34m, 3, 136 },
                    { 226, 1, 3, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6822), 8, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6825), 29.14m, 4, 154 },
                    { 227, 1, 3, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6879), 8, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6881), 25.98m, 5, 133 },
                    { 228, 1, 3, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6936), 8, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(6938), 22.51m, 6, 79 },
                    { 229, 1, 4, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7008), 8, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7012), 28.37m, 1, 152 },
                    { 230, 1, 4, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7090), 8, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7092), 24.71m, 2, 189 },
                    { 231, 1, 4, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7150), 8, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7152), 26.27m, 3, 171 },
                    { 232, 1, 4, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7208), 8, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7210), 23.90m, 4, 193 },
                    { 233, 1, 4, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7267), 8, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7269), 26.99m, 5, 198 },
                    { 234, 1, 4, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7329), 8, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7331), 24.46m, 6, 117 },
                    { 235, 1, 5, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7403), 8, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7406), 27.08m, 1, 175 },
                    { 236, 1, 5, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7491), 8, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7493), 22.67m, 2, 154 },
                    { 237, 1, 5, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7549), 8, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7551), 22.74m, 3, 123 },
                    { 238, 1, 5, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7605), 8, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7607), 21.99m, 4, 72 },
                    { 239, 1, 5, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7665), 8, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7668), 25.61m, 5, 105 },
                    { 240, 1, 5, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7726), 8, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7729), 22.49m, 6, 190 },
                    { 241, 2, 1, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7888), 1, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(7956), 31.94m, 1, 103 },
                    { 242, 2, 1, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8022), 1, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8025), 31.51m, 2, 68 },
                    { 243, 2, 1, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8087), 1, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8089), 32.61m, 3, 110 },
                    { 244, 2, 1, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8145), 1, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8147), 34.62m, 4, 80 },
                    { 245, 2, 1, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8202), 1, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8204), 27.68m, 5, 158 },
                    { 246, 2, 1, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8261), 1, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8263), 30.94m, 6, 161 },
                    { 247, 2, 2, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8352), 1, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8355), 34.28m, 1, 53 },
                    { 248, 2, 2, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8409), 1, true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8412), 29.81m, 2, 185 },
                    { 249, 2, 2, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8468), 1, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8470), 30.94m, 3, 115 },
                    { 250, 2, 2, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8524), 1, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 764, DateTimeKind.Utc).AddTicks(8526), 29.63m, 4, 147 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductVariantId", "Quantity", "TotalPrice", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 81, 3, 81.30m, 27.10m },
                    { 2, 1, 2, 2, 32.76m, 16.38m },
                    { 3, 1, 26, 1, 38.80m, 38.80m },
                    { 4, 1, 74, 1, 38.46m, 38.46m },
                    { 5, 2, 87, 1, 29.44m, 29.44m },
                    { 6, 2, 74, 3, 60.54m, 20.18m },
                    { 7, 2, 6, 2, 48.52m, 24.26m },
                    { 8, 2, 48, 3, 70.14m, 23.38m },
                    { 9, 3, 13, 1, 40.37m, 40.37m },
                    { 10, 3, 4, 1, 37.42m, 37.42m },
                    { 11, 3, 47, 3, 84.30m, 28.10m },
                    { 12, 3, 66, 3, 81.54m, 27.18m },
                    { 13, 3, 15, 1, 32.55m, 32.55m },
                    { 14, 4, 21, 2, 33.12m, 16.56m },
                    { 15, 4, 69, 2, 33.30m, 16.65m },
                    { 16, 4, 92, 3, 127.17m, 42.39m },
                    { 17, 4, 32, 3, 114.60m, 38.20m },
                    { 18, 5, 50, 2, 63.18m, 31.59m },
                    { 19, 5, 74, 2, 85.38m, 42.69m },
                    { 20, 6, 26, 3, 99.99m, 33.33m },
                    { 21, 6, 34, 1, 37.60m, 37.60m },
                    { 22, 7, 63, 2, 49.74m, 24.87m },
                    { 23, 7, 58, 1, 29.17m, 29.17m },
                    { 24, 7, 80, 1, 42.15m, 42.15m },
                    { 25, 8, 60, 2, 34.10m, 17.05m },
                    { 26, 8, 25, 1, 18.76m, 18.76m },
                    { 27, 8, 81, 3, 107.55m, 35.85m },
                    { 28, 8, 78, 3, 67.53m, 22.51m },
                    { 29, 8, 36, 3, 93.09m, 31.03m },
                    { 30, 9, 50, 2, 56.80m, 28.40m },
                    { 31, 9, 96, 3, 78.78m, 26.26m },
                    { 32, 10, 64, 1, 18.17m, 18.17m },
                    { 33, 10, 59, 3, 100.44m, 33.48m },
                    { 34, 10, 31, 2, 53.28m, 26.64m },
                    { 35, 10, 51, 3, 57.66m, 19.22m },
                    { 36, 10, 27, 3, 120.54m, 40.18m },
                    { 37, 11, 63, 3, 78.42m, 26.14m },
                    { 38, 11, 62, 3, 88.38m, 29.46m },
                    { 39, 12, 23, 2, 32.16m, 16.08m },
                    { 40, 12, 9, 3, 79.26m, 26.42m },
                    { 41, 12, 67, 3, 52.32m, 17.44m },
                    { 42, 13, 47, 2, 87.34m, 43.67m },
                    { 43, 13, 6, 2, 34.20m, 17.10m },
                    { 44, 14, 40, 2, 63.24m, 31.62m },
                    { 45, 14, 75, 2, 62.06m, 31.03m },
                    { 46, 14, 28, 1, 34.78m, 34.78m },
                    { 47, 15, 82, 1, 25.37m, 25.37m },
                    { 48, 15, 76, 3, 58.44m, 19.48m },
                    { 49, 15, 92, 3, 128.70m, 42.90m },
                    { 50, 16, 53, 1, 44.93m, 44.93m },
                    { 51, 16, 73, 2, 70.40m, 35.20m },
                    { 52, 16, 93, 3, 82.62m, 27.54m },
                    { 53, 16, 89, 1, 17.66m, 17.66m },
                    { 54, 17, 3, 1, 32.24m, 32.24m },
                    { 55, 17, 93, 2, 67.50m, 33.75m },
                    { 56, 17, 12, 3, 122.34m, 40.78m },
                    { 57, 17, 32, 1, 40.29m, 40.29m },
                    { 58, 18, 74, 2, 63.86m, 31.93m },
                    { 59, 18, 29, 1, 20.28m, 20.28m },
                    { 60, 18, 62, 2, 79.08m, 39.54m },
                    { 61, 18, 7, 2, 79.56m, 39.78m },
                    { 62, 18, 20, 3, 99.78m, 33.26m },
                    { 63, 19, 81, 3, 70.53m, 23.51m },
                    { 64, 19, 73, 2, 49.34m, 24.67m },
                    { 65, 19, 54, 1, 21.64m, 21.64m },
                    { 66, 20, 26, 3, 129.42m, 43.14m },
                    { 67, 20, 68, 1, 43.14m, 43.14m },
                    { 68, 20, 89, 3, 129.39m, 43.13m },
                    { 69, 21, 24, 1, 40.33m, 40.33m },
                    { 70, 21, 87, 2, 51.90m, 25.95m },
                    { 71, 21, 21, 1, 20.17m, 20.17m },
                    { 72, 22, 44, 3, 91.02m, 30.34m },
                    { 73, 22, 30, 1, 31.17m, 31.17m },
                    { 74, 23, 12, 2, 54.78m, 27.39m },
                    { 75, 23, 93, 1, 16.99m, 16.99m },
                    { 76, 23, 75, 3, 117.09m, 39.03m },
                    { 77, 23, 43, 1, 16.61m, 16.61m },
                    { 78, 23, 47, 3, 83.31m, 27.77m },
                    { 79, 24, 15, 1, 35.37m, 35.37m },
                    { 80, 24, 94, 2, 45.06m, 22.53m },
                    { 81, 24, 7, 1, 26.22m, 26.22m },
                    { 82, 24, 16, 1, 40.67m, 40.67m },
                    { 83, 24, 56, 1, 34.30m, 34.30m },
                    { 84, 25, 48, 1, 38.10m, 38.10m },
                    { 85, 25, 41, 2, 62.48m, 31.24m },
                    { 86, 25, 100, 1, 17.87m, 17.87m },
                    { 87, 25, 95, 3, 129.33m, 43.11m },
                    { 88, 26, 11, 3, 59.43m, 19.81m },
                    { 89, 26, 1, 3, 78.30m, 26.10m },
                    { 90, 27, 38, 2, 51.22m, 25.61m },
                    { 91, 27, 87, 1, 23.88m, 23.88m },
                    { 92, 28, 9, 3, 125.40m, 41.80m },
                    { 93, 28, 37, 2, 77.10m, 38.55m },
                    { 94, 28, 53, 2, 48.12m, 24.06m },
                    { 95, 28, 18, 1, 28.88m, 28.88m },
                    { 96, 29, 24, 2, 80.14m, 40.07m },
                    { 97, 29, 48, 2, 37.44m, 18.72m },
                    { 98, 29, 6, 1, 28.39m, 28.39m },
                    { 99, 29, 96, 3, 120.99m, 40.33m },
                    { 100, 30, 59, 1, 40.99m, 40.99m },
                    { 101, 30, 81, 3, 54.12m, 18.04m },
                    { 102, 30, 23, 3, 127.20m, 42.40m },
                    { 103, 30, 12, 1, 32.46m, 32.46m },
                    { 104, 30, 18, 1, 30.92m, 30.92m },
                    { 105, 31, 41, 3, 133.77m, 44.59m },
                    { 106, 31, 26, 3, 118.62m, 39.54m },
                    { 107, 31, 76, 3, 123.72m, 41.24m },
                    { 108, 31, 29, 1, 22.10m, 22.10m },
                    { 109, 32, 64, 3, 49.17m, 16.39m },
                    { 110, 32, 52, 2, 41.96m, 20.98m },
                    { 111, 32, 28, 3, 89.40m, 29.80m },
                    { 112, 33, 93, 1, 33.31m, 33.31m },
                    { 113, 33, 33, 2, 68.00m, 34.00m },
                    { 114, 33, 90, 2, 88.32m, 44.16m },
                    { 115, 34, 75, 1, 44.12m, 44.12m },
                    { 116, 34, 87, 2, 39.50m, 19.75m },
                    { 117, 34, 77, 2, 35.66m, 17.83m },
                    { 118, 34, 94, 2, 85.40m, 42.70m },
                    { 119, 35, 71, 1, 18.87m, 18.87m },
                    { 120, 35, 16, 1, 33.04m, 33.04m },
                    { 121, 35, 96, 1, 39.34m, 39.34m },
                    { 122, 35, 92, 3, 50.88m, 16.96m },
                    { 123, 35, 2, 1, 29.74m, 29.74m },
                    { 124, 36, 14, 3, 125.01m, 41.67m },
                    { 125, 36, 21, 3, 93.42m, 31.14m },
                    { 126, 36, 60, 1, 20.57m, 20.57m },
                    { 127, 37, 42, 2, 77.12m, 38.56m },
                    { 128, 37, 62, 2, 68.92m, 34.46m },
                    { 129, 37, 100, 1, 42.13m, 42.13m },
                    { 130, 37, 6, 2, 58.64m, 29.32m },
                    { 131, 37, 84, 3, 46.74m, 15.58m },
                    { 132, 38, 94, 1, 22.43m, 22.43m },
                    { 133, 38, 80, 2, 89.90m, 44.95m },
                    { 134, 38, 28, 1, 43.67m, 43.67m },
                    { 135, 39, 73, 3, 70.56m, 23.52m },
                    { 136, 39, 17, 3, 55.08m, 18.36m },
                    { 137, 39, 98, 1, 20.60m, 20.60m },
                    { 138, 39, 53, 2, 41.52m, 20.76m },
                    { 139, 39, 36, 1, 17.02m, 17.02m },
                    { 140, 40, 26, 2, 83.30m, 41.65m },
                    { 141, 40, 67, 1, 17.70m, 17.70m },
                    { 142, 40, 19, 2, 66.28m, 33.14m },
                    { 143, 40, 47, 3, 80.13m, 26.71m },
                    { 144, 40, 35, 2, 39.34m, 19.67m },
                    { 145, 41, 67, 2, 85.24m, 42.62m },
                    { 146, 41, 29, 3, 111.24m, 37.08m },
                    { 147, 41, 38, 1, 30.21m, 30.21m },
                    { 148, 41, 69, 2, 59.92m, 29.96m },
                    { 149, 42, 75, 3, 60.60m, 20.20m },
                    { 150, 42, 73, 3, 111.84m, 37.28m },
                    { 151, 42, 84, 2, 47.66m, 23.83m },
                    { 152, 42, 82, 2, 61.84m, 30.92m },
                    { 153, 42, 86, 2, 42.56m, 21.28m },
                    { 154, 43, 58, 3, 114.33m, 38.11m },
                    { 155, 43, 37, 3, 92.58m, 30.86m },
                    { 156, 43, 76, 1, 38.61m, 38.61m },
                    { 157, 44, 52, 1, 33.93m, 33.93m },
                    { 158, 44, 16, 2, 58.66m, 29.33m },
                    { 159, 44, 69, 2, 81.78m, 40.89m },
                    { 160, 44, 70, 2, 69.74m, 34.87m },
                    { 161, 44, 55, 3, 73.80m, 24.60m },
                    { 162, 45, 37, 3, 70.44m, 23.48m },
                    { 163, 45, 75, 1, 20.18m, 20.18m },
                    { 164, 46, 92, 3, 125.25m, 41.75m },
                    { 165, 46, 85, 1, 41.76m, 41.76m },
                    { 166, 47, 3, 1, 43.23m, 43.23m },
                    { 167, 47, 99, 1, 38.02m, 38.02m },
                    { 168, 48, 14, 2, 39.60m, 19.80m },
                    { 169, 48, 85, 1, 36.02m, 36.02m },
                    { 170, 48, 52, 3, 127.59m, 42.53m },
                    { 171, 48, 26, 1, 16.35m, 16.35m },
                    { 172, 49, 16, 3, 123.39m, 41.13m },
                    { 173, 49, 4, 3, 76.23m, 25.41m },
                    { 174, 49, 91, 3, 65.46m, 21.82m },
                    { 175, 49, 57, 2, 63.22m, 31.61m },
                    { 176, 50, 66, 3, 96.90m, 32.30m },
                    { 177, 50, 73, 2, 57.04m, 28.52m },
                    { 178, 50, 56, 2, 43.76m, 21.88m },
                    { 179, 50, 44, 1, 42.20m, 42.20m }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 1, "Product variant 1 mockup image 1", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3002), "variant_1_image_1.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3010), 1 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 2, "Product variant 1 mockup image 2", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3059), "variant_1_image_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3062), 1 },
                    { 3, "Product variant 1 mockup image 3", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3074), "variant_1_image_3.jpg", "https://images.unsplash.com/photo-kkj9iKxsdhY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3077), 1 },
                    { 4, "Product variant 1 mockup image 4", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3087), "variant_1_image_4.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3089), 1 },
                    { 5, "Product variant 1 mockup image 5", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3101), "variant_1_image_5.jpg", "https://picsum.photos/seed/mockup28/800/600", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3102), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 6, "Product variant 2 mockup image 1", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3117), "variant_2_image_1.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3119), 2 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 7, "Product variant 2 mockup image 2", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3128), "variant_2_image_2.jpg", "https://picsum.photos/seed/mockup10/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3130), 2 },
                    { 8, "Product variant 2 mockup image 3", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3180), "variant_2_image_3.jpg", "https://picsum.photos/seed/mockup10/800/600", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3185), 2 },
                    { 9, "Product variant 2 mockup image 4", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3198), "variant_2_image_4.jpg", "https://images.unsplash.com/photo-mks2xvUYGnc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3200), 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 11, "Product variant 3 mockup image 1", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3214), "variant_3_image_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3216), 3 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 12, "Product variant 3 mockup image 2", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3227), "variant_3_image_2.jpg", "https://picsum.photos/seed/mockup17/800/600", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3230), 3 },
                    { 13, "Product variant 3 mockup image 3", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3240), "variant_3_image_3.jpg", "https://picsum.photos/seed/mockup6/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3243), 3 },
                    { 14, "Product variant 3 mockup image 4", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3252), "variant_3_image_4.jpg", "https://picsum.photos/seed/mockup28/800/600", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3254), 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 16, "Product variant 4 mockup image 1", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3264), "variant_4_image_1.jpg", "https://picsum.photos/seed/mockup4/800/600", true, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3266), 4 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 17, "Product variant 4 mockup image 2", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3277), "variant_4_image_2.jpg", "https://picsum.photos/seed/mockup17/800/600", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3279), 4 },
                    { 18, "Product variant 4 mockup image 3", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3289), "variant_4_image_3.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3291), 4 },
                    { 19, "Product variant 4 mockup image 4", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3301), "variant_4_image_4.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3303), 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 21, "Product variant 5 mockup image 1", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3318), "variant_5_image_1.jpg", "https://picsum.photos/seed/mockup30/800/600", true, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3320), 5 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 22, "Product variant 5 mockup image 2", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3330), "variant_5_image_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3332), 5 },
                    { 23, "Product variant 5 mockup image 3", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3343), "variant_5_image_3.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3345), 5 },
                    { 24, "Product variant 5 mockup image 4", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3354), "variant_5_image_4.jpg", "https://images.unsplash.com/photo-mks2xvUYGnc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3356), 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 26, "Product variant 6 mockup image 1", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3366), "variant_6_image_1.jpg", "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3368), 6 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 27, "Product variant 6 mockup image 2", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3378), "variant_6_image_2.jpg", "https://picsum.photos/seed/mockup13/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3380), 6 },
                    { 28, "Product variant 6 mockup image 3", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3389), "variant_6_image_3.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3391), 6 },
                    { 29, "Product variant 6 mockup image 4", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3400), "variant_6_image_4.jpg", "https://picsum.photos/seed/mockup17/800/600", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3401), 6 },
                    { 30, "Product variant 6 mockup image 5", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3411), "variant_6_image_5.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3413), 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 31, "Product variant 7 mockup image 1", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3424), "variant_7_image_1.jpg", "https://images.unsplash.com/photo-6Nub980bI3I?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3425), 7 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 32, "Product variant 7 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3436), "variant_7_image_2.jpg", "https://picsum.photos/seed/mockup6/800/600", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3438), 7 },
                    { 33, "Product variant 7 mockup image 3", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3448), "variant_7_image_3.jpg", "https://picsum.photos/seed/mockup30/800/600", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3450), 7 },
                    { 34, "Product variant 7 mockup image 4", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3460), "variant_7_image_4.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3462), 7 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 36, "Product variant 8 mockup image 1", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3497), "variant_8_image_1.jpg", "https://picsum.photos/seed/mockup19/800/600", true, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3499), 8 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 37, "Product variant 8 mockup image 2", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3510), "variant_8_image_2.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3511), 8 },
                    { 38, "Product variant 8 mockup image 3", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3521), "variant_8_image_3.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3523), 8 },
                    { 39, "Product variant 8 mockup image 4", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3536), "variant_8_image_4.jpg", "https://picsum.photos/seed/mockup27/800/600", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3539), 8 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 41, "Product variant 9 mockup image 1", "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3551), "variant_9_image_1.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3553), 9 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 42, "Product variant 9 mockup image 2", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3563), "variant_9_image_2.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3565), 9 },
                    { 43, "Product variant 9 mockup image 3", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3574), "variant_9_image_3.jpg", "https://picsum.photos/seed/mockup19/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3576), 9 },
                    { 44, "Product variant 9 mockup image 4", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3585), "variant_9_image_4.jpg", "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3587), 9 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 46, "Product variant 10 mockup image 1", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3601), "variant_10_image_1.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3603), 10 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 47, "Product variant 10 mockup image 2", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3616), "variant_10_image_2.jpg", "https://picsum.photos/seed/mockup12/800/600", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3617), 10 },
                    { 48, "Product variant 10 mockup image 3", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3630), "variant_10_image_3.jpg", "https://picsum.photos/seed/mockup7/800/600", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3632), 10 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 51, "Product variant 11 mockup image 1", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3644), "variant_11_image_1.jpg", "https://picsum.photos/seed/mockup10/800/600", true, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3646), 11 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 52, "Product variant 11 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3658), "variant_11_image_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3660), 11 },
                    { 53, "Product variant 11 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3670), "variant_11_image_3.jpg", "https://picsum.photos/seed/mockup3/800/600", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3672), 11 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 56, "Product variant 12 mockup image 1", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3685), "variant_12_image_1.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3687), 12 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 57, "Product variant 12 mockup image 2", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3698), "variant_12_image_2.jpg", "https://picsum.photos/seed/mockup7/800/600", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3700), 12 },
                    { 58, "Product variant 12 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3713), "variant_12_image_3.jpg", "https://picsum.photos/seed/mockup20/800/600", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3715), 12 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 61, "Product variant 13 mockup image 1", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3728), "variant_13_image_1.jpg", "https://picsum.photos/seed/mockup4/800/600", true, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3730), 13 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 62, "Product variant 13 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3741), "variant_13_image_2.jpg", "https://picsum.photos/seed/mockup21/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3744), 13 },
                    { 63, "Product variant 13 mockup image 3", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3754), "variant_13_image_3.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3756), 13 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 66, "Product variant 14 mockup image 1", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3768), "variant_14_image_1.jpg", "https://picsum.photos/seed/mockup21/800/600", true, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3770), 14 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 67, "Product variant 14 mockup image 2", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3780), "variant_14_image_2.jpg", "https://picsum.photos/seed/mockup11/800/600", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3782), 14 },
                    { 68, "Product variant 14 mockup image 3", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3818), "variant_14_image_3.jpg", "https://picsum.photos/seed/mockup21/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3821), 14 },
                    { 69, "Product variant 14 mockup image 4", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3832), "variant_14_image_4.jpg", "https://picsum.photos/seed/mockup21/800/600", true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3834), 14 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 71, "Product variant 15 mockup image 1", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3846), "variant_15_image_1.jpg", "https://picsum.photos/seed/mockup2/800/600", true, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3848), 15 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 72, "Product variant 15 mockup image 2", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3859), "variant_15_image_2.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3862), 15 },
                    { 73, "Product variant 15 mockup image 3", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3872), "variant_15_image_3.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3874), 15 },
                    { 74, "Product variant 15 mockup image 4", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3887), "variant_15_image_4.jpg", "https://picsum.photos/seed/mockup6/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3888), 15 },
                    { 75, "Product variant 15 mockup image 5", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3899), "variant_15_image_5.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3901), 15 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 76, "Product variant 16 mockup image 1", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3912), "variant_16_image_1.jpg", "https://picsum.photos/seed/mockup1/800/600", true, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3914), 16 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 77, "Product variant 16 mockup image 2", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3925), "variant_16_image_2.jpg", "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3927), 16 },
                    { 78, "Product variant 16 mockup image 3", "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3938), "variant_16_image_3.jpg", "https://picsum.photos/seed/mockup19/800/600", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3940), 16 },
                    { 79, "Product variant 16 mockup image 4", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3952), "variant_16_image_4.jpg", "https://picsum.photos/seed/mockup15/800/600", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3953), 16 },
                    { 80, "Product variant 16 mockup image 5", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3964), "variant_16_image_5.jpg", "https://picsum.photos/seed/mockup12/800/600", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3965), 16 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 81, "Product variant 17 mockup image 1", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3977), "variant_17_image_1.jpg", "https://picsum.photos/seed/mockup20/800/600", true, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3979), 17 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 82, "Product variant 17 mockup image 2", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3995), "variant_17_image_2.jpg", "https://picsum.photos/seed/mockup13/800/600", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(3997), 17 },
                    { 83, "Product variant 17 mockup image 3", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4008), "variant_17_image_3.jpg", "https://picsum.photos/seed/mockup10/800/600", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4009), 17 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 86, "Product variant 18 mockup image 1", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4022), "variant_18_image_1.jpg", "https://picsum.photos/seed/mockup3/800/600", true, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4024), 18 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 87, "Product variant 18 mockup image 2", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4036), "variant_18_image_2.jpg", "https://images.unsplash.com/photo-lMcxXplVycA?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4038), 18 },
                    { 88, "Product variant 18 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4048), "variant_18_image_3.jpg", "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4050), 18 },
                    { 89, "Product variant 18 mockup image 4", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4062), "variant_18_image_4.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4064), 18 },
                    { 90, "Product variant 18 mockup image 5", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4074), "variant_18_image_5.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4076), 18 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 91, "Product variant 19 mockup image 1", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4111), "variant_19_image_1.jpg", "https://picsum.photos/seed/mockup2/800/600", true, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4114), 19 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 92, "Product variant 19 mockup image 2", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4127), "variant_19_image_2.jpg", "https://images.unsplash.com/photo-VQLdvHWikBI?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4129), 19 },
                    { 93, "Product variant 19 mockup image 3", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4139), "variant_19_image_3.jpg", "https://picsum.photos/seed/mockup8/800/600", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4141), 19 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 96, "Product variant 20 mockup image 1", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4151), "variant_20_image_1.jpg", "https://picsum.photos/seed/mockup4/800/600", true, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4154), 20 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 97, "Product variant 20 mockup image 2", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4164), "variant_20_image_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4166), 20 },
                    { 98, "Product variant 20 mockup image 3", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4177), "variant_20_image_3.jpg", "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4179), 20 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 101, "Product variant 21 mockup image 1", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4191), "variant_21_image_1.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4193), 21 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 102, "Product variant 21 mockup image 2", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4203), "variant_21_image_2.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4206), 21 },
                    { 103, "Product variant 21 mockup image 3", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4216), "variant_21_image_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4218), 21 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 106, "Product variant 22 mockup image 1", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4229), "variant_22_image_1.jpg", "https://picsum.photos/seed/mockup26/800/600", true, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4231), 22 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 107, "Product variant 22 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4241), "variant_22_image_2.jpg", "https://picsum.photos/seed/mockup28/800/600", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4243), 22 },
                    { 108, "Product variant 22 mockup image 3", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4254), "variant_22_image_3.jpg", "https://picsum.photos/seed/mockup3/800/600", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4256), 22 },
                    { 109, "Product variant 22 mockup image 4", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4265), "variant_22_image_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4267), 22 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 111, "Product variant 23 mockup image 1", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4278), "variant_23_image_1.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4280), 23 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 112, "Product variant 23 mockup image 2", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4290), "variant_23_image_2.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4292), 23 },
                    { 113, "Product variant 23 mockup image 3", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4303), "variant_23_image_3.jpg", "https://picsum.photos/seed/mockup24/800/600", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4305), 23 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 116, "Product variant 24 mockup image 1", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4316), "variant_24_image_1.jpg", "https://images.unsplash.com/photo-6Nub980bI3I?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4318), 24 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 117, "Product variant 24 mockup image 2", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4328), "variant_24_image_2.jpg", "https://picsum.photos/seed/mockup6/800/600", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4330), 24 },
                    { 118, "Product variant 24 mockup image 3", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4340), "variant_24_image_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4342), 24 },
                    { 119, "Product variant 24 mockup image 4", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4353), "variant_24_image_4.jpg", "https://picsum.photos/seed/mockup26/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4357), 24 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 121, "Product variant 25 mockup image 1", "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4366), "variant_25_image_1.jpg", "https://picsum.photos/seed/mockup3/800/600", true, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4368), 25 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 122, "Product variant 25 mockup image 2", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4377), "variant_25_image_2.jpg", "https://images.unsplash.com/photo-x8Vg7Up6TUc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4379), 25 },
                    { 123, "Product variant 25 mockup image 3", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4387), "variant_25_image_3.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4389), 25 },
                    { 124, "Product variant 25 mockup image 4", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4399), "variant_25_image_4.jpg", "https://images.unsplash.com/photo-7WE1LbSc4zM?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4400), 25 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 126, "Product variant 26 mockup image 1", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4435), "variant_26_image_1.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4439), 26 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 127, "Product variant 26 mockup image 2", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4449), "variant_26_image_2.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4451), 26 },
                    { 128, "Product variant 26 mockup image 3", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4460), "variant_26_image_3.jpg", "https://picsum.photos/seed/mockup21/800/600", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4462), 26 },
                    { 129, "Product variant 26 mockup image 4", "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4470), "variant_26_image_4.jpg", "https://picsum.photos/seed/mockup26/800/600", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4471), 26 },
                    { 130, "Product variant 26 mockup image 5", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4482), "variant_26_image_5.jpg", "https://picsum.photos/seed/mockup15/800/600", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4484), 26 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 131, "Product variant 27 mockup image 1", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4496), "variant_27_image_1.jpg", "https://picsum.photos/seed/mockup28/800/600", true, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4498), 27 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 132, "Product variant 27 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4507), "variant_27_image_2.jpg", "https://images.unsplash.com/photo-KeJkQ5mVvvk?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4509), 27 },
                    { 133, "Product variant 27 mockup image 3", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4519), "variant_27_image_3.jpg", "https://picsum.photos/seed/mockup10/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4520), 27 },
                    { 134, "Product variant 27 mockup image 4", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4530), "variant_27_image_4.jpg", "https://picsum.photos/seed/mockup24/800/600", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4532), 27 },
                    { 135, "Product variant 27 mockup image 5", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4541), "variant_27_image_5.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4543), 27 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 136, "Product variant 28 mockup image 1", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4552), "variant_28_image_1.jpg", "https://picsum.photos/seed/mockup7/800/600", true, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4554), 28 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 137, "Product variant 28 mockup image 2", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4564), "variant_28_image_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4565), 28 },
                    { 138, "Product variant 28 mockup image 3", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4574), "variant_28_image_3.jpg", "https://images.unsplash.com/photo-9ShY-Tq70Mc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4576), 28 },
                    { 139, "Product variant 28 mockup image 4", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4586), "variant_28_image_4.jpg", "https://picsum.photos/seed/mockup16/800/600", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4588), 28 },
                    { 140, "Product variant 28 mockup image 5", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4601), "variant_28_image_5.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4603), 28 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 141, "Product variant 29 mockup image 1", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4614), "variant_29_image_1.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4616), 29 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 142, "Product variant 29 mockup image 2", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4625), "variant_29_image_2.jpg", "https://images.unsplash.com/photo-WWesmHEgXDs?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4627), 29 },
                    { 143, "Product variant 29 mockup image 3", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4636), "variant_29_image_3.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4638), 29 },
                    { 144, "Product variant 29 mockup image 4", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4647), "variant_29_image_4.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4649), 29 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 146, "Product variant 30 mockup image 1", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4659), "variant_30_image_1.jpg", "https://picsum.photos/seed/mockup27/800/600", true, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4661), 30 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 147, "Product variant 30 mockup image 2", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4670), "variant_30_image_2.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4672), 30 },
                    { 148, "Product variant 30 mockup image 3", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4681), "variant_30_image_3.jpg", "https://picsum.photos/seed/mockup8/800/600", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4684), 30 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 151, "Product variant 31 mockup image 1", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4695), "variant_31_image_1.jpg", "https://picsum.photos/seed/mockup27/800/600", true, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4697), 31 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 152, "Product variant 31 mockup image 2", "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4730), "variant_31_image_2.jpg", "https://picsum.photos/seed/mockup24/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4733), 31 },
                    { 153, "Product variant 31 mockup image 3", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4743), "variant_31_image_3.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4744), 31 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 156, "Product variant 32 mockup image 1", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4755), "variant_32_image_1.jpg", "https://picsum.photos/seed/mockup8/800/600", true, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4757), 32 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 157, "Product variant 32 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4766), "variant_32_image_2.jpg", "https://picsum.photos/seed/mockup12/800/600", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4768), 32 },
                    { 158, "Product variant 32 mockup image 3", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4777), "variant_32_image_3.jpg", "https://picsum.photos/seed/mockup19/800/600", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4779), 32 },
                    { 159, "Product variant 32 mockup image 4", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4788), "variant_32_image_4.jpg", "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4790), 32 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 161, "Product variant 33 mockup image 1", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4800), "variant_33_image_1.jpg", "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4802), 33 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 162, "Product variant 33 mockup image 2", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4811), "variant_33_image_2.jpg", "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4813), 33 },
                    { 163, "Product variant 33 mockup image 3", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4823), "variant_33_image_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4824), 33 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 166, "Product variant 34 mockup image 1", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4834), "variant_34_image_1.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4836), 34 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 167, "Product variant 34 mockup image 2", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4855), "variant_34_image_2.jpg", "https://picsum.photos/seed/mockup19/800/600", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4857), 34 },
                    { 168, "Product variant 34 mockup image 3", "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4866), "variant_34_image_3.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4867), 34 },
                    { 169, "Product variant 34 mockup image 4", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4877), "variant_34_image_4.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4878), 34 },
                    { 170, "Product variant 34 mockup image 5", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4888), "variant_34_image_5.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4890), 34 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 171, "Product variant 35 mockup image 1", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4900), "variant_35_image_1.jpg", "https://picsum.photos/seed/mockup22/800/600", true, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4901), 35 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 172, "Product variant 35 mockup image 2", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4911), "variant_35_image_2.jpg", "https://images.unsplash.com/photo-VQLdvHWikBI?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4913), 35 },
                    { 173, "Product variant 35 mockup image 3", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4923), "variant_35_image_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(4924), 35 },
                    { 174, "Product variant 35 mockup image 4", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5089), "variant_35_image_4.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5093), 35 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 176, "Product variant 36 mockup image 1", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5107), "variant_36_image_1.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5109), 36 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 177, "Product variant 36 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5119), "variant_36_image_2.jpg", "https://images.unsplash.com/photo-mks2xvUYGnc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5121), 36 },
                    { 178, "Product variant 36 mockup image 3", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5130), "variant_36_image_3.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5132), 36 },
                    { 179, "Product variant 36 mockup image 4", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5142), "variant_36_image_4.jpg", "https://picsum.photos/seed/mockup24/800/600", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5144), 36 },
                    { 180, "Product variant 36 mockup image 5", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5154), "variant_36_image_5.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5156), 36 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 181, "Product variant 37 mockup image 1", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5166), "variant_37_image_1.jpg", "https://picsum.photos/seed/mockup23/800/600", true, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5167), 37 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 182, "Product variant 37 mockup image 2", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5177), "variant_37_image_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5179), 37 },
                    { 183, "Product variant 37 mockup image 3", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5188), "variant_37_image_3.jpg", "https://picsum.photos/seed/mockup15/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5190), 37 },
                    { 184, "Product variant 37 mockup image 4", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5200), "variant_37_image_4.jpg", "https://picsum.photos/seed/mockup17/800/600", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5202), 37 },
                    { 185, "Product variant 37 mockup image 5", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5211), "variant_37_image_5.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5213), 37 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 186, "Product variant 38 mockup image 1", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5224), "variant_38_image_1.jpg", "https://picsum.photos/seed/mockup18/800/600", true, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5226), 38 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 187, "Product variant 38 mockup image 2", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5236), "variant_38_image_2.jpg", "https://picsum.photos/seed/mockup28/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5237), 38 },
                    { 188, "Product variant 38 mockup image 3", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5247), "variant_38_image_3.jpg", "https://picsum.photos/seed/mockup13/800/600", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5249), 38 },
                    { 189, "Product variant 38 mockup image 4", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5258), "variant_38_image_4.jpg", "https://images.unsplash.com/photo-7WE1LbSc4zM?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5260), 38 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 191, "Product variant 39 mockup image 1", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5271), "variant_39_image_1.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5274), 39 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 192, "Product variant 39 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5284), "variant_39_image_2.jpg", "https://images.unsplash.com/photo-VQLdvHWikBI?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5285), 39 },
                    { 193, "Product variant 39 mockup image 3", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5295), "variant_39_image_3.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5297), 39 },
                    { 194, "Product variant 39 mockup image 4", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5307), "variant_39_image_4.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5309), 39 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 196, "Product variant 40 mockup image 1", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5320), "variant_40_image_1.jpg", "https://picsum.photos/seed/mockup28/800/600", true, true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5322), 40 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 197, "Product variant 40 mockup image 2", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5330), "variant_40_image_2.jpg", "https://picsum.photos/seed/mockup2/800/600", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5332), 40 },
                    { 198, "Product variant 40 mockup image 3", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5341), "variant_40_image_3.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5343), 40 },
                    { 199, "Product variant 40 mockup image 4", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5352), "variant_40_image_4.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5354), 40 },
                    { 200, "Product variant 40 mockup image 5", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5363), "variant_40_image_5.jpg", "https://picsum.photos/seed/mockup12/800/600", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5365), 40 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 201, "Product variant 41 mockup image 1", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5398), "variant_41_image_1.jpg", "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5401), 41 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 202, "Product variant 41 mockup image 2", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5410), "variant_41_image_2.jpg", "https://picsum.photos/seed/mockup26/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5413), 41 },
                    { 203, "Product variant 41 mockup image 3", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5423), "variant_41_image_3.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5425), 41 },
                    { 204, "Product variant 41 mockup image 4", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5435), "variant_41_image_4.jpg", "https://images.unsplash.com/photo-6Nub980bI3I?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5437), 41 },
                    { 205, "Product variant 41 mockup image 5", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5446), "variant_41_image_5.jpg", "https://picsum.photos/seed/mockup12/800/600", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5448), 41 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 206, "Product variant 42 mockup image 1", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5457), "variant_42_image_1.jpg", "https://picsum.photos/seed/mockup9/800/600", true, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5459), 42 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 207, "Product variant 42 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5468), "variant_42_image_2.jpg", "https://picsum.photos/seed/mockup22/800/600", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5470), 42 },
                    { 208, "Product variant 42 mockup image 3", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5479), "variant_42_image_3.jpg", "https://picsum.photos/seed/mockup12/800/600", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5481), 42 },
                    { 209, "Product variant 42 mockup image 4", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5489), "variant_42_image_4.jpg", "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5491), 42 },
                    { 210, "Product variant 42 mockup image 5", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5500), "variant_42_image_5.jpg", "https://images.unsplash.com/photo-fTDWpCxLA0k?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5502), 42 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 211, "Product variant 43 mockup image 1", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5512), "variant_43_image_1.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5514), 43 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 212, "Product variant 43 mockup image 2", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5523), "variant_43_image_2.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5525), 43 },
                    { 213, "Product variant 43 mockup image 3", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5535), "variant_43_image_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5537), 43 },
                    { 214, "Product variant 43 mockup image 4", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5548), "variant_43_image_4.jpg", "https://picsum.photos/seed/mockup7/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5550), 43 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 216, "Product variant 44 mockup image 1", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5559), "variant_44_image_1.jpg", "https://picsum.photos/seed/mockup7/800/600", true, true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5561), 44 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 217, "Product variant 44 mockup image 2", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5572), "variant_44_image_2.jpg", "https://picsum.photos/seed/mockup16/800/600", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5574), 44 },
                    { 218, "Product variant 44 mockup image 3", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5583), "variant_44_image_3.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5584), 44 },
                    { 219, "Product variant 44 mockup image 4", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5594), "variant_44_image_4.jpg", "https://images.unsplash.com/photo-KeJkQ5mVvvk?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5596), 44 },
                    { 220, "Product variant 44 mockup image 5", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5605), "variant_44_image_5.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5607), 44 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 221, "Product variant 45 mockup image 1", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5618), "variant_45_image_1.jpg", "https://picsum.photos/seed/mockup30/800/600", true, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5619), 45 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 222, "Product variant 45 mockup image 2", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5629), "variant_45_image_2.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5631), 45 },
                    { 223, "Product variant 45 mockup image 3", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5640), "variant_45_image_3.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5642), 45 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 226, "Product variant 46 mockup image 1", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5652), "variant_46_image_1.jpg", "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5653), 46 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 227, "Product variant 46 mockup image 2", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5682), "variant_46_image_2.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5685), 46 },
                    { 228, "Product variant 46 mockup image 3", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5694), "variant_46_image_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5697), 46 },
                    { 229, "Product variant 46 mockup image 4", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5707), "variant_46_image_4.jpg", "https://picsum.photos/seed/mockup4/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5709), 46 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 231, "Product variant 47 mockup image 1", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5720), "variant_47_image_1.jpg", "https://picsum.photos/seed/mockup11/800/600", true, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5722), 47 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 232, "Product variant 47 mockup image 2", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5732), "variant_47_image_2.jpg", "https://picsum.photos/seed/mockup16/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5733), 47 },
                    { 233, "Product variant 47 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5742), "variant_47_image_3.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5744), 47 },
                    { 234, "Product variant 47 mockup image 4", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5753), "variant_47_image_4.jpg", "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5755), 47 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 236, "Product variant 48 mockup image 1", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5765), "variant_48_image_1.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5767), 48 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 237, "Product variant 48 mockup image 2", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5776), "variant_48_image_2.jpg", "https://picsum.photos/seed/mockup26/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5778), 48 },
                    { 238, "Product variant 48 mockup image 3", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5786), "variant_48_image_3.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5788), 48 },
                    { 239, "Product variant 48 mockup image 4", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5797), "variant_48_image_4.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5799), 48 },
                    { 240, "Product variant 48 mockup image 5", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5808), "variant_48_image_5.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5810), 48 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 241, "Product variant 49 mockup image 1", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5819), "variant_49_image_1.jpg", "https://picsum.photos/seed/mockup25/800/600", true, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5822), 49 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 242, "Product variant 49 mockup image 2", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5832), "variant_49_image_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5834), 49 },
                    { 243, "Product variant 49 mockup image 3", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5844), "variant_49_image_3.jpg", "https://picsum.photos/seed/mockup3/800/600", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5846), 49 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 246, "Product variant 50 mockup image 1", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5858), "variant_50_image_1.jpg", "https://picsum.photos/seed/mockup26/800/600", true, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5860), 50 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 247, "Product variant 50 mockup image 2", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5869), "variant_50_image_2.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5870), 50 },
                    { 248, "Product variant 50 mockup image 3", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5879), "variant_50_image_3.jpg", "https://picsum.photos/seed/mockup20/800/600", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5881), 50 },
                    { 249, "Product variant 50 mockup image 4", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5889), "variant_50_image_4.jpg", "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5891), 50 },
                    { 250, "Product variant 50 mockup image 5", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5900), "variant_50_image_5.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5902), 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 251, "Product variant 51 mockup image 1", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5911), "variant_51_image_1.jpg", "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5913), 51 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 252, "Product variant 51 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5923), "variant_51_image_2.jpg", "https://picsum.photos/seed/mockup10/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5925), 51 },
                    { 253, "Product variant 51 mockup image 3", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5934), "variant_51_image_3.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5937), 51 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 256, "Product variant 52 mockup image 1", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5969), "variant_52_image_1.jpg", "https://picsum.photos/seed/mockup6/800/600", true, true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5972), 52 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 257, "Product variant 52 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5982), "variant_52_image_2.jpg", "https://picsum.photos/seed/mockup11/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5985), 52 },
                    { 258, "Product variant 52 mockup image 3", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5994), "variant_52_image_3.jpg", "https://picsum.photos/seed/mockup30/800/600", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(5996), 52 },
                    { 259, "Product variant 52 mockup image 4", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6005), "variant_52_image_4.jpg", "https://picsum.photos/seed/mockup13/800/600", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6007), 52 },
                    { 260, "Product variant 52 mockup image 5", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6017), "variant_52_image_5.jpg", "https://picsum.photos/seed/mockup23/800/600", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6019), 52 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 261, "Product variant 53 mockup image 1", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6029), "variant_53_image_1.jpg", "https://picsum.photos/seed/mockup24/800/600", true, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6031), 53 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 262, "Product variant 53 mockup image 2", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6040), "variant_53_image_2.jpg", "https://images.unsplash.com/photo-6Nub980bI3I?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6041), 53 },
                    { 263, "Product variant 53 mockup image 3", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6050), "variant_53_image_3.jpg", "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6052), 53 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 266, "Product variant 54 mockup image 1", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6062), "variant_54_image_1.jpg", "https://picsum.photos/seed/mockup28/800/600", true, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6064), 54 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 267, "Product variant 54 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6073), "variant_54_image_2.jpg", "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6075), 54 },
                    { 268, "Product variant 54 mockup image 3", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6084), "variant_54_image_3.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6086), 54 },
                    { 269, "Product variant 54 mockup image 4", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6095), "variant_54_image_4.jpg", "https://picsum.photos/seed/mockup11/800/600", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6097), 54 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 271, "Product variant 55 mockup image 1", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6107), "variant_55_image_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6109), 55 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 272, "Product variant 55 mockup image 2", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6117), "variant_55_image_2.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6119), 55 },
                    { 273, "Product variant 55 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6129), "variant_55_image_3.jpg", "https://picsum.photos/seed/mockup23/800/600", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6130), 55 },
                    { 274, "Product variant 55 mockup image 4", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6139), "variant_55_image_4.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6141), 55 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 276, "Product variant 56 mockup image 1", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6151), "variant_56_image_1.jpg", "https://images.unsplash.com/photo-1605902711834-8b11c3e3ef75?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6152), 56 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 277, "Product variant 56 mockup image 2", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6161), "variant_56_image_2.jpg", "https://images.unsplash.com/photo-fTDWpCxLA0k?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6163), 56 },
                    { 278, "Product variant 56 mockup image 3", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6172), "variant_56_image_3.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6174), 56 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 281, "Product variant 57 mockup image 1", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6185), "variant_57_image_1.jpg", "https://picsum.photos/seed/mockup10/800/600", true, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6186), 57 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 282, "Product variant 57 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6196), "variant_57_image_2.jpg", "https://picsum.photos/seed/mockup23/800/600", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6198), 57 },
                    { 283, "Product variant 57 mockup image 3", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6208), "variant_57_image_3.jpg", "https://picsum.photos/seed/mockup4/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6209), 57 },
                    { 284, "Product variant 57 mockup image 4", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6219), "variant_57_image_4.jpg", "https://picsum.photos/seed/mockup25/800/600", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6221), 57 },
                    { 285, "Product variant 57 mockup image 5", "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6252), "variant_57_image_5.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6255), 57 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 286, "Product variant 58 mockup image 1", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6269), "variant_58_image_1.jpg", "https://images.unsplash.com/photo-9ShY-Tq70Mc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6271), 58 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 287, "Product variant 58 mockup image 2", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6281), "variant_58_image_2.jpg", "https://picsum.photos/seed/mockup13/800/600", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6283), 58 },
                    { 288, "Product variant 58 mockup image 3", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6293), "variant_58_image_3.jpg", "https://picsum.photos/seed/mockup6/800/600", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6295), 58 },
                    { 289, "Product variant 58 mockup image 4", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6304), "variant_58_image_4.jpg", "https://picsum.photos/seed/mockup20/800/600", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6306), 58 },
                    { 290, "Product variant 58 mockup image 5", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6315), "variant_58_image_5.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6317), 58 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 291, "Product variant 59 mockup image 1", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6328), "variant_59_image_1.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6330), 59 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 292, "Product variant 59 mockup image 2", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6340), "variant_59_image_2.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6343), 59 },
                    { 293, "Product variant 59 mockup image 3", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6353), "variant_59_image_3.jpg", "https://images.unsplash.com/photo-kkj9iKxsdhY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6355), 59 },
                    { 294, "Product variant 59 mockup image 4", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6364), "variant_59_image_4.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6366), 59 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 296, "Product variant 60 mockup image 1", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6376), "variant_60_image_1.jpg", "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6379), 60 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 297, "Product variant 60 mockup image 2", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6389), "variant_60_image_2.jpg", "https://images.unsplash.com/photo-x8Vg7Up6TUc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6391), 60 },
                    { 298, "Product variant 60 mockup image 3", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6400), "variant_60_image_3.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6402), 60 },
                    { 299, "Product variant 60 mockup image 4", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6412), "variant_60_image_4.jpg", "https://picsum.photos/seed/mockup20/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6414), 60 },
                    { 300, "Product variant 60 mockup image 5", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6425), "variant_60_image_5.jpg", "https://picsum.photos/seed/mockup16/800/600", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6427), 60 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 301, "Product variant 61 mockup image 1", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6437), "variant_61_image_1.jpg", "https://picsum.photos/seed/mockup9/800/600", true, true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6439), 61 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 302, "Product variant 61 mockup image 2", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6449), "variant_61_image_2.jpg", "https://picsum.photos/seed/mockup30/800/600", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6451), 61 },
                    { 303, "Product variant 61 mockup image 3", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6460), "variant_61_image_3.jpg", "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6462), 61 },
                    { 304, "Product variant 61 mockup image 4", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6471), "variant_61_image_4.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6473), 61 },
                    { 305, "Product variant 61 mockup image 5", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6483), "variant_61_image_5.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6485), 61 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 306, "Product variant 62 mockup image 1", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6495), "variant_62_image_1.jpg", "https://picsum.photos/seed/mockup18/800/600", true, true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6497), 62 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 307, "Product variant 62 mockup image 2", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6507), "variant_62_image_2.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6509), 62 },
                    { 308, "Product variant 62 mockup image 3", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6518), "variant_62_image_3.jpg", "https://picsum.photos/seed/mockup15/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6520), 62 },
                    { 309, "Product variant 62 mockup image 4", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6530), "variant_62_image_4.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6531), 62 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 311, "Product variant 63 mockup image 1", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6563), "variant_63_image_1.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6565), 63 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 312, "Product variant 63 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6575), "variant_63_image_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6577), 63 },
                    { 313, "Product variant 63 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6593), "variant_63_image_3.jpg", "https://picsum.photos/seed/mockup29/800/600", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6595), 63 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 316, "Product variant 64 mockup image 1", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6605), "variant_64_image_1.jpg", "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6607), 64 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 317, "Product variant 64 mockup image 2", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6626), "variant_64_image_2.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6628), 64 },
                    { 318, "Product variant 64 mockup image 3", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6636), "variant_64_image_3.jpg", "https://picsum.photos/seed/mockup22/800/600", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6638), 64 },
                    { 319, "Product variant 64 mockup image 4", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6648), "variant_64_image_4.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6650), 64 },
                    { 320, "Product variant 64 mockup image 5", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6661), "variant_64_image_5.jpg", "https://images.unsplash.com/photo-kkj9iKxsdhY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6664), 64 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 321, "Product variant 65 mockup image 1", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6673), "variant_65_image_1.jpg", "https://picsum.photos/seed/mockup20/800/600", true, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6675), 65 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 322, "Product variant 65 mockup image 2", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6685), "variant_65_image_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6687), 65 },
                    { 323, "Product variant 65 mockup image 3", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6697), "variant_65_image_3.jpg", "https://picsum.photos/seed/mockup30/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6699), 65 },
                    { 324, "Product variant 65 mockup image 4", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6728), "variant_65_image_4.jpg", "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6731), 65 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 326, "Product variant 66 mockup image 1", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6742), "variant_66_image_1.jpg", "https://picsum.photos/seed/mockup27/800/600", true, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6745), 66 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 327, "Product variant 66 mockup image 2", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6757), "variant_66_image_2.jpg", "https://picsum.photos/seed/mockup29/800/600", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6759), 66 },
                    { 328, "Product variant 66 mockup image 3", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6767), "variant_66_image_3.jpg", "https://images.unsplash.com/photo-kkj9iKxsdhY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6769), 66 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 331, "Product variant 67 mockup image 1", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6780), "variant_67_image_1.jpg", "https://images.unsplash.com/photo-VQLdvHWikBI?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6782), 67 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 332, "Product variant 67 mockup image 2", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6792), "variant_67_image_2.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6794), 67 },
                    { 333, "Product variant 67 mockup image 3", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6806), "variant_67_image_3.jpg", "https://picsum.photos/seed/mockup7/800/600", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6807), 67 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 336, "Product variant 68 mockup image 1", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6819), "variant_68_image_1.jpg", "https://picsum.photos/seed/mockup29/800/600", true, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6821), 68 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 337, "Product variant 68 mockup image 2", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6831), "variant_68_image_2.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6833), 68 },
                    { 338, "Product variant 68 mockup image 3", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6842), "variant_68_image_3.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6844), 68 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 341, "Product variant 69 mockup image 1", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6855), "variant_69_image_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6857), 69 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 342, "Product variant 69 mockup image 2", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6866), "variant_69_image_2.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6869), 69 },
                    { 343, "Product variant 69 mockup image 3", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6879), "variant_69_image_3.jpg", "https://images.unsplash.com/photo-KeJkQ5mVvvk?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6881), 69 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 346, "Product variant 70 mockup image 1", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6890), "variant_70_image_1.jpg", "https://images.unsplash.com/photo-x8Vg7Up6TUc?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6892), 70 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 347, "Product variant 70 mockup image 2", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6902), "variant_70_image_2.jpg", "https://picsum.photos/seed/mockup17/800/600", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6904), 70 },
                    { 348, "Product variant 70 mockup image 3", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6914), "variant_70_image_3.jpg", "https://picsum.photos/seed/mockup30/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6916), 70 },
                    { 349, "Product variant 70 mockup image 4", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6927), "variant_70_image_4.jpg", "https://picsum.photos/seed/mockup27/800/600", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6929), 70 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 351, "Product variant 71 mockup image 1", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6940), "variant_71_image_1.jpg", "https://picsum.photos/seed/mockup22/800/600", true, true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6942), 71 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 352, "Product variant 71 mockup image 2", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6951), "variant_71_image_2.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6953), 71 },
                    { 353, "Product variant 71 mockup image 3", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6963), "variant_71_image_3.jpg", "https://images.unsplash.com/photo-mks2xvUYGnc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6965), 71 },
                    { 354, "Product variant 71 mockup image 4", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6975), "variant_71_image_4.jpg", "https://picsum.photos/seed/mockup2/800/600", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6977), 71 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 356, "Product variant 72 mockup image 1", "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6990), "variant_72_image_1.jpg", "https://picsum.photos/seed/mockup22/800/600", true, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(6991), 72 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 357, "Product variant 72 mockup image 2", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7002), "variant_72_image_2.jpg", "https://picsum.photos/seed/mockup25/800/600", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7004), 72 },
                    { 358, "Product variant 72 mockup image 3", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7014), "variant_72_image_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7016), 72 },
                    { 359, "Product variant 72 mockup image 4", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7050), "variant_72_image_4.jpg", "https://picsum.photos/seed/mockup24/800/600", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7054), 72 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 361, "Product variant 73 mockup image 1", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7066), "variant_73_image_1.jpg", "https://picsum.photos/seed/mockup15/800/600", true, true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7068), 73 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 362, "Product variant 73 mockup image 2", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7077), "variant_73_image_2.jpg", "https://picsum.photos/seed/mockup11/800/600", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7080), 73 },
                    { 363, "Product variant 73 mockup image 3", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7090), "variant_73_image_3.jpg", "https://picsum.photos/seed/mockup8/800/600", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7092), 73 },
                    { 364, "Product variant 73 mockup image 4", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7103), "variant_73_image_4.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7105), 73 },
                    { 365, "Product variant 73 mockup image 5", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7115), "variant_73_image_5.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7117), 73 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 366, "Product variant 74 mockup image 1", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7128), "variant_74_image_1.jpg", "https://picsum.photos/seed/mockup29/800/600", true, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7130), 74 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 367, "Product variant 74 mockup image 2", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7140), "variant_74_image_2.jpg", "https://picsum.photos/seed/mockup25/800/600", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7141), 74 },
                    { 368, "Product variant 74 mockup image 3", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7152), "variant_74_image_3.jpg", "https://picsum.photos/seed/mockup6/800/600", true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7154), 74 },
                    { 369, "Product variant 74 mockup image 4", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7165), "variant_74_image_4.jpg", "https://picsum.photos/seed/mockup1/800/600", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7168), 74 },
                    { 370, "Product variant 74 mockup image 5", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7179), "variant_74_image_5.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7181), 74 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 371, "Product variant 75 mockup image 1", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7192), "variant_75_image_1.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7194), 75 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 372, "Product variant 75 mockup image 2", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7205), "variant_75_image_2.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7207), 75 },
                    { 373, "Product variant 75 mockup image 3", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7218), "variant_75_image_3.jpg", "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7220), 75 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 376, "Product variant 76 mockup image 1", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7232), "variant_76_image_1.jpg", "https://picsum.photos/seed/mockup21/800/600", true, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7234), 76 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 377, "Product variant 76 mockup image 2", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7244), "variant_76_image_2.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7246), 76 },
                    { 378, "Product variant 76 mockup image 3", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7256), "variant_76_image_3.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7258), 76 },
                    { 379, "Product variant 76 mockup image 4", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7269), "variant_76_image_4.jpg", "https://images.unsplash.com/photo-1514228742587-6b1558fcf93a?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7271), 76 },
                    { 380, "Product variant 76 mockup image 5", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7281), "variant_76_image_5.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7283), 76 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 381, "Product variant 77 mockup image 1", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7295), "variant_77_image_1.jpg", "https://images.unsplash.com/photo-fTDWpCxLA0k?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7297), 77 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 382, "Product variant 77 mockup image 2", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7307), "variant_77_image_2.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7308), 77 },
                    { 383, "Product variant 77 mockup image 3", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7319), "variant_77_image_3.jpg", "https://picsum.photos/seed/mockup28/800/600", true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7320), 77 },
                    { 384, "Product variant 77 mockup image 4", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7330), "variant_77_image_4.jpg", "https://picsum.photos/seed/mockup19/800/600", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7332), 77 },
                    { 385, "Product variant 77 mockup image 5", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7366), "variant_77_image_5.jpg", "https://picsum.photos/seed/mockup23/800/600", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7368), 77 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 386, "Product variant 78 mockup image 1", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7382), "variant_78_image_1.jpg", "https://picsum.photos/seed/mockup12/800/600", true, true, "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7384), 78 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 387, "Product variant 78 mockup image 2", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7394), "variant_78_image_2.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7396), 78 },
                    { 388, "Product variant 78 mockup image 3", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7407), "variant_78_image_3.jpg", "https://picsum.photos/seed/mockup9/800/600", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7409), 78 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 391, "Product variant 79 mockup image 1", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7421), "variant_79_image_1.jpg", "https://picsum.photos/seed/mockup15/800/600", true, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7423), 79 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 392, "Product variant 79 mockup image 2", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7434), "variant_79_image_2.jpg", "https://picsum.photos/seed/mockup21/800/600", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7436), 79 },
                    { 393, "Product variant 79 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7445), "variant_79_image_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7447), 79 },
                    { 394, "Product variant 79 mockup image 4", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7457), "variant_79_image_4.jpg", "https://picsum.photos/seed/mockup24/800/600", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7461), 79 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 396, "Product variant 80 mockup image 1", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7471), "variant_80_image_1.jpg", "https://picsum.photos/seed/mockup9/800/600", true, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7473), 80 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 397, "Product variant 80 mockup image 2", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7483), "variant_80_image_2.jpg", "https://images.unsplash.com/photo-6Nub980bI3I?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7485), 80 },
                    { 398, "Product variant 80 mockup image 3", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7495), "variant_80_image_3.jpg", "https://picsum.photos/seed/mockup8/800/600", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7497), 80 },
                    { 399, "Product variant 80 mockup image 4", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7507), "variant_80_image_4.jpg", "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7509), 80 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 401, "Product variant 81 mockup image 1", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7521), "variant_81_image_1.jpg", "https://picsum.photos/seed/mockup28/800/600", true, true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7523), 81 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 402, "Product variant 81 mockup image 2", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7533), "variant_81_image_2.jpg", "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7536), 81 },
                    { 403, "Product variant 81 mockup image 3", "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7545), "variant_81_image_3.jpg", "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7548), 81 },
                    { 404, "Product variant 81 mockup image 4", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7558), "variant_81_image_4.jpg", "https://images.unsplash.com/photo-ItL2yJq4gU4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7561), 81 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 406, "Product variant 82 mockup image 1", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7573), "variant_82_image_1.jpg", "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7574), 82 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 407, "Product variant 82 mockup image 2", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7584), "variant_82_image_2.jpg", "https://images.unsplash.com/photo-KeJkQ5mVvvk?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7586), 82 },
                    { 408, "Product variant 82 mockup image 3", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7595), "variant_82_image_3.jpg", "https://picsum.photos/seed/mockup17/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7597), 82 },
                    { 409, "Product variant 82 mockup image 4", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7606), "variant_82_image_4.jpg", "https://images.unsplash.com/photo-7WE1LbSc4zM?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7608), 82 },
                    { 410, "Product variant 82 mockup image 5", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7619), "variant_82_image_5.jpg", "https://picsum.photos/seed/mockup6/800/600", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7621), 82 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 411, "Product variant 83 mockup image 1", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7633), "variant_83_image_1.jpg", "https://images.unsplash.com/photo-KeJkQ5mVvvk?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7635), 83 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 412, "Product variant 83 mockup image 2", "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7645), "variant_83_image_2.jpg", "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7647), 83 },
                    { 413, "Product variant 83 mockup image 3", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7679), "variant_83_image_3.jpg", "https://images.unsplash.com/photo-7WE1LbSc4zM?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7682), 83 },
                    { 414, "Product variant 83 mockup image 4", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7694), "variant_83_image_4.jpg", "https://picsum.photos/seed/mockup29/800/600", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7697), 83 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 416, "Product variant 84 mockup image 1", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7707), "variant_84_image_1.jpg", "https://images.unsplash.com/photo-KeJkQ5mVvvk?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7709), 84 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 417, "Product variant 84 mockup image 2", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7720), "variant_84_image_2.jpg", "https://picsum.photos/seed/mockup8/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7722), 84 },
                    { 418, "Product variant 84 mockup image 3", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7731), "variant_84_image_3.jpg", "https://picsum.photos/seed/mockup8/800/600", true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7733), 84 },
                    { 419, "Product variant 84 mockup image 4", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7744), "variant_84_image_4.jpg", "https://images.unsplash.com/photo-acn5ERAeSb4?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7746), 84 },
                    { 420, "Product variant 84 mockup image 5", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7757), "variant_84_image_5.jpg", "https://picsum.photos/seed/mockup15/800/600", true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7758), 84 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 421, "Product variant 85 mockup image 1", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7770), "variant_85_image_1.jpg", "https://images.unsplash.com/photo-fTDWpCxLA0k?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7771), 85 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 422, "Product variant 85 mockup image 2", "admin-001", new DateTime(2025, 8, 15, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7783), "variant_85_image_2.jpg", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7785), 85 },
                    { 423, "Product variant 85 mockup image 3", "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7795), "variant_85_image_3.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7797), 85 },
                    { 424, "Product variant 85 mockup image 4", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7807), "variant_85_image_4.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7809), 85 },
                    { 425, "Product variant 85 mockup image 5", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7821), "variant_85_image_5.jpg", "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7824), 85 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 426, "Product variant 86 mockup image 1", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7916), "variant_86_image_1.jpg", "https://picsum.photos/seed/mockup25/800/600", true, true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7919), 86 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 427, "Product variant 86 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7931), "variant_86_image_2.jpg", "https://picsum.photos/seed/mockup30/800/600", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7933), 86 },
                    { 428, "Product variant 86 mockup image 3", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7943), "variant_86_image_3.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7945), 86 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 431, "Product variant 87 mockup image 1", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7956), "variant_87_image_1.jpg", "https://picsum.photos/seed/mockup21/800/600", true, true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7958), 87 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 432, "Product variant 87 mockup image 2", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7969), "variant_87_image_2.jpg", "https://picsum.photos/seed/mockup3/800/600", true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7971), 87 },
                    { 433, "Product variant 87 mockup image 3", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7980), "variant_87_image_3.jpg", "https://images.unsplash.com/photo-lMcxXplVycA?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7983), 87 },
                    { 434, "Product variant 87 mockup image 4", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7993), "variant_87_image_4.jpg", "https://picsum.photos/seed/mockup9/800/600", true, "admin-001", new DateTime(2025, 8, 11, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(7995), 87 },
                    { 435, "Product variant 87 mockup image 5", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8005), "variant_87_image_5.jpg", "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8007), 87 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 436, "Product variant 88 mockup image 1", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8018), "variant_88_image_1.jpg", "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8020), 88 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 437, "Product variant 88 mockup image 2", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8030), "variant_88_image_2.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8033), 88 },
                    { 438, "Product variant 88 mockup image 3", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8044), "variant_88_image_3.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8045), 88 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 441, "Product variant 89 mockup image 1", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8056), "variant_89_image_1.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8058), 89 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 442, "Product variant 89 mockup image 2", "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8097), "variant_89_image_2.jpg", "https://picsum.photos/seed/mockup19/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8099), 89 },
                    { 443, "Product variant 89 mockup image 3", "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8108), "variant_89_image_3.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8110), 89 },
                    { 444, "Product variant 89 mockup image 4", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8121), "variant_89_image_4.jpg", "https://picsum.photos/seed/mockup16/800/600", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8122), 89 },
                    { 445, "Product variant 89 mockup image 5", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8133), "variant_89_image_5.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8135), 89 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 446, "Product variant 90 mockup image 1", "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8146), "variant_90_image_1.jpg", "https://picsum.photos/seed/mockup12/800/600", true, true, "admin-001", new DateTime(2025, 7, 30, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8148), 90 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 447, "Product variant 90 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8159), "variant_90_image_2.jpg", "https://images.unsplash.com/photo-1553735105-c4de0ad64d53?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8161), 90 },
                    { 448, "Product variant 90 mockup image 3", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8171), "variant_90_image_3.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8173), 90 },
                    { 449, "Product variant 90 mockup image 4", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8183), "variant_90_image_4.jpg", "https://picsum.photos/seed/mockup8/800/600", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8185), 90 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 451, "Product variant 91 mockup image 1", "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8197), "variant_91_image_1.jpg", "https://images.unsplash.com/photo-1586023492125-27b2c045efd7?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8199), 91 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 452, "Product variant 91 mockup image 2", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8210), "variant_91_image_2.jpg", "https://picsum.photos/seed/mockup12/800/600", true, "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8211), 91 },
                    { 453, "Product variant 91 mockup image 3", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8221), "variant_91_image_3.jpg", "https://picsum.photos/seed/mockup29/800/600", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8223), 91 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 456, "Product variant 92 mockup image 1", "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8234), "variant_92_image_1.jpg", "https://picsum.photos/seed/mockup29/800/600", true, true, "admin-001", new DateTime(2025, 8, 1, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8236), 92 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 457, "Product variant 92 mockup image 2", "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8249), "variant_92_image_2.jpg", "https://picsum.photos/seed/mockup2/800/600", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8251), 92 },
                    { 458, "Product variant 92 mockup image 3", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8260), "variant_92_image_3.jpg", "https://picsum.photos/seed/mockup16/800/600", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8262), 92 },
                    { 459, "Product variant 92 mockup image 4", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8272), "variant_92_image_4.jpg", "https://images.unsplash.com/photo-Q0zoxQF7OUY?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8274), 92 },
                    { 460, "Product variant 92 mockup image 5", "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8288), "variant_92_image_5.jpg", "https://images.unsplash.com/photo-gEupiRvyxh0?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8289), 92 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 461, "Product variant 93 mockup image 1", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8300), "variant_93_image_1.jpg", "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 25, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8302), 93 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 462, "Product variant 93 mockup image 2", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8312), "variant_93_image_2.jpg", "https://picsum.photos/seed/mockup27/800/600", true, "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8313), 93 },
                    { 463, "Product variant 93 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8322), "variant_93_image_3.jpg", "https://images.unsplash.com/photo-lMcxXplVycA?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8324), 93 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 466, "Product variant 94 mockup image 1", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8334), "variant_94_image_1.jpg", "https://images.unsplash.com/photo-fTDWpCxLA0k?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8336), 94 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 467, "Product variant 94 mockup image 2", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8345), "variant_94_image_2.jpg", "https://images.unsplash.com/photo-7WE1LbSc4zM?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8347), 94 },
                    { 468, "Product variant 94 mockup image 3", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8357), "variant_94_image_3.jpg", "https://images.unsplash.com/photo-tWOz2_EK5EQ?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8359), 94 },
                    { 469, "Product variant 94 mockup image 4", "admin-001", new DateTime(2025, 8, 2, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8368), "variant_94_image_4.jpg", "https://images.unsplash.com/photo-ogmenj2NGho?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8370), 94 },
                    { 470, "Product variant 94 mockup image 5", "admin-001", new DateTime(2025, 8, 18, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8402), "variant_94_image_5.jpg", "https://images.unsplash.com/photo-elbKS4DY21g?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8405), 94 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 471, "Product variant 95 mockup image 1", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8416), "variant_95_image_1.jpg", "https://picsum.photos/seed/mockup9/800/600", true, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8418), 95 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 472, "Product variant 95 mockup image 2", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8429), "variant_95_image_2.jpg", "https://picsum.photos/seed/mockup5/800/600", true, "admin-001", new DateTime(2025, 8, 8, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8430), 95 },
                    { 473, "Product variant 95 mockup image 3", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8439), "variant_95_image_3.jpg", "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8441), 95 },
                    { 474, "Product variant 95 mockup image 4", "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8450), "variant_95_image_4.jpg", "https://images.unsplash.com/photo-x8Vg7Up6TUc?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8451), 95 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 476, "Product variant 96 mockup image 1", "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8461), "variant_96_image_1.jpg", "https://picsum.photos/seed/mockup17/800/600", true, true, "admin-001", new DateTime(2025, 8, 10, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8463), 96 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 477, "Product variant 96 mockup image 2", "admin-001", new DateTime(2025, 8, 22, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8474), "variant_96_image_2.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8476), 96 },
                    { 478, "Product variant 96 mockup image 3", "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8486), "variant_96_image_3.jpg", "https://picsum.photos/seed/mockup18/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8488), 96 },
                    { 479, "Product variant 96 mockup image 4", "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8497), "variant_96_image_4.jpg", "https://images.unsplash.com/photo-RrOw2yodWpo?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8499), 96 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 481, "Product variant 97 mockup image 1", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8511), "variant_97_image_1.jpg", "https://picsum.photos/seed/mockup7/800/600", true, true, "admin-001", new DateTime(2025, 8, 19, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8512), 97 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 482, "Product variant 97 mockup image 2", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8522), "variant_97_image_2.jpg", "https://picsum.photos/seed/mockup9/800/600", true, "admin-001", new DateTime(2025, 8, 4, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8524), 97 },
                    { 483, "Product variant 97 mockup image 3", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8533), "variant_97_image_3.jpg", "https://picsum.photos/seed/mockup20/800/600", true, "admin-001", new DateTime(2025, 8, 9, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8535), 97 },
                    { 484, "Product variant 97 mockup image 4", "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8544), "variant_97_image_4.jpg", "https://picsum.photos/seed/mockup22/800/600", true, "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8546), 97 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 486, "Product variant 98 mockup image 1", "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8556), "variant_98_image_1.jpg", "https://picsum.photos/seed/mockup1/800/600", true, true, "admin-001", new DateTime(2025, 8, 3, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8558), 98 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 487, "Product variant 98 mockup image 2", "admin-001", new DateTime(2025, 8, 6, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8567), "variant_98_image_2.jpg", "https://picsum.photos/seed/mockup9/800/600", true, "admin-001", new DateTime(2025, 8, 24, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8569), 98 },
                    { 488, "Product variant 98 mockup image 3", "admin-001", new DateTime(2025, 8, 12, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8578), "variant_98_image_3.jpg", "https://picsum.photos/seed/mockup23/800/600", true, "admin-001", new DateTime(2025, 8, 21, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8580), 98 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 491, "Product variant 99 mockup image 1", "admin-001", new DateTime(2025, 8, 20, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8590), "variant_99_image_1.jpg", "https://images.unsplash.com/photo-kkj9iKxsdhY?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8592), 99 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 492, "Product variant 99 mockup image 2", "admin-001", new DateTime(2025, 8, 16, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8602), "variant_99_image_2.jpg", "https://images.unsplash.com/photo-tT6k5S0fvxs?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 17, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8604), 99 },
                    { 493, "Product variant 99 mockup image 3", "admin-001", new DateTime(2025, 7, 29, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8615), "variant_99_image_3.jpg", "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 13, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8617), 99 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "IsPrimary", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[] { 496, "Product variant 100 mockup image 1", "admin-001", new DateTime(2025, 7, 28, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8628), "variant_100_image_1.jpg", "https://images.unsplash.com/photo-kkj9iKxsdhY?w=800&h=600&fit=crop", true, true, "admin-001", new DateTime(2025, 8, 23, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8630), 100 });

            migrationBuilder.InsertData(
                table: "ProductVariantImages",
                columns: new[] { "Id", "AltText", "CreatedBy", "CreatedOn", "FileName", "ImageUrl", "IsActive", "LastModifiedBy", "LastModifiedOn", "ProductVariantId" },
                values: new object[,]
                {
                    { 497, "Product variant 100 mockup image 2", "admin-001", new DateTime(2025, 7, 31, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8639), "variant_100_image_2.jpg", "https://picsum.photos/seed/mockup14/800/600", true, "admin-001", new DateTime(2025, 8, 14, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8641), 100 },
                    { 498, "Product variant 100 mockup image 3", "admin-001", new DateTime(2025, 8, 7, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8651), "variant_100_image_3.jpg", "https://images.unsplash.com/photo-1556821840-3a9fbc8e7449?w=800&h=600&fit=crop", true, "admin-001", new DateTime(2025, 8, 5, 15, 35, 45, 765, DateTimeKind.Utc).AddTicks(8653), 100 }
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
                name: "IX_DesignImages_DsignId",
                table: "DesignImages",
                column: "DsignId");

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
                name: "IX_Designs_ArtistId",
                table: "Designs",
                column: "ArtistId");

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
                name: "DesignImages");

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
