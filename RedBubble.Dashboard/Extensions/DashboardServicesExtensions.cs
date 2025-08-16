using Microsoft.AspNetCore.Authorization; // Add this
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization; // Add this
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using RedBubble.Dashboard.Services;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.UnitOfWork;
using System; // Add this

namespace RedBubble.Dashboard.Extensions
{
    public static class DashboardServicesExtensions
    {
        public static IServiceCollection AddDashboardServices(this IServiceCollection services, IConfiguration configuration)
        {
            // 1. Add global authorization filter
            services.AddControllersWithViews(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddDbContext<AppDbContext>(options =>
            {
                // NOTE: Make sure your appsettings.json has a connection string named "StoreContext"
                options.UseSqlServer(configuration.GetConnectionString("StoreContext"));
            });

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.SignIn.RequireConfirmedAccount = false; 
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
            services.AddScoped<IEmailSender, EmailSender>();

            // 2. Configure the application cookie for "Remember Me" and login path
            services.ConfigureApplicationCookie(options =>
            {
                // The path for the login page
                options.LoginPath = "/Account/Login";

                // Set the cookie to expire after 14 days for "Remember Me"
                options.ExpireTimeSpan = TimeSpan.FromDays(14);

                // If true, the cookie lifetime is reset each time the user visits
                options.SlidingExpiration = true;
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}