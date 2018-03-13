using System;
using System.Collections.Generic;
using System.Text;

public class Box
{ 
    private double length;

    public double Length
    {
        get { return this.length; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    private double width;

    public double Width
    {
        get { return this.width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    private double height;

    public double Height
    {
        get { return this.height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double SurfaceArea()
    {
        return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
    }

    public double LateralSurfaceArea()
    {
        return (2 * this.length * this.height) + (2 * this.width * this.height);
    }

    public double Volume()
    {
        return this.length * this.width * this.height;
    }
}

