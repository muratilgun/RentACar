using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Brands.Commands.Create;

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
}
