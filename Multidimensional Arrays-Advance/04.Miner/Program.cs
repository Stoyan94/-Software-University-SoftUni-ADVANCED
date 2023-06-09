using System;
using System.Collections.Generic;
using System.Linq;


namespace _09.Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            char[,] matrixField =  new char[size, size]; 

            int colCount = 0;
            int playerRow = 0;
            int playerCol = 0;


            for (int row = 0; row < matrixField.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>char.Parse(x)).ToArray();
                for (int col = 0; col < matrixField.GetLength(1); col++)
                {
                    matrixField[row, col] = input[col];

                    if (matrixField[row,col]=='c')
                    {
                        colCount++;
                    }
                    else if (matrixField[row, col] == 's')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

           
            foreach (var dircetion in directions)
            {
               // left, right, up, and down. 
                int nextRow = 0;
                int nextCol = 0;


                if (dircetion == "left")
                {
                    nextCol = -1;
                }
                else if (dircetion == "right")
                {
                    nextCol = 1;
                }              
                else if (dircetion == "down")
                {
                    nextRow = 1;
                }
                else if (dircetion == "up")
                {
                    nextRow = -1;
                }


                if (!IsInRenage(matrixField, playerRow + nextCol, playerCol + nextCol)) 
                {
                    continue;
                }
                playerRow += nextRow;
                playerCol += nextCol;


                if (matrixField[playerRow, playerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                    Environment.Exit(0);
                }

                if (matrixField[playerRow,playerCol]=='c')
                {
                    matrixField[playerRow, playerCol] = '*';
                    colCount--;                   

                    if (colCount<=0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        Environment.Exit(0);                        
                    }
                }             
               
            }            
                Console.WriteLine($"{colCount} coals left. ({playerRow}, {playerCol})");
            
        }

        private static bool IsInRenage(char[,] matrixField, int row, int col)
        {
            return row >= 0 && row < matrixField.GetLength(0) &&
                   col >= 0 && col < matrixField.GetLength(1);
        }

        
    }
}
