using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Mini_E_Commerce_Backend.Domain.Entities;
using Mini_E_Commerce_Backend.Domain.Entities.Common;

namespace Mini_E_Commerce_Backend.Persistence.Contexts;

public class ECommerceAPIDbContext : DbContext
{
    public ECommerceAPIDbContext(DbContextOptions options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        var datas = ChangeTracker.Entries<BaseEntity>();

        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreateDate = DateTime.Now,
                EntityState.Modified => data.Entity.UpdateDate = DateTime.Now,
            };
        }
        return await base.SaveChangesAsync(cancellationToken);
    }
}
