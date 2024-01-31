using L13_HTTP;
using L13_HTTP.Entities;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (int num) => $"Hello World {num}!");

app.MapGet("sum", (int num1, int num2) =>
    $"{num1} + {num2} = {num1 + num2}");

app.MapGet("students", (int? id) =>
{
    if (id.HasValue)
    {
        if (id < 0)
            return Results.BadRequest("Значение ID не может быть меньше 0.");

        return Results.Ok(Students.Data.FirstOrDefault(s => s.Id == id));
    }

    return Results.Ok(Students.Data);
})
    .Produces(200, typeof(List<Student>))
    .Produces(200, typeof(Student))
    .Produces(400, typeof(string));

app.MapGet("students/{name}", (string name) =>
    Students.Data.FirstOrDefault(s => s.FirstName == name));

app.Run();
