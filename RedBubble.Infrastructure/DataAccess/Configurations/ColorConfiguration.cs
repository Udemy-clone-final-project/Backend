using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
        
            builder.Property(c => c.ColorName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.ColorCode)
                .IsRequired()
                .HasMaxLength(7); 

            builder.Property(c => c.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

         
            builder.HasMany(c => c.ProductVariants)
                .WithMany(pv => pv.Colors);
        }
    }
}