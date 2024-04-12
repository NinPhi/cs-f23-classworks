using System.ComponentModel.DataAnnotations;

namespace L40_API_Integration.Dtos;

public class GitHubRepository
{
    public long Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public bool Private { get; set; }
}
