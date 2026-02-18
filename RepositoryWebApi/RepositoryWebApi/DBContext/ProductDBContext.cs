using Microsoft.EntityFrameworkCore;
using RepositoryWebApi.Models;

namespace RepositoryWebApi.DBContext
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Description = "Electronic devices and gadgets" },
                new Category { Id = 2, Name = "Books", Description = "Various kinds of books" },
                new Category { Id = 3, Name = "Clothing", Description = "Apparel and accessories" }
            );
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
