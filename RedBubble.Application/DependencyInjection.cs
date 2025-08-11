using Microsoft.Extensions.DependencyInjection;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Application.Mappers;
using RedBubble.Application.Services;
using RedBubble.Application.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(t => t.AddProfile<MappingProfile>());

            // Register individual services first
            //services.AddScoped<IRoleService, RoleService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IBaseProductService, BaseProductService>();

            // Register Lazy services
            services.AddScoped<Lazy<IBaseProductService>>(provider =>
                new Lazy<IBaseProductService>(() => provider.GetRequiredService<IBaseProductService>()));

            // Register ServiceManager last
            services.AddScoped<IServiceManager, ServiceManager>();

            return services;
        }
    }
}