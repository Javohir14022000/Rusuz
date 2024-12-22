using Rusuz.Models;

namespace Rusuz.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Sektion> InsertSektionAsync(Sektion Sektion);
        ValueTask<IQueryable<Sektion>> SelectAllSektionsAsync();
        ValueTask<Sektion> SelectSektionByIdAsync(int SektionId);
        ValueTask<Sektion> UpdateSektionAsync(Sektion Sektion);
        ValueTask<Sektion> DeleteSektionAsync(Sektion Sektion);
    }
}
