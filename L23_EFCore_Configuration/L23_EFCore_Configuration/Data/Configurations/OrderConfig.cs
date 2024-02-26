using L23_EFCore_Configuration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace L23_EFCore_Configuration.Data.Configurations;

public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .HasOne<Customer>()
            .WithMany()
            .HasForeignKey(o => o.CustomerId);
    }
}
