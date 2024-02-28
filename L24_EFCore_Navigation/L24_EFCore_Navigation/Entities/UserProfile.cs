using System.ComponentModel.DataAnnotations;

namespace L24_EFCore_Navigation.Entities;

public class UserProfile
{
    public long UserId { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? AvatarUrl { get; set; }

    public User? User { get; set; }
}