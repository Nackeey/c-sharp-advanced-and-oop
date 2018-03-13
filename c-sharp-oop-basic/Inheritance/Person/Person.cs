using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
            this.name = value;
        }
    }

    public virtual int Age
    {
        get { return age; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            this.age = value;
        }
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(String.Format($"Name: {this.name}, Age: {this.age}"));

        return sb.ToString();
    }
}



