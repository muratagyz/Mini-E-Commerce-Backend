using Microsoft.EntityFrameworkCore;
using Mini_E_Commerce_Backend.Domain.Entities;

namespace Mini_E_Commerce_Backend.Persistence.Contexts;

public class ECommerceAPIDbContext : DbContext
{
    public ECommerceAPIDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }


}