using L5_Interfaces.Enums;
using L5_Interfaces.Shapes;

namespace L5_Interfaces.Helpers;

internal static class ShapeHelper
{
    public static IShape? CreateShape(ShapeType? type)
    {
        switch (type)
        {
            case ShapeType.Circle:
                return CreateCircle();
            case ShapeType.Square:
                return CreateSquare();
            case ShapeType.Triangle:
                return CreateTriangle();
            default:
                return null;
        }
    }

    private static IShape CreateCircle()
    {
        Console.Write("Enter circle radius: ");
        double radius = double.Parse(Console.ReadLine() ?? "0");
        return new Circle(radius);
    }

    private static IShape CreateSquare()
    {
        Console.Write("Enter square side: ");
        double side = double.Parse(Console.ReadLine() ?? "0");
        return new Square(side);
    }

    private static IShape CreateTriangle()
    {
        Console.Write("Enter triangle base: ");
        double @base = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter triangle height: ");
        double height = double.Parse(Console.ReadLine() ?? "0");

        return new Triangle(@base, height);
    }
}
