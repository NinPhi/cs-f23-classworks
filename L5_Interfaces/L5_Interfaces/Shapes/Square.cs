namespace L5_Interfaces.Shapes;

internal class Square : IShape
{
    private readonly double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double GetArea()
    {
        return _side * _side;
    }
}
