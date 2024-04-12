using L40_API_Integration.Dtos;
using L40_API_Integration.Services;
using Microsoft.AspNetCore.Mvc;

namespace L40_API_Integration.Controllers;

[ApiController]
public class RepositoryController : ControllerBase
{
    private readonly HttpClient _client;
    private readonly GitHubService _gitHubService;
    private readonly IGitHubService _gitHubRefitService;

    public RepositoryController(
        IHttpClientFactory clientFactory,
        GitHubService gitHubService,
        IGitHubService gitHubRefitService)
    {
        _client = clientFactory.CreateClient("github.com");
        _gitHubService = gitHubService;
        _gitHubRefitService = gitHubRefitService;
    }

    [HttpGet("api/v1/users/{username}/repos")]
    public async Task<IActionResult> GetUserRepos1(string username)
    {
        var repos = await _client.GetFromJsonAsync<List<GitHubRepository>>(
            $"users/{username}/repos");

        return Ok(repos);
    }

    [HttpGet("api/v2/users/{username}/repos")]
    public async Task<IActionResult> GetUserRepos2(string username)
    {
        var repos = await _gitHubService.GetRepositoriesByUserAsync(username);

        return Ok(repos);
    }

    [HttpGet("api/v3/users/{username}/repos")]
    public async Task<IActionResult> GetUserRepos3(string username)
    {
        var repos = await _gitHubRefitService.GetRepositoriesByUserAsync(username);

        return Ok(repos);
    }

    [HttpPost("api/v3/user/repos")]
    public async Task<IActionResult> GetUserRepos3(CreateGitHubRepository repository)
    {
        await _gitHubRefitService.CreateNewRepository(repository);

        return NoContent();
    }
}
