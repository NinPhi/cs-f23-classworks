using L10_LINQ.Entities;

namespace L10_LINQ;
internal class Methods
{
    public static bool IsBrown(Employee e)
    {
        return e.LastName == "Brown";
    }
}
