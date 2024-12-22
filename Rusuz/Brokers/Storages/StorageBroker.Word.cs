using Microsoft.EntityFrameworkCore;
using Rusuz.Models;

namespace Rusuz.Brokers.Storages
{
    public partial class StorageBroker
    {
        public async ValueTask<Word> InsertWordAsync(Word Word) =>
       await InsertAsync(Word);

        public async ValueTask<IQueryable<Word>> SelectAllWordsAsync() =>
           await SelectAllAsync<Word>();

        public async ValueTask<Word> SelectWordByIdAsync(int WordId) =>
           await SelectAsync<Word>(WordId);

        public async ValueTask<Word> UpdateWordAsync(Word Word) =>
           await UpdateAsync(Word);

        public async ValueTask<Word> DeleteWordAsync(Word Word) =>
          await DeleteAsync(Word);

        public async Task<List<Word>> GetWordsBySektionId(int sektionId)
        {
            return await this.Words
                .Where(w => w.SektionId == sektionId)
                .ToListAsync();
        }
    }
}
