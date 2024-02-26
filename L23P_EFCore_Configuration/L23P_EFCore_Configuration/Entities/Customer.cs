using System.ComponentModel.DataAnnotations;

namespace L23P_EFCore_Configuration.Entities;

public class Customer
{
    public long Id { get; set; }

    [StringLength(200)]
    public string? FullName { get; set; }

    [StringLength(150)]
    public required string Email { get; set; }

    public required DateTime CreatedOn { get; set; }

    public List<Order> Orders { get; set; } = new();
}
