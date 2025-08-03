using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedBubble.Domain.Entities.Models;
using RedBubble.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess
{
    // This context includes:
    // DbSet<IdentityUser> (for users)
    // DbSet<IdentityRole> (for roles)
    // and other Identity tables like UserRoles, UserClaims, etc.
    public class AppDbContext:IdentityDbContext<ApplicationUser , ApplicationRole , Guid>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyInformation).Assembly);
        }
    }
}
