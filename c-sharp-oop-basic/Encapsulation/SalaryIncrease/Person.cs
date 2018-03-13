﻿using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName
    {
        get => this.firstName;
    }

    public string LastName
    {
        get => this.lastName;
    }

    public int Age
    {
        get => this.age;
    }

    public decimal Salary
    {
        get => this.salary;
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;   
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.age > 30)
        {
            this.salary += this.salary * percentage / 100;
        }
        else
        {
            this.salary += this.salary * percentage / 200;
        }
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
    }
}

