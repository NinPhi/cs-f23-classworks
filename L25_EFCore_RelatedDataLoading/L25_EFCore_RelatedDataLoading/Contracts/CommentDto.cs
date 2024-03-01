namespace L25_EFCore_RelatedDataLoading.Contracts;

public record CommentDto
{
    public long UserId { get; set; }
    public required string Content { get; set; }
}
