namespace Domain.Modules.Scooters;

public class Scooter
{
    public Guid Id { get; set; }
    public required string Location { get; set; }
    public required CringePhrase CringePhrase { get; set; }
    public int Charge { get; set; } = 100;
}
