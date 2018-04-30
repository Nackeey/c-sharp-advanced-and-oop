﻿using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Factories
{
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            Vehicle vehicle;
            switch (type)
            {
                case "Truck":
                    vehicle = new Truck();
                    break;
                case "Semi":
                    vehicle = new Semi();
                    break;
                case "Van":
                    vehicle = new Van();
                    break;
                default:
                    throw new InvalidOperationException($"Invalid vehicle type!");
            }

            return vehicle;
        }
    }
}
