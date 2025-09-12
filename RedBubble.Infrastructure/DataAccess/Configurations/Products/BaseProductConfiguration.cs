
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Infrastructure.DataAccess.Configurations;

namespace RedBubble.Infrastructure.DataAccess.Configurations.Products
{
    public class BaseProductConfiguration : BaseAuditableEntityConfigurations<BaseProduct, int>
    {
        public override void Configure(EntityTypeBuilder<BaseProduct> builder)
        {
            base.Configure(builder);

            // Table name
            builder.ToTable("BaseProducts");

            // Properties
            builder.Property(bp => bp.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(bp => bp.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(bp => bp.BasePrice)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

         

           

            builder.Property(bp => bp.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(bp => bp.HasSizes)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(bp => bp.HasColors)
                .IsRequired()
                .HasDefaultValue(false);

          

            // Relationships
            builder.HasOne(bp => bp.Category)
                .WithMany(c => c.BaseProducts)
                .HasForeignKey(bp => bp.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(bp => bp.PrintAreas)
                .WithOne(pa => pa.BaseProduct)
                .HasForeignKey(pa => pa.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(bp => bp.Templates)
                .WithOne(t => t.BaseProduct)
                .HasForeignKey(t => t.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(bp => bp.AvailableSizes)
                .WithOne(s => s.BaseProduct)
                .HasForeignKey(s => s.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(bp => bp.AvailableColors)
                .WithOne(c => c.BaseProduct)
                .HasForeignKey(c => c.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(bp => bp.ProductVariants)
                .WithOne(pv => pv.BaseProduct)
                .HasForeignKey(pv => pv.BaseProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Check constraints for business rules
            builder.HasCheckConstraint("CK_BaseProducts_BasePrice_Positive", "[BasePrice] > 0");
        }
    }

    // BaseProductPrintAreaConfiguration.cs
    public class BaseProductPrintAreaConfiguration : BaseEntityConfigurations<BaseProductPrintArea, int>
    {
        public override void Configure(EntityTypeBuilder<BaseProductPrintArea> builder)
        {
            base.Configure(builder);

            builder.ToTable("BaseProductPrintAreas");

            // Properties
            builder.Property(pa => pa.AreaName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(pa => pa.Width)
                .IsRequired()
                .HasColumnType("decimal(8,2)");

            builder.Property(pa => pa.Height)
                .IsRequired()
                .HasColumnType("decimal(8,2)");

            builder.Property(pa => pa.PositionX)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(pa => pa.PositionY)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(pa => pa.MinDPI)
                .IsRequired()
                .HasDefaultValue(300);

            builder.Property(pa => pa.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(pa => pa.DisplayOrder)
                .IsRequired()
                .HasDefaultValue(1);

            // Indexes
            builder.HasIndex(pa => pa.BaseProductId)
                .HasDatabaseName("IX_PrintAreas_BaseProductId");

            builder.HasIndex(pa => new { pa.BaseProductId, pa.AreaName })
                .IsUnique()
                .HasDatabaseName("IX_PrintAreas_BaseProduct_Area");

            builder.HasIndex(pa => new { pa.BaseProductId, pa.IsActive, pa.DisplayOrder })
                .HasDatabaseName("IX_PrintAreas_BaseProduct_Active_Order");

            // Relationships
            builder.HasOne(pa => pa.BaseProduct)
                .WithMany(bp => bp.PrintAreas)
                .HasForeignKey(pa => pa.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // Check constraints
            builder.HasCheckConstraint("CK_PrintAreas_Width_Positive", "[Width] > 0");
            builder.HasCheckConstraint("CK_PrintAreas_Height_Positive", "[Height] > 0");
            builder.HasCheckConstraint("CK_PrintAreas_Position_NonNegative", "[PositionX] >= 0 AND [PositionY] >= 0");
            builder.HasCheckConstraint("CK_PrintAreas_MinDPI_Range", "[MinDPI] >= 72 AND [MinDPI] <= 600");
            builder.HasCheckConstraint("CK_PrintAreas_DisplayOrder_Positive", "[DisplayOrder] > 0");
        }
    }

    // BaseProductTemplateConfiguration.cs
    public class BaseProductTemplateConfiguration : BaseEntityConfigurations<BaseProductTemplate, int>
    {
        public override void Configure(EntityTypeBuilder<BaseProductTemplate> builder)
        {
            base.Configure(builder);

            builder.ToTable("BaseProductTemplates");

            // Properties
            builder.Property(t => t.ViewName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.TemplateUrl)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.MockupUrl)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.FlatMockupUrl)
                .HasMaxLength(500);

            builder.Property(t => t.IsPrimary)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(t => t.DisplayOrder)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(t => t.TemplateWidth)
                .IsRequired();

            builder.Property(t => t.TemplateHeight)
                .IsRequired();

            // Indexes
            builder.HasIndex(t => t.BaseProductId)
                .HasDatabaseName("IX_Templates_BaseProductId");

            builder.HasIndex(t => new { t.BaseProductId, t.ViewName })
                .IsUnique()
                .HasDatabaseName("IX_Templates_BaseProduct_View");

            builder.HasIndex(t => new { t.BaseProductId, t.IsPrimary })
                .HasDatabaseName("IX_Templates_BaseProduct_Primary");

            builder.HasIndex(t => new { t.BaseProductId, t.IsActive, t.DisplayOrder })
                .HasDatabaseName("IX_Templates_BaseProduct_Active_Order");

            // Relationships
            builder.HasOne(t => t.BaseProduct)
                .WithMany(bp => bp.Templates)
                .HasForeignKey(t => t.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // Check constraints
            builder.HasCheckConstraint("CK_Templates_TemplateWidth_Range", "[TemplateWidth] >= 100 AND [TemplateWidth] <= 5000");
            builder.HasCheckConstraint("CK_Templates_TemplateHeight_Range", "[TemplateHeight] >= 100 AND [TemplateHeight] <= 5000");
            builder.HasCheckConstraint("CK_Templates_DisplayOrder_Positive", "[DisplayOrder] > 0");
        }
    }

    // BaseProductSizeConfiguration.cs - FIXED
    public class BaseProductSizeConfiguration : BaseEntityConfigurations<BaseProductSize, int>
    {
        public override void Configure(EntityTypeBuilder<BaseProductSize> builder)
        {
            base.Configure(builder);

            builder.ToTable("BaseProductSizes");

            // Properties
            builder.Property(bps => bps.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(bps => bps.PriceModifier)
                .IsRequired()
                .HasColumnType("decimal(18,2)")
                .HasDefaultValue(0);

            // Indexes
            builder.HasIndex(bps => bps.BaseProductId)
                .HasDatabaseName("IX_BaseProductSizes_BaseProductId");

            builder.HasIndex(bps => bps.SizeId)
                .HasDatabaseName("IX_BaseProductSizes_SizeId");

            builder.HasIndex(bps => new { bps.BaseProductId, bps.SizeId })
                .IsUnique()
                .HasDatabaseName("IX_BaseProductSizes_BaseProduct_Size");

            builder.HasIndex(bps => new { bps.BaseProductId, bps.IsActive })
                .HasDatabaseName("IX_BaseProductSizes_BaseProduct_Active");

            // FIXED: Only junction table relationships - NO ProductVariant relationship
            builder.HasOne(bps => bps.BaseProduct)
                .WithMany(bp => bp.AvailableSizes)
                .HasForeignKey(bps => bps.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(bps => bps.Size)
                .WithMany(s => s.BaseProductSize)
                .HasForeignKey(bps => bps.SizeId)
                .OnDelete(DeleteBehavior.Restrict);

            // REMOVED: This conflicting relationship
            // builder.HasMany(bps => bps.ProductVariants)
            //     .WithOne()
            //     .HasForeignKey(pv => pv.SizeId)
            //     .OnDelete(DeleteBehavior.Restrict);

            // Check constraints
            builder.HasCheckConstraint("CK_BaseProductSizes_PriceModifier", "[PriceModifier] >= -1000 AND [PriceModifier] <= 1000");
        }
    }

    // BaseProductColorConfiguration.cs - FIXED
    public class BaseProductColorConfiguration : BaseEntityConfigurations<BaseProductColor, int>
    {
        public override void Configure(EntityTypeBuilder<BaseProductColor> builder)
        {
            base.Configure(builder);

            builder.ToTable("BaseProductColors");

            // Properties
            builder.Property(bpc => bpc.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(bpc => bpc.PriceModifier)
                .IsRequired()
                .HasColumnType("decimal(18,2)")
                .HasDefaultValue(0);

            builder.Property(bpc => bpc.ColorSpecificMockupUrl)
                .HasMaxLength(500);

            // Indexes
            builder.HasIndex(bpc => bpc.BaseProductId)
                .HasDatabaseName("IX_BaseProductColors_BaseProductId");

            builder.HasIndex(bpc => bpc.ColorId)
                .HasDatabaseName("IX_BaseProductColors_ColorId");

            builder.HasIndex(bpc => new { bpc.BaseProductId, bpc.ColorId })
                .IsUnique()
                .HasDatabaseName("IX_BaseProductColors_BaseProduct_Color");

            builder.HasIndex(bpc => new { bpc.BaseProductId, bpc.IsActive })
                .HasDatabaseName("IX_BaseProductColors_BaseProduct_Active");

            // FIXED: Only junction table relationships - NO ProductVariant relationship
            builder.HasOne(bpc => bpc.BaseProduct)
                .WithMany(bp => bp.AvailableColors)
                .HasForeignKey(bpc => bpc.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(bpc => bpc.Color)
                .WithMany(c => c.BaseProductColors)
                .HasForeignKey(bpc => bpc.ColorId)
                .OnDelete(DeleteBehavior.Restrict);

            // REMOVED: This conflicting relationship
            // builder.HasMany(bpc => bpc.ProductVariants)
            //     .WithOne()
            //     .HasForeignKey(pv => pv.ColorId)
            //     .OnDelete(DeleteBehavior.Restrict);

            // Check constraints
            builder.HasCheckConstraint("CK_BaseProductColors_PriceModifier", "[PriceModifier] >= -1000 AND [PriceModifier] <= 1000");
        }
    }

  








}