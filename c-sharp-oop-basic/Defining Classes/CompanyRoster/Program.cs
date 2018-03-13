using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        var employees = new List<Employee>();

        for (int i = 0; i < lines; i++)
        {
            string[] info = Console.ReadLine().Split(' ');

            var name = info[0];
            var salary = decimal.Parse(info[1]);
            var position = info[2];
            var department = info[3];
            string email = "n/a";
            int age = -1;

            if (info.Length == 5)
            {
                if (info[4].Contains('@'))
                {
                    email = info[4];
                }
                else
                {
                    age = int.Parse(info[4]);
                }
            }
            else if (info.Length == 6)
            {
                email = info[4];
                age = int.Parse(info[5]);
            }

            var person = new Employee(name, salary, position, department, email, age);

            employees.Add(person);
        }

        var result = employees
            .GroupBy(e => e.Departmend)
            .Select(e => new
            {
                Department = e.Key,
                AverageSalary = e.Average(emp => emp.Salary),
                Employees = e.OrderByDescending(emp => emp.Salary).ToList()
            })
            .OrderByDescending(e => e.AverageSalary)
            .FirstOrDefault();

        if (result != null)
        {
            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
        
    }
}

