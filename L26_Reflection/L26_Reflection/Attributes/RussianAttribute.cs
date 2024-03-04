namespace L26_Reflection.Attributes;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class RussianAttribute : Attribute
{
    public string Translation { get; set; }

    public RussianAttribute(string translation)
    {
        Translation = translation;
    }
}
