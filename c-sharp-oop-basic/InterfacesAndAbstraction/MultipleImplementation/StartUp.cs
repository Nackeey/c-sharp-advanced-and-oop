using System;

public class StartUp
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();
        IIdentifiable identifialble = new Citizen(name, age, id, birthdate);
        IBirthable birthable = new Citizen(name, age, id, birthdate);

        Console.WriteLine(identifialble.Id);
        Console.WriteLine(birthable.Birthdate);
    }
}

