using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        var cars = GetCars();

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] driveInfo = input.Split();
            string model = driveInfo[1];
            int amountOfKm = int.Parse(driveInfo[2]);

            if (cars.ContainsKey(model))
            {
                cars[model].Drive(amountOfKm);
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.Value.ToString());
        }
    }

    private static Dictionary<string, Car> GetCars()
    {
        int inputCars = int.Parse(Console.ReadLine());
        var cars = new Dictionary<string, Car>();

        for (int i = 0; i < inputCars; i++)
        {
            string[] info = Console.ReadLine().Split(' ');
            var car = new Car(info[0], int.Parse(info[1]), double.Parse(info[2]));
            if (!cars.ContainsKey(car.Model))
            {
                cars[car.Model] = car;
            }
        }

        return cars;
    }
}
