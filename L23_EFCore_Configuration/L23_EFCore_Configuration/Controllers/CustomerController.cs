using L23_EFCore_Configuration.Data;
using L23_EFCore_Configuration.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L23_EFCore_Configuration.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomerController : ControllerBase
{
    private readonly AppDbContext _context;

    public CustomerController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var customers = await _context.Customers.ToListAsync();

        return Ok(customers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var customer = await _context.Customers.FindAsync(id);

        return Ok(customer);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();

        return Created($"api/customers/{customer.Id}", customer);
    }
}
