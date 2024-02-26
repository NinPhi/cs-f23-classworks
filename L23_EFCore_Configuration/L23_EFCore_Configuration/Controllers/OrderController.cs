using L23_EFCore_Configuration.Data;
using L23_EFCore_Configuration.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L23_EFCore_Configuration.Controllers;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private readonly AppDbContext _context;

    public OrderController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var orders = await _context.Orders.ToListAsync();

        return Ok(orders);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var order = await _context.Orders.FindAsync(id);

        return Ok(order);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Order order)
    {
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        return Created($"api/orders/{order.Id}", order);
    }
}
