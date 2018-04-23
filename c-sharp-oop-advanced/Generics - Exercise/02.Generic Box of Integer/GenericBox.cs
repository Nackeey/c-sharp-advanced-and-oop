using System;
using System.Collections.Generic;
using System.Text;

public class GenericBox
{
    public static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            var someValue = int.Parse(Console.ReadLine());
            var box = new Box<int>(someValue);

            Console.WriteLine(box.ToString());
        }
    }
}
