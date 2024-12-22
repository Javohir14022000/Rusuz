using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using Rusuz.Brokers.Storages;
using Rusuz.Models;
using Rusuz.Services.Foundations.Categories;

namespace Rusuz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : RESTFulController
    {
        private readonly ICategoryService categoryService;
        private readonly IStorageBroker storageBroker;

        public CategoryController(
            ICategoryService categoryService,
            IStorageBroker storageBroker)
        {
            this.categoryService = categoryService;
            this.storageBroker = storageBroker;
        }

        [HttpPost]
        public async ValueTask<ActionResult<Category>> PostCategoryAsync(Category category)
        {
            try
            {
                Category postedCategory = await this.storageBroker.InsertCategoryAsync(category);
                return Created(postedCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("WithSektions")]
        public async Task<ActionResult<List<Category>>> GetCategoriesWithSektions()
        {
            try
            {
                var categories = await this.storageBroker.SelectCategoryWithSektions();

                return Ok(categories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async ValueTask<ActionResult<Category>> DeleteCategoryByIdAsync(int Id)
        {
            try
            {
                return await this.categoryService.RemoveCategoryAsync(Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}