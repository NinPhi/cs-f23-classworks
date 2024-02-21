using L22_Migrations.Data;
using L22_Migrations.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L22_Migrations.Controllers;

[ApiController]
[Route("api/cinema")]
public class CinemaController : ControllerBase
{
    private readonly AppDbContext _context;

    public CinemaController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var movies = await _context.Movies.ToListAsync();

        return Ok(movies);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Movie movie)
    {
        _context.Movies.Add(movie);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
