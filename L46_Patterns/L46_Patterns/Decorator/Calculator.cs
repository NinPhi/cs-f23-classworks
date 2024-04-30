namespace L46_Patterns.Decorator;

public class Calculator : ICalculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
}
