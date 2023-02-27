using Mini_E_Commerce_Backend.Domain.Entities.Common;
using System.Linq.Expressions;

namespace Mini_E_Commerce_Backend.Application.Repositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T,bool>> expression);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);
    Task<T> GetByIdAsync(string id);
}