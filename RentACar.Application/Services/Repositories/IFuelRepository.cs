using RentACar.Domain.Entities;
using Core.Persistence.Repositories;

namespace RentACar.Application.Services.Repositories;

public interface IFuelRepository : IAsyncRepository<Fuel, Guid>, IRepository<Fuel, Guid>
{

}
