using System;
using System.Linq;

class SquaresInMatrix
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int rows = sizes[0];
        var matrix = new char[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine()
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .SelectMany(x => x.ToCharArray())
                            .ToArray();
        }
        int counter = 0;

        for (int row = 0; row < matrix.Length - 1; row++)
        {
            for (int col = 0; col < matrix[row].Length - 1; col++)
            {
                if (matrix[row][col].Equals(matrix[row][col + 1]) &&
                    matrix[row + 1][col].Equals(matrix[row + 1][col + 1]) &&
                    matrix[row][col].Equals(matrix[row + 1][col + 1]))
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}
