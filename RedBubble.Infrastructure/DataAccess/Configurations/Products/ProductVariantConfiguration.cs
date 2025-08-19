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
                .HasColumnType("decimal(18,2)");

            builder.Property(pv => pv.StockQuantity)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(pv => pv.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.HasOne(pv => pv.BaseProduct)
                .WithMany()
                .HasForeignKey(pv => pv.BaseProductId)
                .OnDelete(DeleteBehavior.Restrict);

            
            builder.HasOne(pv => pv.Design)
                .WithMany(d => d.ProductVariants)
                .HasForeignKey(pv => pv.DesignId)
                .OnDelete(DeleteBehavior.Restrict);

            
            builder.HasMany(pv => pv.Colors)
                .WithMany(c => c.ProductVariants);

            
            builder.HasMany(pv => pv.Sizes)
                .WithMany(s => s.ProductVariants);

            
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