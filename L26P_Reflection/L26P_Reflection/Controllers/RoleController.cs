using L26P_Reflection.Enums;
using L26P_Reflection.Extensions;
using L26P_Reflection.Services;
using Microsoft.AspNetCore.Mvc;

namespace L26P_Reflection.Controllers;

[ApiController]
[Route("api/roles")]
public class RoleController : ControllerBase
{
    private readonly RoleService _roleService;

    public RoleController(RoleService roleService)
    {
        _roleService = roleService;
    }

    [HttpGet("{role}")]
    public string Translate(Role role)
    {
        return $"{role} - {role.Translate()}";
    }
}
