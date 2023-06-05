using System;
using System.Linq;

namespace _09._2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();           

            char[,] matrix = MatrixInput(matrixSize);

            int countMatches =0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row+2 -1 <matrix.GetLength(0) && col+2-1<matrix.GetLength(1))
                    {
                        char[] currChek = new char[]
                    {
                        matrix[row, col],matrix[row, col+1],
                        matrix[row+1, col],matrix[row+1,col+1]
                    };

                        char currChar = currChek[0];

                        if (currChek.All(x=>x==currChar))
                        {
                            countMatches++;
                        }
                    }
                    
                }
            }

            Console.WriteLine(countMatches);

        }

        private static char[,] MatrixInput(int[] matrixSize)
        {
            var rows = matrixSize[0];
            var cols = matrixSize[1];

            char [,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char [] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>char.Parse(x)).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
