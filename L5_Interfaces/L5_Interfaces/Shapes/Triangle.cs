namespace L5_Interfaces.Shapes;

internal class Triangle : IShape
{
    private readonly double _height;
    private readonly double _base;

    public Triangle(double height, double @base)
    {
        _height = height;
        _base = @base;
    }

    public double GetArea()
    {
        return _height * _base / 2;
    }
}
