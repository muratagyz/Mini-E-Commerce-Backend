using Microsoft.Extensions.DependencyInjection;
using Mini_E_Commerce_Backend.Application.Abstractions;
using Mini_E_Commerce_Backend.Persistence.Concretes;

namespace Mini_E_Commerce_Backend.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
    }
}