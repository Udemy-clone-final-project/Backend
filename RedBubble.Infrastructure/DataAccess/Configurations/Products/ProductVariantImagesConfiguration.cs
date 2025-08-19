using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess.Configurations.Products
{
    public class ProductVariantImagesConfiguration : IEntityTypeConfiguration<ProductVariantImages>
    {
        public void Configure(EntityTypeBuilder<ProductVariantImages> builder)
        {
           
            builder.HasKey(pvi => pvi.Id);

           
            builder.Property(pvi => pvi.ImageUrl)
                .HasMaxLength(500);

            
            builder.Property(pvi => pvi.FileName)
                .HasMaxLength(255);

         
            builder.Property(pvi => pvi.AltText)
                .HasMaxLength(200);

        
            builder.Property(pvi => pvi.IsPrimary)
                .IsRequired()
                .HasDefaultValue(false);

            
            builder.Property(pvi => pvi.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            // Foreign Key Relationship
            builder.HasOne(pvi => pvi.ProductVariant)
                .WithMany(pv => pv.ProductVariantImages)
                .HasForeignKey(pvi => pvi.ProductVariantId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}