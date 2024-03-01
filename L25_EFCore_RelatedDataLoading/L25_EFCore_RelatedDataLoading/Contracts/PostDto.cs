namespace L25_EFCore_RelatedDataLoading.Contracts;

public record PostDto
{
    public required string Title { get; init; }
    public required string Content { get; init; }
}
