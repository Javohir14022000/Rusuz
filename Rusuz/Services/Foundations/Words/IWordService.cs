using Rusuz.Models;

namespace Rusuz.Services.Foundations.Words
{
    public interface IWordService
    {
        ValueTask<Word> AddWordAsync(Word Word);
        ValueTask<IQueryable<Word>> RetrieveAllWordsAsync();
        ValueTask<Word> RetrieveWordByIdAsync(int WordId);
        ValueTask<Word> ModifyWordAsync(Word Word);
        ValueTask<Word> RemoveWordAsync(int WordId);
    }
}
