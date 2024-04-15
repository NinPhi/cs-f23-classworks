using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Contracts;

public class CreateFruitRequest
{
    [Required]
    [StringLength(100)]
    public string? Type { get; init; }
}