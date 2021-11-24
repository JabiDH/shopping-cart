using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class ShippingPricesService : IShippingPricesService
    {
        private IEnumerable<ShippingPrice> repo;
        public ShippingPricesService()
        {
            repo = new List<ShippingPrice>() 
            {
                new ShippingPrice() { Type = "Overnight", Price = 25.99M },
                new ShippingPrice() { Type = "2-Day", Price = 9.99M },
                new ShippingPrice() { Type = "Postal", Price = 2.99M }
            };
        }

        public async Task<IEnumerable<ShippingPrice>> GetAllShippingPricesAsync()
        {
            return await Task.FromResult(repo.ToList());
        }
    }
}
