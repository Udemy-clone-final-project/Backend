
using RedBubble.Infrastructure;
using RedBubble.Application;


namespace RedBubble.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // Which is shorthand for:
            // Register AppDbContext
            // Register ApplicationUser, ApplicationRole, Identity
            // (Optionally) Register repositories like IRoleRepository
            // AddPersistenceServices => from Infra/DependencyInjection
            builder.Services.AddPersistenceServices(builder.Configuration);

            //AddApplicationServices() => from App/DependencyInjection
            builder.Services.AddApplicationServices();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
