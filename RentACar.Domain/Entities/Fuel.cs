﻿using Core.Persistence.Repositories;

namespace RentACar.Domain.Entities;

public class Fuel : Entity<Guid>
{
    public string Name { get; set; } = default!;
    public virtual ICollection<Model> Models { get; set; }
    public Fuel() => Models = new HashSet<Model>();
    public Fuel(Guid id, string name):this()
    {
        Id = id;
        Name = name;
    }
}
