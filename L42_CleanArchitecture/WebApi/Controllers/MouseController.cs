using Application.Contracts;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/mice")]
public class MouseController(MouseService mouseService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Add(AddMouseRequest request)
    {
        await mouseService.AddAsync(request);

        return Ok();
    }
}
