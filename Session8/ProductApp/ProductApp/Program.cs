using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using ProductApp.Context;
using ProductApp.Repository;
using ProductApp.Service;


namespace ProductApp
{
    /* public class Program
     {
         public static void Main(string[] args)
         {
             var builder = WebApplication.CreateBuilder(args);
             string? conn = builder.Configuration.GetConnectionString("AppConn");
             builder.Services.AddDbContext<AppDbContext>(o=>o.UseSqlServer(conn));
             builder.Services.AddScoped<IProductRepository, ProductRepository>();
             builder.Services.AddScoped<IProductService, ProductService>();

             // Add services to the container.
             builder.Services.AddControllersWithViews();

             //healthcheck
             builder.ConfigureServices((hostContext, services) =>
             {
                 services.AddHealthChecks()
                     .AddCheck("GetAllProducts", () =>
                     {
                         // Add your logic to check the health of the "GetAll" products endpoint
                         var allProducts = _productRepository.GetAllProducts();

                         if (allProducts != null && allProducts.Any())
                         {
                             // If the health check is successful, return a Healthy status
                             return HealthCheckResult.Healthy("GetAllProducts is working fine.");
                         }
                         else
                         {
                             // If there are no products or an error occurred, return a Degraded status
                             return HealthCheckResult.Degraded("No products found or an error occurred.");
                         }
                     });

                 services.AddHealthChecksUI();
             });




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

             app.UseAuthorization();

             app.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Product}/{action=Index}/{id?}");

             app.Run();
         }
     }*/













    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string? conn = builder.Configuration.GetConnectionString("AppConn");
            builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlServer(conn));
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Health check
           

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Product}/{action=Index}/{id?}");

            // Health Check UI
      
            app.Run();
        }
    }

}