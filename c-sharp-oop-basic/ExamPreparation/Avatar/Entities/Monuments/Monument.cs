using System;
using System.Collections.Generic;
using System.Text;

public abstract class Monument
{
    public string Name { get; private set; }

    public Monument(string name)
    {
        this.Name = name; 
    }

    public abstract double GetMonumentBonus();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Monument");
        name = name.Insert(index, " ");

        return $"###{name}: {this.Name}, ";
    }
}

