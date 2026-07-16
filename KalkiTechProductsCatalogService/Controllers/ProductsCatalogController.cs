using KalkiTechProductsCatalogService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KalkiTechProductsCatalogService.Controllers
{

    //GET https://www.kt.com/api/ProductsCatalog

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsCatalogController : ControllerBase
    {
        //GET https://www.kt.com/api/ProductsCatalog
        [HttpGet]
        public List<Product> GetAllProducts() // endpoint
        {
            // fetch the data from the database and return it to the client
            return GetProductsFromDatabase();
        }


        // GET https://www.kt.com/api/ProductsCatalog/54
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetProudctById(int id)
        {
            var product = from p in GetProductsFromDatabase() where p.ProductId == id select p;
            if(product == null) 
            {
                // return 404 - product not found
                return NotFound("Product not found");
            }
            
            // return product with 200
            return Ok(product.FirstOrDefault());
        }

        // get products by category

        // GET https://www.kt.com/api/ProductsCatalog/category/mobiles

        [HttpGet]
        [Route("category/{category}")]
        public IActionResult GetProductsByCategory(string category)
        {
            var products = from p in GetProductsFromDatabase() where p.Category.Contains(category) select p;

            if(!products.Any())
            {
                return NotFound("No products found in this category");
            };
            return Ok(products.ToList());
        }


        // get costliest product
        // GET https://www.kt.com/api/ProductsCatalog/costliest

        [HttpGet]
        [Route("costliest")]
        public Product GetCostliestProduct()
        {
            var product = (from p in GetProductsFromDatabase() orderby p.Price descending select p).FirstOrDefault();
            return product;
        }


        // get proudcts between a price range ex: 500 to 800
        // GET https://www.kt.com/api/ProductsCatalog/pricerange/500/800

        [HttpGet("pricerange/{minPrice}/{maxPrice}")]
        public List<Product> GetProductsByPriceRange(int minPrice, int maxPrice)
        {
            var products = from p in GetProductsFromDatabase() where p.Price >= minPrice && p.Price <= maxPrice select p;
            return products.ToList();
        }

        private List<Product> GetProductsFromDatabase()
        {
            // This is a placeholder for database access logic.
            // In a real application, you would use Entity Framework or another ORM to fetch data from the database.
            return new List<Product>
            {
                new Product { ProductId = 1, Name = "Apple iPhone 15", Price = 999, Category = "Smartphones", Brand = "Apple", Country = "USA" },
                new Product { ProductId = 2, Name = "Samsung Galaxy S24", Price = 899, Category = "Smartphones", Brand = "Samsung", Country = "South Korea" },
                new Product { ProductId = 3, Name = "Sony WH-1000XM5", Price = 349, Category = "Headphones", Brand = "Sony", Country = "Japan" },
                new Product { ProductId = 4, Name = "Dell XPS 13", Price = 1199, Category = "Laptops", Brand = "Dell", Country = "USA" },
                new Product { ProductId = 5, Name = "Nike Air Zoom Pegasus 40", Price = 130, Category = "Footwear", Brand = "Nike", Country = "Vietnam" },
                new Product { ProductId = 6, Name = "Levi's 501 Original Jeans", Price = 69, Category = "Apparel", Brand = "Levi's", Country = "USA" },
                new Product { ProductId = 7, Name = "Instant Pot Duo 7-in-1", Price = 99, Category = "Kitchen Appliances", Brand = "Instant Pot", Country = "China" },
                new Product { ProductId = 8, Name = "Dyson V11 Torque Drive", Price = 599, Category = "Home Appliances", Brand = "Dyson", Country = "UK" },
                new Product { ProductId = 9, Name = "Samsung 55\" QLED 4K TV", Price = 699, Category = "Televisions", Brand = "Samsung", Country = "South Korea" },
                new Product { ProductId = 10, Name = "Cuisinart Chef's Classic 12-Piece", Price = 179, Category = "Cookware", Brand = "Cuisinart", Country = "USA" },
                new Product { ProductId = 11, Name = "The Alchemist (Paulo Coelho)", Price = 15, Category = "Books", Brand = "HarperOne", Country = "Brazil" },
                new Product { ProductId = 12, Name = "Organic Bananas (1 kg)", Price = 2, Category = "Groceries", Brand = "Local Farm", Country = "Ecuador" }
            };
        }
    }
}
