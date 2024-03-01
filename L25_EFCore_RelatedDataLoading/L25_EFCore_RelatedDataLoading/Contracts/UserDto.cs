namespace L25_EFCore_RelatedDataLoading.Contracts;

public record UserDto
{
    public required long Id { get; init; }
    public required string Email { get; init; }
}
