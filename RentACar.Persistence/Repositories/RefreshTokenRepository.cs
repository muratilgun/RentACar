using Core.Persistence.Repositories;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using RentACar.Application.Services.Repositories;
using RentACar.Persistence.Contexts;

namespace RentACar.Persistence.Repositories;

public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, Guid, BaseDbContext>, IRefreshTokenRepository
{
    public RefreshTokenRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<List<RefreshToken>> GetOldRefreshTokensAsync(Guid userId, int refreshTokenTTL)
    {
        List<RefreshToken> oldRefreshTokens = await Query().AsNoTracking()
            .Where(rt => rt.UserId == userId && rt.Revoked == null && rt.Expires >= DateTime.UtcNow 
            && rt.CreatedAt.AddDays(refreshTokenTTL) <= DateTime.UtcNow).ToListAsync();

        return oldRefreshTokens;
    }
}
