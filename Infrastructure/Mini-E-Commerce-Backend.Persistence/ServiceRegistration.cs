using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mini_E_Commerce_Backend.Application.Repositories;
using Mini_E_Commerce_Backend.Persistence.Contexts;
using Mini_E_Commerce_Backend.Persistence.Repositories;

namespace Mini_E_Commerce_Backend.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ECommerceAPIDbContext>(options =>
        {
            options.UseNpgsql(Configuration.ConnectionString);
        });

        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
    }
}