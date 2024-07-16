using GameStore3.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore3.Data
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration configuration;

        public DataContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbSet<Game> Games { get; set; }























        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}

