using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace L34P_AuthBasics.Controllers;

[Authorize]
[ApiController]
[Route("api/gold")]
public class GoldController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("ЗОЛОТО! GOLD!");
    }
}
