using KnowledgeHubPortal.Business.Interfaces;
using KnowledgeHubPortal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHubPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        // get all categories
        [HttpGet]
        public IActionResult GetCategories()
        {
            // fetch all categories from the database/repository    
            ICategoryRepository categoryRepository = new CategoryRepository(); 
            var categories = categoryRepository.GetCategories();
            if(categories == null || categories.Count == 0)
            {
                return NotFound("No categories found.");
            }
            return Ok(categories);
        }

    }
}
