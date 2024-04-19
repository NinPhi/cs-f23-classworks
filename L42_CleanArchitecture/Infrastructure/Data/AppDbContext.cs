using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> opts)
    : DbContext(opts), IAppDbContext
{
    public DbSet<Mouse> Mice => Set<Mouse>();
}
