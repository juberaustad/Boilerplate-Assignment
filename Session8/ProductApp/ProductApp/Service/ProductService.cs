using ProductApp.Context;
using ProductApp.Models;
using ProductApp.Repository;


namespace ProductApp.Service
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool AddProductRepo(Product product)
        {
            bool t = _productRepository.AddProduct(product);
           
            return t;
        }

        public void deleteByIdRepo(int id)
        {
            _productRepository.deleteByI(id);
        }

        public List<Product> GetAllProductsRepo()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetByIDRepo(int id)
        {
            return _productRepository.GetByID(id);
        }

        public void UpdateRepo(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
