using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    /// <summary>
    /// Represents a database context for the Sports Store application.
    /// </summary>
    /// <param name="options">The options for configuring the database context.</param>
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<Product> Products => Set<Product>();
    }
}