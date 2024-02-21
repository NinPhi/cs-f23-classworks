namespace L22_Migrations.Entities;

public class Movie
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public required int MinimumAge { get; set; }
}
