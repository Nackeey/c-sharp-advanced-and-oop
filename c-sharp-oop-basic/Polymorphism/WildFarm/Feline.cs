using System;
using System.Collections.Generic;
using System.Text;

public abstract class Feline : Mammal
{
    private string breed;

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }
    public Feline(string name, string breed, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
        this.Breed = breed;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]");
        return sb.ToString();
    }
}

