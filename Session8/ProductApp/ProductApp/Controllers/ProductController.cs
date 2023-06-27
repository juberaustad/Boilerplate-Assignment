using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using ProductApp.Repository;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository= productRepository;
        }
        public IActionResult Index(string categoryFilter)
        {
            ViewBag.Message = TempData["Message"];
            IEnumerable<Product> allproducts = _productRepository.GetAllProducts();

            if (!string.IsNullOrEmpty(categoryFilter))
            {
                allproducts = allproducts.Where(p => p.category.ToString() == categoryFilter);
            }

            return View(allproducts);
        }


        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]

        //argumets call model binding
        public IActionResult AddProduct(Product product)
        {

            bool addProductStatus = _productRepository.AddProduct(product);
            
            if (addProductStatus)
            {
                
                TempData["Message"] = "Product added successfully!";
               
            }
            else
            {
               
                TempData["Message"] = "Failed to add product. Beacuase It already Present ";
               
            }
            return RedirectToAction("index");

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product product = _productRepository.GetByID(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            _productRepository.deleteByI(product.ProductId);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
           var product= _productRepository.GetByID(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
             _productRepository.Update(product);
            return RedirectToAction("index");
        }




    }
}
