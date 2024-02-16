namespace L5_Interfaces.Shapes;

internal class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
