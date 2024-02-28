using L24_EFCore_Navigation.Entities;
using Microsoft.EntityFrameworkCore;

namespace L24_EFCore_Navigation.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Tag> Tags => Set<Tag>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder
        //    .Entity<User>()
        //    .HasMany<Post>()
        //    .WithOne();

        //modelBuilder
        //    .Entity<Post>()
        //    .HasOne<User>()
        //    .WithMany();

        modelBuilder.Entity<UserProfile>().HasKey(up => up.UserId);
        modelBuilder.Entity<User>()
            .HasMany(u => u.Friends)
            .WithMany()
            .UsingEntity<Friendship>()
            .HasKey(f => new { f.UserId1, f.UserId });
    }
}
