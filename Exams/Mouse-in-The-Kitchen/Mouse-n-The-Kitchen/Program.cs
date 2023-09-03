namespace Mouse_n_The_Kitchen
{
    public class Program
    {
        static void Main(string[] args)
        {           
            int[]  seize = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

            char[,] field = new char[seize[0], seize[1]];

            int mouseRow = 0;
            int mouseCol = 0;
            int cheeseCount = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] fieldInput = Console.ReadLine()!.ToCharArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row,col] = fieldInput[col];

                    if (field[row,col] == 'M')
                    {
                        mouseRow = row;
                        mouseCol = col;
                    }
                    if (field[row,col] == 'C')
                    {
                        cheeseCount++;
                    }
                }
            }
            
            while (true)
            {
                int nextRow = 0;
                int nextCol = 0;

                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "up": nextRow = -1;break;
                    case "down": nextRow= 1; break;
                    case "left": nextCol = -1; break;
                    case "right": nextCol = 1; break;
                    case "danger": Console.WriteLine("Mouse will come back later!");
                        PrintMatrix(field);
                        return;
                }

                if (!isInRenage(field,mouseRow+nextRow,mouseCol+nextCol))
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }
                if (field[mouseRow+nextRow, mouseCol+nextCol] == '@')
                {
                    continue;
                }
                field[mouseRow, mouseCol] = '*';

                mouseRow += nextRow;
                mouseCol += nextCol;             
               
                if (field[mouseRow,mouseCol] == 'C')
                {                    
                    cheeseCount--;

                    if (cheeseCount == 0)
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        field[mouseRow, mouseCol] = 'M';
                        break;
                    }
                }
                else if (field[mouseRow,mouseCol] == 'T')
                {
                    Console.WriteLine("Mouse is trapped!");
                    field[mouseRow, mouseCol] = 'M';
                    break;
                }
                field[mouseRow, mouseCol] = 'M';
            }

            PrintMatrix(field);
        }

        public static void PrintMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for(int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }
        }

        public static bool isInRenage(char[,] field, int row, int col)
        {
            return row>=0 && row<field.GetLength(0) &&
                   col>=0 && col<field.GetLength(1);
        }
    }
}