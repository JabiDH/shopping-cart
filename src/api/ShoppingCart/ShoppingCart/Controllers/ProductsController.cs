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
    public class ProductsController : ControllerBase
    {
        private IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> Get() => 
            await productsService.GetAllProductsAsync();

        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id) =>
            await productsService.GetProductByIdAsync(id);

    }
}
