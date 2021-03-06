﻿using System;
using System.Collections.Generic;
using System.Text;

public abstract class Mammal : Animal
{
    private string livingRegion;
    public string LivingRegion { get; set; }

    public Mammal(string name, double weight, string livingRegion)
        : base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }
}

