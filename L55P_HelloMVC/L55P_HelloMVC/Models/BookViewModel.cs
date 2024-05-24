using System.ComponentModel.DataAnnotations;

namespace L55P_HelloMVC.Models;

public class BookViewModel
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Author { get; set; }

    public decimal Price { get; set; }

    public int AvailableCount { get; set; }
}
