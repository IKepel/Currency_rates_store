using Microsoft.EntityFrameworkCore;

namespace Currency_rates_store
{
    public class AppDbContext : DbContext
    {
        public DbSet<CurrencyRate> CurrencyRates { get; set; }

        public AppDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = currencyRate.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
