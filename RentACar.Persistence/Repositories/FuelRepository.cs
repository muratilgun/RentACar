using Core.Persistence.Repositories;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;
using RentACar.Persistence.Contexts;

namespace RentACar.Persistence.Repositories;

public class FuelRepository : EfRepositoryBase<Fuel, Guid, BaseDbContext>, IFuelRepository
{
    public FuelRepository(BaseDbContext context) : base(context) { }
}
