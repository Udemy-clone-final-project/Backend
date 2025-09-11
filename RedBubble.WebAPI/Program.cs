using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RedBubble.Application;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Services;
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
            builder.Services.AddSwaggerGen(options =>
            {
                // «·ŒÿÊ… «·√Ê·Ï:  ⁄—Ì› ‰Ÿ«„ «·Õ„«Ì… (Security Scheme)
                // ‰Œ»— Swagger √‰‰« ‰” Œœ„ ‰Ÿ«„ Õ„«Ì…° Ê‰’›Â ·Â
                options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Name = "Authorization", // «”„ «·‹ Header «·–Ì ”ÌÕ„· «· Êﬂ‰
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey, // «·‰Ê⁄ «·„” Œœ„ ··‹ Bearer token
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Description = "√œŒ· 'Bearer' À„ „”«›… À„ «· Êﬂ‰ «·Œ«’ »ﬂ. \r\n\r\n „À«·: 'Bearer eyJhbGciOi...' "
                });

                // «·ŒÿÊ… «·À«‰Ì…:  ÿ»Ìﬁ Â–« «·‰Ÿ«„ ⁄·Ï ﬂ· «·‹ endpoints
                // ‰Œ»— Swagger √‰ Ì÷Ì› √ÌﬁÊ‰… «·ﬁ›· ÊÌ” Œœ„ Â–« «· ⁄—Ì›
                options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer" // ÌÃ» √‰ Ìÿ«»ﬁ «·«”„ ›Ì AddSecurityDefinition
                }
            },
            new string[] {}
        }
    });
            });
            builder.Services.AddHttpContextAccessor();

            // Register our new service as a singleton
            builder.Services.AddSingleton<ICurrentUserService, CurrentUserService>();

            // Register Persistence Services
            builder.Services.AddPersistenceServices(builder.Configuration);

            //AddApplicationServices() => from App/DependencyInjection
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
                    var context = services.GetRequiredService<AppDbContext>();
                    // Ensure database is created and migrations are applied before seeding
                    await context.Database.MigrateAsync();
                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();

                    // This single line will seed all your data in the correct order
                    await DataSeed.SeedAllAsync(context, userManager, roleManager);

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