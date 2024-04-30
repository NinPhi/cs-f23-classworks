using L46_Patterns.Builder;
using L46_Patterns.Decorator;
using L46_Patterns.Factory;
using L46_Patterns.FactoryMethod;

#region ===========
Console.WriteLine();
Console.WriteLine(new string('=', 40));
#endregion

// Builder паттерн
var builder = new SandwichBuilder();

var sandwich = builder
    .AddSalad()
    .AddSalad()
    .AddTomato()
    .AddTomato()
    .Build();

sandwich.Eat();

#region ===========
Console.WriteLine();
Console.WriteLine(new string('=', 40));
#endregion

// Factory Method паттерн
ISecret secret = ISecret.CreateFbi();

Console.WriteLine(secret.SecretInfo);

#region ===========
Console.WriteLine();
Console.WriteLine(new string('=', 40));
#endregion

// Factory паттерн
ICoderFactory factory;

Console.WriteLine("Какие курсы Азим выберет?");
var input = Console.ReadLine();

if (input == "Attractor")
{
    factory = new Attractor();
}
else
{
    factory = new ItAcademy();
}

var coder = factory.Create("Azim");
Console.WriteLine(coder.Name + " " + coder.Quality);

#region ===========
Console.WriteLine();
Console.WriteLine(new string('=', 40));
#endregion

// Decorator паттерн
ICalculator calculator1 = new Calculator();
ICalculator calculator2 = new LoggingCalculator(calculator1);

Console.WriteLine(calculator2.Add(2, 2));
