using L21P_EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace L21P_EFCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer("Server=.; Database=HelloWorldDb; Trusted_Connection=True; Encrypt=Optional");
    }
}
