using System;
using System.Collections.Generic;
using System.Linq;

public class TruckTour
{
    public static void Main()
    {
        int pumpsCount = int.Parse(Console.ReadLine());
        var pumps = new Queue<long[]>();

        for (int i = 0; i < pumpsCount; i++)
        {
            long[] infoForEachPump = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            pumps.Enqueue(infoForEachPump);
        }

        for (int pumpIndex = 0; pumpIndex < pumpsCount; pumpIndex++)
        {
            long petrol = 0;
            long distance = 0;
            bool isCompleteTour = true;

            foreach (var pump in pumps)
            {
                petrol += pump[0];
                distance += pump[1];
                if (petrol < distance)
                {
                    isCompleteTour = false;
                    break;
                }
            }
            if (isCompleteTour)
            {
                Console.WriteLine(pumpIndex);
                break;
            }
            pumps.Enqueue(pumps.Dequeue());
        }
    }
}

