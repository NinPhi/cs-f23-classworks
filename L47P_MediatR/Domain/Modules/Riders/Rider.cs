using Domain.Modules.Scooters;

namespace Domain.Modules.Riders;

public class Rider
{
    public Guid Id { get; set; }
    public required string Pin { get; set; }

    public Scooter? RentedScooter { get; set; }
}
