using L27_InputValidation.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace L27_InputValidation.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(EmployeeDto dto)
    {
        return Ok("Сотрудник создан успешон!");
    }

    // Создать UserDto с четырьмя свойствами:
    // - string? Email
    // - string? Phone
    // - Role? Role (отдельная энамка)
    // - int? Age

    // Провалидировать все свойства с помощью атрибутов.
}
