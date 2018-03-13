using System;
using System.Linq;
using System.Collections.Generic;

namespace E06_Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToList();

            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = n => n % divisor == 0;

            var result = numbers
                .Where(n => !isDivisible(n))
                .Reverse()
                .ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
