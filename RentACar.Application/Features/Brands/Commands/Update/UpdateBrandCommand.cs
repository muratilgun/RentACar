using AutoMapper;
using MediatR;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;

namespace RentACar.Application.Features.Brands.Commands.Update;
public class UpdateBrandCommand : IRequest<UpdatedBrandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;

    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, UpdatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public UpdateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedBrandResponse> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate:b=> b.Id == request.Id, cancellationToken: cancellationToken);
            
            brand = _mapper.Map(request, brand);
            
            await _brandRepository.UpdateAsync(brand);

            UpdatedBrandResponse response = _mapper.Map<UpdatedBrandResponse>(brand);

            return response;
        }
    }   
}
