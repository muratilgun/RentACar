using RentACar.Domain.Entities;
using RentACar.Persistence.Contexts;
using Core.Persistence.Repositories;
using RentACar.Application.Services.Repositories;

namespace RentACar.Persistence.Repositories;

public class CarRepository : EfRepositoryBase<Car, Guid, BaseDbContext>, ICarRepository
{
    public CarRepository(BaseDbContext context) : base(context) { }
}
