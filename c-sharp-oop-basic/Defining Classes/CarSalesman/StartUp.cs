using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();

        int numberOfEngines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfEngines; i++)
        {
            Engine engine = null;
            int displacement = 0;
            string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (engineInfo.Length == 2)
            {
                engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]));
            }
            else if (engineInfo.Length == 4)
            {
                engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2]), engineInfo[3]);
            }
            else if (engineInfo.Length == 3 && int.TryParse(engineInfo[2], out displacement))
            {
                engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]), displacement);
            }
            else
            {
                engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]), engineInfo[2]);
            }
            engines.Add(engine);
        }
        int numberOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCars; i++)
        {
            string[] carsInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Car car = null;
            Engine engine = engines.First(e => e.model == carsInfo[1]);
            int weight = 0;
            if (carsInfo.Length == 2)
            {
                car = new Car(carsInfo[0], engine);
            }
            else if (carsInfo.Length == 4)
            {
                car = new Car(carsInfo[0], engine, int.Parse(carsInfo[2]), carsInfo[3]);
            }
            else if (carsInfo.Length == 3 && int.TryParse(carsInfo[2], out weight))
            {
                car = new Car(carsInfo[0], engine, weight);
            }
            else
            {
                car = new Car(carsInfo[0], engine, carsInfo[2]);
            }
            cars.Add(car);
        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.model}:");
            Console.WriteLine($"  {car.engine.model}:");
            Console.WriteLine($"    Power: {car.engine.power}");
            Console.WriteLine("    Displacement: {0}", car.engine.displacement == -1 ? @"n/a" : car.engine.displacement.ToString());
            Console.WriteLine("    Efficiency: {0}", car.engine.efficiency);
            Console.WriteLine("  Weight: {0}", car.weight == -1 ? @"n/a" : car.weight.ToString());
            Console.WriteLine($"  Color: {car.color}");

        }
    }
}

