using L5_Interfaces.Enums;
using L5_Interfaces.Helpers;
using L5_Interfaces.Shapes;

Console.WriteLine("Press 1 to get area of a circle.");
Console.WriteLine("Press 2 to get area of a square.");
Console.WriteLine("Press 3 to get area of a triangle.");

int.TryParse(Console.ReadLine(), out int digit);
if (!Enum.IsDefined((ShapeType)digit))
{
    Console.WriteLine("This is not an option!");
    return;
}

ShapeType type = (ShapeType)digit;
IShape? shape = ShapeHelper.CreateShape(type);
double area = shape?.GetArea() ?? 0;

Console.WriteLine($"Area of the {shape?.GetType().Name} {area:0.00}.");