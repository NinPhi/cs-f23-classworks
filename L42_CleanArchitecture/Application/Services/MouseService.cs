using Application.Contracts;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services;

public class MouseService(IMouseRepository mouseRepository)
{
    public async Task AddAsync(AddMouseRequest request)
    {
        var mouse = new Mouse
        {
            Model = request.Model,
            Brand = request.Brand,
            Price = request.Price,
        };

        await mouseRepository.AddAsync(mouse);
    }
}
