using MediatR;

namespace Application.Features.Scooters.GetAll;

public class GetAllScootersQuery : IRequest<List<ScooterDto>>;
