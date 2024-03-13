using Core.Persistence.Repositories;
using Core.Security.Entities;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;
using RentACar.Persistence.Contexts;

namespace RentACar.Persistence.Repositories;
public class UserRepository : EfRepositoryBase<User, Guid, BaseDbContext>, IUserRepository
{
    public UserRepository(BaseDbContext context) : base(context)
    {
    }
}
