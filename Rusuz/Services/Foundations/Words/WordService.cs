using Rusuz.Brokers.Storages;
using Rusuz.Models;

namespace Rusuz.Services.Foundations.Words
{
    public class WordService: IWordService
    {
        private readonly IStorageBroker storageBroker;

        public WordService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Word> AddWordAsync(Word Word) =>
            await this.storageBroker.InsertWordAsync(Word);

        public async ValueTask<IQueryable<Word>> RetrieveAllWordsAsync() =>
           await this.storageBroker.SelectAllWordsAsync();

        public async ValueTask<Word> RetrieveWordByIdAsync(int WordId) =>
            await this.storageBroker.SelectWordByIdAsync(WordId);

        public async ValueTask<Word> ModifyWordAsync(Word Word) =>
            await this.storageBroker.UpdateWordAsync(Word);

        public async ValueTask<Word> RemoveWordAsync(int WordId)
        {
            Word maybeWord = await this.storageBroker.SelectWordByIdAsync(WordId);
            return await this.storageBroker.DeleteWordAsync(maybeWord);
        }
    }
}
