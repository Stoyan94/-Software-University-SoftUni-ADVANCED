using System;
using System.Linq;


namespace _5._Square_Maximum_Sum_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] inputRowCol= Console.ReadLine().Split(",",
               StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int [,] matrix = ReadMatrix(inputRowCol);

            int maxSum = int.MinValue;
            int currSum = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row +2 -1 <matrix.GetLength(0) && col +2-1 <matrix.GetLength(1))
                    {
                        currSum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];

                        if (currSum > maxSum)
                        {
                            maxSum = currSum;
                            maxRowIndex = row;
                            maxColIndex = col;
                        }
                    }                    
                }              
            }

            for (int row = maxRowIndex; row < maxRowIndex+2; row++)
            {
                for (int col = maxColIndex; col < maxColIndex+2; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }

        public static int [,] ReadMatrix(int[] inputRowCol)
        {
          int[,] matrix = new int[inputRowCol[0], inputRowCol[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputNums = Console.ReadLine().Split(",",
               StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNums[col];
                }
            }
            return matrix;
        }
    }
}
