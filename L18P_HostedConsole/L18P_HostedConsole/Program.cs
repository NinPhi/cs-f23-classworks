using L18P_HostedConsole;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHostBuilder builder = Host.CreateDefaultBuilder();

builder.ConfigureServices((IServiceCollection services) =>
{
    services.AddHostedService<DiscordBot>();
    services.AddTransient((services) =>
    {
        return new DatabaseService()
        {
            ConnectionString = "Server=.; Database=DiscordDb"
        };
    });
});

IHost app = builder.Build();

app.Run();
