using Rusuz.Models;

namespace Rusuz.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Category> InsertCategoryAsync(Category Category);
        ValueTask<IQueryable<Category>> SelectAllCategorysAsync();
        ValueTask<Category> SelectCategoryByIdAsync(int CategoryId);
        ValueTask<Category> UpdateCategoryAsync(Category Category);
        ValueTask<Category> DeleteCategoryAsync(Category Category);

        Task<List<Category>> SelectCategoryWithSektions();
    }
}
