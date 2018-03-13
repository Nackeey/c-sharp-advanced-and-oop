using System;
using System.Linq;

namespace E01_Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            Action<string> print = x => Console.WriteLine(x);

            foreach (var n in names)
            {
                print(n);
            }
        }
    }
}
