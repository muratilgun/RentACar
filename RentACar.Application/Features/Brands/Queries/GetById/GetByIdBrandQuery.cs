using AutoMapper;
using MediatR;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;

namespace RentACar.Application.Features.Brands.Queries.GetById;
public class GetByIdBrandQuery : IRequest<GetByIdBrandResponse>
{
    public Guid Id { get; set; }


    public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetByIdBrandResponse>
    {

        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;

        public GetByIdBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdBrandResponse> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, withDeleted: true, cancellationToken: cancellationToken);
            GetByIdBrandResponse response = _mapper.Map<GetByIdBrandResponse>(brand);
            return response;
        }
    }


}
