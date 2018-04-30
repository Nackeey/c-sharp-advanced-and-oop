using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities
{
    public abstract class Storage
    {
        private readonly Vehicle[] garage;
        private readonly List<Product> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.garage = new Vehicle[garageSlots];
            this.products = new List<Product>();

            this.InitializeGarage(vehicles);
        }

        public string Name { get; }

        public int Capacity { get; }

        public int GarageSlots { get; }

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        public bool IsFull => this.products.Sum(p => p.Weight) >= this.Capacity;

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= garage.Length)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            var vehicle = this.garage[garageSlot];
            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var vehicle = GetVehicle(garageSlot);

            if (!deliveryLocation.garage.Any(s => s == null))
            {
                throw new InvalidOperationException("No room in garage!");
            }

            int openArray = 0;

            for (int i = 0; i < deliveryLocation.garage.Length; i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    openArray = i;
                    break;
                }
            }

            deliveryLocation.garage[openArray] = vehicle;

            return openArray;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            var vehicle = GetVehicle(garageSlot);

            int unloadedProducts = 0;

            while (vehicle.Trunk.Count > 0)
            {
                foreach (var product in vehicle.Trunk)
                {
                    this.products.Add(product);

                    unloadedProducts++;

                    if (this.IsFull)
                    {
                        break;
                    }
                }

                break;
            }

            return unloadedProducts;
        }

        private void InitializeGarage(IEnumerable<Vehicle> vehicles)
        {
            var garageSlot = 0;
            foreach (var vehicle in vehicles)
            {
                this.garage[garageSlot++] = vehicle;
            }
        }
    }
}
