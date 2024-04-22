using Domain.Entities;

namespace Domain.Repositories;

public interface IMouseRepository
{
    Task AddAsync(Mouse mouse);
}

