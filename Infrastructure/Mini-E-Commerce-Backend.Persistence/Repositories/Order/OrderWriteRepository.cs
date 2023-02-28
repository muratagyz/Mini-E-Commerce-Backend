using Mini_E_Commerce_Backend.Application.Repositories;
using Mini_E_Commerce_Backend.Domain.Entities;
using Mini_E_Commerce_Backend.Persistence.Contexts;

namespace Mini_E_Commerce_Backend.Persistence.Repositories;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}