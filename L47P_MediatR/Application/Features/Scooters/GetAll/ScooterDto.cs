using Domain.Modules.Scooters;

namespace Application.Features.Scooters.GetAll;

public record ScooterDto
{
    public Guid Id { get; init; }
    public required string Location { get; init; }
    public required CringePhrase CringePhrase { get; init; }
    public int Charge { get; init; }
}
