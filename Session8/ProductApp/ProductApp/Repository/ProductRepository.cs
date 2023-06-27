using ProductApp.Context;
using ProductApp.Models;
using ProductApp.Service;
using System.Linq;

namespace ProductApp.Repository
{
    public class ProductRepository : IProductRepository
    {

        AppDbContext _context;
        public ProductRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public bool AddProduct(Product product)
        {
            if (_context.products.Any(p => p.ProductName == product.ProductName) == false)
            {
                _context.products.Add(product);
            }

            bool b= _context.SaveChanges() > 0 ? true : false;

            return b;

        }


        public void deleteByI(int id)
        {
            var product = _context.products.FirstOrDefault(u => u.ProductId == id);
            if (product != null)
            {
                _context.products.Remove(product);
                _context.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = _context.products.ToList();

            return products;
        }

        public Product GetByID(int id)
        {
            Product? product = _context.products.FirstOrDefault(u => u.ProductId == id);

            return product;
        }

        public void Update(Product product)
        {
            var products1 = _context.products.FirstOrDefault(u => u.ProductId == product.ProductId);
            if (products1 != null)
            {
                _context.products.Remove(products1);
                _context.products.Add(product);
                _context.SaveChanges();
            }
        }
        
    }
}
