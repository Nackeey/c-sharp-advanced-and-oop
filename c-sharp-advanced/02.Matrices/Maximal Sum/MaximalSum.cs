using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = sizes[0];

        var matrix = new int[rows][];
        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        int maxSum = int.MinValue;
        var biggestSubMatrix = new int[3][];

        for (int row = 0; row < matrix.Length - 2; row++)
        {
            for (int col = 0; col < matrix[row].Length - 2; col++)
            {
                int currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                 matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                                 matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;

                    biggestSubMatrix[0] = new int[] { matrix[row][col], matrix[row][col + 1], matrix[row][col + 2] };
                    biggestSubMatrix[1] = new int[] { matrix[row + 1][col], matrix[row + 1][col + 1], matrix[row + 1][col + 2] };
                    biggestSubMatrix[2] = new int[] { matrix[row + 2][col], matrix[row + 2][col + 1], matrix[row + 2][col + 2] };
                }
            }
        }
        Console.WriteLine($"Sum = {maxSum}");

        foreach (var row in biggestSubMatrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}

