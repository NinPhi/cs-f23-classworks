using System.ComponentModel.DataAnnotations;

namespace L25_EFCore_RelatedDataLoading.Entities;

public class Comment
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long PostId { get; set; }

    [StringLength(2000)]
    public required string Content { get; set; }

    public User? User { get; set; }
}
