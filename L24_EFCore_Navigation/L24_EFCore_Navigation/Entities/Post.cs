using System.ComponentModel.DataAnnotations;

namespace L24_EFCore_Navigation.Entities;

public class Post
{
    public long Id { get; set; }

    public long AuthorId { get; set; }

    [StringLength(2000)]
    public required string Content { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.Now;

    public User? Author { get; set; }

    public List<Tag> Tags { get; set; } = new();
}
