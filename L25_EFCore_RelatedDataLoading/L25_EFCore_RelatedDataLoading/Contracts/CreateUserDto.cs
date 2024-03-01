namespace L25_EFCore_RelatedDataLoading.Contracts;

public record CreateUserDto
{
    public required string Email { get; init; }
    public required string Password { get; init; }
}
