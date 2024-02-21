namespace L21_EFCore.Entities;

public class Auto
{
    public long Id { get; set; }
    public required string Model { get; set; }
    public required string Brand { get; set; }
    public required double EngineVolume { get; set; }
    public required decimal Price { get; set; }
}
