using MediatR;

namespace Application.Features.Riders.GetById;

public class GetRiderByIdQuery : IRequest
{
    public Guid Id { get; init; }
}
