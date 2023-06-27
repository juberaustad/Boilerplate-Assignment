using ProductApp.Constatnts;
using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }

        [MaxLength(100)]
        public string ProductName { get; set; }
        public string Make { get; set; }

        
        public int Price { get; set; }

        public ProductCategory category { get; set; }
    }
}
