using L56P_DevWorkflow.Data;
using L56P_DevWorkflow.Services;
using Microsoft.EntityFrameworkCore;

namespace L56P_DevWorkflow.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<MyFileService>();

        return services;
    }

    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opts =>
            opts.UseInMemoryDatabase("MyFileDb"));

        return services;
    }
}
