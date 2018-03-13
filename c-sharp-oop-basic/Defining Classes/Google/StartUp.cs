using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var persons = new List<Person>();

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            var info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var name = info[0];

            var person = persons.FirstOrDefault(p => p.Name == name);
            if (person == null)
            {
                person = new Person(name);
                persons.Add(person);
            }

            var subclass = info[1];

            switch (subclass)
            {
                case "company":
                    person.Company = new Company(info[2], info[3], decimal.Parse(info[4]));
                    break;
                case "pokemon":
                    person.Pokemons.Add(new Pokemon(info[2], info[3]));
                    break;
                case "parents":
                    person.Parents.Add(new FamilyMember(info[2], info[3]));
                    break;
                case "children":
                    person.Children.Add(new FamilyMember(info[2], info[3]));
                    break;
                case "car":
                    person.Car = new Car(info[2], int.Parse(info[3]));
                    break;
                default:
                    break;
            }
        }
        var searchedName = Console.ReadLine();
        var searchedPerson = persons.FirstOrDefault(p => p.Name == searchedName);
        if (searchedPerson != null)
        {
            Console.WriteLine(searchedPerson.ToString());
        }
    }
}

