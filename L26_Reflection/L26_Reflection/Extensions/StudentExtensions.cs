using L26_Reflection.Entities;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace L26_Reflection.Extensions;

public static class StudentExtensions
{
    public static void Validate<T>(this T entity)
    {
        var properties = entity?
            .GetType()
            .GetProperties()
            .Where(p => p.PropertyType == typeof(string))
            .Where(p => p.GetCustomAttribute<MaxLengthAttribute>() != null)
            .ToList() ?? new();

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<MaxLengthAttribute>();
            var maxLength = attr?.Length;
            var propValue = (string)prop.GetValue(entity)!;

            if (propValue.Length > maxLength)
                throw new Exception("Student is not valid.");
        }
    }
}
