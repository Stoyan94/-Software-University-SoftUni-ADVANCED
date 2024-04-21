using System;

int size = int.Parse(Console.ReadLine());

int planeRow = 0;
int planeCol = 0;
int planeArmor = 300;
int enemiesCount = 0;

string[,] airspace = CreatField(size, planeRow, planeCol, enemiesCount);

Console.WriteLine();



string[,] CreatField(int size, int planeRow, int planeCol, int enemiesCount)
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

