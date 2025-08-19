using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.Base;
using RedBubble.Infrastructure.Implementations.Repositories;
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
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("StoreContext"));
            });

            ////  Add Identity using custom ApplicationUser and ApplicationRole
            //services.AddIdentity<ApplicationUser, ApplicationRole>()
            //    .AddEntityFrameworkStores<AppDbContext>()
            //    .AddDefaultTokenProviders();

      
            

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped<IDesignRepository, DesignRepository>();
            #region is generic one alternative of this ??
            // But most of the time, you want to use specific repositories(like IDesignRepository) so you can:
            // Add custom methods(e.g., GetByCategoryId, GetTopRatedDesigns)
            // Keep service code clean
            // Separate logic for each entity
            #endregion

            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }
    }
}
