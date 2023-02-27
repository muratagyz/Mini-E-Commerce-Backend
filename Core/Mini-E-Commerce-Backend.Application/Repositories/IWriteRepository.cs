using Mini_E_Commerce_Backend.Domain.Entities.Common;

namespace Mini_E_Commerce_Backend.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> model);
    bool Remove(T model);
    bool RemoveRange(List<T> model);
    Task<bool> Remove(string id);
    bool Update(T model);
    Task<int> SaveAsync();
}