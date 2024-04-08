using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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
            var token = GetToken(email);

            return Ok(token);
        }

        return Unauthorized();
    }

    private static string GetToken(string email)
    {
        var claims = new Claim[]
        {
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Email, email),
            new Claim("role", "Alien"),
            new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString()),
        };

        var identity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);

        var handler = new JwtSecurityTokenHandler();

        var securityKey = Encoding.UTF8.GetBytes("SUPER SECURE CODe 1337 AZIM JKDLFVJFDILHVNLDFJVN;FDJV;LSJFV;LDJVFDLJV;LFDJB;LVJFL;B JLFJBL;");

        var credentials = new SigningCredentials(
                    new SymmetricSecurityKey(securityKey),
                    SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            SigningCredentials = credentials,
            Expires = DateTime.UtcNow.AddMinutes(30),
            Subject = identity,
        };

        var token = handler.CreateToken(tokenDescriptor);

        var tokenString = handler.WriteToken(token);

        return tokenString;
    }
}
