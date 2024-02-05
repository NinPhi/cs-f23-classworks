using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L16_Async.WebAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("get")]
    public async Task<long> Get()
    {
        var sw = Stopwatch.StartNew();

        await Task.Delay(10000);

        sw.Stop();

        return sw.ElapsedMilliseconds;
    }

    [HttpGet("get2")]
    public async Task<long> Get2()
    {
        var sw = Stopwatch.StartNew();

        await Task.Delay(2000);

        sw.Stop();

        return sw.ElapsedMilliseconds;
    }
}
