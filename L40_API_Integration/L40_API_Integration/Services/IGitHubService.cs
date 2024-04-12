using L40_API_Integration.Dtos;
using Refit;

namespace L40_API_Integration.Services;

public interface IGitHubService
{
    [Get("/users/{username}/repos")]
    Task<List<GitHubRepository>> GetRepositoriesByUserAsync(string username);

    [Post("/user/repos")]
    Task CreateNewRepository(CreateGitHubRepository repository);
}