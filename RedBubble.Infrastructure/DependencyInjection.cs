using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Identity;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.Base;
using RedBubble.Infrastructure.Implementations.UnitOfWork;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace RedBubble.Infrastructure
{
    // This class is a central place to register Infrastructure layer services — such as:
    // The database context
    // The Identity system
    // Any repositories, if needed
    // It’s used to separate infrastructure configuration from the main Program.cs / Startup.cs,
    // so your application setup stays clean and layered.


    public static class DependencyInjection
    {
        public static async Task<IServiceCollection> AddPersistenceServicesAsync(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("StoreContext"));
            });

            //  Add Identity using custom ApplicationUser and ApplicationRole
            services.AddIdentity<AppUser,IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            //try
            //{
            //    var userManager = services.GetRequiredService<UserManager<Domain.Entities.Identity.AppUser>>();
            //    var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
            //    await AppIdentityDbContextSeed.SeedUsersAsync(userManager, roleManager);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error during seeding: {ex.Message}");
            //}
            //services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            return services;
        }
    }
}
