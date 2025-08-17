using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    // // What does IEntityTypeConfiguration<Design> do?
    // It’s an interface provided by Entity Framework Core
    // to help you configure entity properties in a separate class,
    // instead of inside OnModelCreating() in DbContext.
    public class DesignConfiguration : IEntityTypeConfiguration<Design>
    {
        

        public void Configure(EntityTypeBuilder<Design> builder)
        {
            // Relationship between Design and User(Artist)
            // Design Created by one Artist
            builder.HasOne(d => d.Artist)
                .WithMany()
                .HasForeignKey(d => d.ArtistId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relationship between Design and User(Admin)
            // Design Reviewed by one Admin
            builder.HasOne(d => d.Admin)
                .WithMany()
                .HasForeignKey(d => d.AdminId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
