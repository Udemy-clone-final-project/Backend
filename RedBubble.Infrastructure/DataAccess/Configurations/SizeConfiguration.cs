using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {

            // ADD: Missing table name
            builder.ToTable("Sizes");

            builder.Property(s => s.SizeName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(s => s.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            // ADD: Missing indexes for performance
            builder.HasIndex(s => s.SizeName)
                .IsUnique()
                .HasDatabaseName("IX_Sizes_SizeName");

            builder.HasIndex(s => s.IsActive)
                .HasDatabaseName("IX_Sizes_IsActive");

            // Direct relationship to ProductVariant (this stays)
            builder.HasMany(s => s.ProductVariants)
                 .WithOne(pv => pv.Size)
                 .HasForeignKey(pv => pv.SizeId)
                 .OnDelete(DeleteBehavior.Restrict);

            // Junction table relationship (this stays)
            builder.HasMany(s => s.BaseProductSize)
                 .WithOne(bps => bps.Size)
                 .HasForeignKey(bps => bps.SizeId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}