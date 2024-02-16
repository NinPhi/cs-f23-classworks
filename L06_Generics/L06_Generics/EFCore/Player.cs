namespace L6_Generics.EFCore;

internal class Player : IEntity
{
    public int Id { get; set; }
    public int TeamId { get; set; }
    public string Fullname { get; set; }
    public int JerseyNumber { get; set; }
}
