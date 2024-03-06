using L27_InputValidation.Enums;
using System.ComponentModel.DataAnnotations;

namespace L27_InputValidation.Entities;

public class Employee
{
    public long Id { get; set; }

    [StringLength(200)]
    public required string FullName { get; set; }

    [StringLength(150)]
    public required string Email { get; set; }

    [StringLength(20)]
    public required string Phone { get; set; }

    public required Position Position { get; set; }

    public required decimal Salary { get; set; }

    public required int YearsExperience { get; set; }

    public required DateTime DateOfEmployment { get; set; }
}
