using System;
using System.Linq;

namespace E02_Knights_of_honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            Action<string> printAndAppend = x => Console.WriteLine($"Sir {x}");

            foreach (var n in names)
            {
                printAndAppend(n);
            }
        }
    }
}
