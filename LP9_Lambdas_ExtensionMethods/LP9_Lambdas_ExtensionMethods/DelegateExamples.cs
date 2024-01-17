namespace LP9_Lambdas_ExtensionMethods;

public static class DelegateExamples
{
    public static void Test()
    {
        VoidDelegate voidDelegate = VoidMethod;
        voidDelegate();

        IntDelegate intDelegate = IntMethod;
        string intMethodResult = intDelegate(10);

        PredicateDelegate predicateDelegate = PredicateMethod;
        bool predicateMethodResult = predicateDelegate("Dima");


        Action voidAction = VoidMethod;
        voidAction();

        Func<int, string> intFunc = IntMethod;
        string intFuncResult = intFunc(10);

        Func<string, bool> predicateFunc = PredicateMethod;
        bool predicateFuncResult = predicateFunc("Dima");


        VoidGenericDelegate<string> stringMethod = VoidGenericMethod<string>;
        stringMethod("Batya");

        VoidGenericDelegate<int> intMethod = VoidGenericMethod<int>;
        intMethod(228);

        VoidGenericDelegate<bool> boolMethod = VoidGenericMethod<bool>;
        boolMethod(true);


        Console.WriteLine(intMethodResult);
        Console.WriteLine(predicateMethodResult);
        Console.WriteLine(intFuncResult);
        Console.WriteLine(predicateFuncResult);
    }

    public delegate void VoidDelegate();

    public static void VoidMethod()
    {
        Console.WriteLine("Hello, World!");
    }

    public delegate string IntDelegate(int number);

    public static string IntMethod(int number)
    {
        return number.ToString();
    }

    public delegate bool PredicateDelegate(string input);

    public static bool PredicateMethod(string input)
    {
        return input == "Dima";
    }

    public delegate void VoidGenericDelegate<T>(T argument);

    public static void VoidGenericMethod<T>(T argument)
    {
        Console.WriteLine(argument?.ToString());
    }
}
