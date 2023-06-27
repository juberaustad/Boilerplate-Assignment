
using Microsoft.EntityFrameworkCore;
using ProductApp.Constatnts;
using ProductApp.Models;

namespace ProductApp.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Test",
                    Make = "Samsung",
                    category = ProductCategory.Electronics
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Test2",
                    Make = "Samsung2",
                    category = ProductCategory.Electronics
                }


                ) ;
        }


        //create table

        public DbSet<Product> products { get; set; }

       
    }
}
