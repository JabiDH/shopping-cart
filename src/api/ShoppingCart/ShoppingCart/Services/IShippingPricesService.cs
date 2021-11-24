using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public interface IShippingPricesService
    {
        Task<IEnumerable<ShippingPrice>> GetAllShippingPricesAsync();
    }
}
