using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
