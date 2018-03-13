using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    string name;
    decimal salary;
    string position;
    string department;
    string email;
    int age;

    public string Name
    {
        get { return this.name; }
    }

    public decimal Salary
    {
        get { return this.salary; }
    }

    public string Position
    {
        get { return this.position; }
    }

    public string Departmend
    {
        get { return this.department; }
    }

    public string Email
    {
        get { return this.email; }
    }

    public int Age
    {
        get { return this.age; }
    }

    public Employee(string name, decimal salary, string position, string department, string email, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }

}
