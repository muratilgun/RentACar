using AutoMapper;
using Core.Persistence.Paging;
using RentACar.Domain.Entities;
using Core.Application.Responses;
using RentACar.Application.Features.Models.Queries.GetList;
using RentACar.Application.Features.Models.Queries.GetListByDynamic;

namespace RentACar.Application.Features.Models.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //GetList
        CreateMap<Model, GetListModelListDto>().ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListModelListDto>>().ReverseMap();
        
        //Dynamic Query
        CreateMap<Model, GetListByDynamicModelListItemDto>().ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListByDynamicModelListItemDto>>().ReverseMap();

    }
}
