using L26P_Reflection.Abstractions;
using L26P_Reflection.Attributes;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

namespace L26P_Reflection.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices<T>(
        this IServiceCollection services)
    {
        var serviceTypes = FindServiceTypes<T>();

        foreach (var serviceType in serviceTypes)
        {
            services.TryAddTransient(serviceType);
        }

        return services;
    }

    private static List<Type> FindServiceTypes<T>()
    {
        //var serviceTypes = typeof(T).Assembly
        //    .DefinedTypes
        //    .Where(type => type.IsAbstract is false
        //        && type.IsAssignableTo(typeof(IServiceMarker)))
        //    .Select(type => type.AsType())
        //    .ToList();

        var serviceTypes = typeof(T).Assembly
            .DefinedTypes
            .Where(type => type.IsAbstract is false
                && type.GetCustomAttributes<TransientServiceAttribute>().Any())
            .Select(type => type.AsType())
            .ToList();

        return serviceTypes;
    }
}
