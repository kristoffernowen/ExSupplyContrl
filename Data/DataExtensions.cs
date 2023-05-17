using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data;

public static class DataExtensions
{
    public static IServiceCollection ConfigureDataContext(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(o => o.UseSqlServer(configuration.GetConnectionString("Sql")));
        services.AddScoped<IOrderRepository, OrderRepository>();

        return services;
    }
}