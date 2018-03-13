using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_age
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int i = 0; i < peopleNumber; i++)
            {
                string[] nameAndAge = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);

                people.Add(name, age);
            }
            string condition = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            var filter = Checker(condition, ageLimit);
            var print = Printer(format);

            people.Where(filter).ToList().ForEach(print); 
        }

        public static Action<KeyValuePair<string, int>> Printer(string format)
        {
            switch (format)
            {
                case "name":
                    return p => Console.WriteLine($"{p.Key}");
                case "age":
                    return p => Console.WriteLine($"{p.Value}");
                case "name age":
                    return p => Console.WriteLine($"{p.Key} - {p.Value}");
                default: return null;
            }
        }

        public static Func<KeyValuePair<string, int>, bool> Checker(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x.Value < age;
                case "older": return x => x.Value >= age;
                default: return null;
            }
        }
    }
}
