using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    class Program
    {
        static void Main()
        {
            var matrix = GetTheMatrix();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Nuke it from orbit")
            {
                int[] commands = input.Split().Select(int.Parse).ToArray();
                int hitRow = commands[0];
                int hitCol = commands[1];
                int radius = commands[2];

                RemoveDestroyedElementsInMatrix(matrix, hitRow, hitCol, radius);
                RemoveEmptyRowsInMatrix(matrix);
            }

            PrintMatrix(matrix);
        }

        private static void RemoveDestroyedElementsInMatrix(List<List<int>> matrix, int hitRow, int hitCol, int radius)
        {
            for (int row = Math.Max(0, hitRow - radius); row <= Math.Min(hitRow + radius, matrix.Count - 1); row++)
            {
                var resultRow = new List<int>();
                for (int col = 0; col < matrix[row].Count; col++)
                {
                    if (!IsElementDestroyed(matrix, row, col, hitRow, hitCol, radius))
                    {
                        resultRow.Add(matrix[row][col]);
                    }
                }
                matrix[row] = resultRow.ToList();
            }
        }

        private static void RemoveEmptyRowsInMatrix(List<List<int>> matrix)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                if (matrix[row].Count == 0)
                {
                    matrix.RemoveAt(row);
                    row--;
                }
            }
        }

        private static bool IsElementDestroyed(List<List<int>> matrix, int row, int col, int hitRow, int hitCol, int radius)
        {
            if (col == hitCol) return true;
            if (row == hitRow &&
                col >= Math.Max(hitCol - radius, 0) &&
                col <= Math.Min(hitCol + radius, matrix[row].Count - 1)) return true;
            return false;
        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static List<List<int>> GetTheMatrix()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            var matrix = new List<List<int>>();
            int counter = 1;

            for (int row = 0; row < rows; row++)
            {
                matrix.Add(new List<int>());
                for (int col = 0; col < cols; col++)
                {
                    matrix[row].Add(counter++);
                }
            }
            return matrix;
        }
    }
}
