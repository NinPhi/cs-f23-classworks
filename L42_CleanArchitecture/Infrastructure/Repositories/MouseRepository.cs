using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

internal class MouseRepository(AppDbContext dbContext)
    : IMouseRepository
{
    public async Task AddAsync(Mouse mouse)
    {
        dbContext.Mice.Add(mouse);
        await dbContext.SaveChangesAsync();
    }
}
