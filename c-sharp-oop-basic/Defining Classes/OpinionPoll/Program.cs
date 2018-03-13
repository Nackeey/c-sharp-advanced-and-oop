using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>();
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] info = Console.ReadLine().Split(' ');
            var person = new Person(info[0], int.Parse(info[1]));
            people.Add(person);
        }

        var ordered = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
        foreach (var person in ordered)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

