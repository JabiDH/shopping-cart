using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Models;
using ShoppingCart.Services;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingPricesController : ControllerBase
    {
        private IShippingPricesService shippingPricesService;

        public ShippingPricesController(IShippingPricesService shippingPricesService)
        {
            this.shippingPricesService = shippingPricesService;
        }
        [HttpGet]
        public async Task<IEnumerable<ShippingPrice>> Get() => 
            await shippingPricesService.GetAllShippingPricesAsync();

    }
}
