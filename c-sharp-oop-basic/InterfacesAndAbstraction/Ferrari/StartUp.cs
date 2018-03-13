using System;

public class StartUp
{
    public static void Main()
    {
        string driverName = Console.ReadLine();
        var ferrari = new Ferrari("488-Spider", driverName);
        Console.WriteLine(ferrari.ToString());
    }
}

