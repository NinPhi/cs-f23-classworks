using L26_Reflection.Entities;
using L26_Reflection.Enums;
using L26_Reflection.Extensions;
using L26_Reflection.Lib;
using L26_Reflection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace L26_Reflection.Controllers;

[ApiController]
[Route("api/roles")]
public class RoleController : ControllerBase
{
    public RoleController(RoleService roleService, AuthService authService)
    {
        Console.WriteLine("RoleController Constructor Invoked!");
    }

    [HttpGet]
    public IActionResult Get(Role enumValue)
    {
        var student = new Student()
        {
            FullName = "eiruwoieurioewuroieuworiuewiriuoeiwuriuewiruoewiu",
        };

        student.Validate();

        return Ok(enumValue.Translate());
    }

    [HttpPost]
    public void Post(Student student)
    {

    }

    //[HttpGet]
    //public IActionResult Get(string typeName, string method)
    //{
    //    Type type = typeof(RoleController);

    //    Assembly assembly = type.Assembly;

    //    TypeInfo requestedType = assembly.DefinedTypes.First(t => t.Name == typeName);

    //    object? obj = Activator.CreateInstance(requestedType);

    //    MethodInfo? methodInfo = requestedType.GetMethod(method);

    //    methodInfo?.Invoke(obj, null);

    //    return Ok();
    //}





    // Создать класс-сущность Student
    // с одним свойством string FullName.
    // Навесить на FullName атрибут MaxLength.
    // Затем создать класс StudentExtensions.
    // В нем создать метод Validate(this Student student).
    // Этот метод должен находить все string свойства
    // класса Student с атрибутом MaxLength и если
    // длина этого свойства превышает значение MaxLength
    // кидать исключение.

    // Затем проверить работу этого метода в Program.
}
