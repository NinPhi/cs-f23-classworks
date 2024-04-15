using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Contracts;

public class CreateShavarmaRequest
{
    [Required]
    [StringLength(100)]
    public string? Meat { get; set; }

    [Required]
    [StringLength(300)]
    public string? Veggies { get; set; }

    public bool IsSpicy { get; set; }

    public bool HasCheese { get; set; }
}