using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace L35_Auth.Controllers;

[AllowAnonymous]
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private static string _email = "dima@gmail.com";
    private static string _password = "123456";

    [HttpPost("register")]
    public IActionResult Register(string email, string password)
    {
        _email = email;
        _password = password;

        return NoContent();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(string email, string password)
    {
        if (_email == email && _password == password)
        {
            await LoginWithHttpContext(email);

            return NoContent();
        }

        return Unauthorized();
    }

    private Task LoginWithHttpContext(string email)
    {
        var claims = new Claim[]
        {
            new Claim("guid", Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Email, email),
            new Claim(ClaimTypes.Role, "Alien"),
        };

        var identity = new ClaimsIdentity(claims, "Cookies");
        var principal = new ClaimsPrincipal(identity);

        return HttpContext.SignInAsync(principal);
    }
}
