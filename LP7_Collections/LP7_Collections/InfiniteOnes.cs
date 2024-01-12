using System.Collections;

namespace LP7_Collections;

internal class InfiniteOnes
{
    public IEnumerator<string> GetEnumerator()
    {
        string ones = "1";

        while (true)
        {
            yield return ones;
            ones += "1";
        }
    }
}
