using L26P_Reflection.Attributes;
using L26P_Reflection.Enums;
using System.Reflection;

namespace L26P_Reflection.Extensions;

public static class TranslateExtensions
{
    public static string Translate(this Role role)
    {
        //получаем тип данных
        Type enumType = role.GetType();

        //получаем поле типа
        FieldInfo? enumField = enumType.GetField(role.ToString());

        //получаем атрибут этого поля
        TranslationAttribute? attribute = 
            enumField?.GetCustomAttribute<TranslationAttribute>();

        //получаем значение из атрибута
        string? translation = attribute?.Translation;

        if (translation != null)
            return translation;

        return role.ToString();
    }
}
