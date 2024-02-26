using L23P_EFCore_Configuration.Entities;
using Microsoft.EntityFrameworkCore;

namespace L23P_EFCore_Configuration.Data;

public class AppDbContext : DbContext
{
    /// <summary>
    /// Конструктор для передачи настроек контекста БД в базовый класс.
    /// </summary>
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Order> Orders => Set<Order>();
}
