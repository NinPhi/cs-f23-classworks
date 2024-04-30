using Application.Features.Riders.Create;
using Application.Features.Riders.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace L47P_MediatR.Web.Controllers;

[ApiController]
[Route("api/riders")]
public class RiderController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateRiderCommand request)
    {
        await sender.Send(request);

        return Created("", null);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var request = new GetRiderByIdQuery() { Id = id };

        await sender.Send(request);

        return Ok();
    }
}
