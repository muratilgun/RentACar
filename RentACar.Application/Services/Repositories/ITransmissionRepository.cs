using RentACar.Domain.Entities;
using Core.Persistence.Repositories;

namespace RentACar.Application.Services.Repositories;

public interface ITransmissionRepository : IAsyncRepository<Transmission, Guid>, IRepository<Transmission, Guid>
{

}