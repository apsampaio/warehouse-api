using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

using Warehouse.Entities;

namespace Warehouse.Database
{
    public class SQLiteContext : DbContext
    {

        public DbSet<Item> items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = @"Database/database.db";
            var connection = new SqliteConnection(connectionStringBuilder.ConnectionString);

            optionsBuilder.UseSqlite(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Items", "item");
            modelBuilder.Entity<Item>(entity =>
                {
                    entity.HasKey(e => e.Id);
                    entity.HasIndex(e => e.Name).IsUnique();
                    entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}