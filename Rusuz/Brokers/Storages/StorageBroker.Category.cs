using Microsoft.EntityFrameworkCore;
using Rusuz.Models;

namespace Rusuz.Brokers.Storages
{
    public partial class StorageBroker
    {
        public async ValueTask<Category> InsertCategoryAsync(Category Category) =>
        await InsertAsync(Category);

        public async ValueTask<IQueryable<Category>> SelectAllCategorysAsync() =>
           await SelectAllAsync<Category>();

        public async ValueTask<Category> SelectCategoryByIdAsync(int CategoryId) =>
           await SelectAsync<Category>(CategoryId);

        public async ValueTask<Category> UpdateCategoryAsync(Category Category) =>
           await UpdateAsync(Category);

        public async ValueTask<Category> DeleteCategoryAsync(Category Category) =>
          await DeleteAsync(Category);

        public async Task<List<Category>> SelectCategoryWithSektions()
        {
            return await this.Categories
                .Include(h => h.Sekions)
                .ToListAsync();
        }
    }
}
