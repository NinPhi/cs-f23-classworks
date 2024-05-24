using System.ComponentModel.DataAnnotations;

namespace L55_FirstMVC.Models;

public class TodoModel
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    public bool Complete { get; set; }
}
