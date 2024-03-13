using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace RentACar.Application.Services.Repositories;
public interface IOperationClaimRepository : IAsyncRepository<OperationClaim, Guid>, IRepository<OperationClaim, Guid> { }
