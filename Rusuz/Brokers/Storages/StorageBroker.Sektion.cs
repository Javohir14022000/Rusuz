
using Rusuz.Models;

namespace Rusuz.Brokers.Storages
{
    public partial class StorageBroker
    {
        public async ValueTask<Sektion> InsertSektionAsync(Sektion Sektion) =>
        await InsertAsync(Sektion);

        public async ValueTask<IQueryable<Sektion>> SelectAllSektionsAsync() =>
           await SelectAllAsync<Sektion>();

        public async ValueTask<Sektion> SelectSektionByIdAsync(int SektionId) =>
           await SelectAsync<Sektion>(SektionId);

        public async ValueTask<Sektion> UpdateSektionAsync(Sektion Sektion) =>
           await UpdateAsync(Sektion);

        public async ValueTask<Sektion> DeleteSektionAsync(Sektion Sektion) =>
          await DeleteAsync(Sektion);
    }
}
