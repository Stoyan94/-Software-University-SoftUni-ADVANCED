using System;
using System.Linq;

namespace _08.Diagonal_Diffrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int [,] matrix = ReadMatrix(size);

            int rightLeft = 0;
            int leftRight = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rightLeft += matrix[i, i];
                leftRight += matrix[i,matrix.GetLength(1)-i-1];
            }

            Console.WriteLine($"{Math.Abs(rightLeft-leftRight)}");
        }

        private static int[,] ReadMatrix(int size)
        {
            int [,] matrix = new int[size,size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
