using Microsoft.EntityFrameworkCore;
using ShoppingCart.DbContexts;
using ShoppingCart.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class ProductsService : IProductsService
    {
        private ShoppingCartDbContext dbContext;
        public ProductsService(ShoppingCartDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await Task.FromResult(dbContext.Products.ToList());
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await Task.FromResult(dbContext.Products.Find(id));
        }
        public async Task<Product> CreateProductAsync(Product product)
        {
            var newProduct = this.dbContext.Products.Add(product).Entity;
            Save();
            return await Task.FromResult(newProduct);
        }
        private void Save()
        {
            this.dbContext.SaveChanges();
        }
    }
}
