using System;
using System.Collections.Generic;
using System.Text;

public class StartUp
{
    public static void Main()
    {
        List<Animal> animals = new List<Animal>();

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            Animal animal = GetAnimal(input);
            animals.Add(animal);
            animal.ProduceSound();

            var foodInfo = Console.ReadLine().Split();
            Food food = GetFoodInfo(foodInfo);
            animal.TimeToEat(food, int.Parse(foodInfo[1]));
        }
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }

    private static Food GetFoodInfo(string[] foodInfo)
    {
        var food = foodInfo[0];
        var quantity = int.Parse(foodInfo[1]);
        switch (food)
        {
            case "Vegetable": return new Vegetable(quantity);
            case "Meat": return new Meat(quantity);
            case "Seeds": return new Seeds(quantity);
            case "Fruit": return new Fruit(quantity);
            default: return null;
        }
    }

    private static Animal GetAnimal(string input)
    {
        var animalInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var animalType = animalInfo[0];
        var animalName = animalInfo[1];
        var animalWeight = double.Parse(animalInfo[2]);
        
        switch (animalType)
        {
            case "Cat":
                return new Cat(animalName, animalInfo[4], animalWeight, animalInfo[3]);
            case "Tiger":
                return new Tiger(animalName, animalInfo[4], animalWeight, animalInfo[3]);
            case "Dog":
                return new Dog(animalName, animalWeight, animalInfo[3]);
            case "Mouse":
                return new Mouse(animalName, animalWeight, animalInfo[3]);
            case "Hen":
                return new Hen(animalName, double.Parse(animalInfo[3]), animalWeight);
            case "Owl":
                return new Owl(animalName, double.Parse(animalInfo[3]), animalWeight);
            default: return null;
        }
    }
}


