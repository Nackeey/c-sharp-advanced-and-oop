using System;
using System.Text;

public class Dog : Mammal
{
    private const double weightIncreaseBy = 0.40;

    public Dog(string name, double weight, string livingRegion)
    : base(name, weight, livingRegion)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Woof!");
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

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]");
        return sb.ToString();
    }
}

