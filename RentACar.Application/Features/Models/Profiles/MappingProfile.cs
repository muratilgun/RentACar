using AutoMapper;
using RentACar.Domain.Entities;
using Core.Application.Responses;
using RentACar.Application.Features.Models.Queries.GetList;

namespace RentACar.Application.Features.Models.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //CreateMap<Model, CreateModelCommand>().ReverseMap();
        //CreateMap<Model, CreatedModelResponse>().ReverseMap();

        //CreateMap<Model, UpdateModelCommand>().ReverseMap();
        //CreateMap<Model, UpdatedModelResponse>().ReverseMap();
        
        //CreateMap<Model, DeleteModelCommand>().ReverseMap();
        //CreateMap<Model, DeletedModelResponse>().ReverseMap();
        
        CreateMap<Model, GetListModelListDto>().ReverseMap();
        CreateMap<Core.Persistence.Paging.Paginate<Model>, GetListResponse<GetListModelListDto>>().ReverseMap();

        //CreateMap<Model, GetByIdModelResponse>().ReverseMap();
    }
}
