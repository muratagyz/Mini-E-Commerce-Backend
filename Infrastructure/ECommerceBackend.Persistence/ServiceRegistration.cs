using ECommerceBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceBackend.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ECommerceBackendDbContext>(options=> options.UseNpgsql(Configuration.ConnectionString));
    }
}