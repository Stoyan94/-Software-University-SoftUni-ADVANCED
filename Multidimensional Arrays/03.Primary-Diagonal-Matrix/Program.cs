using System;
using System.Linq;


namespace _03.Primary_Diagonal_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());           

            int[,] matrix = new int[size, size];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[row, col] = colsInput[col];                   
                }
            }

            int sumDiagonal = 0;

            for (int colIndex = 0; colIndex < matrix.GetLength(0); colIndex++)
            {
                sumDiagonal+=matrix[colIndex,colIndex];

            }
            Console.WriteLine(sumDiagonal);
        }
    }
}
