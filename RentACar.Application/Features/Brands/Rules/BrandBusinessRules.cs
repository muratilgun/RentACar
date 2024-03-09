using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using RentACar.Application.Features.Brands.Constants;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;

namespace RentACar.Application.Features.Brands.Rules;
public class BrandBusinessRules : BaseBusinessRules
{
    private readonly IBrandRepository _brandRepository;
    public BrandBusinessRules(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task BrandNameCannotBeDuplicatedWhenInserted(string name, CancellationToken cancellationToken)
    {
        Brand? result = await _brandRepository.GetAsync(predicate: b => b.Name.ToLower() == name.ToLower(), cancellationToken: cancellationToken);

        if (result != null)
        {
            throw new BusinessException(BrandsMessages.BrandNameExists);
        }

    }

}
