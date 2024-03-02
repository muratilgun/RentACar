﻿

namespace RentACar.Application.Features.Brands.Commands.Delete;
public class DeletedBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}
