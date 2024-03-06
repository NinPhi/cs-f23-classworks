using L27P_Validation.Enums;

namespace L27P_Validation.Entities;

public class User
{
    public long Id { get; set; }
    public required string Email { get; set; }
    public required string FullName { get; set; }
    public required DateTime DateOfBirth { get; set; }

    public Subscription Subscription { get; set; } = Subscription.None;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
}
