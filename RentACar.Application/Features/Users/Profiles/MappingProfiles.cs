using AutoMapper;
using Core.Security.Entities;
using RentACar.Application.Features.Users.Commands.Create;

namespace RentACar.Application.Features.Users.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, CreateUserCommand>().ReverseMap();
        CreateMap<User, CreatedUserResponse>().ReverseMap();
    }
}