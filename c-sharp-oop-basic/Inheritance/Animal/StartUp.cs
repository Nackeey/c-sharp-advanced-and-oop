using System;

public class StartUp
{
    public static void Main()
    {
        string animalType = string.Empty;
        while ((animalType = Console.ReadLine()) != "Beast!")
        {
            try
            {
                Animal animal = GetAnimal(animalType);
                Console.WriteLine(animal.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static Animal GetAnimal(string animalType)
    {
        var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var name = tokens[0];
        var age = int.Parse(tokens[1]);

        switch (animalType)
        {
            case "Cat":
                return new Cat(name, age, tokens[2]);
            case "Dog":
                return new Dog(name, age, tokens[2]);
            case "Frog":
                return new Frog(name, age, tokens[2]);
            case "Kitten":
                return new Kitten(name, age);
            case "Tomcat":
                return new Tomcat(name, age);
            default:
                throw new ArgumentException("Invalid input!");
        }
    }
}