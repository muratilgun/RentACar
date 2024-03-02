using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Brands.Commands.Create;
using RentACar.Application.Features.Brands.Queries.GetList;

namespace RentACar.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BrandsController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<CreatedBrandResponse>> Create([FromBody] CreateBrandCommand command)
    {
        CreatedBrandResponse response = await Mediator.Send(command);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBrandQuery query = new GetListBrandQuery { PageRequest = pageRequest };
        GetListResponse<GetListBrandListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}
