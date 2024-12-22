
using Rusuz.Models;

namespace Rusuz.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Word> InsertWordAsync(Word Word);
        ValueTask<IQueryable<Word>> SelectAllWordsAsync();
        ValueTask<Word> SelectWordByIdAsync(int WordId);
        ValueTask<Word> UpdateWordAsync(Word Word);
        ValueTask<Word> DeleteWordAsync(Word Word);

        Task<List<Word>> GetWordsBySektionId(int sektionId);
    }
}
