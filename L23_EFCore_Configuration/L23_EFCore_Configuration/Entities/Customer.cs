using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L23_EFCore_Configuration.Entities;

public class Customer
{
    public long Id { get; set; }

    [StringLength(200)]
    public string? FullName { get; set; }

    [StringLength(150)]
    public required string Email { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.Now;
}
