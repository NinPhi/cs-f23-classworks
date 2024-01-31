using Microsoft.AspNetCore.Mvc;

namespace L14_Swagger.Controllers;

[ApiController]
[Route("students")]
public class StudentController : ControllerBase
{
    private static List<Student> _students = new()
    {
        new Student() { Id = 1, GroupName = "CS-F23", FullName = "Janarbek Sagaliev", },
        new Student() { Id = 2, GroupName = "CS-F23", FullName = "Nazar Mamedov", },
    };

    [HttpGet("name")]
    public List<Student> GeAll()
    {
        return _students;
    }
}

public class Student
{
    public long Id { get; set; }
    public required string GroupName { get; set; }
    public required string FullName { get; set; }
}