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
            services.AddScoped<IRoleService, RoleService>();
            //services.AddScoped<IDesignService, DesignService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IBaseProductService, BaseProductService>();

            // Register Lazy services
            services.AddScoped<Lazy<IBaseProductService>>(provider =>
                new Lazy<IBaseProductService>(() => provider.GetRequiredService<IBaseProductService>()));
            services.AddScoped<Lazy<IProductVariantService>>(provider =>
               new Lazy<IProductVariantService>(() => provider.GetRequiredService<IProductVariantService>()));
            services.AddScoped<Lazy<IProductVariantImageService>>(provider =>
               new Lazy<IProductVariantImageService>(() => provider.GetRequiredService<IProductVariantImageService>()));
            services.AddScoped<Lazy<IUserService>>(provider =>
               new Lazy<IUserService>(() => provider.GetRequiredService<IUserService>()));
            services.AddScoped<Lazy<ITokenService>>(provider =>
              new Lazy<ITokenService>(() => provider.GetRequiredService<ITokenService>()));
            services.AddScoped<Lazy<IRoleService>>(provider =>
              new Lazy<IRoleService>(() => provider.GetRequiredService<IRoleService>()));

            // Register ServiceManager last
            services.AddScoped<IServiceManager, ServiceManager>();

            



            // inject design mapper
            services.AddAutoMapper(m => m.AddProfile<DesignProfile>());

            services.AddScoped<IDesignService, DesignService>();

            // ingect Order Service and Order mapper
            services.AddScoped<IOrderService, OrderService>();
            services.AddAutoMapper(m => m.AddProfile<OrderProfile>());
            services.AddAutoMapper(m => m.AddProfile<OrderItemProfile>());

            return services;

        }
    }
}