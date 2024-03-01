using System.ComponentModel.DataAnnotations;

namespace L25_EFCore_RelatedDataLoading.Entities;

public class Post
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    [StringLength(500)]
    public required string Title { get; set; }

    [StringLength(4000)]
    public required string Content { get; set; }

    public List<Comment> Comments { get; set; } = new();
}
