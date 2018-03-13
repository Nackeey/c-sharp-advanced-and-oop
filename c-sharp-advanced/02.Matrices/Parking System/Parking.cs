using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int rows = int.Parse(input[0]);
        int columns = int.Parse(input[1]);
        int[][] matrix = new int[rows][];

        string command = "";
        while ((command = Console.ReadLine()) != "stop")
        {
            string[] data = command.Split();
            int entrance = int.Parse(data[0]);
            int row = int.Parse(data[1]);
            int col = int.Parse(data[2]);

            int steps = Math.Abs(entrance - row) + 1;
            if (matrix[row] == null)
            {
                matrix[row] = new int[columns];
            }

            if (matrix[row][col] == 0)
            {
                matrix[row][col] = 1;
                steps += col;
                Console.WriteLine(steps);
            }
            else
            {
                int cnt = 1;
                while (true)
                {
                    int lowerCell = col - cnt;
                    int upperCell = col + cnt;

                    if (lowerCell < 1 && upperCell > columns - 1)
                    {
                        Console.WriteLine($"Row {row} full");
                        break;
                    }
                    if (lowerCell > 0 && matrix[row][lowerCell] == 0)
                    {
                        matrix[row][lowerCell] = 1;
                        steps += lowerCell;
                        Console.WriteLine(steps);
                        break;
                    }
                    if (upperCell < columns && matrix[row][upperCell] == 0)
                    {
                        matrix[row][upperCell] = 1;
                        steps += upperCell;
                        Console.WriteLine(steps);
                        break;
                    }
                    cnt++;
                }
            }
        }
    }
}
