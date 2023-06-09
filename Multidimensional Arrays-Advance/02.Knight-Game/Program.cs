using System;
using System.Linq;

namespace _07.Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size =int.Parse(Console.ReadLine());

            char[,] board = ReadMatrix(size);

            int removedKnights = 0;
            while (true)
            {
                int maxAtack = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {                 

                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (board[row, col] == '0')
                        {
                            continue;
                        }
                        int currMaxAtack = 0;

                        //upLeft //upRight
                        if (IsInRnage(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            currMaxAtack++;
                        }

                        if (IsInRnage(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currMaxAtack++;

                        }
                        //leftUp //leftDown
                        if (IsInRnage(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            currMaxAtack++;

                        }

                        if (IsInRnage(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currMaxAtack++;

                        }
                        //downLeft //downRight
                        if (IsInRnage(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currMaxAtack++;

                        }

                        if (IsInRnage(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currMaxAtack++;

                        }
                        //rightUp //rigtDown

                        if (IsInRnage(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currMaxAtack++;

                        }

                        if (IsInRnage(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currMaxAtack++;

                        }

                        if (currMaxAtack > maxAtack)
                        {
                            maxAtack = currMaxAtack;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if(maxAtack > 0)
                {
                    removedKnights++;
                    board[knightRow,knightCol] = '0';
                }
                else
                {
                    Console.WriteLine(removedKnights);
                    break;
                }
            }          

           
        }

        private static bool IsInRnage(char[,] board, int row, int col)
        {
            return row>= 0 && row< board.GetLength(0) &&
                   col>=0 && col< board.GetLength(1);
        }

        private static char[,] ReadMatrix(int size)
        {
            char[,] matrix = new char[size,size];

            for (int row = 0; row <matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
