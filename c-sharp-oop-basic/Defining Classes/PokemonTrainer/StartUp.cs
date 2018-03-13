using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var trainers = GetTrainers();
        trainers = UpdateList(trainers);
        PrintTrainers(trainers);
    }

    private static void PrintTrainers(List<Trainer> trainers)
    {
        trainers
            .OrderByDescending(t => t.Badges)
            .ToList()
            .ForEach(t => Console.WriteLine(t.ToString()));
    }

    private static List<Trainer> UpdateList(List<Trainer> trainers)
    {
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "End")
        {
            trainers
                .Where(t => t.Pokemons.Any(p => p.Element == command))
                .ToList()
                .ForEach(t => t.Badges++);

            var trainersWhithoutTheElement = trainers
                                           .Where(t => t.Pokemons.All(p => p.Element != command));

            foreach (var trainer in trainersWhithoutTheElement)
            {
                trainer.Pokemons.ForEach(p => p.Health -= 10);
                trainer.Pokemons = trainer.Pokemons
                                 .Where(p => p.Health > 0)
                                 .ToList();
            }
        }
        return trainers;
    }

    private static List<Trainer> GetTrainers()
    {
        List<Trainer> trainers = new List<Trainer>();
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var trainerName = info[0];
            var pokemonName = info[1];
            var element = info[2];
            var health = int.Parse(info[3]);

            var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);
            if (trainer == null)
            {
                trainer = new Trainer(trainerName);
                trainers.Add(trainer);
            }
            trainer.Pokemons.Add(new Pokemon(pokemonName, element, health));
        }
        return trainers;
    }
}

