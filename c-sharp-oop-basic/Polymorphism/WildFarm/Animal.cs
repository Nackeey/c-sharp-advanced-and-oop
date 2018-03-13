using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal
{
    private string name;
    private double weight;
    private int foodEaten;

    public string Name { get; set; }
    public double Weight { get; set; }
    public int FoodEaten { get; set; }

    protected Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
        FoodEaten = foodEaten;
    }

    public abstract void ProduceSound();

    public abstract void TimeToEat(Food food, int quantity);

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("");
        return sb.ToString();
    }
}

