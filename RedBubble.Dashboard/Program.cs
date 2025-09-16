using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application;
using RedBubble.Dashboard.Extensions;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.UnitOfWork;
using RedBubble.Infrastructure;
using RedBubble.Application;



namespace RedBubble.Dashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            
          builder.Services.AddDashboardServices(builder.Configuration);

            // Register Persistence Services
            builder.Services.AddPersistenceServices(builder.Configuration);

            //AddApplicationServices() => from App/DependencyInjection
            // Register Application Services
            builder.Services.AddApplicationServices();
            
            // Add HttpContextAccessor for CurrentUserService
            builder.Services.AddHttpContextAccessor();

            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
