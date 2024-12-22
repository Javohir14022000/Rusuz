using Microsoft.EntityFrameworkCore;
using Rusuz.Models;

namespace Rusuz.Brokers.Storages
{
    public class StorageBroker: DbContext,IStorageBroker
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = 
                this.configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Sektion> Sektions { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}
