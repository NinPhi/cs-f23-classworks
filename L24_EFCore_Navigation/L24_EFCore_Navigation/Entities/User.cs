using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L24_EFCore_Navigation.Entities;

public class User
{
    public long Id { get; set; }

    [StringLength(100)]
    public required string Username { get; set; }

    [StringLength(300)]
    public required string PasswordHash { get; set; }

    public List<User> Friends { get; set; } = new();

    public List<Post> Posts { get; set; } = new();

    public UserProfile? Profile { get; set; }
}