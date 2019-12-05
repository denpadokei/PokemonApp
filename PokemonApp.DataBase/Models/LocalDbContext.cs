using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace PokemonApp.DataBase.Models
{
    public class LocalDbContext : DbContext
    {
        public DbSet<pokemon> pokemons { get; set; }
        public DbSet<type> types { get; set; }
        public DbSet<characteristic> characteristics { get; set; }
        public DbSet<trick> tricks { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddDebug(); });

        public LocalDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new SqliteConnectionStringBuilder { DataSource = @".\localdb.db" }.ToString();
            optionsBuilder.UseLoggerFactory(MyLoggerFactory).UseSqlite(new SqliteConnection(connectionString));
        }

    }
}
