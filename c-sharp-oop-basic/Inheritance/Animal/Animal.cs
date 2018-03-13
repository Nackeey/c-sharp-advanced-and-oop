using System;
using System.Collections.Generic;
using System.Text;
public class Animal : IProduceSound
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            this.age = value;
        }
    }

    public virtual string Gender
    {
        get { return this.gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.gender = value;
        }
    }

    public virtual string SayMoo()
    {
        return "Moooo";
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.GetType().Name)
            .AppendLine($"{this.Name} {this.Age} {this.Gender}")
            .AppendLine($"{this.SayMoo()}");
        return sb.ToString();
    }
}

