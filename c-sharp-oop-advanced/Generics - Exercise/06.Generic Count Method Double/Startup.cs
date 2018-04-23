using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var list = GetList();
        var element = double.Parse(Console.ReadLine());

        Console.WriteLine(CountTheGreaters(list, element));
    }

    private static int CountTheGreaters<T>(List<T> collection, T element)
        where T : IComparable
    {
        return collection.Count(x => x.CompareTo(element) > 0);
    }

    private static List<IComparable> GetList()
    {
        var lines = int.Parse(Console.ReadLine());
        var list = new List<IComparable>();
        for (int i = 0; i < lines; i++)
        {
            var element = double.Parse(Console.ReadLine());
            list.Add(element);
        }

        return list;
    }
}

