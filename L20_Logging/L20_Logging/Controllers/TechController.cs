using L20_Logging.Entities;
using Microsoft.AspNetCore.Mvc;

namespace L20_Logging.Controllers;

[ApiController]
[Route("api/tech")]
public class TechController : ControllerBase
{
    private static readonly List<TechProduct> _products = new()
    {
        new TechProduct("GALAX GeForce RTX3060", 15, 27000),
        new TechProduct("GEFORCE RTX4060", 28, 32500),
    };

    private readonly ILogger<TechController> _logger;

    public TechController(ILogger<TechController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        _logger.LogInformation(
            "{Count} products has been returned.",
            _products.Count);

        return Ok(_products);
    }

    [HttpPost]
    public IActionResult AddProduct(TechProduct product)
    {
        Serilog.Log.Information("AddProduct has fired!");

        _products.Add(product);

        return NoContent();
    }
}
