namespace L6P_Generics;

public class EnumHelper
{
    public static AppleProduct ParseOrFirst(string value)
    {
        var enumHasValue = Enum.IsDefined(typeof(AppleProduct), value);

        if (enumHasValue)
        {
            var enumValue = (AppleProduct)Enum.Parse(typeof(AppleProduct), value);

            return enumValue;
        }

        var enumValues = Enum.GetValues(typeof(AppleProduct));

        foreach (var enumValue in enumValues)
        {
            return (AppleProduct)enumValue;
        }

        return new AppleProduct();
    }

    public static T ParseOrFirst<T>(string value) where T : Enum, new()
    {
        var enumHasValue = Enum.IsDefined(typeof(T), value);

        if (enumHasValue)
        {
            var enumValue = (T)Enum.Parse(typeof(T), value);

            return enumValue;
        }

        var enumValues = Enum.GetValues(typeof(T));

        foreach (var enumValue in enumValues)
        {
            return (T)enumValue;
        }

        return new T();
    }
}
