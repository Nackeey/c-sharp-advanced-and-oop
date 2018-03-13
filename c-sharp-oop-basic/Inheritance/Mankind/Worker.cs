using System;
using System.Text;

public class Worker : Human
{
    private const int workDays = 5;

    private decimal weekSalary;
    private decimal workHours;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHours)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHours = workHours;
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public decimal WorkHours
    {
        get { return this.workHours; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHours = value;
        }
    }

    private decimal CalculateSalaryPerHour()
    {
        return this.WeekSalary / (workDays * this.WorkHours);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours per day: {this.WorkHours:f2}")
            .AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():f2}");
        return sb.ToString();
    }
}

