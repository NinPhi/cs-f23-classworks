using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IAppDbContext
{
    DbSet<Mouse> Mice { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
