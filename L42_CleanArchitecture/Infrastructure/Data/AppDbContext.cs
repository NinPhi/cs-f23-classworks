using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

internal class AppDbContext(DbContextOptions<AppDbContext> opts)
    : DbContext(opts)
{
    public DbSet<Mouse> Mice => Set<Mouse>();
}
