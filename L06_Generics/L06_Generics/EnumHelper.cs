namespace L6_Generics;

public static class EnumHelper
{
    public static string ConcatEnumValues<TEnum>() where TEnum : struct, Enum
    {
        var values = Enum.GetValues<TEnum>();

        return string.Join(", ", values);
    }
}
