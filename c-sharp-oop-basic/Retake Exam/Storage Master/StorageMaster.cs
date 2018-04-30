using StorageMaster.Entities;
using StorageMaster.Entities.Vehicles;
using StorageMaster.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster
{
    public class StorageMaster
    {
        private readonly Dictionary<string, Storage> storageRegistry;
        private readonly Dictionary<string, Stack<Product>> productPool;

        private readonly ProductFactory productFactory;
        private readonly StorageFactory storageFactory;

        private Vehicle currentVehicle;

        public StorageMaster()
        {
            this.productPool = new Dictionary<string, Stack<Product>>();
            this.storageRegistry = new Dictionary<string, Storage>();
            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
        }

        public Vehicle Vehicle { get; set; }

        public string AddProduct(string type, double price)
        {
            if (!this.productPool.ContainsKey(type))
            {
                this.productPool[type] = new Stack<Product>();
            }

            var product = productFactory.CreateProduct(type, price);

            this.productPool[type].Push(product);

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            var storage = storageFactory.CreateStorage(type, name);

            this.storageRegistry[storage.Name] = storage;

            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            var storage = this.storageRegistry[storageName];

            this.currentVehicle = storage.GetVehicle(garageSlot);

            return $"Selected {currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductCount = 0;

            foreach (var productName in productNames)
            {
                if (this.currentVehicle.IsFull)
                {
                    break;
                }

                if (!this.productPool.ContainsKey(productName) || !this.productPool[productName].Any())
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
                }

                var product = this.productPool[productName].Pop();

                this.currentVehicle.LoadProduct(product);

                loadedProductCount++;
            }

            return $"Loaded {loadedProductCount}/{productNames.Count()} products into {currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!this.storageRegistry.ContainsKey(sourceName))
            {
                throw new InvalidOperationException($"Invalid source storage!");
            }

            if (!this.storageRegistry.ContainsKey(destinationName))
            {
                throw new InvalidOperationException($"Invalid destination storage!");
            }

            var sourceStorage = this.storageRegistry[sourceName];
            var destinatianStorage = this.storageRegistry[destinationName];

            int vehiclePosition = sourceStorage.SendVehicleTo(sourceGarageSlot, destinatianStorage);

            var vehicleType = sourceStorage.GetVehicle(sourceGarageSlot);

            return $"Sent {vehicleType.GetType().Name} to {destinationName} (slot {vehiclePosition})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            var storage = this.storageRegistry[storageName];
            var vehicle = storage.GetVehicle(garageSlot);

            var productsInVehicle = vehicle.Trunk.Count();

            var unloadedProducts = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProducts}/{productsInVehicle} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            var storage = this.storageRegistry[storageName];

            var storageInfo = storage.Products.GroupBy(p => p.GetType().Name)
                .Select(g => new
                {
                    Name = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(p => p.Count)
                .ThenBy(p => p.Name)
                .Select(p => $"{p.Name} ({p.Count})")
                .ToArray();

            var productsCapacity = storage.Products.Sum(p => p.Weight);

            var stockFormat = string.Format("Stock ({0}/{1}): [{2}]",
                productsCapacity,
                storage.Capacity,
                string.Join(", ", storageInfo));

            var garage = storage.Garage.ToArray();
            var vehicleNames = garage.Select(vehicle => vehicle?.GetType().Name ?? "empty").ToArray();

            var garageFormat = string.Format("Garage: [{0}]", string.Join("|", vehicleNames));
            return stockFormat + Environment.NewLine + garageFormat;
        }

        public string GetSummary()
        {
            var sb = new StringBuilder();

            foreach (var storage in storageRegistry.OrderByDescending(p => p.Value.Products.Sum(x => x.Price)))
            {
                var totalMoney = storage.Value.Products.Sum(p => p.Price);
                    
                sb.AppendLine($"{storage.Key}:");
                sb.AppendLine($"Storage worth: ${totalMoney:F2}");
            }

            return sb.ToString().Trim();
        }
    }
}
