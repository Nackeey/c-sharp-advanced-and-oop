using System;
using System.Linq;

namespace E07_Predicate_for_names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Predicate<string> filter = n => n.Length <= length;
            var result = names.Where(n => filter(n));
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
