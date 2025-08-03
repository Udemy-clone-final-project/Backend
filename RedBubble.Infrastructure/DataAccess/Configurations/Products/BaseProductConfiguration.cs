using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models.Products;
namespace RedBubble.Infrastructure.DataAccess.Configurations.Products
{
    public class BaseProductConfiguration : IEntityTypeConfiguration<BaseProduct>
    {
        public void Configure(EntityTypeBuilder<BaseProduct> builder)
        {
           
            builder.ToTable("BaseProducts");

           
            builder.HasKey(p => p.Id);

            
            builder.Property(p => p.Name)
                .IsRequired() 
                .HasMaxLength(100); 

            builder.Property(p => p.Description)
                .HasMaxLength(500); 

            builder.Property(p => p.BasePrice)
                .IsRequired()
                .HasColumnType("decimal(18, 2)"); 

           
            builder.HasOne(p => p.Category)         
                   .WithMany(c => c.BaseProducts)   
                   .HasForeignKey(p => p.CategoryId)  
                   .IsRequired();                    
        }
    }
}



