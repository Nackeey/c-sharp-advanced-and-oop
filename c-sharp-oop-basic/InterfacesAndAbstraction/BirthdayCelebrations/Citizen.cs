using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IIdentifiable, IBirthable
{
    private string name;
    private int age;
    private string id;
    private string birthdate;

    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public string Birthdate { get; set; }

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }
}

