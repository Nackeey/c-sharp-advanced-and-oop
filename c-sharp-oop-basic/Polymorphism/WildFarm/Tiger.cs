using System;
using System.Collections.Generic;
using System.Text;

public class Tiger : Feline
{
    public const double weightIncreaseBy = 1.00;
    

    public Tiger(string name, string breed, double weight, string livingRegion)
        : base(name, breed, weight, livingRegion)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("ROAR!!!");
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

