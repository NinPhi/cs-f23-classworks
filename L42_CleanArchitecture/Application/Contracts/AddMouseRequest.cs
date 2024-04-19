namespace Application.Contracts;

public record AddMouseRequest(
    string Model, string Brand, decimal Price);