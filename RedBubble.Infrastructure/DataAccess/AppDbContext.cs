using Microsoft.EntityFrameworkCore;
using RedBubble.Domain.Entities.Models;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.DataAccess.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace RedBubble.Infrastructure.DataAccess
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    
    {
        public DbSet<Design> Designs { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyInformation).Assembly);

            // this line apply configuration from DesignConfiguration()
            modelBuilder.ApplyConfiguration(new DesignConfiguration());

        }
    }
}
