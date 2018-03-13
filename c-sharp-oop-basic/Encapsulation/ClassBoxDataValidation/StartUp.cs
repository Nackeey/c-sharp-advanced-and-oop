using System;

public class StartUp
{
    public static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        try
        {
            var box = new Box(length, width, height);

            double surfaceArea = box.SurfaceArea();
            double lateralSurfaceArea = box.LateralSurfaceArea();
            double volume = box.Volume();

            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
            Console.WriteLine($"Volume - {volume:f2}");
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}

