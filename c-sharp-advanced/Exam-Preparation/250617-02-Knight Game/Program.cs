using System;

namespace _250617_02_Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardSize = int.Parse(Console.ReadLine());
            char[][] board = new char[boardSize][];

            for (int row = 0; row < board.Length; row++)
            {
                board[row] = Console.ReadLine().ToCharArray();
            }

            int maxRow = 0;
            int maxCol = 0;
            int maxAttackedPositions = 0;
            int removedHorses = 0;
            do
            {
                if (maxAttackedPositions > 0)
                {
                    board[maxRow][maxCol] = '0';
                    maxAttackedPositions = 0;
                    removedHorses++;
                }

                int currentAttackPosition = 0;
                for (int row = 0; row < boardSize; row++)
                {
                    for (int col = 0; col < boardSize; col++)
                    {
                        if (board[row][col] == 'K')
                        {
                            currentAttackPosition = CalculateAttackPositions(row, col, board);
                            if (currentAttackPosition > maxAttackedPositions)
                            {
                                maxAttackedPositions = currentAttackPosition;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }

            } while (maxAttackedPositions > 0);

            Console.WriteLine(removedHorses);
        }

        static int CalculateAttackPositions(int row, int col, char[][] board)
        {
            var currentAttackPosition = 0;
            if (IsPositionAttacked(row - 2, col - 1, board)) currentAttackPosition++;
            if (IsPositionAttacked(row - 2, col + 1, board)) currentAttackPosition++;
            if (IsPositionAttacked(row - 1, col - 2, board)) currentAttackPosition++;
            if (IsPositionAttacked(row - 1, col + 2, board)) currentAttackPosition++;
            if (IsPositionAttacked(row + 1, col - 2, board)) currentAttackPosition++;
            if (IsPositionAttacked(row + 1, col + 2, board)) currentAttackPosition++;
            if (IsPositionAttacked(row + 2, col - 1, board)) currentAttackPosition++;
            if (IsPositionAttacked(row + 2, col + 1, board)) currentAttackPosition++;
            return currentAttackPosition;

        }

        static bool IsPositionAttacked(int row, int col, char[][] board)    
        {
            return IsInTheBoard(row, col, board[0].Length) && board[row][col] == 'K';
        }

        static bool IsInTheBoard(int row, int col, int boardSize)
        {
            return row >= 0 && row < boardSize && col >= 0 && col < boardSize;
        }
    }
}
