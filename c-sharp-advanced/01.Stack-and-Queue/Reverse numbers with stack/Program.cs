using System;
using System.Collections.Generic;
using System.Linq;

class Reverse_Numbers
{
    static void Main()
    {
        int[] integers = Console.ReadLine()
            .Trim()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        Stack<int> stack = new Stack<int>(integers);

        Console.WriteLine(string.Join(" ", stack));
    }
}

