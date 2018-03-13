using System;
using System.Linq;

namespace _180616_02_Cubics_Rube
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var particlesSum = 0L;
            int changedCells = 0;

            var inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "Analyze")
            {
                var tokens = inputLine
                    .Split(' ')
                    .Select(x => int.Parse(x))
                    .ToArray();

                if (tokens.Take(3).Any(pt => pt < 0 || pt >= size))
                {
                    continue;
                }
                else
                {
                    if (tokens[3] != 0)
                    {
                        particlesSum += tokens[3];
                        changedCells++;
                    }
                }
            }
            Console.WriteLine(particlesSum);
            Console.WriteLine(Math.Pow(size, 3) - changedCells);
        }
    }
}
