﻿using MediatR;
using AutoMapper;
using Core.Application.Pipelines.Transaction;
using RentACar.Application.Features.Brands.Rules;
using RentACar.Domain.Entities;
using RentACar.Application.Services.Repositories;
using Core.Application.Pipelines.Caching;
using Core.Application.Pipelines.Logging;

namespace RentACar.Application.Features.Brands.Commands.Create;

public class CreateBrandCommand : IRequest<CreatedBrandResponse>, ITransactionalRequest,ICacheRemoverRequest,ILoggableRequest
{
    public string Name { get; set; } = default!;

    public string CacheKey => string.Empty;

    public bool BypassCache { get; }

    public string? CacheGroupKey => "GetBrands";

    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly BrandBusinessRules _brandBusinessRules;


        public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _brandBusinessRules = brandBusinessRules;
        }

        public async Task<CreatedBrandResponse> Handle(
            CreateBrandCommand request,
            CancellationToken cancellationToken)
        {
            await _brandBusinessRules.BrandNameCannotBeDuplicatedWhenInserted(request.Name, cancellationToken);

            Brand brand = _mapper.Map<Brand>(request);
            brand.Id = Guid.NewGuid();

            await _brandRepository.AddAsync(brand);

            CreatedBrandResponse response = _mapper.Map<CreatedBrandResponse>(brand);

            return response;
        }
    }
}
