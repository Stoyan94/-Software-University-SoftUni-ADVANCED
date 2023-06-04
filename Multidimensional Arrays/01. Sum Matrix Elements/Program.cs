using System;
using System.Linq;

namespace _011._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(",")
                .Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows,cols];

            int sumCols = 0;
            int rowsMax = matrix.GetLength(0);
            int colsMax = matrix.GetLength(1);

            for (int row = 0; row <matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = rowInput[col];
                    sumCols+=matrix[row,col];
                }
            }

            Console.WriteLine(rowsMax);
            Console.WriteLine(colsMax);
            Console.WriteLine(sumCols);
        }
    }
}
