﻿using Mini_E_Commerce_Backend.Application.Abstractions;
using Mini_E_Commerce_Backend.Domain.Entities;

namespace Mini_E_Commerce_Backend.Persistence.Concretes;

public class ProductService : IProductService
{
    public List<Product> GetProducts() => new()
    {
        new ()
        {
            Id = Guid.NewGuid(),
            Name = "Product 1",
            Price = 100,
            Stock = 10,
            DateTime = DateTime.Now
        },

        new ()
        {
            Id = Guid.NewGuid(),
            Name = "Product 2",
            Price = 200,
            Stock = 20,
            DateTime = DateTime.Now
        },
        new ()
        {
            Id = Guid.NewGuid(),
            Name = "Product 3",
            Price = 300,
            Stock = 30,
            DateTime = DateTime.Now
        },
        new ()
        {
            Id = Guid.NewGuid(),
            Name = "Product 4",
            Price = 400,
            Stock = 40,
            DateTime = DateTime.Now
        },
        new ()
        {
            Id = Guid.NewGuid(),
            Name = "Product 5",
            Price = 500,
            Stock = 50,
            DateTime = DateTime.Now
        }
    };
}