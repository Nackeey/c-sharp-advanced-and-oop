using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main(string[] args)
    {
        var list = new List<string>();

        int lines = int.Parse(Console.ReadLine());  
        for (int i = 0; i < lines; i++)
        {
            var element = Console.ReadLine();
            list.Add(element);
        }

        var swapCommand = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var box = new Box<string>();
        box.SwapElements(list, swapCommand[0], swapCommand[1]);

        foreach (var element in list)
        {
            Console.WriteLine($"{element.GetType().FullName}: {element}");
        }
    }
}

