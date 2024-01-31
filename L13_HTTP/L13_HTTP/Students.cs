using L13_HTTP.Entities;

namespace L13_HTTP;

public class Students
{
    public static List<Student> Data { get; } = new()
    {
        new Student() { Id = 1, FirstName = "Иван", LastName = "Иванов", Language = Language.Csharp },
        new Student() { Id = 2, FirstName = "Мария", LastName = "Маратова", Language = Language.Java },
        new Student() { Id = 3, FirstName = "Вова", LastName = "Адидас", Language = Language.TypeScript },
        new Student() { Id = 3, FirstName = "Петр", LastName = "Паркер", Language = Language.Csharp },
    };
}
