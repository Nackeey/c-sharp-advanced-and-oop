using System;
using System.Collections.Generic;
using System.Text;

public class Pet : IBirthable
{
    private string name;
    private string birthdate;

    public string Name { get; set; }
    public string Birthdate { get; set; }

    public Pet(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }
}

