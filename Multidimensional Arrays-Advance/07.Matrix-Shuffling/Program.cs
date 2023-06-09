using System;
using System.Linq;


namespace _11.Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] matrixSize = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            string[,] matrix = ReadMatrix(matrixSize);

            string inputComand;

            while ((inputComand=Console.ReadLine())!="END")
            {
                var cmdArgs = inputComand.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                var command = cmdArgs[0];              

                if (command=="swap")
                {
                    var firstRow = int.Parse(cmdArgs[1]);
                    var firstCol = int.Parse(cmdArgs[2]);
                    var seckondRow = int.Parse(cmdArgs[3]);
                    var seckondCol = int.Parse(cmdArgs[4]);

                    if (!isInRange(matrix, firstRow, firstCol, seckondRow, seckondCol))
                    {
                        

                        Console.WriteLine($"Invalid input!");
                        continue;
                    }
                    string firstSwap = matrix[firstRow, firstCol];
                    string seckondSwap= matrix[seckondRow, seckondCol];
                    matrix[seckondRow, seckondCol] = firstSwap;
                    matrix[firstRow, firstCol] = seckondSwap;

                    PrintChage(matrix);
                }
                else 
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
        }

        private static bool isInRange(string[,] matrix, int firstRow, int firstCol, int seckondRow, int seckondCol)
        {
            return firstRow >= 0 && firstRow < matrix.GetLength(0) &&
            firstCol >= 0 && firstCol < matrix.GetLength(1) &&
            seckondRow >= 0 && seckondRow < matrix.GetLength(0)&&
            seckondCol >= 0 && seckondCol < matrix.GetLength(1);


        }

        private static void PrintChage(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]+" ");
                }
                Console.WriteLine();
            }
        }

        private static string[,] ReadMatrix(int[] matrixSize)
        {
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string [] input= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = input[col];
                }
            }

            return matrix;
        }
    }
}
