using L21_EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace L21_EFCore;

public class App : IHostedService
{
    private readonly AppDbContext _context;

    public App(AppDbContext context)
    {
        _context = context;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        var autos = await _context.Autos
            .Where(a => a.Brand == "Chevrolet")
            .ToListAsync(); ;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
