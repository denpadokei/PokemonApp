using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PokemonApp.DataBase.Models
{
    public class LocalDbContext : DbContext
    {
        public DbSet<pokemon> pokemons { get; set; }
        public DbSet<type> types { get; set; }
        public DbSet<characteristic> characteristics { get; set; }
        public DbSet<trick> tricks { get; set; }
        public DbSet<link_trick> link_tricks { get; set; }

        public DbSet<category> categories { get; set; }

        public ILoggerFactory MyLoggerFactory { get; set; } = LoggerFactory.Create(builder => { builder.AddDebug(); });

        public LocalDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new SqliteConnectionStringBuilder { DataSource = @".\localdb.db" }.ToString();
            optionsBuilder.UseLoggerFactory(this.MyLoggerFactory).UseSqlite(new SqliteConnection(connectionString));
        }

    }
}
