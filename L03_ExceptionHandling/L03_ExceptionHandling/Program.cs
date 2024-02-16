
using L3_ExceptionHandling.Exceptions;

while (true)
{
    try
    {
        Start();
    }
    catch (DivideByZeroException)
    {
        Console.Clear();
        Console.WriteLine("Невозможно поделить число на ноль.");
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Что-то пошло не так:");
        Console.WriteLine(ex.Message);
    }
}


void Start()
{
    Console.WriteLine("====================");
    Console.WriteLine("Enter a number: ");

    int input = int.Parse(Console.ReadLine() ?? string.Empty);

    Console.WriteLine($"You entered {input}!");

    if (input == 3)
        throw new CannotDivideByThreeException();

    int result = 100 / input;

    Console.WriteLine($"100 divided by {input} = {result}");
}