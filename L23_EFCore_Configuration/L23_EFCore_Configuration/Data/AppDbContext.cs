using L23_EFCore_Configuration.Data.Configurations;
using L23_EFCore_Configuration.Entities;
using Microsoft.EntityFrameworkCore;

namespace L23_EFCore_Configuration.Data;

public class AppDbContext : DbContext
{
    /// <summary>
    /// Конструктор для передачи настроек контекста БД в базовый класс.
    /// </summary>
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);

        modelBuilder.Entity<Item>()
            .HasMany<Order>()
            .WithOne(o => o.Item)
            .HasForeignKey(o => o.ItemName);

        modelBuilder.Entity<Item>()
            .ToTable("Items")
            .HasKey(i => i.Name)
            .IsClustered(false);
    }

    protected override void ConfigureConventions(
        ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<decimal>().HaveColumnType("decimal(18, 2)");
    }
}
