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
            builder.ToTable("Categories");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasMaxLength(250);

            builder.Property(c => c.ParentCategoryId)
                .IsRequired(false); // Nullable for main categories

            // Self-referencing relationship 
            builder.HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .OnDelete(DeleteBehavior.Restrict) // Prevent cascade delete to avoid orphaning subcategories
                .HasConstraintName("FK_Categories_ParentCategory");

        }
    }
}