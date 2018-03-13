using System;

public class StartUp
{
    public static void Main()
    {
        Smartphone smartphone = new Smartphone();

        var phoneNumbers = Console.ReadLine().Split();
        foreach (var number in phoneNumbers)
        {
            Console.WriteLine(smartphone.MakeCall(number));
        }

        var websites = Console.ReadLine().Split();
        foreach (var website in websites)
        {
            Console.WriteLine(smartphone.BrowseTheNet(website));
        }
    }
}

