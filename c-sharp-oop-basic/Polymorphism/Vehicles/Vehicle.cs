using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;

    protected double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }

    protected double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    protected Vehicle(double fuelQuantity, double fuelConsumption)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public virtual void Drive(double distance)
    {
        if (this.fuelQuantity < distance * this.fuelConsumption)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else
        {
            this.fuelQuantity -= distance * this.fuelConsumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }

    public virtual void Refuel(double fuel)
    {
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }

}

