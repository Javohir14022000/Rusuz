using Rusuz.Models;

namespace Rusuz.Services.Foundations.Sektions
{
    public interface ISectionService
    {
        ValueTask<Sektion> AddSektionAsync(Sektion Sektion);
        ValueTask<IQueryable<Sektion>> RetrieveAllSektionsAsync();
        ValueTask<Sektion> RetrieveSektionByIdAsync(int SektionId);
        ValueTask<Sektion> ModifySektionAsync(Sektion Sektion);
        ValueTask<Sektion> RemoveSektionAsync(int SektionId);
    }
}
