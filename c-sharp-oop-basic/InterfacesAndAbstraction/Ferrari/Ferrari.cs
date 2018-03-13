using System;
using System.Collections.Generic;
using System.Text;

public class Ferrari : ICar
{
    private string model;
    private string driver;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Driver        
    {
        get { return driver; }
        set { driver = value; }
    }

    public Ferrari(string model, string driver)
    {
        Model = model;
        Driver = driver;
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string UseGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.UseBrakes()}/{this.UseGasPedal()}/{this.Driver}";
    }
}

