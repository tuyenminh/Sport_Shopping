using Microsoft.EntityFrameworkCore;
using Sports_store.Models;

namespace Sports_store.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ProductDetailModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
    }
}
