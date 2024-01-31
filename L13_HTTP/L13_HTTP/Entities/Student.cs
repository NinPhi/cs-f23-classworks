namespace L13_HTTP.Entities;

public class Student
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Language Language { get; set; }
}

public enum Language
{
    Csharp = 1,
    TypeScript = 2,
    Java = 35
}