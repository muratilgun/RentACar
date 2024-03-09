using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;

namespace RentACar.Application.Features.Models.Queries.GetListByDynamic;
public class GetListByDynamicModelQuery : IRequest<GetListResponse<GetListByDynamicModelListItemDto>>
{
    public PageRequest PageRequest { get; set; } = default!;
    public DynamicQuery? DynamicQuery { get; set; }

    public class GetListByDynamicModelQueryHandler : IRequestHandler<GetListByDynamicModelQuery, GetListResponse<GetListByDynamicModelListItemDto>>
    {
        private readonly IModelRepository _repository;
        private readonly IMapper _mapper;
        public GetListByDynamicModelQueryHandler(IModelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicModelListItemDto>> Handle(GetListByDynamicModelQuery request, CancellationToken cancellationToken)
        {
            Paginate<Model> list = await _repository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: m => m.Include(navigationPropertyPath: b => b.Brand).Include(f => f.Fuel).Include(t => t.Transmission),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize);

            var response = _mapper.Map<GetListResponse<GetListByDynamicModelListItemDto>>(list);
            return response;
        }
    }
}
