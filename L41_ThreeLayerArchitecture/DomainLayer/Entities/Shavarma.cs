using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Entities;

public class Shavarma
{
    public long Id { get; set; }

    [StringLength(100)]
    public required string Meat { get; set; }

    [StringLength(300)]
    public required string Veggies { get; set; }

    public required bool IsSpicy { get; set; }

    public required bool HasCheese { get; set; }
}
