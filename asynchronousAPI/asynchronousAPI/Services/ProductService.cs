using asynchronousAPI.Data;
using asynchronousAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace asynchronousAPI.Services
{
    public class ProductService
    {
        private SampleDbContext sampleDbContext;

        public ProductService(SampleDbContext sampleDbContext)
        {
            this.sampleDbContext = sampleDbContext;
        }

        public async  Task<List<Product>> GetProductsAsync()
        {
            var products = await sampleDbContext.Products.ToListAsync();
            
            return products;
        }
    }
}
