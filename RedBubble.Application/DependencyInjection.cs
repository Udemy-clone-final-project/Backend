using Microsoft.Extensions.DependencyInjection;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Application.Interfaces.Services;
using RedBubble.Application.Mappers;
using RedBubble.Application.Profiles;
using RedBubble.Application.Services;
using RedBubble.Application.Services.Implementations;
using RedBubble.Application.Services.Interfaces;
using RedBubble.Application.Services.Products;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.Implementations.Services;
using RedBubble.Infrastructure.Services;
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
            services.AddAutoMapper(t => t.AddProfile<DesignProfile>());

            // Register individual services first
            //services.AddScoped<IRoleService, RoleService>();

            //services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IBaseProductService, BaseProductService>();
            services.AddScoped<IProductVariantService, ProductVariantService>();
            //services.AddScoped<IProductVariantImageService, ProductVariantImageService>();
            services.AddScoped<IDesignService, DesignService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IColorService, ColorService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped(typeof(Func<ICartService>), (serviceporvider) =>
            {

                return () => serviceporvider.GetRequiredService<ICartService>();

            });
            services.AddScoped<ISizeService, SizeService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAiService, AiService>();
            // Register Lazy services
            services.AddScoped<Lazy<IBaseProductService>>(provider =>
                new Lazy<IBaseProductService>(() => provider.GetRequiredService<IBaseProductService>()));
            services.AddScoped<Lazy<IProductVariantService>>(provider =>
               new Lazy<IProductVariantService>(() => provider.GetRequiredService<IProductVariantService>()));
            //services.AddScoped<Lazy<IProductVariantImageService>>(provider =>
            //   new Lazy<IProductVariantImageService>(() => provider.GetRequiredService<IProductVariantImageService>()));
            //services.AddScoped<Lazy<IUserService>>(provider =>
            //   new Lazy<IUserService>(() => provider.GetRequiredService<IUserService>()));
            services.AddScoped<Lazy<ITokenService>>(provider =>
              new Lazy<ITokenService>(() => provider.GetRequiredService<ITokenService>()));
            //services.AddScoped<Lazy<IRoleService>>(provider =>
            //  new Lazy<IRoleService>(() => provider.GetRequiredService<IRoleService>()));
            services.AddScoped<Lazy<IDesignService>>(provider =>
                new Lazy<IDesignService>(() => provider.GetRequiredService<IDesignService>()));
            services.AddScoped<Lazy<IFileService>>(provider =>
                new Lazy<IFileService>(() => provider.GetRequiredService<IFileService>()));
            services.AddScoped<Lazy<IOrderService>>(provider =>
                new Lazy<IOrderService>(() => provider.GetRequiredService<IOrderService>()));
            services.AddScoped<Lazy<IColorService>>(provider =>
                new Lazy<IColorService>(() => provider.GetRequiredService<IColorService>()));
            services.AddScoped<Lazy<ISizeService>>(provider =>
                new Lazy<ISizeService>(() => provider.GetRequiredService<ISizeService>()));
            services.AddScoped<Lazy<ICategoryService>>(provider =>
              new Lazy<ICategoryService>(() => provider.GetRequiredService<ICategoryService>()));
            //services.AddScoped<Lazy<ICartService>>(provider =>
            // new Lazy<ICartService>(() => provider.GetRequiredService<ICartService>()));

            // Register ServiceManager last
            services.AddScoped<IServiceManager, ServiceManager>();


            services.AddScoped<IAccountService, AccountService>();


            // inject design mapper
            services.AddAutoMapper(m => m.AddProfile<DesignProfile>());

            services.AddScoped<IDesignService, DesignService>();

            // ingect Order Service and Order mapper
            // services.AddScoped<IOrderService, OrderService>(); // Already registered above
            services.AddAutoMapper(m => m.AddProfile<OrderProfile>());
            services.AddAutoMapper(m => m.AddProfile<OrderItemProfile>());
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IVariantGeneratorService, VariantGeneratorService>();
            








            return services;

        }
    }
}