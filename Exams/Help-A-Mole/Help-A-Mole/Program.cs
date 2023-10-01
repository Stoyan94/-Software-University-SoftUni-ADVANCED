using System;
using System.Collections.Generic;

int fieldSize = int.Parse(Console.ReadLine());

int moulRow = 0;
int moulCol = 0;
List<int> teleports = new List<int>();

char[,] field = CreatField(fieldSize,ref moulRow,ref moulCol,teleports);

int moulPoints = 0;
bool isWin = false;

string directios;

while((directios = Console.ReadLine())!="End")
{
    int nextRow = 0;
    int nextCol = 0;

    switch (directios)
    {
        case "up": nextRow = -1; break;
        case "down": nextRow = 1; break;
        case "left": nextCol = -1; break;
        case "right": nextCol = 1; break;
    }

    if (!isInrenage(field, moulRow+nextRow, moulCol + nextCol))
    {
        Console.WriteLine("Don't try to escape the playing field");
        continue;
    }

    field[moulRow, moulCol] = '-';

    moulRow += nextRow;
    moulCol += nextCol;

    if (field[moulRow, moulCol] == 'S')
    {
        moulPoints -= 3;

        int index = teleports.FindIndex(x => x == moulRow);
        field[moulRow, moulCol] = '-';

        if (index > 1)
        {
            moulRow = teleports[0];
            moulCol = teleports[1];
        }
        else if (index < 1)
        {
            moulRow = teleports[2];
            moulCol = teleports[3];
        }

        field[moulRow, moulCol] = 'M';
    }
    else if (char.IsDigit(field[moulRow,moulCol]))
    {
        int currPoints = field[moulRow, moulCol] - 48;
        moulPoints += currPoints;        
    }

    field[moulRow, moulCol] = 'M';


    if (moulPoints >= 25)
    {
        isWin = true;
        break;
    }
}

if (isWin)
{
    Console.WriteLine("Yay! The Mole survived another game!");
    Console.WriteLine($"The Mole managed to survive with a total of {moulPoints} points.");
    PrintMatrix(field);
}
else
{
    Console.WriteLine("Too bad! The Mole lost this battle!");
    Console.WriteLine($"The Mole lost the game with a total of {moulPoints} points.");
    PrintMatrix(field);
}



void PrintMatrix(char[,] field)
{
    for (int row = 0; row < field.GetLength(0); row++)
    {
        for (int col = 0; col < field.GetLength(0); col++)
        {
            Console.Write(field[row,col]);
        }
        Console.WriteLine();
    }
}

bool isInrenage(char[,] field, int moulRow, int moulCol)
{
    return moulRow>=0 && moulRow<field.GetLength(0) &&
           moulCol>=0 && moulCol<field.GetLength(1);
}

char[,] CreatField(int fieldSize,ref int moulRow, ref int moulColl, List<int> teleports)
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
            else if (field[row,col] == 'S')
            {
                teleports.Add(row);
                teleports.Add(col);
            }
        }
    }

    return field;
}