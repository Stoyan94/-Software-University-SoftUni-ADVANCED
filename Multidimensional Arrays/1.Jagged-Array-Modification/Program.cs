using System;
using System.Linq;

namespace _6.Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());            

            int[][] jaggedArray = ReadJagged(rows);

            string command;
            while ((command=Console.ReadLine())!="END")
            {
                var input = command.Split();
                var action = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row < 0 || col < 0|| row >jaggedArray.Length || col>jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (action=="Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    jaggedArray[row][col]-=value;
                }
            }

            PrintJagged(jaggedArray);
        }

        private static void PrintJagged(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine($"{string.Join(" ",jaggedArray[row])}");
            }
        }

        private static int[][] ReadJagged(int rows)
        {
            int [][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            return jaggedArray;
        }
    }
}
