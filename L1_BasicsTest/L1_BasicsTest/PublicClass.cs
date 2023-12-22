namespace _20231218_CSharpBasicsTest;

public class PublicClass
{
    private int field;
    public string Property { get; set; }

    public PublicClass()
    {
        
    }

    public PublicClass(string property)
    {
        Property = property;
    }

    public void VoidMethod()
    {
        int result = IntMethod(50);
    }

    private int IntMethod(int value)
    {
        return value;
    }

    public static void Print(string value)
    {
        Console.WriteLine(value);
    }
}
