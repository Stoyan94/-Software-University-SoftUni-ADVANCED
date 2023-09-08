namespace The_Squirrel
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);

            List<string> squCommands = new List<string>(Console.ReadLine()!.Split(","));

            char[,] field = new char[size, size];

            int squRow = 0;
            int squCol = 0;

            CreateFieldAndInfo(field, ref squRow, ref squCol);

            int nutsCount = 0;


            foreach (var command in squCommands)
            {
                int nextRow = 0;
                int nextCol = 0;

                string direction = command;

                switch (direction)
                {
                    case "up": nextRow = -1; break;
                    case "down": nextRow = 1; break;
                    case "left": nextCol = -1; break;
                    case "right": nextCol = 1; break;
                }

                if (isInRenage(field,squRow+nextRow,squCol+nextCol))
                {

                }
            }

        }

        public static bool isInRenage(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0) &&
                   col >= 0 && col < field.GetLength(col);
        }

        public static void CreateFieldAndInfo(char[,] field, ref int squRow, ref int squCol)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] fieldInput = Console.ReadLine()!.ToCharArray(); 

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row,col] = fieldInput[col];

                    if (field[row,col] == 's')
                    {
                        squRow = row; squCol = col;
                    }
                }
            }
        }
    }
}