using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Brands.Queries.GetList;
using RentACar.Application.Features.Models.Queries.GetList;
using RentACar.Application.Features.Models.Queries.GetListByDynamic;

namespace RentACar.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ModelsController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListModelQuery query = new GetListModelQuery { PageRequest = pageRequest };
        GetListResponse<GetListModelListDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetList/ByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery=null)
    {
        GetListByDynamicModelQuery query = new GetListByDynamicModelQuery { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicModelListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
