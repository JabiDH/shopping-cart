using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Services;

namespace ShoppingCart
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
            services.AddScoped<IShippingPricesService, ShippingPricesService>();
            services.AddScoped<IProductsService, ProductsService>();
        }
    }
}
