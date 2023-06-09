using System;
using System.Linq;


namespace _12.Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] matrixSize = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            string snakeSymnols = Console.ReadLine();

            char[,] field = new char [matrixSize[0],matrixSize[1]];

            bool rightLeft = true;
            int indexOfSymbol = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                if (rightLeft)
                {
                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        field[row, col] = snakeSymnols[indexOfSymbol++];

                        if (indexOfSymbol==snakeSymnols.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }

                    rightLeft = false;
                }
                else
                {
                    for (int col = field.GetLength(1) - 1; col >= 0; col--)
                    {
                        field[row, col] = snakeSymnols[indexOfSymbol++];

                        if (indexOfSymbol == snakeSymnols.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }
                    rightLeft= true;
                }
            }

            for (int rol = 0; rol < field.GetLength(0); rol++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[rol, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
