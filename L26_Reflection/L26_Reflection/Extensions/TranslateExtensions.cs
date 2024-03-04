using L26_Reflection.Attributes;
using L26_Reflection.Enums;
using System.Reflection;

namespace L26_Reflection.Extensions;

public static class TranslateExtensions
{
    public static string Translate<TEnum>(this TEnum value) where TEnum : Enum
    {
        Type type = value.GetType();
        FieldInfo? field = type.GetField(value.ToString());
        RussianAttribute? attribute = field?.GetCustomAttribute<RussianAttribute>();

        if (attribute != null)
        {
            return attribute.Translation;
        }

        return value.ToString();
    }
}
