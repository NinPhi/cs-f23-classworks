using L26_Reflection.Lib.Abstractions;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

namespace L26_Reflection.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddTransientServices<T>(
        this IServiceCollection services)
    {
        var serviceTypes = typeof(T).Assembly
            .DefinedTypes
            .Where(type => type.IsAbstract is false
                && type.IsAssignableTo(typeof(ITransientService)))
            .Select(type => type.AsType())
            .ToList();

        foreach (var serviceType in serviceTypes)
        {
            services.TryAddTransient(serviceType);
        }

        return services;
    }
}
