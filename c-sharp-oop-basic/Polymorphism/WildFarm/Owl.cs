using System;
using System.Collections.Generic;
using System.Text;

public class Owl : Bird
{
    public const double weightIncreaseBy = 0.25;
    public Owl(string name, double wingSize, double weight)
        : base(name, wingSize, weight)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Hoot Hoot");
    }

    public override void TimeToEat(Food food, int quantity)
    {
        if (food is Meat)
        {
            this.Weight += (weightIncreaseBy * quantity);
            this.FoodEaten += quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}

