using System;
using System.Collections.Generic;

int fieldSize = int.Parse(Console.ReadLine());

int moulRow = 0;
int moulCol = 0;
List<int> teleports = new List<int>();

char[,] field = CreatField(fieldSize,moulRow,moulCol,teleports);


char[,] CreatField(int fieldSize, int moulRow, int moulColl, List<int> teleports)
{
    char[,] field = new char[fieldSize,fieldSize];

    for (int row = 0; row < field.GetLength(0); row++)
    {
        char[] fieldInput = Console.ReadLine().ToCharArray(); 

        for (int col = 0; col < field.GetLength(1); col++) 
        {
            field[row,col] = fieldInput[col];
            if (field[row,col] == 'M')
            {
                moulRow = row;
                moulCol = col;
            }
        }
    }

    return field;
}