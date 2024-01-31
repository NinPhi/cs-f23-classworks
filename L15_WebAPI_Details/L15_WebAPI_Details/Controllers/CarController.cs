using L15_WebAPI_Details.Entities;
using Microsoft.AspNetCore.Mvc;

namespace L15_WebAPI_Details.Controllers;

[ApiController]
[Route("cars")]
public class CarController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(List<Car>))]
    [ProducesResponseType(400, Type = typeof(string))]
    public ActionResult<List<Car>> GetCar(int count)
    {
		try
		{
            if (count < 0)
                throw new Exception("Count cannot be negative.");

            var cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                cars.Add(new Car
                {
                    Id = Random.Shared.Next(100, 100000),
                    Model = "Spark",
                    Brand = "Chevrolet",
                });
            }

            return Ok(cars);
        }
		catch (Exception ex)
		{
            return BadRequest(ex.Message);
		}
    }
}
