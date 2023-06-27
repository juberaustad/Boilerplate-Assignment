using ProductApp.Constatnts;
using ProductApp.Models;
using ProductApp.Repository;
using ProductAppTest.Class;

namespace ProductAppTest
{
    public class ProductRepotest:IClassFixture<ProductDbFixture>
    {
        readonly IProductRepository _repository;

        public ProductRepotest(ProductDbFixture fixture)
        {
            _repository = new ProductRepository(fixture._appDbContext);
        }

        [Fact]
        public void AddProduct()
        {
            //Assign
            string expectedProductName = "Printer";

            //Act-->Call Devlopment code
            _repository.AddProduct(new Product() { ProductId = 4, ProductName = "Printer", Make="Samsung",category=ProductCategory.Electronics,Price = 14999 });

            List<Product> products =  _repository.GetAllProducts();

            var actualProductName = products[3].ProductName;

            //Assert
            Assert.Equal(expectedProductName, actualProductName);
        }
    }
}