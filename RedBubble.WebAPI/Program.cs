using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using RedBubble.Application;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Infrastructure;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.WebAPI.Extensions;
using System.Text;

namespace RedBubble.WebAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register Persistence Services
            builder.Services.AddPersistenceServices(builder.Configuration);

            // Register Application Services
            builder.Services.AddApplicationServices();

            // Add Authentication
            
            builder.Services.AddIdentityServices(builder.Configuration);
            // Add Authorization
            builder.Services.AddAuthorization();

            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
                    await AppDbContextSeed.SeedRolesAsync(roleManager);

                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    await AppDbContextSeed.SeedAdminUserAsync(userManager);
                    await AppDbContextSeed.SeedCustomersAsync(userManager, roleManager);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}