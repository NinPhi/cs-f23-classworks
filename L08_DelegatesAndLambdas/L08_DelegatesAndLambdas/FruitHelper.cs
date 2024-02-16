namespace L8_DelegatesAndLambdas;

public class FruitHelper
{
    public static bool IsPineapple(string fruit)
    {
        if (fruit.ToLower() == "pineapple")
            Console.WriteLine("It's a pineapple!!");
        else return false;

        return true;
    }

    public static bool IsWatermelon(string fruit)
    {
        if (fruit.ToLower() == "watermelon")
            Console.WriteLine("It's a watermelon!!!!!");
        else return false;

        return true;
    }
}
