using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    public void SwapElements(List<T> list, int elementOne, int elementTwo)
    {
        var rem = list[elementOne];
        list[elementOne] = list[elementTwo];
        list[elementTwo] = rem;
    }
}

