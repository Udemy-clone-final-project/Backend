using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
           
            builder.Property(s => s.SizeName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(s => s.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            
            builder.HasMany(s => s.ProductVariants)
                .WithMany(pv => pv.Sizes);
        }
    }
}