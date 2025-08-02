using Microsoft.Extensions.DependencyInjection;
using RedBubble.Application.Interfaces;
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
            services.AddScoped<IRoleService, RoleService>();

           

            return services;
        }
    }
}
