using System;
using System.Linq;
using System.Collections.Generic;

class Lego
{
    static void Main()
    {
        int numberOfRows = int.Parse(Console.ReadLine());

        var firstJagged = FillTheRows(numberOfRows);
        var secondJagged = FillTheRows(numberOfRows);

        for (int row = 0; row < numberOfRows; row++)
        {
            secondJagged[row] = secondJagged[row].Reverse().ToArray();
        }

        var completedJag = MakeOneFromTwoMatrix(firstJagged, secondJagged);

        if (IsItFit(completedJag))
        {
            foreach (var row in completedJag)
            {
                Console.WriteLine($"[{string.Join(", ", row)}]");
            }
        }
        else
        {
            Console.WriteLine($"The total number of cells is: {GetNumberOfCells(completedJag)}");
        }
    }

    private static int GetNumberOfCells(int[][] completedJag)
    {
        int totalSum = 0;
        for (int row = 0; row < completedJag.GetLength(0); row++)
        {
            totalSum += completedJag[row].Length;
        }
        return totalSum;
    }

    private static bool IsItFit(int[][] completedJag)
    {
        bool isIt = false;
        for (int row = 0; row < completedJag.GetLength(0) - 1; row++)
        {
            if (completedJag[row].Length == completedJag[row + 1].Length)
            {
                isIt = true;
            }
            else
            {
                isIt = false;
            }
        }
        return isIt;
    }

    private static int[][] MakeOneFromTwoMatrix(int[][] firstJag, int[][] secondJag)
    {
        int[][] completedJag = new int[firstJag.GetLength(0)][];
        var allElements = new List<int>();

        for (int row = 0; row < firstJag.GetLength(0); row++)
        {
            allElements.AddRange(firstJag[row]);
            allElements.AddRange(secondJag[row]);
            completedJag[row] = allElements.ToArray();
            allElements.Clear();
        }
        return completedJag;
    }

    private static int[][] FillTheRows(int numberOfRows)
    {
        var jagged = new int[numberOfRows][];
        for (int row = 0; row < numberOfRows; row++)
        {
            jagged[row] = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        return jagged;
    }
}

