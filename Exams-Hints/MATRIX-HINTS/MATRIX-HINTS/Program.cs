namespace Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];

            int TESTRow = 0;
            int TESTCol = 0;        

            CreateField(field, ref TESTRow, ref TESTCol);

           

            bool isElectrocuted = false;
            bool isRoadHit = false;

            while (true)
            {
                int nextRow = 0;
                int nextCol = 0;

                int lastRow = TESTRow;
                int lastCol = TESTCol;

                string direction = Console.ReadLine();

                switch (direction)
                {
                    case "up": nextRow = -1; break;
                    case "down": nextRow = 1; break;
                    case "left": nextCol = -1; break;
                    case "right": nextCol = 1; break;
                }

                if (!isInRenage(field, TESTRow + nextRow, TESTCol + nextCol))
                {
                    continue;
                }
                else if (direction == "End")
                {
                    break;
                }

                TESTRow += nextRow;
                TESTCol += nextCol;

                if (field[TESTRow, TESTCol] == 'C')
                {                                    

                    break;
                }
                else if (field[TESTRow, TESTCol] == 'R')
                {               

                    continue;
                }
                else
                {                   

                }
            }

            if (isElectrocuted)
            {
                Console.WriteLine($"");
                PrintMatrix(field);
            }
            else
            {
                Console.WriteLine($"");
                field[TESTRow, TESTCol] = 'V';
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

        public static void CreateField(char[,] field, ref int TESTRow,
            ref int TESTCol)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] fieldInput = Console.ReadLine()!.ToCharArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = fieldInput[col];

                    if (field[row, col] == 'V')
                    {
                        TESTRow = row;
                        TESTCol = col;
                    }

                }
            }
        }
    }
}