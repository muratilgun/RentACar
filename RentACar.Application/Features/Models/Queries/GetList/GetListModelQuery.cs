using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACar.Application.Services.Repositories;
using RentACar.Domain.Entities;

namespace RentACar.Application.Features.Models.Queries.GetList;
public class GetListModelQuery : IRequest<GetListResponse<GetListModelListDto>>
{
    public PageRequest PageRequest { get; set; } = default!;

    public class GetListModelQueryHandler : IRequestHandler<GetListModelQuery, GetListResponse<GetListModelListDto>>
    {
        private readonly IModelRepository _repository;
        private readonly IMapper _mapper;
        public GetListModelQueryHandler(IModelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        public async Task<GetListResponse<GetListModelListDto>> Handle(GetListModelQuery request, CancellationToken cancellationToken)
        {
            Paginate<Model> list = await _repository.GetListAsync(
                include: m => m.Include(navigationPropertyPath: b => b.Brand).Include(f => f.Fuel).Include(t => t.Transmission),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize);

            var response = _mapper.Map<GetListResponse<GetListModelListDto>>(list);
            return response;
        }
    }
}
