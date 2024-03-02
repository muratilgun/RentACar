using AutoMapper;
using RentACar.Domain.Entities;
using RentACar.Application.Features.Brands.Commands.Create;
using Core.Persistence.Paging;
using Core.Application.Responses;
using RentACar.Application.Features.Brands.Queries.GetList;
using RentACar.Application.Features.Brands.Queries.GetById;
using RentACar.Application.Features.Brands.Commands.Update;
using RentACar.Application.Features.Brands.Commands.Delete;

namespace RentACar.Application.Features.Brands.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();

        CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
        CreateMap<Brand, UpdatedBrandResponse>().ReverseMap();
        
        CreateMap<Brand, DeleteBrandCommand>().ReverseMap();
        CreateMap<Brand, DeletedBrandResponse>().ReverseMap();
        
        CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();
        CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDto>>().ReverseMap();

        CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();

    }
}
