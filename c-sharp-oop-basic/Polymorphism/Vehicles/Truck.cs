using System;
using System.Collections.Generic;
using System.Text;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + 1.6)
    {
    }

    public override void Refuel(double fuel)
    {
        base.Refuel(fuel * 0.95);
    }
}

