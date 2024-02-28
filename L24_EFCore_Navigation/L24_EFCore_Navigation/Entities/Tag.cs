using System.ComponentModel.DataAnnotations.Schema;

namespace L24_EFCore_Navigation.Entities;

public class Tag
{
    public long Id { get; set; }

    public required string Title { get; set; }

    public List<Post> Posts { get; set; } = new();
}
