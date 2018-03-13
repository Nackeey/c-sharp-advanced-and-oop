using System;
using System.Collections.Generic;
using System.Text;

public class Mouse : Mammal
{
    public const double weightIncreaseBy = 0.10;
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Squeak");
    }

    public override void TimeToEat(Food food, int quantity)
    {
        if (food is Vegetable || food is Fruit)
        {
            this.Weight += (weightIncreaseBy * quantity);
            this.FoodEaten += quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]");
        return sb.ToString();
    }
}


