using ProductApp.Models;

namespace ProductApp.Service
{
    public interface IProductService
    {

        bool AddProductRepo(Product product);
        void deleteByIdRepo(int id);
        List<Product> GetAllProductsRepo();
        Product GetByIDRepo(int id);
        void UpdateRepo(Product product);
        /* bool AddProduct(Product product);
         void deleteByI(int id);
         List<Product> GetAllProducts();
         Product GetByID(int id);
         void Update(Product product);*/
    }
}
