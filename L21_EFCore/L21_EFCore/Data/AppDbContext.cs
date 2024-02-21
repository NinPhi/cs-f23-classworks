using L21_EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace L21_EFCore.Data;

public class AppDbContext : DbContext
{
    public DbSet<Auto> Autos => Set<Auto>();

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        string constr = "Server=.; Database=AutoDb; Trusted_Connection=True; Encrypt=Optional;";
        optionsBuilder.UseSqlServer(constr);
    }
}
