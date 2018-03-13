using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private double fuelAmount;
    private double consumption;
    private double distanceTraveled;

    public Car(string model, int fuelAmount, double consumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.consumption = consumption;
        this.distanceTraveled = 0;
    }

    public string Model => this.model;


    public void Drive(int distance)
    {
        if (this.consumption * distance <= this.fuelAmount)
        {
            this.distanceTraveled += distance;
            this.fuelAmount -= this.consumption * distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{this.model} {this.fuelAmount:f2} {this.distanceTraveled}";
    }
}

