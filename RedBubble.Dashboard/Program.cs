using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RedBubble.Domain.Entities.Identity;
using RedBubble.Domain.Entities.Models;
using RedBubble.Infrastructure.DataAccess;

namespace RedBubble.Dashboard
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("StoreContext")));

            builder.Services.AddIdentity<Domain.Entities.Identity.AppUser,IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
            var app = builder.Build();
            //using (var scope = app.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    try
            //    {
            //        var userManager = services.GetRequiredService<UserManager<Domain.Entities.Identity.AppUser>>();
            //        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            //        await AppIdentityDbContextSeed.SeedUsersAsync(userManager, roleManager);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error during seeding: {ex.Message}");
            //    }
            //}
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

            app.UseAuthorization();
            app.UseAuthentication();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
