using AutoMapper;
using MediatR;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;

namespace RentACar.Application.Features.Brands.Commands.Create;

public class CreateBrandCommand : IRequest<CreatedBrandResponse>
{
    public string Name { get; set; } = default!;

    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;


        public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<CreatedBrandResponse> Handle(
            CreateBrandCommand request, 
            CancellationToken cancellationToken)
        {
            Brand brand = _mapper.Map<Brand>(request);
            brand.Id = Guid.NewGuid();
            brand.CreatedAt = DateTime.UtcNow;

            await _brandRepository.AddAsync(brand);

            CreatedBrandResponse response = _mapper.Map<CreatedBrandResponse>(brand);


            return response;
        }
    }
}
