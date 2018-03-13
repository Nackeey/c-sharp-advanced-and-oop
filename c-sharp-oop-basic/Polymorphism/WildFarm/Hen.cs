using System;
using System.Collections.Generic;
using System.Text;

public class Hen : Bird
{
    public const double weightIncreaseBy = 0.35;
    public Hen(string name, double wingSize, double weight)
        : base(name, wingSize, weight)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Cluck");
    }

    public override void TimeToEat(Food food, int quantity)
    {
        this.Weight += (weightIncreaseBy * quantity);
        this.FoodEaten += quantity;
    }
}

