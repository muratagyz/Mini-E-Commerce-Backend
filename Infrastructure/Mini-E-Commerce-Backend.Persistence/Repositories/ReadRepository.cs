using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Mini_E_Commerce_Backend.Application.Repositories;
using Mini_E_Commerce_Backend.Domain.Entities.Common;
using Mini_E_Commerce_Backend.Persistence.Contexts;

namespace Mini_E_Commerce_Backend.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly ECommerceAPIDbContext _context;
    public ReadRepository(ECommerceAPIDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll() => Table;

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression) => Table.Where(expression);

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression) => await Table.FirstOrDefaultAsync(expression);

    public async Task<T> GetByIdAsync(string id) => await Table.FindAsync(Guid.Parse(id));
}