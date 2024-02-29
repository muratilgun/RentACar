﻿using AutoMapper;
using RentACar.Domain.Entities;
using RentACar.Application.Features.Brands.Commands.Create;

namespace RentACar.Application.Features.Brands.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
    }
}
