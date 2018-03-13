using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string title, string author, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Title
    {
        get { return this.title; }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

    public string Author
    {
        get { return this.author; }
        protected set
        {
            CheckIfSecondNameIsValid(value);
            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get { return this.price; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }

    private static void CheckIfSecondNameIsValid(string value)
    {
        var fullName = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (fullName.Length > 1 && char.IsDigit(fullName[1][0]))
        {
            throw new ArgumentException("Author not valid!");
        }
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }
}

