using MediatR;

namespace Application.Features.Riders.Create;

public class CreateRiderCommandHandler
    : IRequestHandler<CreateRiderCommand>
{
    public async Task Handle(
        CreateRiderCommand request, CancellationToken cancellationToken)
    {
        await Console.Out.WriteLineAsync("Azim " + request.Pin);
    }
}
