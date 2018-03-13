using System;

public class Truck : Vehicle
{
    private const double fuelConsumptionIncrease = 1.6;
    private const double fuelEfficiency = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption + fuelConsumptionIncrease, tankCapacity)
    {
    }

    public override void Refuel(double liters)
    {
        if (base.TankCapacity < liters)
        {
            throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
        }
        base.Refuel(liters * fuelEfficiency);
    }
}


