namespace L8_DelegatesAndLambdas;

public class ListHelper
{
    public static List<string> MyWhere(
        List<string> list,
        Func<string, bool> predicate)
    {
        List<string> newList = new List<string>();

        foreach (var item in list)
        {
            if (predicate(item) == true)
            {
                newList.Add(item);
            }
        }

        return newList;
    }
}
