using Mini_E_Commerce_Backend.Domain.Entities;

namespace Mini_E_Commerce_Backend.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();

}