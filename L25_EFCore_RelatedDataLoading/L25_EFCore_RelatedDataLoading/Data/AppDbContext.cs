using L25_EFCore_RelatedDataLoading.Entities;
using Microsoft.EntityFrameworkCore;

namespace L25_EFCore_RelatedDataLoading.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Post> Posts => Set<Post>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>().ToTable("Comments");
    }
}
