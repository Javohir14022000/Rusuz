﻿using Microsoft.EntityFrameworkCore;
using Rusuz.Models;

namespace Rusuz.Brokers.Storages
{
    public partial class StorageBroker: DbContext,IStorageBroker
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

        private async ValueTask<T> InsertAsync<T>(T @object)
        {
            this.Entry(@object).State = EntityState.Added;
            await this.SaveChangesAsync();
            DetachEntity(@object);

            return @object;
        }

        private async ValueTask<IQueryable<T>> SelectAllAsync<T>() where T : class =>
            this.Set<T>();

        private async ValueTask<T> SelectAsync<T>(params object[] @objectIds) where T : class =>
            await this.FindAsync<T>(@objectIds);

        private async ValueTask<T> UpdateAsync<T>(T @object)
        {
            this.Entry(@object).State = EntityState.Modified;
            await this.SaveChangesAsync();
            DetachEntity(@object);

            return @object;
        }

        private async ValueTask<T> DeleteAsync<T>(T @object)
        {
            this.Entry(@object).State = EntityState.Deleted;
            await this.SaveChangesAsync();
            DetachEntity(@object);

            return @object;
        }

        private void DetachEntity<T>(T @object)
        {
            this.Entry(@object).State = EntityState.Detached;
        }
    }
}
