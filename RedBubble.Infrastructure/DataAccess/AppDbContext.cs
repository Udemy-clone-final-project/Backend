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
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Entities.Models.Identity;

namespace RedBubble.Infrastructure.DataAccess
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BaseProduct> BaseProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductVariantImages> ProductVariantImages { get; set; }
        public DbSet<Design> Designs { get; set; }
        public DbSet<DesignImage> DesignImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyInformation).Assembly);


        }
    }
}
