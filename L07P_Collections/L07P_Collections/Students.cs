using System.Collections;

namespace LP7_Collections;

internal class Students : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        yield return "Mark";
        yield return "Dima";
        yield return "Batya";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
