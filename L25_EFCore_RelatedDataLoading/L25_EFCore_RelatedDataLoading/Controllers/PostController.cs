using L25_EFCore_RelatedDataLoading.Contracts;
using L25_EFCore_RelatedDataLoading.Data;
using L25_EFCore_RelatedDataLoading.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L25_EFCore_RelatedDataLoading.Controllers;

[ApiController]
[Route("api/posts")]
public class PostController : ControllerBase
{
    private readonly AppDbContext _context;

    public PostController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("{postId}/comments")]
    public async Task<IActionResult> AddComment(long postId, CommentDto commentDto)
    {
        var post = await _context.Posts.FindAsync(postId);

        if (post is null) return NotFound($"Post with ID {postId} was not found.");

        bool userExists = await _context.Users.AnyAsync(u => u.Id == commentDto.UserId);
        if (userExists is false) return NotFound($"User with ID {commentDto.UserId} was not found.");

        var comment = new Comment
        {
            UserId = commentDto.UserId,
            Content = commentDto.Content,
        };

        post.Comments.Add(comment);

        await _context.SaveChangesAsync();

        return NoContent();
    }

}
