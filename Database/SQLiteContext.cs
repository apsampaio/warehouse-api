using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

using Warehouse.Entities;

namespace Warehouse.Database
{
    public class SQLiteContext : DbContext
    {

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "database.db";
            var connection = new SqliteConnection(connectionStringBuilder.ConnectionString);

            optionsBuilder.UseSqlite(connection);
        }

    }
}