using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Sorter
{
    public static GenericDataStructure<T> Sort<T>(GenericDataStructure<T> list)
        where T : IComparable
    {
        var sorted = list
            .Element
            .OrderBy(e => e)
            .ToList();
        return new GenericDataStructure<T>(sorted);
    }
}

