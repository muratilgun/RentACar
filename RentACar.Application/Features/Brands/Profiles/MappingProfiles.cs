using AutoMapper;
using RentACar.Domain.Entities;
using RentACar.Application.Features.Brands.Commands.Create;
using Core.Persistence.Paging;
using Core.Application.Responses;
using RentACar.Application.Features.Brands.Queries.GetList;
using RentACar.Application.Features.Brands.Queries.GetById;

namespace RentACar.Application.Features.Brands.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
        CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();
        CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDto>>().ReverseMap();
        CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();
    }
}
