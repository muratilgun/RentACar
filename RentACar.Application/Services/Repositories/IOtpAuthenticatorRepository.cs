using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace RentACar.Application.Services.Repositories;

public interface IOtpAuthenticatorRepository : IAsyncRepository<OtpAuthenticator, Guid>, IRepository<OtpAuthenticator, Guid> { }
