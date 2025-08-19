using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Infrastructure.DataAccess;
using System.Text;

namespace RedBubble.WebAPI.Extensions
{
    public static class IdentityServicesExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            // 1. إعداد خدمات Identity الأساسية
            // هذا سيقوم تلقائيًا بإضافة المصادقة المستندة إلى الكوكيز
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedAccount = false;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

            // 2. إضافة إعدادات المصادقة وتحديد JWT كخيار إضافي
            services.AddAuthentication(options =>
            {
                // الخيار الافتراضي سيظل للكوكيز (مناسب للـ MVC)
                options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddJwtBearer(options => // إضافة نظام JWT
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
                };
            });

            services.AddAuthorization();

            return services;
        }
    
}
}
