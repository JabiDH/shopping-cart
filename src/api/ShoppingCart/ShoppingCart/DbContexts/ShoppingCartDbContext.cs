using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.DbContexts
{
    public class ShoppingCartDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ShippingPrice> ShippingPrices { get; set; }
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) : base(options)
        {
        }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Phone XL",
                    Price = 799,
                    Description = "A large phone with one of the best screens"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Phone Mini",
                    Price = 699,
                    Description = "A great phone with one of the best cameras"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Phone Standard",
                    Price = 299,
                    Description = "A standard phone that can make and receive calls"
                }
            );

            modelBuilder.Entity<ShippingPrice>().HasData(
                new ShippingPrice() { Id = 1, Type = "Overnight", Price = 25.99M },
                new ShippingPrice() { Id = 2, Type = "2-Day", Price = 9.99M },
                new ShippingPrice() { Id = 3, Type = "Postal", Price = 2.99M }
            );
        }
    }
}
