using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
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
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShippingAddress_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    DesignId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignImages_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { "1", null, new DateTime(2025, 9, 15, 7, 38, 26, 316, DateTimeKind.Utc).AddTicks(9540), "System Administrator with full access to manage products and designs", true, "Admin", "ADMIN" },
                    { "2", null, new DateTime(2025, 9, 15, 7, 38, 26, 316, DateTimeKind.Utc).AddTicks(9545), "Customer who can browse and purchase products", true, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "admin-001", 0, "407e6a1a-8564-4c7c-8822-69b95018e347", new DateTime(2025, 9, 15, 7, 38, 26, 432, DateTimeKind.Utc).AddTicks(8394), "System Administrator", "admin@redbubble.com", true, true, false, null, "ADMIN@REDBUBBLE.COM", "ADMIN@REDBUBBLE.COM", "AQAAAAIAAYagAAAAEEYTEBcar48ZHKPZiGvSpMI94cgjOhQYIyL02R/+IwKR/N+zjQ2zMou3D3PUu1os+Q==", null, false, "f55dcc39-6e46-458d-b2f4-b471a678a2bf", false, new DateTime(2025, 9, 15, 7, 38, 26, 432, DateTimeKind.Utc).AddTicks(8403), "admin@redbubble.com" },
                    { "customer-001", 0, "ba263ff4-6948-442e-ad3d-a54e83982b01", new DateTime(2024, 12, 24, 7, 38, 26, 567, DateTimeKind.Utc).AddTicks(5646), "John Doe", "john.doe@email.com", true, true, false, null, "JOHN.DOE@EMAIL.COM", "JOHN.DOE@EMAIL.COM", "AQAAAAIAAYagAAAAEBOh31tJ4K20+9ZEnPU2kn9ip9bzLQJSDKEwUX+6mPBQM3iSAuwDJIh8biajRf+eGw==", null, false, "4e616b27-e0d9-491c-a785-85f929d92a7d", false, new DateTime(2025, 8, 24, 7, 38, 26, 567, DateTimeKind.Utc).AddTicks(5695), "john.doe@email.com" },
                    { "customer-002", 0, "210a17e8-eff9-4413-bea5-3a0bfbc3ea9a", new DateTime(2025, 6, 16, 7, 38, 26, 700, DateTimeKind.Utc).AddTicks(3307), "Jane Smith", "jane.smith@email.com", true, true, false, null, "JANE.SMITH@EMAIL.COM", "JANE.SMITH@EMAIL.COM", "AQAAAAIAAYagAAAAECeUZK1ZhYh9Wc+B6aUA8q2yAINGC9WGBcwOORMeDjx30ON3c49ZPoFlCWEzBZ/mdw==", null, false, "85a70ffb-7396-448d-96ff-8e4d3f1d8506", false, new DateTime(2025, 9, 7, 7, 38, 26, 700, DateTimeKind.Utc).AddTicks(3353), "jane.smith@email.com" },
                    { "customer-003", 0, "cbd31069-295c-4502-9758-a6d9b75124f0", new DateTime(2024, 12, 8, 7, 38, 26, 832, DateTimeKind.Utc).AddTicks(8405), "Michael Johnson", "michael.johnson@email.com", true, true, false, null, "MICHAEL.JOHNSON@EMAIL.COM", "MICHAEL.JOHNSON@EMAIL.COM", "AQAAAAIAAYagAAAAEOZKKHzYEHu6S024S3AfpJSeYQj5VEzmPrCBlgsoGF+DAH4GjcU5JnBdV8J4kgxKag==", null, false, "c7c2e15d-cecf-475e-957c-8862aee18744", false, new DateTime(2025, 8, 23, 7, 38, 26, 832, DateTimeKind.Utc).AddTicks(8464), "michael.johnson@email.com" },
                    { "customer-004", 0, "21bd04f1-75e1-469f-86a3-21bed8f1cb3f", new DateTime(2025, 5, 31, 7, 38, 26, 964, DateTimeKind.Utc).AddTicks(8978), "Sarah Williams", "sarah.williams@email.com", true, true, false, null, "SARAH.WILLIAMS@EMAIL.COM", "SARAH.WILLIAMS@EMAIL.COM", "AQAAAAIAAYagAAAAEEVoS0xjlq0SJpEw6o1akTQHmRhdum+v72AMHDW8usz7r8vLEqL21eprQOXt2qvVOA==", null, false, "35a39d32-97b0-4833-b410-45429326c64b", false, new DateTime(2025, 9, 6, 7, 38, 26, 964, DateTimeKind.Utc).AddTicks(9290), "sarah.williams@email.com" },
                    { "customer-005", 0, "8486582d-d2af-4cf6-acfa-cddca572cad4", new DateTime(2024, 11, 21, 7, 38, 27, 96, DateTimeKind.Utc).AddTicks(3832), "David Brown", "david.brown@email.com", true, true, false, null, "DAVID.BROWN@EMAIL.COM", "DAVID.BROWN@EMAIL.COM", "AQAAAAIAAYagAAAAEF7n7xtx0pQ5wHtf0b5phKwRtUExyZjv9qIf/yfm1Ho8QTNV4NekNuZP/1R2Nu84bw==", null, false, "d8137448-b426-4d69-a39e-0413e1afa95a", false, new DateTime(2025, 8, 22, 7, 38, 27, 96, DateTimeKind.Utc).AddTicks(3892), "david.brown@email.com" },
                    { "customer-006", 0, "04f06082-97c0-4f1f-b9a7-248e1af5cdca", new DateTime(2025, 5, 14, 7, 38, 27, 227, DateTimeKind.Utc).AddTicks(3214), "Emily Davis", "emily.davis@email.com", true, true, false, null, "EMILY.DAVIS@EMAIL.COM", "EMILY.DAVIS@EMAIL.COM", "AQAAAAIAAYagAAAAEP3IKiVQ2B71+MLs8Wev/CS5PYpjBoEVoS6MuAWio1QiBrj+L2IbXWlcA9p6acln7Q==", null, false, "4884f6a3-5b30-48e5-b436-0be606663064", false, new DateTime(2025, 9, 5, 7, 38, 27, 227, DateTimeKind.Utc).AddTicks(3324), "emily.davis@email.com" },
                    { "customer-007", 0, "7e34202d-dbf8-4465-8e57-832578594ec7", new DateTime(2024, 11, 5, 7, 38, 27, 359, DateTimeKind.Utc).AddTicks(1395), "James Miller", "james.miller@email.com", true, true, false, null, "JAMES.MILLER@EMAIL.COM", "JAMES.MILLER@EMAIL.COM", "AQAAAAIAAYagAAAAEDQM9JgBmTnJ8wuN70SRFGw5MEumL3Bgbl7RA9B+ZZNBzLcpGjNzCdKnmMazYtWS2A==", null, false, "a45bf610-2582-4c62-a6fc-1fc6890e88d6", false, new DateTime(2025, 8, 21, 7, 38, 27, 359, DateTimeKind.Utc).AddTicks(1442), "james.miller@email.com" },
                    { "customer-008", 0, "49c216b1-3ccd-4693-803d-c3f718590e01", new DateTime(2025, 4, 28, 7, 38, 27, 491, DateTimeKind.Utc).AddTicks(7170), "Jessica Wilson", "jessica.wilson@email.com", true, true, false, null, "JESSICA.WILSON@EMAIL.COM", "JESSICA.WILSON@EMAIL.COM", "AQAAAAIAAYagAAAAEDrUcFgzc03O4weIlIumf+XzYTRjmzD419HTYn42gBTR8HciGuv09r1g/81FH0+Vdg==", null, false, "e4cd7efa-8255-4ef8-beae-915afde48a9d", false, new DateTime(2025, 9, 3, 7, 38, 27, 491, DateTimeKind.Utc).AddTicks(7218), "jessica.wilson@email.com" },
                    { "customer-009", 0, "5e83af82-5a62-40f7-a998-a4fa51c3082d", new DateTime(2024, 10, 20, 7, 38, 27, 624, DateTimeKind.Utc).AddTicks(9873), "Robert Moore", "robert.moore@email.com", true, true, false, null, "ROBERT.MOORE@EMAIL.COM", "ROBERT.MOORE@EMAIL.COM", "AQAAAAIAAYagAAAAEL45/f9SKpjNd38o5HTNGMOIr2Vktqpn3Semz+cAipoEgP5xXhPjmblo4z0OpedREw==", null, false, "b3c554ca-c6ff-44b3-878b-edf1a120df62", false, new DateTime(2025, 8, 19, 7, 38, 27, 624, DateTimeKind.Utc).AddTicks(9914), "robert.moore@email.com" },
                    { "customer-010", 0, "464522ae-9a60-4e62-9836-716e7e08393c", new DateTime(2025, 4, 12, 7, 38, 27, 754, DateTimeKind.Utc).AddTicks(1521), "Ashley Taylor", "ashley.taylor@email.com", true, true, false, null, "ASHLEY.TAYLOR@EMAIL.COM", "ASHLEY.TAYLOR@EMAIL.COM", "AQAAAAIAAYagAAAAEDvhI64MKDBsJQ32E0RaCgWFPjMtXv4sHApCqGIEBn3LyxKpoWTFbSvQMBSaVf1thA==", null, false, "8b5e0851-1a3b-446a-b41d-443c51052b31", false, new DateTime(2025, 9, 2, 7, 38, 27, 754, DateTimeKind.Utc).AddTicks(1578), "ashley.taylor@email.com" },
                    { "customer-011", 0, "6ef92085-2f5d-4ded-87a8-501be19cdab2", new DateTime(2024, 10, 4, 7, 38, 27, 885, DateTimeKind.Utc).AddTicks(7581), "Christopher Anderson", "christopher.anderson@email.com", true, true, false, null, "CHRISTOPHER.ANDERSON@EMAIL.COM", "CHRISTOPHER.ANDERSON@EMAIL.COM", "AQAAAAIAAYagAAAAEBy4pSQgk+ELG4AlzYXPV5P2vHWldkKOaAusJlKHOXsRdavWQO9ec6pZSiI70y7W2w==", null, false, "a2e5238b-1d75-4db7-97ec-5d9358d869af", false, new DateTime(2025, 8, 18, 7, 38, 27, 885, DateTimeKind.Utc).AddTicks(7632), "christopher.anderson@email.com" },
                    { "customer-012", 0, "905fb37f-c5f5-416e-9dc0-0e732319c337", new DateTime(2025, 3, 26, 7, 38, 28, 18, DateTimeKind.Utc).AddTicks(3812), "Amanda Thomas", "amanda.thomas@email.com", true, true, false, null, "AMANDA.THOMAS@EMAIL.COM", "AMANDA.THOMAS@EMAIL.COM", "AQAAAAIAAYagAAAAENWXd1tJGdl2Pf4HYSUMt3nqE6q+FXPWGwiya+DmltudzNN4T1hisAJMKCNqGSzbaA==", null, false, "a3644fea-16d3-4777-9361-4bf3290a216a", false, new DateTime(2025, 9, 1, 7, 38, 28, 18, DateTimeKind.Utc).AddTicks(3849), "amanda.thomas@email.com" },
                    { "customer-013", 0, "b076aecc-ef0e-4133-86a8-9a0a08e21dd8", new DateTime(2024, 9, 17, 7, 38, 28, 143, DateTimeKind.Utc).AddTicks(6287), "Matthew Jackson", "matthew.jackson@email.com", true, true, false, null, "MATTHEW.JACKSON@EMAIL.COM", "MATTHEW.JACKSON@EMAIL.COM", "AQAAAAIAAYagAAAAEHxZ1q6Ny3izcixVPLdAYzEbEhB7zggtJ/iuJksvzT7WVUErlofoB9gB0+M7pWb0hQ==", null, false, "736f04d9-b9e2-4049-bdc6-564b42a66b55", false, new DateTime(2025, 8, 17, 7, 38, 28, 143, DateTimeKind.Utc).AddTicks(6330), "matthew.jackson@email.com" },
                    { "customer-014", 0, "4d9b5649-b0db-48ae-a6b5-92d62c657b30", new DateTime(2025, 3, 10, 7, 38, 28, 263, DateTimeKind.Utc).AddTicks(1277), "Melissa White", "melissa.white@email.com", true, true, false, null, "MELISSA.WHITE@EMAIL.COM", "MELISSA.WHITE@EMAIL.COM", "AQAAAAIAAYagAAAAEEVwLbwUdl5gfEilzD0DNL/ZtmEQS3anzV+4pDKWMb6yltypnQSzRthzQUIgKeN+sQ==", null, false, "6614b39e-7ba1-478a-a731-6aff43d84e03", false, new DateTime(2025, 8, 30, 7, 38, 28, 263, DateTimeKind.Utc).AddTicks(1316), "melissa.white@email.com" },
                    { "customer-015", 0, "1a6139a6-d3c7-493c-be15-aa9ccefccc89", new DateTime(2025, 8, 31, 7, 38, 28, 367, DateTimeKind.Utc).AddTicks(9738), "Anthony Harris", "anthony.harris@email.com", true, true, false, null, "ANTHONY.HARRIS@EMAIL.COM", "ANTHONY.HARRIS@EMAIL.COM", "AQAAAAIAAYagAAAAEDUTjPYg8quMJa7vxyH50OLdI+b1W4nnLt+xCzcdiTvFq0ukt5l3Skw2wOlYeKuQ9A==", null, false, "31080f6f-4891-49cc-b662-7a21ddcab9e4", false, new DateTime(2025, 9, 13, 7, 38, 28, 367, DateTimeKind.Utc).AddTicks(9777), "anthony.harris@email.com" },
                    { "customer-016", 0, "29651b25-667b-448e-a518-adccffec9c04", new DateTime(2025, 2, 22, 7, 38, 28, 466, DateTimeKind.Utc).AddTicks(4270), "Stephanie Martin", "stephanie.martin@email.com", true, true, false, null, "STEPHANIE.MARTIN@EMAIL.COM", "STEPHANIE.MARTIN@EMAIL.COM", "AQAAAAIAAYagAAAAEIrUfF8jfaXHjF/GjV0WNNLjeQCpBvbuaxUddngdB0kcA5emI787op1Uqao/deq2ZQ==", null, false, "ddb4dabb-62b8-4ed3-8075-a8c0158e6621", false, new DateTime(2025, 8, 29, 7, 38, 28, 466, DateTimeKind.Utc).AddTicks(4311), "stephanie.martin@email.com" },
                    { "customer-017", 0, "a9bdee12-3d9c-41ec-973d-0348828c6eb1", new DateTime(2025, 8, 15, 7, 38, 28, 565, DateTimeKind.Utc).AddTicks(2290), "Mark Thompson", "mark.thompson@email.com", true, true, false, null, "MARK.THOMPSON@EMAIL.COM", "MARK.THOMPSON@EMAIL.COM", "AQAAAAIAAYagAAAAEEJu9eIr+75FBjEUf73fisuQgdEl6YnBZJvc2rO79SLvm6PoIQCVPjP64/wzeiAVtQ==", null, false, "de05414d-1d0f-4148-81e6-3beada4f621c", false, new DateTime(2025, 9, 12, 7, 38, 28, 565, DateTimeKind.Utc).AddTicks(2327), "mark.thompson@email.com" },
                    { "customer-018", 0, "75a404a2-b220-46c5-bb5c-9ed130587a3a", new DateTime(2025, 2, 5, 7, 38, 28, 663, DateTimeKind.Utc).AddTicks(6978), "Laura Garcia", "laura.garcia@email.com", true, true, false, null, "LAURA.GARCIA@EMAIL.COM", "LAURA.GARCIA@EMAIL.COM", "AQAAAAIAAYagAAAAEAKNDwJyUwum2MzOFZ6jk9SegTTuzYX7pCwrewMeaBFelNCaCrYjM8KiEBWzY/c0Sg==", null, false, "f12b8a59-6fb8-4c3d-8beb-37711011e881", false, new DateTime(2025, 8, 28, 7, 38, 28, 663, DateTimeKind.Utc).AddTicks(7018), "laura.garcia@email.com" },
                    { "customer-019", 0, "709986c1-fd26-4596-973c-d44803e3fee7", new DateTime(2025, 7, 29, 7, 38, 28, 762, DateTimeKind.Utc).AddTicks(4267), "Steven Martinez", "steven.martinez@email.com", true, true, false, null, "STEVEN.MARTINEZ@EMAIL.COM", "STEVEN.MARTINEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEPVHf9ufwkhhITb35YG+vWV6nJ5+L33XAtIAG1SyxQV/HZHUhxjypsNOh06HeZW/tg==", null, false, "7890dc80-3f4f-4832-8095-67932f17f7aa", false, new DateTime(2025, 9, 11, 7, 38, 28, 762, DateTimeKind.Utc).AddTicks(4308), "steven.martinez@email.com" },
                    { "customer-020", 0, "42b03328-9e1c-4ce5-ba74-24bdbd06f269", new DateTime(2025, 1, 20, 7, 38, 28, 864, DateTimeKind.Utc).AddTicks(1649), "Michelle Robinson", "michelle.robinson@email.com", true, true, false, null, "MICHELLE.ROBINSON@EMAIL.COM", "MICHELLE.ROBINSON@EMAIL.COM", "AQAAAAIAAYagAAAAEDHr6mqqlvWE6f53B0TMQIqEZQuA2a/dioXm7Eld50+4/Gmut794LBn3GZJYI4LF3Q==", null, false, "ea431832-1cb6-4bb0-9591-02a157c2e927", false, new DateTime(2025, 8, 27, 7, 38, 28, 864, DateTimeKind.Utc).AddTicks(1692), "michelle.robinson@email.com" },
                    { "customer-021", 0, "2234e8c1-7c57-4db4-92de-ed013969f08d", new DateTime(2025, 7, 13, 7, 38, 28, 964, DateTimeKind.Utc).AddTicks(8834), "Kevin Clark", "kevin.clark@email.com", true, true, false, null, "KEVIN.CLARK@EMAIL.COM", "KEVIN.CLARK@EMAIL.COM", "AQAAAAIAAYagAAAAEPCk3du1rq8Zfyf0LmHkqrMRQvo72jSqYDsr+ZmWyDzf99HYaVRt0+IryTJfE/4udQ==", null, false, "0e3e12a5-3f63-4009-a2ac-1a8a8574384b", false, new DateTime(2025, 9, 9, 7, 38, 28, 964, DateTimeKind.Utc).AddTicks(8884), "kevin.clark@email.com" },
                    { "customer-022", 0, "8bfb929f-da27-4d11-9b34-1423b83d533f", new DateTime(2025, 1, 4, 7, 38, 29, 75, DateTimeKind.Utc).AddTicks(5136), "Kimberly Rodriguez", "kimberly.rodriguez@email.com", true, true, false, null, "KIMBERLY.RODRIGUEZ@EMAIL.COM", "KIMBERLY.RODRIGUEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEDisM/ypg1MYgB2wnQ91GXbu4YHendSjMvE5UJyf34pf4xSKUGnKhQJx5sK7jpTENw==", null, false, "a424f9a4-e51b-4c43-80b6-e35f2d101136", false, new DateTime(2025, 8, 25, 7, 38, 29, 75, DateTimeKind.Utc).AddTicks(5184), "kimberly.rodriguez@email.com" },
                    { "customer-023", 0, "6e4de95f-e1fb-4085-b530-92ae4deba9a9", new DateTime(2025, 6, 27, 7, 38, 29, 195, DateTimeKind.Utc).AddTicks(1286), "Joshua Lewis", "joshua.lewis@email.com", true, true, false, null, "JOSHUA.LEWIS@EMAIL.COM", "JOSHUA.LEWIS@EMAIL.COM", "AQAAAAIAAYagAAAAEN+v+IX47whtqlClVRHEmQ04CoIXcnzT1ePkFKKNRN9rNEJ6t1AOb+JFLLcEMNCszg==", null, false, "860e0048-20b8-44a0-af66-9687019c3dd6", false, new DateTime(2025, 9, 8, 7, 38, 29, 195, DateTimeKind.Utc).AddTicks(1330), "joshua.lewis@email.com" },
                    { "customer-024", 0, "9d5c1594-48b5-4d2e-a8fd-031aa9bd274b", new DateTime(2024, 12, 18, 7, 38, 29, 308, DateTimeKind.Utc).AddTicks(8965), "Lisa Lee", "lisa.lee@email.com", true, true, false, null, "LISA.LEE@EMAIL.COM", "LISA.LEE@EMAIL.COM", "AQAAAAIAAYagAAAAEOTmJLB5WuugdPOVnIaYj+HphkVBn8nwhxUJQfPwRfIsFgojJU0lEUZmq4rbZ8YLwg==", null, false, "a642a50e-d8fb-43df-a523-2641adb0aa92", false, new DateTime(2025, 8, 24, 7, 38, 29, 308, DateTimeKind.Utc).AddTicks(9004), "lisa.lee@email.com" },
                    { "customer-025", 0, "7974aabc-a1f9-4430-9c0e-aff3c82eddd3", new DateTime(2025, 6, 10, 7, 38, 29, 405, DateTimeKind.Utc).AddTicks(4994), "Andrew Walker", "andrew.walker@email.com", true, true, false, null, "ANDREW.WALKER@EMAIL.COM", "ANDREW.WALKER@EMAIL.COM", "AQAAAAIAAYagAAAAEFizeTn4u3D5FX2Wc5MZEvH0EMPyp/yYaGxLj4Pkx8I1L0v3A14pVHELh+BVXnf57Q==", null, false, "cd945454-de3a-4289-87e4-1f6820011529", false, new DateTime(2025, 9, 7, 7, 38, 29, 405, DateTimeKind.Utc).AddTicks(5036), "andrew.walker@email.com" },
                    { "customer-026", 0, "93b13c7b-0b89-4e1e-86f5-bbee7cb0f025", new DateTime(2024, 12, 2, 7, 38, 29, 507, DateTimeKind.Utc).AddTicks(2917), "Nancy Hall", "nancy.hall@email.com", true, true, false, null, "NANCY.HALL@EMAIL.COM", "NANCY.HALL@EMAIL.COM", "AQAAAAIAAYagAAAAEPvRlNV3jY7xutrxRCKuE02WD8Vlb/Glda5Puf4FqpZd9nhmoDLE4Zc8H3HMjzxaRQ==", null, false, "0abbfaa7-1ae4-4f0f-b9b3-79263f1fde9e", false, new DateTime(2025, 8, 23, 7, 38, 29, 507, DateTimeKind.Utc).AddTicks(2959), "nancy.hall@email.com" },
                    { "customer-027", 0, "7bbc0a5d-d2eb-4269-9b12-5e0a69d4c189", new DateTime(2025, 5, 25, 7, 38, 29, 621, DateTimeKind.Utc).AddTicks(8186), "Brian Allen", "brian.allen@email.com", true, true, false, null, "BRIAN.ALLEN@EMAIL.COM", "BRIAN.ALLEN@EMAIL.COM", "AQAAAAIAAYagAAAAEIKYzhA11SkXz1pI/vlbz884ohWskwV85DhHk176vnvYXZSBO9hZ2FILPSrGmHzDpg==", null, false, "43c3c96f-7e68-49d1-abea-85bc57ceadd8", false, new DateTime(2025, 9, 6, 7, 38, 29, 621, DateTimeKind.Utc).AddTicks(8458), "brian.allen@email.com" },
                    { "customer-028", 0, "fb700be5-f304-450d-a75d-08461277b26b", new DateTime(2024, 11, 16, 7, 38, 29, 739, DateTimeKind.Utc).AddTicks(8368), "Betty Young", "betty.young@email.com", true, true, false, null, "BETTY.YOUNG@EMAIL.COM", "BETTY.YOUNG@EMAIL.COM", "AQAAAAIAAYagAAAAEJpk8qwOLlZ0wm863xRk0Z5OrrUWtxnmQi0EgbxTvtrPQrgzbr19VWnMktGeBcWq1Q==", null, false, "75bd75b0-fa06-4caf-ae0f-cf4e440a7379", false, new DateTime(2025, 8, 21, 7, 38, 29, 739, DateTimeKind.Utc).AddTicks(8404), "betty.young@email.com" },
                    { "customer-029", 0, "45853ce4-5d8e-446c-b7dc-82249eb9c5d6", new DateTime(2025, 5, 9, 7, 38, 29, 879, DateTimeKind.Utc).AddTicks(9828), "Gary Hernandez", "gary.hernandez@email.com", true, true, false, null, "GARY.HERNANDEZ@EMAIL.COM", "GARY.HERNANDEZ@EMAIL.COM", "AQAAAAIAAYagAAAAEET7SRQTUaoZ7FOoQ5BF49O4vLMNfxuwmn5DHOFvTKcmSdMj0AVyzUBGtY+JccMjdA==", null, false, "3a5f53a9-b17e-4ff5-b861-04a1573931f6", false, new DateTime(2025, 9, 4, 7, 38, 29, 879, DateTimeKind.Utc).AddTicks(9880), "gary.hernandez@email.com" },
                    { "customer-030", 0, "6c153a3a-57fa-4c59-b57b-1146fa3e8baa", new DateTime(2024, 10, 30, 7, 38, 30, 12, DateTimeKind.Utc).AddTicks(9739), "Helen King", "helen.king@email.com", true, true, false, null, "HELEN.KING@EMAIL.COM", "HELEN.KING@EMAIL.COM", "AQAAAAIAAYagAAAAEFDW+UcKm8AqBF4NJE46+4biP5vC16r6iZrw3vDOUvROGv+c5vD2fDMIo8u4eySo6A==", null, false, "26b8c682-9176-4dad-bc2e-59670a77c244", false, new DateTime(2025, 8, 20, 7, 38, 30, 12, DateTimeKind.Utc).AddTicks(9789), "helen.king@email.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Clothing", "admin-001", new DateTime(2025, 6, 17, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8109), "Apparel and wearable items for all ages", true, "admin-001", new DateTime(2025, 8, 16, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8114), null },
                    { 2, "Accessories", "admin-001", new DateTime(2025, 6, 17, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8131), "Fashion and lifestyle accessories", true, "admin-001", new DateTime(2025, 8, 16, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8132), null },
                    { 3, "Home & Living", "admin-001", new DateTime(2025, 6, 17, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8134), "Home decor and lifestyle items", true, "admin-001", new DateTime(2025, 8, 16, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8134), null },
                    { 4, "Stickers & Decals", "admin-001", new DateTime(2025, 6, 17, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8136), "Decorative stickers and decals", true, "admin-001", new DateTime(2025, 8, 16, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8137), null },
                    { 5, "Wall Art", "admin-001", new DateTime(2025, 6, 17, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8139), "Prints, posters, and wall decorations", true, "admin-001", new DateTime(2025, 8, 16, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8140), null },
                    { 6, "Stationery & Office", "admin-001", new DateTime(2025, 6, 17, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8144), "Notebooks, cards, and office supplies", true, "admin-001", new DateTime(2025, 8, 16, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8144), null },
                    { 7, "Bags & Purses", "admin-001", new DateTime(2025, 6, 17, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8146), "Tote bags, backpacks, and purses", true, "admin-001", new DateTime(2025, 8, 16, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8147), null },
                    { 8, "Tech Accessories", "admin-001", new DateTime(2025, 6, 17, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8149), "Phone cases and tech accessories", true, "admin-001", new DateTime(2025, 8, 16, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8149), null }
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
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedOn", "Description", "IsActive", "LastModifiedBy", "LastModifiedOn", "ParentCategoryId" },
                values: new object[,]
                {
                    { 9, "T-Shirts", "admin-001", new DateTime(2025, 6, 22, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8161), "Classic and graphic t-shirts for all occasions", true, "admin-001", new DateTime(2025, 8, 21, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8162), 1 },
                    { 10, "Tank Tops", "admin-001", new DateTime(2025, 6, 22, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8165), "Comfortable sleeveless tank tops", true, "admin-001", new DateTime(2025, 8, 21, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8166), 1 },
                    { 11, "Long Sleeve Shirts", "admin-001", new DateTime(2025, 6, 22, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8168), "Cozy long sleeve t-shirts", true, "admin-001", new DateTime(2025, 8, 21, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8168), 1 },
                    { 12, "Hoodies & Sweatshirts", "admin-001", new DateTime(2025, 6, 22, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8170), "Warm pullover hoodies and sweatshirts", true, "admin-001", new DateTime(2025, 8, 21, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8171), 1 },
                    { 13, "Zip Hoodies", "admin-001", new DateTime(2025, 6, 22, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8173), "Full-zip hoodies and jackets", true, "admin-001", new DateTime(2025, 8, 21, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8174), 1 },
                    { 14, "Crewneck Sweatshirts", "admin-001", new DateTime(2025, 6, 22, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8175), "Classic crewneck style sweatshirts", true, "admin-001", new DateTime(2025, 8, 21, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8176), 1 },
                    { 15, "Dresses", "admin-001", new DateTime(2025, 6, 22, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8178), "Casual and dressy options for all styles", true, "admin-001", new DateTime(2025, 8, 21, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8179), 1 },
                    { 16, "Skirts", "admin-001", new DateTime(2025, 6, 22, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8180), "Mini, midi, and maxi skirts", true, "admin-001", new DateTime(2025, 8, 21, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8181), 1 },
                    { 17, "Hats & Caps", "admin-001", new DateTime(2025, 6, 27, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8188), "Baseball caps, beanies, and fashion hats", true, "admin-001", new DateTime(2025, 8, 26, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8189), 2 },
                    { 18, "Scarves", "admin-001", new DateTime(2025, 6, 27, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8192), "Fashionable scarves and wraps", true, "admin-001", new DateTime(2025, 8, 26, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8193), 2 },
                    { 19, "Socks", "admin-001", new DateTime(2025, 6, 27, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8277), "Fun and colorful socks with unique designs", true, "admin-001", new DateTime(2025, 8, 26, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8278), 2 },
                    { 20, "Face Masks", "admin-001", new DateTime(2025, 6, 27, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8280), "Stylish and protective face coverings", true, "admin-001", new DateTime(2025, 8, 26, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8281), 2 },
                    { 21, "Pins & Badges", "admin-001", new DateTime(2025, 6, 27, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8283), "Enamel pins and collectible badges", true, "admin-001", new DateTime(2025, 8, 26, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8284), 2 },
                    { 22, "Coffee Mugs", "admin-001", new DateTime(2025, 7, 2, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8292), "Ceramic mugs for your favorite beverages", true, "admin-001", new DateTime(2025, 8, 31, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8293), 3 },
                    { 23, "Travel Mugs", "admin-001", new DateTime(2025, 7, 2, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8296), "Insulated travel mugs for on-the-go", true, "admin-001", new DateTime(2025, 8, 31, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8296), 3 },
                    { 24, "Water Bottles", "admin-001", new DateTime(2025, 7, 2, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8298), "Reusable water bottles with custom designs", true, "admin-001", new DateTime(2025, 8, 31, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8299), 3 },
                    { 25, "Throw Pillows", "admin-001", new DateTime(2025, 7, 2, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8301), "Decorative pillows to enhance your space", true, "admin-001", new DateTime(2025, 8, 31, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8301), 3 },
                    { 26, "Blankets & Throws", "admin-001", new DateTime(2025, 7, 2, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8303), "Cozy blankets with artistic designs", true, "admin-001", new DateTime(2025, 8, 31, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8304), 3 },
                    { 27, "Wall Tapestries", "admin-001", new DateTime(2025, 7, 2, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8306), "Large fabric wall art and tapestries", true, "admin-001", new DateTime(2025, 8, 31, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8306), 3 },
                    { 28, "Wall Clocks", "admin-001", new DateTime(2025, 7, 2, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8308), "Functional art for keeping time", true, "admin-001", new DateTime(2025, 8, 31, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8309), 3 },
                    { 29, "Candles", "admin-001", new DateTime(2025, 7, 2, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8311), "Scented candles with custom labels", true, "admin-001", new DateTime(2025, 8, 31, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8311), 3 },
                    { 30, "iPhone Cases", "admin-001", new DateTime(2025, 7, 7, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8319), "Protective cases for iPhone models", true, "admin-001", new DateTime(2025, 9, 5, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8320), 8 },
                    { 31, "Samsung Cases", "admin-001", new DateTime(2025, 7, 7, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8322), "Samsung Galaxy phone protection", true, "admin-001", new DateTime(2025, 9, 5, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8323), 8 },
                    { 32, "Laptop Sleeves", "admin-001", new DateTime(2025, 7, 7, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8335), "Padded laptop bags and sleeves", true, "admin-001", new DateTime(2025, 9, 5, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8335), 8 },
                    { 33, "Mouse Pads", "admin-001", new DateTime(2025, 7, 7, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8337), "Gaming and office mouse pads", true, "admin-001", new DateTime(2025, 9, 5, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8338), 8 },
                    { 34, "Tablet Cases", "admin-001", new DateTime(2025, 7, 7, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8343), "iPad and tablet protective cases", true, "admin-001", new DateTime(2025, 9, 5, 7, 38, 30, 13, DateTimeKind.Utc).AddTicks(8344), 8 }
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
                name: "IX_DesignImages_DesignId",
                table: "DesignImages",
                column: "DesignId");

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
