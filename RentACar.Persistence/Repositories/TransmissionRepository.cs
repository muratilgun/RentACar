using RentACar.Domain.Entities;
using RentACar.Persistence.Contexts;
using Core.Persistence.Repositories;
using RentACar.Application.Services.Repositories;

namespace RentACar.Persistence.Repositories;

public class TransmissionRepository : EfRepositoryBase<Transmission, Guid, BaseDbContext>, ITransmissionRepository
{
    public TransmissionRepository(BaseDbContext context) : base(context) { }
}