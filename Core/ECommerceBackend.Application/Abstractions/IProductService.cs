using ECommerceBackend.Domain.Entities;

namespace ECommerceBackend.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();
}