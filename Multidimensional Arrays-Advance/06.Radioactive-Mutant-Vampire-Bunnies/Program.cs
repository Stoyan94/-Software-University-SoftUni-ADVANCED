using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Radioactive_Mutant_Vampire_Bunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions= Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int allRows = dimensions[0];
            int allCols = dimensions[1];

            int playerRow = 0;
            int playerCol = 0;

            char [,] matrix = new char[allRows, allCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char [] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row,col]=='P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string directions = Console.ReadLine();

            bool hasWon=  false;
            bool isDead = false;

            foreach (var direction in directions)
            {
                int nextRow = 0;
                int nextCol = 0;

                switch (direction)
                {
                   
                        case 'U':
                        nextRow = -1;                  
                        break;
                        case 'D':
                        nextRow = 1;                  
                        break;
                        case 'L':
                        nextCol = -1;                  
                        break;
                        case 'R':
                        nextCol = 1;
                        break;
                }

                matrix[playerRow, playerCol] = '.';

                if (!IsInRenage(matrix,playerRow+nextRow,playerCol+nextCol))
                {
                    hasWon = true;
                }
                else
                {
                    playerRow += nextRow;
                    playerCol+=nextCol;
                }
                

                if (matrix[playerRow,playerCol]=='B')
                {
                    isDead = true;
                }
                else if(!hasWon)
                {
                    matrix[playerRow, playerCol] = 'P';
                }
               

                List<int[]> bunnies= new List<int[]>();

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row,col]=='B')
                        {
                            bunnies.Add(new int[] { row, col });
                        }
                    }
                }

                foreach (var currentBuny in bunnies)
                {
                    int bunnyRow = currentBuny[0];
                    int bunnyCol = currentBuny[1];

                    //up
                    if (IsInRenage(matrix,bunnyRow-1,bunnyCol))
                    {
                        if (matrix[bunnyRow-1,bunnyCol]=='P')
                        {
                            isDead = true;
                        }

                        matrix[bunnyRow-1,bunnyCol] = 'B';
                    }

                    //down
                    if (IsInRenage(matrix, bunnyRow + 1, bunnyCol))
                    {
                        if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                        {
                            isDead = true;
                        }

                        matrix[bunnyRow + 1, bunnyCol] = 'B';
                    }

                    //left
                    if (IsInRenage(matrix, bunnyRow , bunnyCol-1))
                    {
                        if (matrix[bunnyRow , bunnyCol-1] == 'P')
                        {
                            isDead = true;
                        }

                        matrix[bunnyRow , bunnyCol-1] = 'B';
                    }

                    //right
                    if (IsInRenage(matrix, bunnyRow, bunnyCol + 1))
                    {
                        if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                        {
                            isDead = true;
                        }

                        matrix[bunnyRow, bunnyCol + 1] = 'B';
                    }
                }

                if (isDead || hasWon)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                }

                if (isDead)
                {
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
                else if (hasWon)
                {
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
                //nextCell
                //if outside - win
                //if colide with bunny-dead
                //spread bunnys
            }

        }

        private static bool IsInRenage(char [,] board ,int row, int col)
        {
            return row>=0 && row< board.GetLength(0) &&
                   col>=0 && col< board.GetLength(1);
        }
    }
}
