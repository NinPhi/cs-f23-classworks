//using L24_EFCore_Navigation.Auth;
//using L24_EFCore_Navigation.Auth.Contracts;
//using L24_EFCore_Navigation.Auth.Exceptions;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System.Security.Claims;

//namespace L24_EFCore_Navigation.Controllers;

//[AllowAnonymous]
//[ApiController]
//[Route("api/auth")]
//public partial class AuthController : ControllerBase
//{
//    private readonly AuthService _authService;

//    public AuthController(AuthService authService)
//    {
//        _authService = authService;
//    }

//    [HttpPost("register")]
//    public async Task<IActionResult> Register(AuthData data)
//    {
//        try
//        {
//            await _authService.RegisterAsync(data);

//            return NoContent();
//        }
//        catch (UsernameTakenException ex)
//        {
//            return Conflict(ex.Message);
//        }
//        catch (Exception ex)
//        {
//            return BadRequest(ex.Message);
//        }
//    }

//    [HttpPost("login")]
//    public async Task<IActionResult> Login(AuthData data)
//    {
//        try
//        {
//            var user = await _authService.ValidateAsync(data);

//            var claims = new Claim[]
//            {
//                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
//                new Claim(ClaimTypes.Name, user.Username),
//            };

//            var identity = new ClaimsIdentity(claims,
//                CookieAuthenticationDefaults.AuthenticationScheme);
//            var principal = new ClaimsPrincipal(identity);

//            await HttpContext.SignInAsync(principal);

//            return NoContent();
//        }
//        catch (WrongCredentialsException ex)
//        {
//            return Unauthorized(ex.Message);
//        }
//        catch (Exception ex)
//        {
//            return BadRequest(ex.Message);
//        }
//    }

//    [HttpGet("logout")]
//    public async Task<IActionResult> Logout()
//    {
//        await HttpContext.SignOutAsync();

//        return NoContent();
//    }
//}
