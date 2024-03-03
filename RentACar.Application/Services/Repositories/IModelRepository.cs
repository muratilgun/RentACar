using RentACar.Domain.Entities;
using Core.Persistence.Repositories;

namespace RentACar.Application.Services.Repositories;

public interface IModelRepository : IAsyncRepository<Model, Guid>, IRepository<Model, Guid>
{

}
