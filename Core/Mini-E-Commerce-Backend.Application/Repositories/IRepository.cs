using Microsoft.EntityFrameworkCore;
using Mini_E_Commerce_Backend.Domain.Entities.Common;

namespace Mini_E_Commerce_Backend.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}