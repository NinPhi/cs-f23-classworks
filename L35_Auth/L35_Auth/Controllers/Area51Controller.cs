using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace L35_Auth.Controllers;

[ApiController]
[Route("api/area51")]
public class Area51Controller : ControllerBase
{
    [HttpGet("a")]
    public IActionResult GetA()
    {
        var user = HttpContext.User;

        return Ok(user.FindFirstValue(JwtRegisteredClaimNames.Email));
    }

    [Authorize(Roles = "Officer, Guard")]
    [HttpGet("b")]
    public IActionResult GetB()
    {
        var user = HttpContext.User;

        return Ok(user.FindFirstValue(ClaimTypes.Email));
    }
}
