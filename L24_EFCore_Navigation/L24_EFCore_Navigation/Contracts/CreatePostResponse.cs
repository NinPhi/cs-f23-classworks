namespace L24_EFCore_Navigation.Dtos;

public class CreatePostResponse
{
    public long Id { get; set; }
    public long AuthorId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedOn { get; set; }
}
