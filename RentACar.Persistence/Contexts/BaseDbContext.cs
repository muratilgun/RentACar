using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentACar.Domain.Entities;
using System.Reflection;

namespace RentACar.Persistence.Contexts;
public class BaseDbContext : DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Fuel> Fuels { get; set; }
    public DbSet<Transmission> Transmissions { get; set; }
    public DbSet<OperationClaim> OperationClaims{ get; set; }
    public DbSet<OtpAuthenticator> OtpAuthenticators{ get; set; }
    public DbSet<RefreshToken> RefreshTokens{ get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<EmailAuthenticator> EmailAuthenticators { get; set; }


    public BaseDbContext(DbContextOptions<BaseDbContext> options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
