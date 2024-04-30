using System.Reflection;

namespace Application;

public class ApplicationAssembly
{
    public static Assembly Reference =>
        typeof(ApplicationAssembly).Assembly;
}
