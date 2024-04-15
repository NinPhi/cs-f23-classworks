using BusinessLogicLayer.Services;
using DomainLayer.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers;

[ApiController]
[Route("api/shavarmas")]
public class ShavarmaController(IShavarmaService shavarmaService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateShavarmaRequest request)
    {
        await shavarmaService.CreateAsync(request);

        return Ok();
    }
}
