using System.ComponentModel.DataAnnotations;

namespace L23_EFCore_Configuration.Entities;

public class Item
{
    [StringLength(100)]
    public required string Name { get; set; }

    public required decimal Price { get; set; }
}
