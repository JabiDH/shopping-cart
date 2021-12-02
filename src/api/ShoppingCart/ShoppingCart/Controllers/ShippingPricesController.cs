using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Models;
using ShoppingCart.Services;
using System.Transactions;

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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShippingPrice shippingPrice) 
        {
            using (var scope = new TransactionScope())
            {
                Task<ShippingPrice> createTask = this.shippingPricesService.CreateShippingPriceAsync(shippingPrice);
                await Task.WhenAll(createTask);
                
                scope.Complete();
                ShippingPrice newShippingPrice = createTask.Result;
                return CreatedAtAction(nameof(Get), new { id = newShippingPrice.Id }, newShippingPrice);
            }            
        }
    }
}
