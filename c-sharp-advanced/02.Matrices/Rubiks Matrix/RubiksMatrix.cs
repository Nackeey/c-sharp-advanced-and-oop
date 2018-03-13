using System;
using System.Linq;

class RubiksMatrix
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = sizes[0];
        int cols = sizes[1];
        int[][] matrix = FillTheMatrix(rows, cols);

        int commandsCount = int.Parse(Console.ReadLine());

        for (int command = 0; command < commandsCount; command++)
        {
            var args = Console.ReadLine()
                      .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();
            var index = int.Parse(args[0]);
            var direction = args[1];
            var steps = int.Parse(args[2]);

            switch (direction)
            {
                case "up":
                    RotateMatrixCol(matrix, index, steps);
                    break;
                case "down":
                    RotateMatrixCol(matrix, index, rows - steps % rows);
                    break;
                case "left":
                    RotateMatrixRow(matrix, index, steps);
                    break;
                case "right":
                    RotateMatrixRow(matrix, index, cols - steps % cols);
                    break;
            }
            //PrintMatrix(matrix);
        }

        var element = 1;
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[row][col] == element)
                {
                    Console.WriteLine("No swap required");
                }
                else
                {
                    for (int r = 0; r < matrix.Length; r++)
                    {
                        for (int c = 0; c < matrix[0].Length; c++)
                        {
                            if (matrix[r][c] == element)
                            {
                                var currentNum = matrix[row][col];
                                matrix[row][col] = element;
                                matrix[r][c] = currentNum;
                                Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                break;
                            }             
                        }
                    }
                }
                element++;
            }
        }
    }

    private static void RotateMatrixRow(int[][] matrix, int index, int steps)
    {
        var temp = new int[matrix[0].Length];
        for (int col = 0; col < matrix[0].Length; col++)
        {
            temp[col] = matrix[index][(col + steps) % matrix[0].Length];
        }
        matrix[index] = temp;
    }

    private static int[][] RotateMatrixCol(int[][] matrix, int index, int steps)
    {
        var temp = new int[matrix.Length];
        for (int row = 0; row < matrix.Length; row++)
        {
            temp[row] = matrix[(row + steps) % matrix.Length][index];
        }
        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row][index] = temp[row];
        }
        return matrix;
    }

    private static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }

    private static int[][] FillTheMatrix(int rows, int cols)
    {
        int[][] matrix = new int[rows][];
        int counter = 1;

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new int[cols];
            for (int col = 0; col < cols; col++)
            {
                matrix[row][col] = counter++;
            }
        }
        return matrix;
    }
}

