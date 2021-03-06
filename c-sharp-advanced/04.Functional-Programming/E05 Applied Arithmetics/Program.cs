﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace E05_Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            Func<long, long> add = n => n += 1;
            Func<long, long> multiply = n => n * 2;
            Func<long, long> subtract = n => n -= 1;

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "add": numbers = numbers.Select(add).ToList(); break;
                    case "multiply": numbers = numbers.Select(multiply).ToList(); break;
                    case "subtract": numbers = numbers.Select(subtract).ToList(); break;
                    case "print": Console.WriteLine(string.Join(" ", numbers)); break;
                    default: break;
                }
            }
        }

        
    }
}
