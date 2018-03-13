using System;
using System.Linq;

namespace _030917_Dangerous_Floor
{
    class Program
    {
        static void Main()
        {
            var board = GetBoard();

            string move = string.Empty;
            while ((move = Console.ReadLine()) != "END")
            {
                char symbol = move[0];
                int initialRow = (int)Char.GetNumericValue(move[1]);
                int initialCol = (int)Char.GetNumericValue(move[2]);
                int nextRow = (int)Char.GetNumericValue(move[4]);
                int nextCol = (int)Char.GetNumericValue(move[5]);

                if (board[initialRow][initialCol] != symbol)
                {
                    Console.WriteLine($"There is no such a piece!");
                }
                else
                {
                    if (!IsInsideTheBoard(nextRow, nextCol, board))
                    {
                        Console.WriteLine($"Move go out of board!");
                    }
                    else
                    {
                        if (MoveIsCorrect(symbol, initialRow, initialCol, nextRow, nextCol))
                        {
                            board[nextRow][nextCol] = symbol;
                            board[initialRow][initialCol] = 'x';
                            continue;
                        }
                        Console.WriteLine($"Invalid move!");
                    }
                }
            }
        }

        private static bool MoveIsCorrect(char symbol, int initialRow, int initialCol, int nextRow, int nextCol)
        {
            switch (symbol)
            {
                case 'K':
                    return initialRow == nextRow && Math.Abs(initialCol - nextCol) == 1 ||
                    initialCol == nextCol && Math.Abs(initialRow - nextRow) == 1 ||
                    Math.Abs(initialRow - nextRow) == 1 && Math.Abs(initialCol - nextCol) == 1;
                case 'R':
                    return initialRow == nextRow || initialCol == nextCol;
                case 'B':
                    return Math.Abs(initialRow - nextRow) == Math.Abs(initialCol - nextCol);
                case 'Q':
                    return initialRow == nextRow || initialCol == nextCol ||
                        Math.Abs(initialRow - nextRow) == Math.Abs(initialCol - nextCol);
                case 'P':
                    return nextRow == initialRow - 1 && initialCol == nextCol;
                default: break;
            }
            return false;
        }

        private static bool IsInsideTheBoard(int nextRow, int nextCol, char[][] board)
        {
            return nextRow >= 0 && nextRow < board.Length && nextCol >= 0 && nextCol < board.Length;
        }

        private static char[][] GetBoard()
        {
            var board = new char[8][];
            for (int row = 0; row < board.GetLength(0); row++)
            {
                board[row] = Console.ReadLine().Split(',').Select(char.Parse).ToArray();
            }
            return board;
        }
    }
}
