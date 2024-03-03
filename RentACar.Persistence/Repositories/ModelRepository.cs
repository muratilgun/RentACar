using RentACar.Domain.Entities;
using RentACar.Persistence.Contexts;
using Core.Persistence.Repositories;
using RentACar.Application.Services.Repositories;

namespace RentACar.Persistence.Repositories;

public class ModelRepository : EfRepositoryBase<Model, Guid, BaseDbContext>, IModelRepository
{
    public ModelRepository(BaseDbContext context) : base(context) { }
}
