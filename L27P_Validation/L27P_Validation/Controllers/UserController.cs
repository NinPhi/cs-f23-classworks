using L27P_Validation.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace L27P_Validation.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(UserDto userDto)
    {
        return Ok("Супер!");
    }
}
