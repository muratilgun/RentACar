using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using RentACar.Application.Features.Models.Queries.GetList;
using RentACar.Application.Features.Models.Queries.GetListByDynamic;
using RentACar.Domain.Entities;

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
