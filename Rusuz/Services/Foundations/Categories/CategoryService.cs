using Rusuz.Brokers.Storages;
using Rusuz.Models;

namespace Rusuz.Services.Foundations.Categories
{
    public class CategoryService: ICategoryService
    {
        private readonly IStorageBroker storageBroker;

        public CategoryService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;
        
        public async ValueTask<Category> AddCategoryAsync(Category Category) =>
            await this.storageBroker.InsertCategoryAsync(Category);

        public async ValueTask<IQueryable<Category>> RetrieveAllCategorysAsync() =>
           await this.storageBroker.SelectAllCategorysAsync();

        public async ValueTask<Category> RetrieveCategoryByIdAsync(int CategoryId) =>
            await this.storageBroker.SelectCategoryByIdAsync(CategoryId);

        public async ValueTask<Category> ModifyCategoryAsync(Category Category) =>
            await this.storageBroker.UpdateCategoryAsync(Category);

        public async ValueTask<Category> RemoveCategoryAsync(int CategoryId)
        {
            Category maybeCategory = await this.storageBroker.SelectCategoryByIdAsync(CategoryId);
            return await this.storageBroker.DeleteCategoryAsync(maybeCategory);
        }
    }
}
