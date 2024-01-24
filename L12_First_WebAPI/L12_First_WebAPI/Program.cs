WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("book/en", HelloWorld);
app.MapGet("book/ru", () => "Привет книга!");
app.MapGet("api", () => "Application Programming Interface");

app.Run();

string HelloWorld()
{
    return "Hello world!";
}

_ =
    """
    ЗАДАНИЕ:

    Создать 2 конечных точки.
    Первая точка возвращает ваше короткое резюме.
    Вторая точка возвращает идею для второй точки.
    """;