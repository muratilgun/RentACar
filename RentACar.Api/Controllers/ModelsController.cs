using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Brands.Queries.GetList;
using RentACar.Application.Features.Models.Queries.GetList;

namespace RentACar.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ModelsController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListModelQuery query = new GetListModelQuery { PageRequest = pageRequest };
        GetListResponse<GetListModelListDto> response = await Mediator!.Send(query);
        return Ok(response);
    }

}
