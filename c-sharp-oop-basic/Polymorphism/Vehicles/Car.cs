﻿using System;
using System.Collections.Generic;
using System.Text;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + 0.9)
    {
    }
}

