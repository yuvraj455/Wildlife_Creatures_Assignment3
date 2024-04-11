using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WildlifeCreatures_Assignment3.Data;
using WildlifeCreatures_Assignment3.Models;

namespace WildlifeCreatures_Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new WebApplication instance
            var builder = WebApplication.CreateBuilder(args);

            // Add DbContext to the services container
            builder.Services.AddDbContext<WildlifeCreatures_Assignment3Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("WildlifeCreatures_Assignment3Context")
                    ?? throw new InvalidOperationException("Connection string 'WildlifeCreatures_Assignment3Context' not found.")));

            // Add services to the container
            builder.Services.AddControllersWithViews();

            // Build the application
            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                // Exception handler for non-development environment
                app.UseExceptionHandler("/Home/Error");
                // Enable HTTP Strict Transport Security (HSTS)
                app.UseHsts();
            }

            // Redirect HTTP to HTTPS
            app.UseHttpsRedirection();
            // Serve static files
            app.UseStaticFiles();

            // Enable routing
            app.UseRouting();

            // Enable authorization
            app.UseAuthorization();

            // Define default controller route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Seed the database with initial data
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedData.Initialize(services);
            }

            // Start the application
            app.Run();
        }
    }
}
