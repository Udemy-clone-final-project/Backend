using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
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
                name: "DeliveryMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMethods", x => x.Id);
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
                name: "Address",
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
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AspNetUsers_ApplicationUserId",
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
                });

            migrationBuilder.CreateTable(
                name: "BaseProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HasSizes = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    HasColors = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProducts", x => x.Id);
                    table.CheckConstraint("CK_BaseProducts_BasePrice_Positive", "[BasePrice] > 0");
                    table.ForeignKey(
                        name: "FK_BaseProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShippingAddress_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryMethodId = table.Column<int>(type: "int", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_DeliveryMethods_DeliveryMethodId",
                        column: x => x.DeliveryMethodId,
                        principalTable: "DeliveryMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "BaseProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseProductId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PriceModifier = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    ColorSpecificMockupUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProductColors", x => x.Id);
                    table.CheckConstraint("CK_BaseProductColors_PriceModifier", "[PriceModifier] >= -1000 AND [PriceModifier] <= 1000");
                    table.ForeignKey(
                        name: "FK_BaseProductColors_BaseProducts_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "BaseProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseProductColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaseProductPrintAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseProductId = table.Column<int>(type: "int", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PositionX = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PositionY = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MinDPI = table.Column<int>(type: "int", nullable: false, defaultValue: 300),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProductPrintAreas", x => x.Id);
                    table.CheckConstraint("CK_PrintAreas_DisplayOrder_Positive", "[DisplayOrder] > 0");
                    table.CheckConstraint("CK_PrintAreas_Height_Positive", "[Height] > 0");
                    table.CheckConstraint("CK_PrintAreas_MinDPI_Range", "[MinDPI] >= 72 AND [MinDPI] <= 600");
                    table.CheckConstraint("CK_PrintAreas_Position_NonNegative", "[PositionX] >= 0 AND [PositionY] >= 0");
                    table.CheckConstraint("CK_PrintAreas_Width_Positive", "[Width] > 0");
                    table.ForeignKey(
                        name: "FK_BaseProductPrintAreas_BaseProducts_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "BaseProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaseProductSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseProductId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PriceModifier = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProductSizes", x => x.Id);
                    table.CheckConstraint("CK_BaseProductSizes_PriceModifier", "[PriceModifier] >= -1000 AND [PriceModifier] <= 1000");
                    table.ForeignKey(
                        name: "FK_BaseProductSizes_BaseProducts_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "BaseProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseProductSizes_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaseProductTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseProductId = table.Column<int>(type: "int", nullable: false),
                    ViewName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TemplateUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MockupUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FlatMockupUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TemplateWidth = table.Column<int>(type: "int", nullable: false),
                    TemplateHeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProductTemplates", x => x.Id);
                    table.CheckConstraint("CK_Templates_DisplayOrder_Positive", "[DisplayOrder] > 0");
                    table.CheckConstraint("CK_Templates_TemplateHeight_Range", "[TemplateHeight] >= 100 AND [TemplateHeight] <= 5000");
                    table.CheckConstraint("CK_Templates_TemplateWidth_Range", "[TemplateWidth] >= 100 AND [TemplateWidth] <= 5000");
                    table.ForeignKey(
                        name: "FK_BaseProductTemplates_BaseProducts_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "BaseProducts",
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    BaseProductId = table.Column<int>(type: "int", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true)
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
                    ProductVariantOrdered_VariantId = table.Column<int>(type: "int", nullable: false),
                    ProductVariantOrdered_DesignTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductVariantOrdered_ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductVariantOrdered_PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductVariantOrdered_ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductVariantOrdered_SizeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductVariantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id");
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
                    ProductVariantId = table.Column<int>(type: "int", nullable: false)
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
                    { "1", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System Administrator with full access to manage products and designs", true, "Admin", "ADMIN" },
                    { "2", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer who can browse and purchase products", true, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "admin-001", 0, "d89cfd48-0b4e-4ac3-962d-357e6327790d", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System Administrator", "admin@redbubble.com", true, true, false, null, "ADMIN@REDBUBBLE.COM", "ADMIN@REDBUBBLE.COM", "AQAAAAIAAYagAAAAENEHrxq2WfsHwWfw1l6I9h1C13uTC+uVDNVRUiXtr0b+vYtXT2kqGJY1SNX6JxAKuw==", null, false, "0d6ff3b4-edd5-4491-95c0-cb9c0b2d6d77", false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@redbubble.com" },
                    { "customer-001", 0, "f93e5acc-8313-42d6-8120-925f14669ea6", new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", "customer001@example.com", true, true, false, null, "CUSTOMER001@EXAMPLE.COM", "CUSTOMER001@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG3IS5wkeOOHxJ9fdjjnsBp7bUhCRmnFwDxCgGAeRqxusRVmzHhrZEHinUGofcFrOg==", null, false, "e251c6c4-6d48-4dc2-882a-8f5849b4b415", false, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer001@example.com" },
                    { "customer-002", 0, "008bf57d-3452-430a-ab71-17f87a9a50e4", new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", "customer002@example.com", true, true, false, null, "CUSTOMER002@EXAMPLE.COM", "CUSTOMER002@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG8hBkHrvWE/9OKQ+4El+11Qd4/ppgK95N6AWcr5WABaMtg6AXP0nqRsS0q8goQrYQ==", null, false, "7ca57249-b173-4b74-857c-4786c5603758", false, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer002@example.com" },
                    { "customer-003", 0, "50d8528f-f4da-4534-9ddf-986239cca897", new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Johnson", "customer003@example.com", true, true, false, null, "CUSTOMER003@EXAMPLE.COM", "CUSTOMER003@EXAMPLE.COM", "AQAAAAIAAYagAAAAED9ZW6hO3H11Q+SYDwF6308YaqXXhiqBkVNWjjwEaAGdukJDQxvf8D/m6sG7HYleNw==", null, false, "fbb7ef33-b1d9-4ff3-b47b-838d40a90a84", false, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer003@example.com" },
                    { "customer-004", 0, "d2cc5179-1f97-4697-b2a3-b3759fd482b5", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah Williams", "customer004@example.com", true, true, false, null, "CUSTOMER004@EXAMPLE.COM", "CUSTOMER004@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJtZLRS+lJ0sPpPyNMWpCDMIH7968Ynhh82jmLEQ7IufLXm5mhcE4/rtKeDoh7/qJQ==", null, false, "585b8a4c-cf34-44e1-81b3-8ffd01db6a56", false, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer004@example.com" },
                    { "customer-005", 0, "07ab89ac-7dba-4230-b7ff-738f7344c6ed", new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Brown", "customer005@example.com", true, true, false, null, "CUSTOMER005@EXAMPLE.COM", "CUSTOMER005@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBWOJA1n3iua6U5Gn/cugw+KU6GYYjGa7/UGOZmIq02AVGO5RSGXlFZ5llBzf+B1Fw==", null, false, "0b2e6ee0-2e28-45c5-b9b9-020571e345f7", false, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer005@example.com" },
                    { "customer-006", 0, "adff1d58-100f-440a-ba90-f5ff1f5372fc", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Davis", "customer006@example.com", true, true, false, null, "CUSTOMER006@EXAMPLE.COM", "CUSTOMER006@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJaDxQCNDPc3zL6KuQgqWdUb1Lr5iadH0Wt7LRkKig/4veksLtQZ+wA9uGx9hhAEBQ==", null, false, "0b248334-a970-4508-9580-3235b0f9d339", false, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer006@example.com" },
                    { "customer-007", 0, "7768c4c5-2d72-45c3-bbb1-69b5148665dd", new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher Wilson", "customer007@example.com", true, true, false, null, "CUSTOMER007@EXAMPLE.COM", "CUSTOMER007@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIokplx3fQwrY4XzGqN0qshgj9LWlR+C2Gd/rrZnzSf7esO4BKndECv1BL8aO2ibeQ==", null, false, "34eade0f-b8e6-418c-aded-efdeca591959", false, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer007@example.com" },
                    { "customer-008", 0, "a408f4a3-41dd-465b-83c0-124cc10582a1", new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica Martinez", "customer008@example.com", true, true, false, null, "CUSTOMER008@EXAMPLE.COM", "CUSTOMER008@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJXK4InDLd6XTsap25KUvXlpdDi7L3KRvugp+qIEwSIZLZZuBNxmQ7UoLZ99rWHLbA==", null, false, "f4fd1553-5f22-4b61-9d4c-8851ae43c7d2", false, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer008@example.com" },
                    { "customer-009", 0, "f90bb67b-63ec-447b-a79c-b06155b8aae1", new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel Anderson", "customer009@example.com", true, true, false, null, "CUSTOMER009@EXAMPLE.COM", "CUSTOMER009@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOthq+16pY6oZeRXMsIbdOob/J6an2cWZRfWfw4VSZOgCrWpIjs36eIeAtTDiwSlhA==", null, false, "d725176a-70f7-4871-955d-55a7d624aa7f", false, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer009@example.com" },
                    { "customer-010", 0, "a8ed22c5-2f0b-48c8-b360-65ab3df263a6", new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashley Taylor", "customer010@example.com", true, true, false, null, "CUSTOMER010@EXAMPLE.COM", "CUSTOMER010@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJlXHV7PjUBh42ML82x+SDzSV+Ra/vuZMs+xovaL0+/mUqLtzMd72DiVgjNbb0LgTA==", null, false, "1086e8c4-afbc-4428-b2d2-81d6f83471bf", false, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer010@example.com" },
                    { "customer-011", 0, "5cfa1131-1467-4075-b789-a87823709ff2", new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew Thomas", "customer011@example.com", true, true, false, null, "CUSTOMER011@EXAMPLE.COM", "CUSTOMER011@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJMRt4om/U8jQtaYNxkXLDppUzm1HHFn5Bgussf+JPYVTvlbYfbEOZI8Ts9xX7hjIQ==", null, false, "5404727f-7f5f-4887-a439-b89ba575812f", false, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer011@example.com" },
                    { "customer-012", 0, "94ca2782-697c-4c90-9c73-c9e8f4530651", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda Jackson", "customer012@example.com", true, true, false, null, "CUSTOMER012@EXAMPLE.COM", "CUSTOMER012@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH8DFmclOT4eQa35Tu73HRM6P1NLgqyu4THg1AY55gYWw6CAEpXRmClKFiE6U4xxwg==", null, false, "4c14b5ee-97bc-4c3e-8a55-729a3a8f21b4", false, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer012@example.com" },
                    { "customer-013", 0, "0f43c1da-38b3-445b-b58d-f390cd9335a4", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua White", "customer013@example.com", true, true, false, null, "CUSTOMER013@EXAMPLE.COM", "CUSTOMER013@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBBKSP8hZ2fzsTEMa/+JZNVBXGAfl+lolUm80ta+M/A87vZiOTh1gteAS/dNVlVkzw==", null, false, "56cd0f47-d7f1-4544-9d1c-ed49d04ac19a", false, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer013@example.com" },
                    { "customer-014", 0, "ecfecb09-8eed-4692-a93d-9517aa1d18e2", new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie Harris", "customer014@example.com", true, true, false, null, "CUSTOMER014@EXAMPLE.COM", "CUSTOMER014@EXAMPLE.COM", "AQAAAAIAAYagAAAAEClsuAArctdtLIysyfKOKeR4dDlRMBS++V+HgC6zvSRs3Uw07GhFFq2Qum6lam6+jQ==", null, false, "231e71a0-89ae-4388-b371-bdf982ffc671", false, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer014@example.com" },
                    { "customer-015", 0, "f31928b5-d939-448c-83f8-78a1b98a2372", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew Martin", "customer015@example.com", true, true, false, null, "CUSTOMER015@EXAMPLE.COM", "CUSTOMER015@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM2A/ouAfwto6u9vfd/pOjrKK3VbBST7gvNNN1Q0qgqh5oPITvcDu2jXB8aSyqe1WQ==", null, false, "f65a400b-1c9a-4de6-8376-e1def8d1eb13", false, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer015@example.com" },
                    { "customer-016", 0, "1b7aef7d-ada7-49d0-aae0-9a56fda79a77", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole Thompson", "customer016@example.com", true, true, false, null, "CUSTOMER016@EXAMPLE.COM", "CUSTOMER016@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG4EzjRyY0/G3QCX27SkmryWMQsfPOAhxPmijGhvMNkgyZWvL/O9mM8ifysDCoBWiQ==", null, false, "bf52bc87-8c32-4332-b6bf-9f56f5f1a72b", false, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer016@example.com" },
                    { "customer-017", 0, "a301036e-fc3c-41a1-92d6-ed23f69e87f4", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan Garcia", "customer017@example.com", true, true, false, null, "CUSTOMER017@EXAMPLE.COM", "CUSTOMER017@EXAMPLE.COM", "AQAAAAIAAYagAAAAEILWEslcy1wlvoCSmWATPrMy0uqHhLQqqAmbjfZ8ibRLPy887Nz29e0MrzWCbqliYw==", null, false, "26106778-06f2-497a-a06c-6bc73fe755f6", false, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer017@example.com" },
                    { "customer-018", 0, "def01534-e439-407e-b07e-e3367081d20a", new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heather Martinez", "customer018@example.com", true, true, false, null, "CUSTOMER018@EXAMPLE.COM", "CUSTOMER018@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMIKpWvq0/02XezYUKPgsFsASY9HX35LkXGysPZ+KV7vLOuxyoODVBEJDxClVW1hAQ==", null, false, "74201c63-d1e8-49aa-ba0d-f4851878c40e", false, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer018@example.com" },
                    { "customer-019", 0, "fc800a07-ec18-4571-883f-52f274aa7c5e", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin Robinson", "customer019@example.com", true, true, false, null, "CUSTOMER019@EXAMPLE.COM", "CUSTOMER019@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA/p0u1YKdfnz4Vepnwb/EasXK8SWK2xCCPjk7dQCxIpGrOLm/qLzgCP3K47kKwSTg==", null, false, "433abf9a-a601-4532-89e7-cc478cf29b07", false, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer019@example.com" },
                    { "customer-020", 0, "67765cb7-3e17-486e-8cb0-0441f2135d41", new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rachel Clark", "customer020@example.com", true, true, false, null, "CUSTOMER020@EXAMPLE.COM", "CUSTOMER020@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP0pV+dKw6ItPjdJEMgN6DLM4XQCOYnMzFvkYCtfR4v3PYUO2TmfJOQ2Rf0jBObE0g==", null, false, "e7d9477e-acd4-4bc9-9afc-e8c3b660d1d1", false, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer020@example.com" },
                    { "customer-021", 0, "6cd27e28-0203-4292-ad94-f30276c6ae34", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandon Rodriguez", "customer021@example.com", true, true, false, null, "CUSTOMER021@EXAMPLE.COM", "CUSTOMER021@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMAJvpNY6Z57k9gk76KEd59qFxyEk8WdDURNGUNAznj3+rCbraG8I/tVzTvv0d9SOA==", null, false, "57f74f69-d982-4339-927a-b2ccb2a73f1c", false, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer021@example.com" },
                    { "customer-022", 0, "11e0252a-60c2-4804-a234-aa5b329b5c2a", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren Lewis", "customer022@example.com", true, true, false, null, "CUSTOMER022@EXAMPLE.COM", "CUSTOMER022@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOoCg1A/pj+dA3mReiJZTeKsWizUFtdiY/LgSflcPW3DcFjyqo5znYn2HSB8DfO5Ow==", null, false, "7a70d589-c90d-47c4-81ee-4c2edd7399d2", false, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer022@example.com" },
                    { "customer-023", 0, "cc330585-0634-4d6d-ad71-cd07cc33726c", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler Lee", "customer023@example.com", true, true, false, null, "CUSTOMER023@EXAMPLE.COM", "CUSTOMER023@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG/aZteFXlpKB5kM6VjHTCXewU+mmenJthbqN6LHwnNgM+B42IP/XKlb5O2ypbWC7w==", null, false, "6ab4cd96-13ec-4089-a157-fc0e2b1f8259", false, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer023@example.com" },
                    { "customer-024", 0, "a288cf77-2bcd-4db8-bed3-ecae43253742", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samantha Walker", "customer024@example.com", true, true, false, null, "CUSTOMER024@EXAMPLE.COM", "CUSTOMER024@EXAMPLE.COM", "AQAAAAIAAYagAAAAECXZKio9HHPkm6RfpSvT2Z89Yg+STofLc0XbaAfb2l0S0uKrEuuUXe+1NCKtyvIViA==", null, false, "56948ffb-9dfd-4927-828b-bd7ec0515316", false, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer024@example.com" },
                    { "customer-025", 0, "ae7d5bd3-5c54-4f05-986f-7c9b2841a48a", new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justin Hall", "customer025@example.com", true, true, false, null, "CUSTOMER025@EXAMPLE.COM", "CUSTOMER025@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMV2ErgOBFhibtuiI0uN7/1l76bCzBdq/mOxwiY9BGcalMdN79ozKVETGSMMTHDGgw==", null, false, "d97a7e2d-eef8-4bfd-9994-ce8347a6a312", false, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer025@example.com" },
                    { "customer-026", 0, "02fb1f90-44cf-4b0d-a209-c4d6e20c4425", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan Allen", "customer026@example.com", true, true, false, null, "CUSTOMER026@EXAMPLE.COM", "CUSTOMER026@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKJp1rF9c1qxZT+LoK4xBPkeg+jMOhcJxLsmeP5MINcFjIIu9SrgBVUBh5hfFf5UTQ==", null, false, "d48ce552-911a-44ae-acd5-305e745af1c9", false, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer026@example.com" },
                    { "customer-027", 0, "492fc25a-957d-45a8-b012-acad6c666995", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob Young", "customer027@example.com", true, true, false, null, "CUSTOMER027@EXAMPLE.COM", "CUSTOMER027@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGYoPvnF1/FKOMDNSxey+liWd3EnjrMV0tIahWURkgig46JNa0ptw/TNVGm2fe7vFg==", null, false, "9d4152fd-6035-4ade-b40b-3a5ebd3d86ae", false, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer027@example.com" },
                    { "customer-028", 0, "e03b4932-325e-47b7-865b-16600452be90", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayla King", "customer028@example.com", true, true, false, null, "CUSTOMER028@EXAMPLE.COM", "CUSTOMER028@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFxkVAe/0EcQDa05b1OwRpZnftAGk9ReEcwKUQySqw4NbvbA8Dqrea6MSjtcW02Ccg==", null, false, "198e9799-aecd-4312-99ab-590e1797b2aa", false, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer028@example.com" },
                    { "customer-029", 0, "8f157346-3ead-433f-a074-6b9733955e52", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan Wright", "customer029@example.com", true, true, false, null, "CUSTOMER029@EXAMPLE.COM", "CUSTOMER029@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM6uE3HBgv+FAoTTWIm9LSqcQh6pF67or0XFm+h7rLDWi0VpYZpXRpj5U+YW15snJA==", null, false, "5232a21e-cfd7-410b-a632-b9ccf2dc9f9d", false, new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer029@example.com" },
                    { "customer-030", 0, "d4bdae27-e275-4599-8765-fb55cadc5719", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brittany Lopez", "customer030@example.com", true, true, false, null, "CUSTOMER030@EXAMPLE.COM", "CUSTOMER030@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBco2jQH0X9iTa7IroQl2qOvCvKCIUhseNw8FMAhPLt1w7Qu6k6Rl2c/PhbQUcSsuQ==", null, false, "20dc775b-8b5f-40c7-b3d7-f8db5f20ba25", false, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer030@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Clothing", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel and wearable items for all ages", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Accessories", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fashion and lifestyle accessories", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Home & Living", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home decor and lifestyle items", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Stickers & Decals", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Decorative stickers and decals", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Wall Art", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prints, posters, and wall decorations", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Stationery & Office", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Notebooks, cards, and office supplies", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "Bags & Purses", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tote bags, backpacks, and purses", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Tech Accessories", "admin-001", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone cases and tech accessories", true, "admin-001", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
                table: "Address",
                columns: new[] { "Id", "ApplicationUserId", "City", "Country", "FirstName", "LastName", "Street" },
                values: new object[,]
                {
                    { 1, "customer-001", "San Jose", "Spain", "Customer1", "User", "9846 Main St" },
                    { 2, "customer-002", "San Diego", "USA", "Customer2", "User", "8134 Main St" },
                    { 3, "customer-003", "Los Angeles", "Canada", "Customer3", "User", "268 Main St" },
                    { 4, "customer-004", "San Jose", "Germany", "Customer4", "User", "6337 Main St" },
                    { 5, "customer-005", "Phoenix", "USA", "Customer5", "User", "1972 Main St" },
                    { 6, "customer-006", "Philadelphia", "United Kingdom", "Customer6", "User", "8478 Main St" },
                    { 7, "customer-007", "San Jose", "Canada", "Customer7", "User", "167 Main St" },
                    { 8, "customer-008", "San Diego", "USA", "Customer8", "User", "342 Main St" },
                    { 9, "customer-009", "San Antonio", "Italy", "Customer9", "User", "7570 Main St" },
                    { 10, "customer-010", "Philadelphia", "Canada", "Customer10", "User", "9003 Main St" },
                    { 11, "customer-011", "Dallas", "Spain", "Customer11", "User", "5999 Main St" },
                    { 12, "customer-012", "Philadelphia", "USA", "Customer12", "User", "815 Main St" },
                    { 13, "customer-013", "Chicago", "Germany", "Customer13", "User", "9180 Main St" },
                    { 14, "customer-014", "San Jose", "Netherlands", "Customer14", "User", "7991 Main St" },
                    { 15, "customer-015", "Los Angeles", "Spain", "Customer15", "User", "4980 Main St" },
                    { 16, "customer-016", "Los Angeles", "Australia", "Customer16", "User", "1223 Main St" },
                    { 17, "customer-017", "Phoenix", "Spain", "Customer17", "User", "1715 Main St" },
                    { 18, "customer-018", "New York", "France", "Customer18", "User", "1633 Main St" },
                    { 19, "customer-019", "San Jose", "Canada", "Customer19", "User", "8248 Main St" },
                    { 20, "customer-020", "New York", "Canada", "Customer20", "User", "7438 Main St" },
                    { 21, "customer-021", "Los Angeles", "Italy", "Customer21", "User", "3695 Main St" },
                    { 22, "customer-022", "New York", "USA", "Customer22", "User", "638 Main St" },
                    { 23, "customer-023", "Los Angeles", "Netherlands", "Customer23", "User", "7393 Main St" },
                    { 24, "customer-024", "San Jose", "Australia", "Customer24", "User", "9852 Main St" },
                    { 25, "customer-025", "Chicago", "USA", "Customer25", "User", "8495 Main St" },
                    { 26, "customer-026", "Philadelphia", "France", "Customer26", "User", "2789 Main St" },
                    { 27, "customer-027", "San Antonio", "Germany", "Customer27", "User", "2525 Main St" },
                    { 28, "customer-028", "San Diego", "USA", "Customer28", "User", "3079 Main St" },
                    { 29, "customer-029", "Phoenix", "Netherlands", "Customer29", "User", "4457 Main St" },
                    { 30, "customer-030", "Chicago", "Italy", "Customer30", "User", "2198 Main St" }
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
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 9, "T-Shirts", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic and graphic t-shirts for all occasions", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, "Tank Tops", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable sleeveless tank tops", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, "Long Sleeve Shirts", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cozy long sleeve t-shirts", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, "Hoodies & Sweatshirts", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm pullover hoodies and sweatshirts", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, "Zip Hoodies", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Full-zip hoodies and jackets", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, "Crewneck Sweatshirts", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic crewneck style sweatshirts", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, "Dresses", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casual and dressy options for all styles", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, "Skirts", "admin-001", new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mini, midi, and maxi skirts", true, "admin-001", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, "Hats & Caps", "admin-001", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baseball caps, beanies, and fashion hats", true, "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "Scarves", "admin-001", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fashionable scarves and wraps", true, "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Socks", "admin-001", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fun and colorful socks with unique designs", true, "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Face Masks", "admin-001", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish and protective face coverings", true, "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "Pins & Badges", "admin-001", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enamel pins and collectible badges", true, "admin-001", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Coffee Mugs", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceramic mugs for your favorite beverages", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "Travel Mugs", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insulated travel mugs for on-the-go", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "Water Bottles", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reusable water bottles with custom designs", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "Throw Pillows", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Decorative pillows to enhance your space", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Blankets & Throws", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cozy blankets with artistic designs", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Wall Tapestries", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Large fabric wall art and tapestries", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Wall Clocks", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Functional art for keeping time", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "Candles", "admin-001", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scented candles with custom labels", true, "admin-001", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "iPhone Cases", "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Protective cases for iPhone models", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Samsung Cases", "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy phone protection", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "Laptop Sleeves", "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Padded laptop bags and sleeves", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Mouse Pads", "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaming and office mouse pads", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Tablet Cases", "admin-001", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPad and tablet protective cases", true, "admin-001", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_ApplicationUserId",
                table: "Address",
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
                name: "IX_BaseProductColors_BaseProduct_Active",
                table: "BaseProductColors",
                columns: new[] { "BaseProductId", "IsActive" });

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductColors_BaseProduct_Color",
                table: "BaseProductColors",
                columns: new[] { "BaseProductId", "ColorId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductColors_BaseProductId",
                table: "BaseProductColors",
                column: "BaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductColors_ColorId",
                table: "BaseProductColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_PrintAreas_BaseProduct_Active_Order",
                table: "BaseProductPrintAreas",
                columns: new[] { "BaseProductId", "IsActive", "DisplayOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_PrintAreas_BaseProduct_Area",
                table: "BaseProductPrintAreas",
                columns: new[] { "BaseProductId", "AreaName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrintAreas_BaseProductId",
                table: "BaseProductPrintAreas",
                column: "BaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseProducts_CategoryId",
                table: "BaseProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductSizes_BaseProduct_Active",
                table: "BaseProductSizes",
                columns: new[] { "BaseProductId", "IsActive" });

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductSizes_BaseProduct_Size",
                table: "BaseProductSizes",
                columns: new[] { "BaseProductId", "SizeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductSizes_BaseProductId",
                table: "BaseProductSizes",
                column: "BaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductSizes_SizeId",
                table: "BaseProductSizes",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_BaseProduct_Active_Order",
                table: "BaseProductTemplates",
                columns: new[] { "BaseProductId", "IsActive", "DisplayOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_Templates_BaseProduct_Primary",
                table: "BaseProductTemplates",
                columns: new[] { "BaseProductId", "IsPrimary" });

            migrationBuilder.CreateIndex(
                name: "IX_Templates_BaseProduct_View",
                table: "BaseProductTemplates",
                columns: new[] { "BaseProductId", "ViewName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Templates_BaseProductId",
                table: "BaseProductTemplates",
                column: "BaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IsActive",
                table: "Categories",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ColorCode",
                table: "Colors",
                column: "ColorCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ColorName",
                table: "Colors",
                column: "ColorName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colors_IsActive",
                table: "Colors",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Designs_AdminId",
                table: "Designs",
                column: "AdminId");

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
                name: "IX_Orders_DeliveryMethodId",
                table: "Orders",
                column: "DeliveryMethodId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_IsActive",
                table: "Sizes",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_SizeName",
                table: "Sizes",
                column: "SizeName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

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
                name: "BaseProductColors");

            migrationBuilder.DropTable(
                name: "BaseProductPrintAreas");

            migrationBuilder.DropTable(
                name: "BaseProductSizes");

            migrationBuilder.DropTable(
                name: "BaseProductTemplates");

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
                name: "DeliveryMethods");

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
