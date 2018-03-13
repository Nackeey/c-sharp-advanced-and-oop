using System;
using System.Collections.Generic;

public class Traffic_Lights
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = string.Empty;

        int totalCarPassed = 0;
        var queueOfCars = new Queue<string>();

        while ((input = Console.ReadLine()) != "end")
        {
            if (input != "green")
            {
                queueOfCars.Enqueue(input);
            }
            else
            {
                if (queueOfCars.Count == 0)
                {
                    continue;
                }
                int numberOfCars = n > queueOfCars.Count ? queueOfCars.Count : n;

                for (int i = 0; i < numberOfCars; i++)
                {
                    Console.WriteLine($"{queueOfCars.Dequeue()} passed!");
                }
                totalCarPassed += numberOfCars;
            }
        }
        Console.WriteLine($"{totalCarPassed} cars passed the crossroads.");
    }
}