﻿using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IIdentifiable
{
    private string name;
    private int age;
    private string id;

    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }

    public Citizen(string name, int age, string id)
    {
        Name = name;
        Age = age;
        Id = id;
    }
}

