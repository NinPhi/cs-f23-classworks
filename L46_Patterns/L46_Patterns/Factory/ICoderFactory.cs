namespace L46_Patterns.Factory;

public interface ICoderFactory
{
    public Coder Create(string name);
}

public class Coder
{
    public required string Name { get; set; }
    public required int Quality { get; set; }
}

public class ItAcademy : ICoderFactory
{
    public Coder Create(string name)
    {
        return new Coder { Name = name, Quality = 10 };
    }
}

public class Attractor : ICoderFactory
{
    public Coder Create(string name)
    {
        return new Coder { Name = name, Quality = 3 };
    }
}