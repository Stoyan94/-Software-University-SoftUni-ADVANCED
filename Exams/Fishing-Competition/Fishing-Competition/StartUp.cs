using System;

public class StartUp
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        char[,] field = new char[size, size];

        int shipRow = 0;
        int shipCol = 0;
        int minTonsFish = 20;
        int countFishCatch = 0;

        CreateField(field, ref shipRow, ref shipCol);

        field[shipRow, shipCol] = '-';

        bool isShipSink = false;
        bool isQuotaReach = false;

        while (true)
        {
            int nextRow = 0;
            int nextCol = 0;

            int lastRow = shipRow;
            int lastCol = shipCol;

            bool isDrectionSw = true;

            string direction = Console.ReadLine();

            switch (direction)
            {
                case "up": nextRow = -1; break;
                case "down": nextRow = 1; break;
                case "left": nextCol = -1; break;
                case "right": nextCol = 1; break;
            }

            if (!isInRenage(field, shipRow + nextRow, shipCol + nextCol))
            {
                if (shipRow+nextRow >= field.GetLength(0))
                {
                    shipRow = field.GetLength(0) - field.GetLength(0);                   
                }
                else if (shipCol+nextCol >= field.GetLength(1))
                {
                    shipCol = field.GetLength(1) - field.GetLength(1);
                }
                isDrectionSw = false;
            }
            else if (direction == "collect the nets")
            {
                break;
            }

            if (isDrectionSw)
            {          
                shipRow += nextRow;            
                shipCol += nextCol;

            }


            if (field[shipRow, shipCol] == 'W')
            {
                isShipSink = true;
                break;
            }
            else if (char.IsDigit(field[shipRow,shipCol]))
            {
                countFishCatch += field[shipRow, shipCol] - 48;
                field[shipRow, shipCol] = '-';

                if (countFishCatch >= minTonsFish)
                {                    
                    isQuotaReach = true;
                }
            }
            else
            {

            }
        }

        if (isShipSink)
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{shipRow},{shipCol}]");
            
        }
        else if (isQuotaReach)
        {
            field[shipRow, shipCol] = 'S';
            Console.WriteLine("Success! You managed to reach the quota!");
            Console.WriteLine($"Amount of fish caught: {countFishCatch} tons.");
            PrintMatrix(field);
        }
        else
        {
            field[shipRow, shipCol] = 'S';
            Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {minTonsFish - countFishCatch} tons of fish more.");
            if (countFishCatch > 0)
            {
                Console.WriteLine($"Amount of fish caught: {countFishCatch} tons.");
            }
            
            PrintMatrix(field);
        }


    }

    private static void PrintMatrix(char[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                Console.Write(field[row, col]);
            }
            Console.WriteLine();
        }
    }

    public static bool isInRenage(char[,] field, int row, int col)
    {
        return row >= 0 && row < field.GetLength(0) &&
               col >= 0 && col < field.GetLength(1);
    }

    public static void CreateField(char[,] field, ref int shipRow,
        ref int shipCol)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            char[] fieldInput = Console.ReadLine()!.ToCharArray();

            for (int col = 0; col < field.GetLength(1); col++)
            {
                field[row, col] = fieldInput[col];

                if (field[row, col] == 'S')
                {
                    shipRow = row;
                    shipCol = col;
                }

            }
        }
    }
}