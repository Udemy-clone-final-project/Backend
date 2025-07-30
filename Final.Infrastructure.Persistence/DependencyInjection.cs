using Final.Infrastructure.Persistence._Data;
using LinkDev.Talabat.Core.Domain.Contracts.Persistence.DbInitializers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Infrastructure.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<FinalDbContext>((optionsBuilder) =>
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("StoreContext"));
            });
            services.AddScoped(typeof(IStoreDbInitializer), typeof(StoreContextIntializer));

            return services;
        }
    }
}


