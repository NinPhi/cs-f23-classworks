namespace L26P_Reflection.Attributes;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class TranslationAttribute : Attribute
{
    public string Translation;

    public TranslationAttribute(string translation)
    {
        Translation = translation;
    }
}
