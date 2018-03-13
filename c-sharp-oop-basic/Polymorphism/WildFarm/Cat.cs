using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Feline
{
    private const double weightIncreaseBy = 0.30;

    public Cat(string name, string breed, double weight, string livingRegion)
        : base(name, breed, weight, livingRegion)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }

    public override void TimeToEat(Food food, int quantity)
    {
        if (food is Vegetable || food is Meat)
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

