﻿using Mini_E_Commerce_Backend.Domain.Entities.Common;

namespace Mini_E_Commerce_Backend.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public float Price { get; set; }
    public ICollection<Order> Orders { get; set; }
}