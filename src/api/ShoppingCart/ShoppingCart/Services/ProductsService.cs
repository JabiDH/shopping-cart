using ShoppingCart.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class ProductsService : IProductsService
    {
        private IEnumerable<Product> repo;
        public ProductsService()
        {
            repo = new List<Product>()
            {
                new Product() {
                     Id = 1,
                     Name = "Phone XL",
                     Price = 799,
                     Description = "A large phone with one of the best screens"
                },
                new Product() {
                     Id = 1,
                     Name = "Phone Mini",
                     Price = 699,
                     Description = "A great phone with one of the best cameras"
                },
                new Product() {
                     Id = 1,
                     Name = "Phone Standard",
                     Price = 299,
                     Description = "A standard phone that can make and receive calls"
                }
            };
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await Task.FromResult(repo.ToList());
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await Task.FromResult(repo.FirstOrDefault(x => x.Id == id));
        }
    }
}
