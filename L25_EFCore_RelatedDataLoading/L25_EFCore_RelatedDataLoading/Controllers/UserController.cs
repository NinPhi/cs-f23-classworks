using L25_EFCore_RelatedDataLoading.Contracts;
using L25_EFCore_RelatedDataLoading.Data;
using L25_EFCore_RelatedDataLoading.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L25_EFCore_RelatedDataLoading.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _context.Users.ToListAsync();

        var userDtos = users
            .Select(u => new UserDto
            {
                Id = u.Id,
                Email = u.Email,
            })
            .ToList();

        return Ok(userDtos);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserDto userDto)
    {
        var user = new User()
        {
            Email = userDto.Email,
            Password = userDto.Password,
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok($"User was created under ID {user.Id}");
    }

    [HttpGet("{userId}/posts")]
    public async Task<IActionResult> GetPosts(long userId)
    {
        //var posts = await _context.Posts
        //    .Where(p => p.UserId == userId)
        //    .Select(p => new PostDto { Title = p.Title, Content = p.Content })
        //    .ToListAsync();

        //var posts = await _context.Users
        //    .Include(u => u.Posts)
        //    .Where(u => u.Id == userId)
        //    .SelectMany(u => u.Posts)
        //    .Select(p => new PostDto { Title = p.Title, Content = p.Content })
        //    .ToListAsync();

        var user = await _context.Users
            .Include(u => u.Posts)
            .FirstOrDefaultAsync(u => u.Id == userId);

        if (user is null) return NotFound();

        var posts = user.Posts
            .Select(p => new PostDto
            {
                Title = p.Title,
                Content = p.Content
            })
            .ToList();

        return Ok(posts);
    }

    [HttpPost("{userId}/posts")]
    public async Task<IActionResult> AddPost(long userId, PostDto postDto)
    {
        var user = await _context.Users.FindAsync(userId);

        if (user is null) return NotFound($"User with ID {userId} was not found.");

        var post = new Post()
        {
            Title = postDto.Title,
            Content = postDto.Content,
        };

        user.Posts.Add(post);

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpGet("{userId}/posts/comments")]
    public async Task<IActionResult> GetAllCommentsUnderAllposts(long userId)
    {
        var user = await _context.Users
            .Include(u => u.Posts)
                .ThenInclude(p => p.Comments)
            .FirstOrDefaultAsync(u => u.Id == userId);

        if (user is null) return NotFound();

        var comments = user.Posts
            .SelectMany(p => p.Comments)
            .Select(c => new CommentDto { Content = c.Content })
            .ToList();

        return Ok(comments);
    }
}
