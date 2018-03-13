using System;

public class StartUp
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        try
        {
            var child = new Child(name, age);
            Console.WriteLine(child);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}



