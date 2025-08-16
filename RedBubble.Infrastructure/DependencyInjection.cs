using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.Base;
using RedBubble.Infrastructure.Implementations.UnitOfWork;
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

            //  Add Identity using custom ApplicationUser and ApplicationRole
            //services.AddIdentity<ApplicationUser, ApplicationRole>()
            //    .AddEntityFrameworkStores<AppDbContext>()
            //    .AddDefaultTokenProviders();

            //services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            return services;
        }
    }
}
