using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var divisors = new List<int>();
            var dividers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int num = 1; num <= n; num++)
            {
                bool isDivisible = true;
                foreach (var divisor in dividers)
                {
                    Predicate<int> isNotDivisor = x => num % x != 0;

                    if (isNotDivisor(divisor))
                    {
                        isDivisible = false; break;
                    }
                }
                if (isDivisible)
                {
                    divisors.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", divisors));
        }
    }
}
