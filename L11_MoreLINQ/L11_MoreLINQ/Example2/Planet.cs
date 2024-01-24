namespace L11_MoreLINQ.Example2;

public class Planet
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Star { get; set; }
    public double Radius { get; set; }
    public PlanetType Type { get; set; }

    public Planet(
        long id,
        string name,
        string star,
        double radius,
        PlanetType type)
    {
        Id = id;
        Name = name;
        Star = star;
        Radius = radius;
        Type = type;
    }

    public override string ToString()
    {
        return $"#{Id} {Name} ({Star}), радиус: {Radius}, тип: {Type}";
    }
}
