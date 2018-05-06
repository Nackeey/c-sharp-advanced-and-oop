using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var InitialGreenDuration = int.Parse(Console.ReadLine());
        var freeWindowDuration = int.Parse(Console.ReadLine());

        var greenLightDuration = InitialGreenDuration;
        var cars = new Queue<string>();

        int passedCars = 0;

        var input = string.Empty;

        var crashedCar = string.Empty;
        char letter = '\0';
        bool IsGreenTimeLeft = false;

        while ((input = Console.ReadLine()) != "END")
        {
            if (input != "green")
            {
                cars.Enqueue(input);
            }
            else
            {
                greenLightDuration = InitialGreenDuration;
                IsGreenTimeLeft = false;
                while (true)
                {
                    if (cars.Count == 0 || IsGreenTimeLeft)
                    {
                        break;
                    }

                    if (cars.Peek().Length < greenLightDuration)
                    {
                        greenLightDuration -= cars.Dequeue().Length;
                        passedCars++;
                    }
                    else if (cars.Peek().Length <= greenLightDuration + freeWindowDuration)
                    {
                        cars.Dequeue();
                        passedCars++;
                        IsGreenTimeLeft = true;
                    }
                    else
                    {
                        crashedCar = cars.Peek();
                        var index = greenLightDuration + freeWindowDuration;
                        letter = crashedCar[index];
                        break;
                    }
                }
            }
        }

        if (string.IsNullOrEmpty(crashedCar))
        {
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
        else
        {
            Console.WriteLine($"A crash happened!");
            Console.WriteLine($"{crashedCar} was hit at {letter}.");
        }
    }
}

