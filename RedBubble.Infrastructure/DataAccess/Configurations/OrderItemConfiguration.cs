using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            //builder.HasOne(oi => oi.Order)
            //    .WithMany(o => o.OrderItems)
            //    .HasForeignKey(oi => oi.OrderId)
            //    .OnDelete(DeleteBehavior.Restrict);
            builder.OwnsOne(oi => oi.ProductVariantOrdered, pvo =>
            {
                pvo.WithOwner();
            });

            // نحدد دقة السعر في قاعدة البيانات
            builder.Property(oi => oi.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
