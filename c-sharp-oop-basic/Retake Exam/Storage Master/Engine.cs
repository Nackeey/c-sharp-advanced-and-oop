using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster
{
    public class Engine
    {
        private readonly StorageMaster storageManager;

        public Engine()
        {
            this.storageManager = new StorageMaster();
        }

        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                    Console.WriteLine(ProcessCommand(input)); 
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Error: " + e.Message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(storageManager.GetSummary());
        }

        private string ProcessCommand(string input)
        {
            var commandArgs = input.Split(' ');
            var command = commandArgs[0];
            var args = commandArgs.Skip(1).ToArray();

            var output = string.Empty;
            switch (command)
            {
                case "AddProduct":
                    output = storageManager.AddProduct(args[0], double.Parse(args[1]));
                    break;
                case "RegisterStorage":
                    output = storageManager.RegisterStorage(args[0], args[1]);
                    break;
                case "SelectVehicle":
                    output = storageManager.SelectVehicle(args[0], int.Parse(args[1]));
                    break;
                case "LoadVehicle":
                    output = storageManager.LoadVehicle(args);
                    break;
                case "SendVehicleTo":
                    output = storageManager.SendVehicleTo(args[0], int.Parse(args[1]), args[2]);
                    break;
                case "UnloadVehicle":
                    output = storageManager.UnloadVehicle(args[0], int.Parse(args[1]));
                    break;
                case "GetStorageStatus":
                    output = storageManager.GetStorageStatus(args[0]);
                    break;
            }
            
            return output;
        }
    }
}
