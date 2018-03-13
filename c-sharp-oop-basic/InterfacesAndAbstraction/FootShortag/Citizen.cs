using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthdate;
    private int food;

    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public string Birthdate { get; set; }
    public int Food { get; set; }

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    public void BuyFood()
    {
        this.Food += 10;
    }
}

