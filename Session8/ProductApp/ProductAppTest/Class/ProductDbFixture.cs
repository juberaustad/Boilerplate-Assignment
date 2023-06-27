using Microsoft.EntityFrameworkCore;
using ProductApp.Constatnts;
using ProductApp.Context;
using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppTest.Class
{
    public class ProductDbFixture
    {
        public AppDbContext _appDbContext;

        public ProductDbFixture()
        {
            var productDbcontextOptions = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("InMemoryDatabase").Options;
            _appDbContext = new AppDbContext(productDbcontextOptions);
            _appDbContext.Add(new Product { ProductId=1,ProductName="Mouse",category=ProductCategory.Electronics,Make="Lenovo"
            ,Price=500});
            _appDbContext.Add(new Product
            {
                ProductId = 2,
                ProductName = "Keyboard",
                category = ProductCategory.Electronics,
                Make = "Lenovo",
                Price = 5000
            });
            _appDbContext.Add(new Product
            {
                ProductId = 3,
                ProductName = "Camera",
                category = ProductCategory.Electronics,
                Make = "Lenovo"
           ,
                Price = 50
            });
            _appDbContext.SaveChanges();
        }
    }
}
