using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .Select(x => x * 1.20)
                .ToArray();
            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
