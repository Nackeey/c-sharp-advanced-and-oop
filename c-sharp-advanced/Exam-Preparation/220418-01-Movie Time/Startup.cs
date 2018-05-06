using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var favGenre = Console.ReadLine();
        var favMovieDuration = Console.ReadLine();

        var dict = new Dictionary<string, Dictionary<string, string>>();

        var input = string.Empty;
        while ((input = Console.ReadLine()) != "POPCORN!")
        {
            var movieArgs = input.Split('|');

            var name = movieArgs[0];
            var genre = movieArgs[1];
            var duration = movieArgs[2];

            if (!dict.ContainsKey(name))
            {
                dict[name] = new Dictionary<string, string>();
            }

            if (!dict[name].ContainsKey(genre))
            {
                dict[name][genre] = duration;
            }
        }

        var ordered = new Dictionary<string, Dictionary<string, string>>();
        if (favMovieDuration == "Short")
        {
            ordered = dict
                .Where(m => m.Value.Keys.Contains(favGenre))
                .OrderBy(m => m.Value.Values.Min())
                .ToDictionary(k => k.Key, k=> k.Value);   
        }
        else
        {
            ordered = dict
                .Where(m => m.Value.Keys.Contains(favGenre))
                .OrderByDescending(m => m.Value.Values.Min())
                .ToDictionary(k => k.Key, k => k.Value); ;
        }

        var currentMovie = string.Empty;
        foreach (var movieName in ordered)
        {
            Console.WriteLine(movieName.Key);
            currentMovie = movieName.Key;

            var answer = Console.ReadLine();
            if (answer == "Yes")
            {
                break;
            }
        }

        Console.WriteLine($"We're watching {currentMovie} - {dict[currentMovie][favGenre]}");

        TimeSpan playlistDuration = new TimeSpan();

        foreach (var item in dict)
        {
            foreach (var movie in item.Value.Values)
            {
                var duration = TimeSpan.Parse(movie);
                playlistDuration += duration;
            }
        }

        Console.WriteLine($"Total Playlist Duration: {playlistDuration}");
    }
}

