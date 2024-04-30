using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Riders.Create;

public record CreateRiderCommand : IRequest
{
    [Required]
    [StringLength(14)]
    public string? Pin { get; init; }
}
