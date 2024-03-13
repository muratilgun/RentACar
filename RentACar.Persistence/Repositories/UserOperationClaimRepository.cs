using Core.Persistence.Repositories;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using RentACar.Application.Services.Repositories;
using RentACar.Persistence.Contexts;

namespace RentACar.Persistence.Repositories;

public class UserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, Guid, BaseDbContext>, IUserOperationClaimRepository
{
    public UserOperationClaimRepository(BaseDbContext context) : base(context)
{
    }

    public async Task<IList<OperationClaim>> GetOperationClaimsByUserIdAsync(Guid userId)
    {
        var operationClaims = await Query()
            .AsNoTracking()
            .Where(x => x.UserId == userId)
            .Select(x => new OperationClaim {Id = x.OperationClaimId, Name = x.OperationClaim.Name })
            .ToListAsync();

        return operationClaims;
    }
}
