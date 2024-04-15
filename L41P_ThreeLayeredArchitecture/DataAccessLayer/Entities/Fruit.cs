using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities;

public class Fruit
{
    public long Id { get; set; }

    [StringLength(100)]
    public required string Type { get; set; }
}
