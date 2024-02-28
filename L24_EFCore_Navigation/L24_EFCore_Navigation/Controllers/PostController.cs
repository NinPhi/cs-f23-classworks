
using L24_EFCore_Navigation.Data;
using L24_EFCore_Navigation.Dtos;
using L24_EFCore_Navigation.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L24_EFCore_Navigation.Controllers;

[ApiController]
[Route("api/posts")]
public class PostController : ControllerBase
{
    private readonly AppDbContext _context;

    public PostController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        //var posts = await _context.Posts.ToListAsync();

        //return Ok(posts);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePostRequest request)
    {
        var post = new Post()
        {
            AuthorId = request.AuthorId,
            Content = request.Content,
        };

        _context.Posts.Add(post);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
