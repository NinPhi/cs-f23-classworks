using Microsoft.Extensions.Hosting;

namespace L18P_HostedConsole;

public class DiscordBot : IHostedService
{
    public DiscordBot(DatabaseService service)
    {
        Console.WriteLine("Constructor DiscordBot: " + service.ConnectionString);
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Discord bot has started");

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Discord bot has finished");

        return Task.CompletedTask;
    }
}
