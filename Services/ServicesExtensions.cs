using Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Services
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServicesInServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}
