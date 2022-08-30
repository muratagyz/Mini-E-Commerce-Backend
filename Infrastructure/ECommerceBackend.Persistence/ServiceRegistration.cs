using ECommerceBackend.Application.Abstractions;
using ECommerceBackend.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceBackend.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
    }
}