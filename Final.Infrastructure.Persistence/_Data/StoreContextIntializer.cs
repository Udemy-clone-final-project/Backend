using LinkDev.Talabat.Core.Domain.Contracts.Persistence.DbInitializers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Final.Infrastructure.Persistence._Data
{
    internal class StoreContextIntializer(FinalDbContext dbContext) :
       IDbInitializer
    {
        public async Task InitializeAsync()
        {
            var pendingMigration = dbContext.Database.GetPendingMigrations();
            if (pendingMigration.Any())
                await dbContext.Database.MigrateAsync();

        }



        public async Task SeedAsync()
        {
          
        }
    }
}
