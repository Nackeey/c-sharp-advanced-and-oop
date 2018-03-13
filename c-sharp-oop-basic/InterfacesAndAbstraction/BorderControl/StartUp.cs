using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<IIdentifiable> identifiable = new List<IIdentifiable>();

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            var commands = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (commands.Count() == 3)
            {
                IIdentifiable citizen = new Citizen(commands[0], int.Parse(commands[1]), commands[2]);
                identifiable.Add(citizen);
            }
            else
            {
                IIdentifiable robot = new Robot(commands[0], commands[1]);
                identifiable.Add(robot);
            }
        }

        string fakeId = Console.ReadLine();
        foreach (var id in identifiable.Where(x => x.Id.EndsWith(fakeId)))
        {
            Console.WriteLine(id.Id);
        }
    }
}

