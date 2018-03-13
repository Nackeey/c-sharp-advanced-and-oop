using System;
using System.Collections.Generic;
using System.Text;

public class Robot : IIdentifiable
{
    private string model;
    private string id;

    public string Model { get; set; }
    public string Id { get; set; }

    public Robot(string model, string id)
    {
        Model = model;
        Id = id;
    }
}

