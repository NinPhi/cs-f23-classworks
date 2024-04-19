using Application.Contracts;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class MouseService(IAppDbContext dbContext)
{
    public async Task AddAsync(AddMouseRequest request)
    {
        var mouse = new Mouse
        {
            Model = request.Model,
            Brand = request.Brand,
            Price = request.Price,
        };

        dbContext.Mice.Add(mouse);

        await dbContext.SaveChangesAsync();
    }
}
