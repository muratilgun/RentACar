using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Brands.Commands.Create;
using RentACar.Application.Features.Brands.Commands.Delete;
using RentACar.Application.Features.Brands.Commands.Update;
using RentACar.Application.Features.Brands.Queries.GetById;
using RentACar.Application.Features.Brands.Queries.GetList;

namespace RentACar.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BrandsController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<CreatedBrandResponse>> Create([FromBody] CreateBrandCommand command)
    {
        CreatedBrandResponse response = await Mediator!.Send(command);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBrandQuery query = new GetListBrandQuery { PageRequest = pageRequest };
        GetListResponse<GetListBrandListItemDto> response = await Mediator!.Send(query);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdBrandQuery query = new GetByIdBrandQuery { Id = id };
        GetByIdBrandResponse response = await Mediator!.Send(query);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromQuery] UpdateBrandCommand updateBrandCommand)
    {
        UpdatedBrandResponse response = await Mediator!.Send(updateBrandCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromQuery] DeleteBrandCommand deleteBrandCommand)
    {
        DeletedBrandResponse response = await Mediator!.Send(deleteBrandCommand);
        return Ok(response);
    }
}
