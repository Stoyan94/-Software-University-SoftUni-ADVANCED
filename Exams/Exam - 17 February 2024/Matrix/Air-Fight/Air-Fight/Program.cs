using System;

int size = int.Parse(Console.ReadLine());

int planeRow = 0;
int planeCol = 0;
int planeArmor = 300;
int enemiesCount = 0;

string[,] airspace = CreatField(size, ref planeRow, ref planeCol, ref enemiesCount);

string command;

while (enemiesCount > 0)
{
    command = Console.ReadLine();

    switch (command)
    {
        case "up": planeRow--; break;
        case "down": planeRow++; break;
        case "left": planeCol--; break;
        case "right": planeCol++; break;
    }

    string currPosition = airspace[planeRow, planeCol];
    airspace[planeRow, planeCol] = "-";

    if (currPosition == "E")
    {
        enemiesCount--;
        planeArmor -= 100;

        if (planeArmor == 0)
        {
            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{planeRow}, {planeCol}]!");
            PrintMatrix(planeRow, planeCol, airspace);
            return;
        }
    }
    if (currPosition == "R")
    {
        planeArmor = 300;
    }
}

Console.WriteLine($"Mission accomplished, you neutralized the aerial threat!");
PrintMatrix(planeRow, planeCol, airspace);
        




string[,] CreatField(int size, ref int planeRow, ref int planeCol, ref int enemiesCount)
{
    string[,] matrix = new string[size, size];

    for (int rol = 0; rol < matrix.GetLength(0); rol++)
    {
        string newRow = Console.ReadLine();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            string temp = newRow[col].ToString();

            matrix[rol, col] = temp;

            if (temp == "E")
            {
                enemiesCount++;
            }

            if (temp == "J")
            {
                planeRow = rol;
                planeCol = col;
                matrix[rol, col] = "-";
            }
        }
    }

    return matrix;    
}

 static void PrintMatrix(int planeRow, int planeCol, string[,] matrix)
{
    matrix[planeRow, planeCol] = "J";

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}


