using System;


int fieldSize = int.Parse(Console.ReadLine());

int submarineRow = 0;
int submarineCol = 0;

char[,] field = FieldInfo(fieldSize,ref submarineCol,ref submarineRow);

int submDef = 3;
int desShips = 3;

bool isShipsDes = true;


while (true)
{
    string cmdDirections = Console.ReadLine();

    int nextRow = 0;
    int nextCol = 0;

    switch (cmdDirections)
    {
        case "up":
            nextRow = -1;
            break;
        case "down":
            nextRow = 1;
            break;
        case "left":
            nextCol = -1;
            break;
        case "right":
            nextCol = 1;
            break;
    }
    field[submarineRow, submarineCol] = '-';

    submarineRow += nextRow;
    submarineCol += nextCol;
   
    if (field[submarineRow, submarineCol] == '*')
    {
        submDef--;        

        if (submDef == 0)
        {
            field[submarineRow, submarineCol] = 'S';
            isShipsDes = false;
            break;
        }
    }
    else if (field[submarineRow, submarineCol] == 'C')
    {
        desShips--;

        if (desShips == 0)
        {
            field[submarineRow, submarineCol] = 'S';            
            break;
        }
    }  

}

if (isShipsDes)
{
    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
    PrintMatrix(field);
}
else
{
    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
    PrintMatrix(field);
}

void PrintMatrix(char[,] field)
{
    for (int row = 0; row < field.GetLongLength(0); row++)
    {
        for (int col = 0; col < field.GetLongLength(1); col++)
        {
            Console.Write(field[row,col]);
        }
        Console.WriteLine();
    }
}

char[,] FieldInfo(int fieldSize, ref int submarineCol, ref int submarineRow)
{  
    char[,] matrix = new char[fieldSize,fieldSize];
    
    for (int row = 0; row < matrix.GetLength(0);row++)
    {
        char[] input = Console.ReadLine().ToCharArray();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = input[col];

            if (matrix[row, col] == 'S')
            {
                submarineRow = row;
                submarineCol = col;
            }
        }
    }

    return matrix;
}