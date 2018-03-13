using System;
using System.Collections.Generic;
using System.Text;

public class WaterMonument : Monument
{
    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    private int WaterAffinity { get; set; }

    public override double GetMonumentBonus()
    {
        return this.WaterAffinity;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Water Affinity: {this.WaterAffinity}";
    }
}

