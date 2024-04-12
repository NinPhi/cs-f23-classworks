using L40_API_Integration.Services;
using Refit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Настройка именованного HttpClient
builder.Services.AddHttpClient("github.com", client =>
{
    var baseAddress = builder.Configuration["GitHubSettings:BaseAddress"]!;
    client.BaseAddress = new Uri(baseAddress);

    var userAgent = builder.Configuration["GitHubSettings:UserAgent"]!;
    client.DefaultRequestHeaders.Add("User-Agent", userAgent);
});

// Настройка типизированного HttpClient
builder.Services.AddHttpClient<GitHubService>(client =>
{
    var baseAddress = builder.Configuration["GitHubSettings:BaseAddress"]!;
    client.BaseAddress = new Uri(baseAddress);

    var userAgent = builder.Configuration["GitHubSettings:UserAgent"]!;
    client.DefaultRequestHeaders.Add("User-Agent", userAgent);
});

// Настройка HttpClient от Refit
builder.Services.AddRefitClient<IGitHubService>()
    .ConfigureHttpClient(client =>
    {
        var baseAddress = builder.Configuration["GitHubSettings:BaseAddress"]!;
        client.BaseAddress = new Uri(baseAddress);

        var userAgent = builder.Configuration["GitHubSettings:UserAgent"]!;
        client.DefaultRequestHeaders.Add("User-Agent", userAgent);

        var accessToken = builder.Configuration["GitHubSettings:AccessToken"]!;
        client.DefaultRequestHeaders.Add("Authorization", accessToken);
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
