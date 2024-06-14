namespace SportsStore.Models
{

    /// <summary>
    /// Represents an Entity Framework implementation of the store repository.
    /// </summary>
    public class EFStoreRepository(StoreDbContext dbContext) : IStoreRepository
    {
        private readonly StoreDbContext _dbContext = dbContext;


        /// <summary>
        /// Gets a queryable collection of products.
        /// </summary>
        public IQueryable<Product> Products => _dbContext.Products;
    }
}
