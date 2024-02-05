using L17_DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace L17_DependencyInjection.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult> GetUsers(
        [FromServices] IUserService userService)
    {
        var users = await _userService.GetUsersAsync();

        return Ok(users);
    }
}
