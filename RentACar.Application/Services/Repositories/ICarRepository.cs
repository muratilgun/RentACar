using RentACar.Domain.Entities;
using Core.Persistence.Repositories;

namespace RentACar.Application.Services.Repositories;

public interface ICarRepository : IAsyncRepository<Car, Guid>, IRepository<Car, Guid>
{

}
