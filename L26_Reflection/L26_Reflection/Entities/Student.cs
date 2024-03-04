using System.ComponentModel.DataAnnotations;

namespace L26_Reflection.Entities;

public class Student
{
    [MaxLength(15)]
    public string FullName { get; set; }
}
