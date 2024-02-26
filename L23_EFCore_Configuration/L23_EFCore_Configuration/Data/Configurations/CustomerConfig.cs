using L23_EFCore_Configuration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace L23_EFCore_Configuration.Data.Configurations;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasIndex(c => c.Email)
            .IsUnique(true)
            .IsClustered(false);
    }
}
