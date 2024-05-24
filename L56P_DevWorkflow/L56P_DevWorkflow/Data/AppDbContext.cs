using L56P_DevWorkflow.Entities;
using Microsoft.EntityFrameworkCore;

namespace L56P_DevWorkflow.Data;

public class AppDbContext(DbContextOptions<AppDbContext> opts) : DbContext(opts)
{
    public DbSet<MyFileInfo> Files => Set<MyFileInfo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<MyFileInfo>()
            .Property(f => f.Id)
            .ValueGeneratedNever();

        modelBuilder
            .Entity<MyFileData>()
            .Property(f => f.FileInfoId)
            .ValueGeneratedNever();
    }
}
