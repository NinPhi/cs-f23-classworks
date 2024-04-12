using L40_API_Integration.Dtos;

namespace L40_API_Integration.Services;

public class GitHubService
{
    private readonly HttpClient _client;

    public GitHubService(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<GitHubRepository>> GetRepositoriesByUserAsync(string username)
    {
        var repos = await _client.GetFromJsonAsync<List<GitHubRepository>>($"users/{username}/repos");

        return repos ?? [];
    }
}
