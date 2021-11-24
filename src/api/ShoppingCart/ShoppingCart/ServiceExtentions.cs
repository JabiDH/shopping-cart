using Microsoft.Extensions.DependencyInjection;

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
            services.AddScoped<ShoppingCart.Services.IShippingPricesService, ShoppingCart.Services.ShippingPricesService>();
        }
    }
}
