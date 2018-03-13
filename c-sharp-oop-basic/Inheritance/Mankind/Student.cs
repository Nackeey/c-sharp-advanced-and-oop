using System;
using System.Text;
using System.Text.RegularExpressions;

public class Student : Human
{
    private const string facultyValidation = @"^[A-Za-z\d]{5,10}$";
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.Length < 5 || value.Length > 10)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            if (!Regex.IsMatch(value, facultyValidation))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString())
        .AppendLine($"Faculty number: {this.FacultyNumber}");

        return sb.ToString();
    }
}
