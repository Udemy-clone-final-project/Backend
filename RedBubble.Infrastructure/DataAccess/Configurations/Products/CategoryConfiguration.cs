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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            //base.Configure(builder); // This handles audit properties
            
            // ADD: Missing table name
            builder.ToTable("Categories");

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasMaxLength(250);

            builder.Property(c => c.ParentCategoryId)
                .IsRequired(false); // Nullable for main categories

            builder.Property(c => c.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            // ADD: Missing indexes
            builder.HasIndex(c => c.CategoryName)
                .IsUnique()
                .HasDatabaseName("IX_Categories_CategoryName");

            builder.HasIndex(c => c.ParentCategoryId)
                .HasDatabaseName("IX_Categories_ParentCategoryId");

            builder.HasIndex(c => c.IsActive)
                .HasDatabaseName("IX_Categories_IsActive");

            // Self-referencing relationship 
            builder.HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Categories_ParentCategory");

            builder.HasMany(c => c.BaseProducts)
                  .WithOne(b => b.Category)
                  .HasForeignKey(p => p.CategoryId)
                  .OnDelete(DeleteBehavior.Restrict); // Changed from IsRequired() to OnDelete
        }
    }
}