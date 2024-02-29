using RentACar.Domain.Entities;
using RentACar.Persistence.Contexts;
using Core.Persistence.Repositories;
using RentACar.Application.Services.Repositories;

namespace RentACar.Persistence.Repositories;
public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>, IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context){}


    
}
