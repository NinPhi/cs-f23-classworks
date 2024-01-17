namespace LP9_Lambdas_ExtensionMethods;

public static class DelegateExtensions
{
    public static void Call(
        this Action action)
    {
        action();
    }
}
