using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Entities.Models;

namespace RedBubble.Infrastructure.DataAccess.Configurations.Products
{
    public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
          
            builder.Property(pv => pv.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)")
                .HasDefaultValue(0);

            builder.Property(pv => pv.StockQuantity)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(pv => pv.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

     
            builder.Property(pv => pv.BaseProductId)
                .IsRequired();

            builder.Property(pv => pv.DesignId)
                .IsRequired();

            builder.Property(pv => pv.ColorId)
                .IsRequired();

            builder.Property(pv => pv.SizeId)
                .IsRequired();

           
            builder.HasOne(pv => pv.BaseProduct)
                .WithMany(bp => bp.ProductVariants)
                .HasForeignKey(pv => pv.BaseProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pv => pv.Design)
                .WithMany(d => d.ProductVariants)
                .HasForeignKey(pv => pv.DesignId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pv => pv.Color)
                .WithMany(c => c.ProductVariants)
                .HasForeignKey(pv => pv.ColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pv => pv.Size)
                .WithMany(s => s.ProductVariants)
                .HasForeignKey(pv => pv.SizeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(pv => pv.ProductVariantImages)
                .WithOne(pvi => pvi.ProductVariant)
                .HasForeignKey(pvi => pvi.ProductVariantId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(pv => pv.OrderItems)
                .WithOne(oi => oi.ProductVariant)
                .HasForeignKey(oi => oi.ProductVariantId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}