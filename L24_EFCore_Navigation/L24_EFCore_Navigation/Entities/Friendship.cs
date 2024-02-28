using System.ComponentModel.DataAnnotations.Schema;

namespace L24_EFCore_Navigation.Entities;

[Table("Friends")]
public class Friendship
{
    public long UserId { get; set; }
    public long UserId1 { get; set; }
}
