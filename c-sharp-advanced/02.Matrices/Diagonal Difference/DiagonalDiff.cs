using System;
using System.Linq;

class DiagonalDiff
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] square = new int[n, n];

        for (int row = 0; row < square.GetLength(0); row++)
        {
            int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            for (int col = 0; col < square.GetLength(1); col++)
            {
                square[row, col] = numbers[col];
            }
        }
        int difference = Math.Abs(LeftDiagonal(square, n, n) - RightDiagonal(square, n, n));

        Console.WriteLine(difference);
    }

    private static int LeftDiagonal(int[,] matrix, int row, int col)
    {
        int x = 0;
        for (int i = 0; i < Math.Min(row, col); ++i)
            x += matrix[i, i];
        return x;
    }

    private static int RightDiagonal(int[,] matrix, int row, int col)
    {
        int x = 0;
        for (int i = 0; i < Math.Min(row, col); ++i)
            x += matrix[row - 1 - i, i];
        return x;
    }
}
