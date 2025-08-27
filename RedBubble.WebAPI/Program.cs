using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            builder.Services.AddSwaggerGen(options =>
            {
                // ÇáÎØæÉ ÇáÃæáì: ÊÚÑíÝ äÙÇã ÇáÍãÇíÉ (Security Scheme)
                // äÎÈÑ Swagger ÃääÇ äÓÊÎÏã äÙÇã ÍãÇíÉ¡ æäÕÝå áå
                options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Name = "Authorization", // ÇÓã ÇáÜ Header ÇáÐí ÓíÍãá ÇáÊæßä
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey, // ÇáäæÚ ÇáãÓÊÎÏã ááÜ Bearer token
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Description = "ÃÏÎá 'Bearer' Ëã ãÓÇÝÉ Ëã ÇáÊæßä ÇáÎÇÕ Èß. \r\n\r\n ãËÇá: 'Bearer eyJhbGciOi...' "
                });

                // ÇáÎØæÉ ÇáËÇäíÉ: ÊØÈíÞ åÐÇ ÇáäÙÇã Úáì ßá ÇáÜ endpoints
                // äÎÈÑ Swagger Ãä íÖíÝ ÃíÞæäÉ ÇáÞÝá æíÓÊÎÏã åÐÇ ÇáÊÚÑíÝ
                options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer" // íÌÈ Ãä íØÇÈÞ ÇáÇÓã Ýí AddSecurityDefinition
                }
            },
            new string[] {}
        }
    });
            });

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
            //using (var scope = app.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;

            //    try
            //    {
            //        var context = services.GetRequiredService<AppDbContext>();
            //        // Ensure database is created and migrations are applied before seeding
            //        await context.Database.MigrateAsync();
            //        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            //        var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();

            //        // This single line will seed all your data in the correct order
            //        await DataSeed.SeedAllAsync(context, userManager, roleManager);

            //    }
            //    catch (Exception ex)
            //    {
            //        var logger = services.GetRequiredService<ILogger<Program>>();
            //        logger.LogError(ex, "An error occurred while seeding the database.");
            //    }
            //}
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