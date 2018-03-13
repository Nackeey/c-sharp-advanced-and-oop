using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<IBirthable> birthable = new List<IBirthable>();
        GetBirthables(birthable);

        string birthYear = Console.ReadLine();
        PrintResult(birthable, birthYear);
    }

    private static void PrintResult(List<IBirthable> birthable, string birthYear)
    {
            birthable
                .Where(x => x.Birthdate
                .EndsWith(birthYear))
                .ToList()
                .ForEach(x => Console.WriteLine(x.Birthdate));
    }

    private static void GetBirthables(List<IBirthable> birthable)
    {
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            var info = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (info[0])
            {
                case "Citizen":
                    IBirthable citizen = new Citizen(info[1], int.Parse(info[2]), info[3], info[4]);
                    birthable.Add(citizen);
                    break;
                case "Pet":
                    IBirthable pet = new Pet(info[1], info[2]);
                    birthable.Add(pet);
                    break;
                default:
                    break;
            }
        }
    }
}

