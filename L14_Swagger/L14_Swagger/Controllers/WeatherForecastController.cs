using Microsoft.AspNetCore.Mvc;

namespace L14_Swagger.Controllers;

[ApiController]
[Route("weather")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet("report")]
    public IEnumerable<WeatherForecast> Get()
    {
        return RandomForecasts(5);
    }

    [HttpGet("report/{count}")]
    public IEnumerable<WeatherForecast> Get(int count)
    {
        return RandomForecasts(count);
    }

    [HttpPost("report")]
    public WeatherForecast Post(WeatherForecast forecast)
    {
        return forecast;
    }

    private List<WeatherForecast> RandomForecasts(int count)
    {
        var forecasts = new List<WeatherForecast>();

        for (int i = 1; i <= count; i++)
        {
            var forecast = new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };

            forecasts.Add(forecast);
        }

        return forecasts;
    }
}
