using System;
using System.Collections.Generic;
using System.Text;

public abstract class Bird : Animal
{
    private double wingSize;
    public double WingSize { get; set; }

    public Bird(string name, double wingSize, double weight)
        : base(name, weight)
    {
        this.WingSize = wingSize;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]");
        return sb.ToString();
    }
}

