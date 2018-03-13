using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double length;

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    private double width;

    public double Width
    {
        get { return width; }
        set
        {
            this.width = value;
        }
    }

    private double height;

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double SurfaceArea(double length, double width, double height)
    {
        double surfaceArea = (2 * length * width) + (2 * length * height) + (2 * width * height);
        return surfaceArea;
    }

    public double LateralSurfaceArea(double length, double width, double height)
    {
        double lateralSurfaceArea = (2 * length * height) + (2 * width * height);
        return lateralSurfaceArea;
    }

    public double Volume(double length, double width, double height)
    {
        double volume = length * width * height;
        return volume;
    }
}

