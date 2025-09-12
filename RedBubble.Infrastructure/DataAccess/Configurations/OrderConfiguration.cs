using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //builder.HasOne(o => o.Customer)
            //    .WithMany(c => c.Orders)
            //    .HasForeignKey(o => o.CustomerId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(o=>o.OrderItems)
            //    .WithOne(o => o.Order)
            //    .HasForeignKey(oi=>oi.OrderId)
            //    .OnDelete(DeleteBehavior.Restrict);


            builder.OwnsOne(o => o.ShippingAddress, addressBuilder =>
            {
                addressBuilder.WithOwner();
            });

            
            builder.Property(o => o.Status)
                .HasConversion(
                    s => s.ToString(),
                    s => (OrderStatus)Enum.Parse(typeof(OrderStatus), s)
                );

           
            builder.HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            
            builder.HasOne(o => o.DeliveryMethod)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);





        }
    }
}
