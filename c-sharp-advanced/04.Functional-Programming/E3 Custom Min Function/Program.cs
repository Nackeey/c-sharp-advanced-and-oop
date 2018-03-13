using System;
using System.Linq;

namespace E3_Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();

            Func<double[], double> smallestNum = n => n.Min();

            Console.WriteLine(smallestNum(numbers));
        }
    }
}
