using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace L34P_AuthBasics.Controllers;

[AllowAnonymous]
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpGet("login")]
    public async Task<IActionResult> Login(string email, string password)
    {
        if (email != "dima@gmail.com" ||  password != "123456")
            return Unauthorized();

        var claims = new Claim[]
        {
            new Claim("guid", Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Email, email),
        };

        var identity = new ClaimsIdentity(claims, "Cookies");
        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(principal);

        return Ok();
    }
}
