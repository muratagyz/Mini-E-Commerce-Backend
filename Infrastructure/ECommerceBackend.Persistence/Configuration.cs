using Microsoft.Extensions.Configuration;

namespace ECommerceBackend.Persistence;

static class Configuration
{
    public static string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceBackend.API"));
            configurationManager.AddJsonFile("appsetting.json");

            return configurationManager.GetConnectionString("PostgreSQL");
        }
    }
}