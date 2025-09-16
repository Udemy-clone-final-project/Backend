using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {

            // ADD: Missing table name
            builder.ToTable("Colors");

            builder.Property(c => c.ColorName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.ColorCode)
                .IsRequired()
                .HasMaxLength(7);

            builder.Property(c => c.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            // ADD: Missing indexes for performance
            builder.HasIndex(c => c.ColorName)
                .IsUnique()
                .HasDatabaseName("IX_Colors_ColorName");

            builder.HasIndex(c => c.ColorCode)
                .IsUnique()
                .HasDatabaseName("IX_Colors_ColorCode");

            builder.HasIndex(c => c.IsActive)
                .HasDatabaseName("IX_Colors_IsActive");

            // Direct relationship to ProductVariant (this stays)
            builder.HasMany(c => c.ProductVariants)
                 .WithOne(pv => pv.Color)
                 .HasForeignKey(pv => pv.ColorId)
                 .OnDelete(DeleteBehavior.Restrict);

            // Junction table relationship (this stays)
            builder.HasMany(c => c.BaseProductColors)
                 .WithOne(bpc => bpc.Color)
                 .HasForeignKey(bpc => bpc.ColorId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}