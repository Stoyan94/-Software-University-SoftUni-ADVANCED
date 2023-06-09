using System;
using System.Linq;

namespace _08.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(size);

            int[] bombIndex = Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

            for (int i = 0; i < bombIndex.Length; i += 2)
            {
                int rowBomb = bombIndex[i];
                int colBomb = bombIndex[i + 1];

                if (matrix[rowBomb, colBomb] <= 0)
                {
                    continue;
                }

                int valueBomb = matrix[rowBomb, colBomb];

               
                if (IsInRnage(matrix, rowBomb - 1, colBomb) && matrix[rowBomb - 1, colBomb] > 0) //up 
                {
                    matrix[rowBomb - 1, colBomb] -= valueBomb;
                }
                if (IsInRnage(matrix, rowBomb + 1, colBomb) && matrix[rowBomb + 1, colBomb] > 0)//down 
                {
                    matrix[rowBomb + 1, colBomb] -= valueBomb;
                }
                if (IsInRnage(matrix, rowBomb, colBomb - 1) && matrix[rowBomb, colBomb - 1] > 0) //left
                {
                    matrix[rowBomb, colBomb - 1] -= valueBomb;
                }
                if (IsInRnage(matrix, rowBomb, colBomb + 1) && matrix[rowBomb, colBomb + 1] > 0) //right
                {
                    matrix[rowBomb, colBomb + 1] -= valueBomb;
                }
                if (IsInRnage(matrix, rowBomb - 1, colBomb - 1) && matrix[rowBomb - 1, colBomb - 1] > 0) //upLeft
                {
                    matrix[rowBomb - 1, colBomb - 1] -= valueBomb;
                }
                if (IsInRnage(matrix, rowBomb - 1, colBomb + 1) && matrix[rowBomb - 1, colBomb + 1] > 0) //upRight
                {
                    matrix[rowBomb - 1, colBomb + 1] -= valueBomb;
                }
                if (IsInRnage(matrix, rowBomb + 1, colBomb - 1) && matrix[rowBomb + 1, colBomb - 1] > 0) //downLeft
                {
                    matrix[rowBomb+1, colBomb - 1] -= valueBomb;

                }
                if (IsInRnage(matrix, rowBomb + 1, colBomb +1) && matrix[rowBomb + 1, colBomb + 1] > 0)   //downRifgt
                {
                    matrix[rowBomb + 1, colBomb + 1] -= valueBomb;

                }

                matrix[rowBomb, colBomb] = 0;
            }

            PrintAliveCells(matrix);
            PrintFinalStateMatrix(matrix);
           
        }

        private static void PrintFinalStateMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+ " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintAliveCells(int[,] matrix)
        {
            int sumAliveCells = 0;
            int countAliveCells = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        sumAliveCells += matrix[row, col];
                        countAliveCells++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {countAliveCells}");
            Console.WriteLine($"Sum: {sumAliveCells}");
        }

        private static int[,] ReadMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }

        private static bool IsInRnage(int[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                   col >= 0 && col < board.GetLength(1);
        }
    }
}
