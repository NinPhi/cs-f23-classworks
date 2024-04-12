using System.Text.Json.Serialization;

namespace L40_API_Integration.Dtos;

public class CreateGitHubRepository
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    public required bool Private { get; set; }

    [JsonPropertyName("is_template")]
    public required bool IsTemplate { get; set; }
}
