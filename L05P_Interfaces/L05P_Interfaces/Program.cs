using L5P_Interfaces.Shapes;

Console.WriteLine("Press 1 for square, press 2 for circle.");

var key = Console.ReadKey(true).Key;
IShape? shape = null;

if (key == ConsoleKey.D1)
    shape = new Square(5);
else if (key == ConsoleKey.D2)
    shape = new Circle(5);

Console.WriteLine($"Area of {shape?.GetType().Name} is {shape?.CalculateArea():0.00}");