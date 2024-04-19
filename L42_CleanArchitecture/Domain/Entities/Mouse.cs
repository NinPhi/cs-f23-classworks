namespace Domain.Entities;

public class Mouse
{
    public long Id { get; set; }
    public required string Model { get; set; }
    public required string Brand { get; set; }
    public required decimal Price { get; set; }
}
