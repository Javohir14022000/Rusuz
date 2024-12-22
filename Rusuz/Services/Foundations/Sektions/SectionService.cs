using Rusuz.Brokers.Storages;
using Rusuz.Models;

namespace Rusuz.Services.Foundations.Sektions
{
    public class SectionService: ISectionService
    {
        private readonly IStorageBroker storageBroker;

        public SectionService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;
       
        public async ValueTask<Sektion> AddSektionAsync(Sektion Sektion) =>
            await this.storageBroker.InsertSektionAsync(Sektion);

        public async ValueTask<IQueryable<Sektion>> RetrieveAllSektionsAsync() =>
           await this.storageBroker.SelectAllSektionsAsync();

        public async ValueTask<Sektion> RetrieveSektionByIdAsync(int SektionId) =>
            await this.storageBroker.SelectSektionByIdAsync(SektionId);

        public async ValueTask<Sektion> ModifySektionAsync(Sektion Sektion) =>
            await this.storageBroker.UpdateSektionAsync(Sektion);

        public async ValueTask<Sektion> RemoveSektionAsync(int SektionId)
        {
            Sektion maybeSektion = await this.storageBroker.SelectSektionByIdAsync(SektionId);
            return await this.storageBroker.DeleteSektionAsync(maybeSektion);
        }
    }
}
