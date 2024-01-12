using System;
using System.Collections;
using System.Collections.Generic;

namespace L7_Collections;

internal class Names : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        var result = "1";

        while (true)
        {
            yield return result;
            result += "1";
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
