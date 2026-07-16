using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KalkiTechProductsCatalogService.Controllers
{

    //GET https://www.kt.com/api/ProductsCatalog

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsCatalogController : ControllerBase
    {

        [HttpGet]
        public string GetData() // endpoint
        {
            return "Hello from ProductsCatalogController!";
        }
    }
}
