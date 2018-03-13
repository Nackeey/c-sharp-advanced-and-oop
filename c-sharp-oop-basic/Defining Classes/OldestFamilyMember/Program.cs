using System;

public class Program
{
    static void Main()
    {
        var family = new Family();
        int members = int.Parse(Console.ReadLine());

        for (int i = 0; i < members; i++)
        {
            string[] people = Console.ReadLine().Split();
            string name = people[0];
            int age = int.Parse(people[1]);

            var person = new Person(name, age);

            family.AddMember(person);
        }
        var theOldest = family.GetTheOldestMember();

        if (theOldest != null)
        {
            Console.WriteLine(theOldest.Name + " " + theOldest.Age);
        }
    }
}

