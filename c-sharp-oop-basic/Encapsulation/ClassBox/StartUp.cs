using System;

public class StartUp
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        var box = new Box();

        double surfaceArea = box.SurfaceArea(length, width, height);
        double lateralSurfaceArea = box.LateralSurfaceArea(length, width, height);
        double volume = box.Volume(length, width, height);

        Console.WriteLine($"Surface Area - {surfaceArea:f2}");
        Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
        Console.WriteLine($"Volume - {volume:f2}");
    }
}

