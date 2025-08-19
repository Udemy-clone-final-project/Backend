using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.Property(a => a.DisplayName).HasColumnName("DisplayName")
                .IsRequired()
                .HasMaxLength(100);
            builder.HasOne(user => user.Address)
           .WithOne(address => address.User)
           .HasForeignKey<Address>(address => address.ApplicationUserId)
           .OnDelete(DeleteBehavior.Cascade);








            ;
        }
    }
}