using System;
using System.Collections.Generic;
using System.Linq;

namespace E04_Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderBy(x => x).ToList();
            string filter = Console.ReadLine();

            Predicate<int> isEven = x => x % 2 == 0;

            var result = GetNumbers(nums, filter, isEven);
            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> GetNumbers(List<int> nums, string filter, Predicate<int> isEven)
        {
            var result = new List<int>();
            for (int i = nums[0]; i <= nums[1]; i++)
            {
                if ((isEven(i) && filter == "even" || !isEven(i) && filter == "odd"))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
