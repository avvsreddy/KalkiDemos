using KnowledgeHubPortal.Business.Entities;
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

        private ICategoryRepository categoryRepository = null;
        public CategoryController(ICategoryRepository repo) // DI
        {
            this.categoryRepository = repo;
        }


        // get all categories
        [HttpGet]
        public IActionResult GetCategories()
        {
            // fetch all categories from the database/repository    
            //ICategoryRepository categoryRepository = new CategoryRepository(); 
            var categories = categoryRepository.GetCategories();
            if(categories == null || categories.Count == 0)
            {
                return NotFound("No categories found.");
            }
            return Ok(categories);
        }

        // create a new category

        [HttpPost]
        public IActionResult CreateCategory(Category category) 
        {
            // validate the category object - Automatically done by model binding and data annotations
            // send this data to the database/repository to create a new category
            //ICategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.CreateCategory(category);
            // return the created category with a 201 status code
            // 201+Location+data of the created resource
            return Created($"api/category/{category.CategoryID}", category);
        }

    }
}
