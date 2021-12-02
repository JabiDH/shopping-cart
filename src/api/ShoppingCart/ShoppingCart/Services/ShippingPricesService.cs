using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DbContexts;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class ShippingPricesService : IShippingPricesService
    {
        private ShoppingCartDbContext dbContext;
        public ShippingPricesService(ShoppingCartDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ShippingPrice>> GetAllShippingPricesAsync()
        {
            return await Task.FromResult(this.dbContext.ShippingPrices.ToList());
        }

        public async Task<ShippingPrice> CreateShippingPriceAsync(ShippingPrice shippingPrice)
        {
            var newShippingPrice = this.dbContext.ShippingPrices.Add(shippingPrice).Entity;            
            Save();
            return await Task.FromResult(newShippingPrice);
        }

        private void Save()
        {
            this.dbContext.SaveChanges();
        }
    }
}
