namespace L46_Patterns.Decorator;

public class LoggingCalculator(ICalculator calculator) : ICalculator
{
    public double Add(double a, double b)
    {
        Console.WriteLine($"Добавляем {a} + {b}");

        return calculator.Add(a, b);
    }
}
