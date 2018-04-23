using System;
using System.Collections.Generic;
using System.Text;

public class CommandInterpreter
{
    public static void RunCommands(GenericDataStructure<string> list)
    {
        var command = string.Empty;
        while (command != "END")
        {
            string[] input = Console.ReadLine().Split();

            command = input[0];

            switch (command)
            {
                case "Add":
                    list.Add(input[1]);
                    break;
                case "Remove":
                    list.Remove(int.Parse(input[1]));
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains(input[1]));
                    break;
                case "Swap":
                    list.Swap(int.Parse(input[1]), int.Parse(input[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.Greater(input[1])); 
                    break;
                case "Max":
                    Console.WriteLine(list.Max()); 
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    list.Print();
                    break;
            }
        }        
    }
}

