using Rusuz.Models;

namespace Rusuz.Services.Foundations.Categories
{
    public interface ICategoryService
    {
        ValueTask<Category> AddCategoryAsync(Category Category);
        ValueTask<IQueryable<Category>> RetrieveAllCategorysAsync();
        ValueTask<Category> RetrieveCategoryByIdAsync(int CategoryId);
        ValueTask<Category> ModifyCategoryAsync(Category Category);
        ValueTask<Category> RemoveCategoryAsync(int CategoryId);
    }
}
