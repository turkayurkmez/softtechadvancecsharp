using asynchronousAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace asynchronousAPI.Data
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seeding:
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", Description = "Product 1 description", Price = 100 },
                new Product { Id = 2, Name = "Product 2", Description = "Product 2 description", Price = 200 },
                new Product { Id = 3, Name = "Product 3", Description = "Product 3 description", Price = 300 },
                new Product { Id = 4, Name = "Product 4", Description = "Product 4 description", Price = 400 },
                new Product { Id = 5, Name = "Product 5", Description = "Product 5 description", Price = 500 }

                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
