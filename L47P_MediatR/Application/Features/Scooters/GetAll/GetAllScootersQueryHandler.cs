using Domain.Modules.Scooters;
using Mapster;
using MediatR;

namespace Application.Features.Scooters.GetAll;

internal class GetAllScootersQueryHandler(IScooterRepository scooterRepository)
    : IRequestHandler<GetAllScootersQuery, List<ScooterDto>>
{
    public async Task<List<ScooterDto>> Handle(
        GetAllScootersQuery request, CancellationToken cancellationToken)
    {
        var scooters = await scooterRepository.GetAllAsync();

        return scooters.Adapt<List<ScooterDto>>();
    }
}
