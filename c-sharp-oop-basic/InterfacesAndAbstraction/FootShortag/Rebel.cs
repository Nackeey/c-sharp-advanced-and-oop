using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : IBuyer
{
    private string name;
    private int age;
    private string group;
    private int food;

    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
        Food = food;
    }

    public int Food { get; set; }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public void BuyFood()
    {
        this.Food += 5;
    }

    

}

