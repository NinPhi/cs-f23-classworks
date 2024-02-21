using L22_Migrations.Entities;
using Microsoft.EntityFrameworkCore;

namespace L22_Migrations.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
    {
    }

    // Add-Migration {название_миграции}
    // Update-Database
    // Update-Database {название_предпоследней_миграции} либо 0
    // Remove-Migration

    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<User> Users => Set<User>();
}
