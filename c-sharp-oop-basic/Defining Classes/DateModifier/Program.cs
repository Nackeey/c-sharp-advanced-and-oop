using System;

public class Program
{
    static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();
        Console.WriteLine(DateModifier.GetDateDifference(firstDate, secondDate));
    }
}

