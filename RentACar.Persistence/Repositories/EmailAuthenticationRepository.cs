using Core.Persistence.Repositories;
using Core.Security.Entities;
using RentACar.Application.Services.Repositories;
using RentACar.Persistence.Contexts;

namespace RentACar.Persistence.Repositories;

public class EmailAuthenticationRepository : EfRepositoryBase<EmailAuthenticator, Guid, BaseDbContext>, IEmailAuthenticatorRepository
{
    public EmailAuthenticationRepository(BaseDbContext context) : base(context)
    {
    }
}