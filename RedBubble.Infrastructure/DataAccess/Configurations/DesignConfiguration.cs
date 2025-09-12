using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class DesignConfiguration : IEntityTypeConfiguration<Design>
    {
        public void Configure(EntityTypeBuilder<Design> builder)
        {

            builder.HasOne(d => d.Admin)
                .WithMany(u => u.CreatedDesigns)
                .HasForeignKey(d => d.AdminId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.HasMany(d => d.ProductVariants)
                .WithOne(pv => pv.Design)
                .HasForeignKey(pv => pv.DesignId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(d => d.ImageUrl)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(d => d.FileName)
                .HasMaxLength(255);

            builder.Property(d => d.AltText)
                .HasMaxLength(255);
        }
    }
}