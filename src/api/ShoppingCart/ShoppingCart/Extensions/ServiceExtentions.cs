using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.DbContexts;
using ShoppingCart.Services;

namespace ShoppingCart.Extentions
{
    public static class ServiceExtentions
    {
        public static void ConfigureCors(this IServiceCollection services, string policyName)
        {
            services.AddCors(options => {
                options.AddPolicy(policyName,
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });
        }

        public static void RegisterServicesIoc(this IServiceCollection services) 
        {
            services.AddTransient<IShippingPricesService, ShippingPricesService>();
            services.AddTransient<IProductsService, ProductsService>();
        }

        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShoppingCartDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("ShoppingCartDb")));            
        }
    }
}
