using System.ComponentModel.DataAnnotations;

namespace L25_EFCore_RelatedDataLoading.Entities;

public class User
{
    public long Id { get; set; }

    [StringLength(200)]
    public required string Email { get; set; }

    [StringLength(200)]
    public required string Password { get; set; }

    public List<Post> Posts { get; set; } = new();
}
