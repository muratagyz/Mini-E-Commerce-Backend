using ECommerceBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackend.Persistence.Contexts;

public class ECommerceBackendDbContext : DbContext
{
    public ECommerceBackendDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
}