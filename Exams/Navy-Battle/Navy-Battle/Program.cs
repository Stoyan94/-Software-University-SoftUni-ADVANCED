using System;


int fieldSize = int.Parse(Console.ReadLine());

int submarineRow = 0;
int submarineCol = 0;
int submDef = 3;



char[,] filed = FieldInfo(fieldSize,ref submarineCol,ref submarineRow);

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

            if (matrix[row,col] == 'S')
            {
                submarineRow = row;
                submarineCol = col;
            }
        }

    }

    return matrix;
}