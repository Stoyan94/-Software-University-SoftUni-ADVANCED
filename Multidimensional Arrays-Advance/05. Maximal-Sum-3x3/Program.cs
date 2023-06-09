using System;
using System.Linq;


namespace _10._Maximal_Sum_3x3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] rowColInputSize = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[,] matrix = ReadMatrix(rowColInputSize);

            int maxSum = int.MinValue;
            int bestRows = 0;
            int bestCols = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int currSum = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row+3-1<matrix.GetLength(0) && col+3-1 <matrix.GetLength(1))
                    {
                        currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                              + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                              + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        if (currSum>maxSum)
                        {
                            maxSum = currSum;
                            bestRows = row;
                            bestCols = col;
                        }
                    }
                }                    
            }
            Console.WriteLine($"Sum = {maxSum}");
            PrintBestSumRolCol(matrix, bestRows, bestCols);

        }

        private static void PrintBestSumRolCol(int[,] matrix, int bestRows, int bestCols)
        {          
            for (int row = bestRows; row <= bestRows+2; row++)
            {
                for (int col = bestCols; col <= bestCols+2; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }

                Console.WriteLine();
            }
            
        }

        private static int[,] ReadMatrix(int[] rowColInputSize)
        {
            var rows = rowColInputSize[0];
            var cols = rowColInputSize[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
