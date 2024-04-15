using BusinessLogicLayer.Services;
using BusinessLogicLayer.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers;

[ApiController]
[Route("api/fruits")]
public class FruitController(FruitService fruitService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateFruitRequest request)
    {
        await fruitService.CreateAsync(request);

        return Ok();
    }
}
