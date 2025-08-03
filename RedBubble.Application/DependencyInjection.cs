using Microsoft.Extensions.DependencyInjection;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Application.Mappers;
using RedBubble.Application.Services;
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
            services.AddScoped(typeof(IServiceManager), typeof(ServiceManager));

            services.AddScoped<IRoleService, RoleService>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();


            return services;
        }
    }
}
