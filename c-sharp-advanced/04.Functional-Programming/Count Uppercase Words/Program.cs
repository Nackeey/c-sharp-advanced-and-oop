using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.Write(string.Join("\n", words.Where(x => char.IsUpper(x[0]))));
        }
    }
}
