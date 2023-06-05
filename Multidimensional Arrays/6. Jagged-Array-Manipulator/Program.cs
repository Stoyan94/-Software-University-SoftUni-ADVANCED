using System;
using System.Linq;


namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = ReadInput();
            AnalyseJaggedArrayByRows(jaggedArray);

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                var cmdArgs = commands.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                var command = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                var addValue = int.Parse(cmdArgs[3]);

                if (IsInRenage(jaggedArray, row, col))
                {
                    if (command == "Add")
                    {
                        jaggedArray[row][col] += addValue;
                    }
                    else if (command == "Subtract")
                    {
                        jaggedArray[row][col] -= addValue;

                    }
                }               


            }

            PrintJagged(jaggedArray);

        }

        private static bool IsInRenage(int[][] jaggedArray, int row, int col)
        {

            if (row < 0 || row > jaggedArray.Length)
            {
                return false;
            }
            if (col < 0 || col > jaggedArray[row].Length)
            {
                return false;
            }
            return true;
        }

        private static void PrintJagged(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }        

        private static void AnalyseJaggedArrayByRows(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length-1; row++)
            {
                if (jaggedArray[row].Length==jaggedArray[row+1].Length)
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x * 2).ToArray();
                    jaggedArray[row+1] = jaggedArray[row+1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x / 2).ToArray();
                    jaggedArray[row+1] = jaggedArray[row+1].Select(x => x / 2).ToArray();
                }
                
            }
        }

        private static int[][] ReadInput()
        {
            int jaggedRows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[jaggedRows][];
            for (int row = 0; row < jaggedRows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            return jaggedArray;
        }
    }
}
