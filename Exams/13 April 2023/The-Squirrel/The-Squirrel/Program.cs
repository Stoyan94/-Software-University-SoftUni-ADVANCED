namespace The_Squirrel
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
                       
            List<string> squCommands = Console.ReadLine()!.Split(", ").ToList();

            char[,] field = new char[size, size];

            int squRow = 0;
            int squCol = 0;
            int allNutsCount = 0;

            CreateFieldAndInfo(field, ref squRow, ref squCol, ref allNutsCount);
            

            int nutsCountCollected = 0;

            bool isNotColledted = true;

            foreach (var command in squCommands)
            {
                int nextRow = 0;
                int nextCol = 0;

                string direction = command;

                switch (direction)
                {
                    case "up": nextRow = -1;   break;
                    case "down": nextRow = 1;  break;
                    case "left": nextCol = -1; break;
                    case "right": nextCol = 1; break;                   
                }

                if (!isInRenage(field,squRow+nextRow,squCol+nextCol))
                {
                    isNotColledted = false;

                    OutFieldMeessage(nutsCountCollected);
                    break;
                }

                squRow += nextRow;
                squCol += nextCol;

                if (field[squRow, squCol] == 't')
                {
                    isNotColledted = false;

                    TrapMessage(nutsCountCollected);
                    break;
                }
                else
                {
                    if (field[squRow,squCol] == 'h')
                    {
                        nutsCountCollected++;
                        allNutsCount--;

                        field[squRow, squCol] = '*';

                        if (nutsCountCollected == 3)
                        {                            
                            isNotColledted = false;
                            AllCollectedMessage(nutsCountCollected);
                            break;
                        }
                    }
                }
            }

            if (isNotColledted)
            {
                Console.WriteLine("There are more hazelnuts to collect.");
                Console.WriteLine($"Hazelnuts collected: {nutsCountCollected}");
            }
        }

        public static void AllCollectedMessage(int nutsCountCollected)
        {
            Console.WriteLine("Good job! You have collected all hazelnuts!");
            Console.WriteLine($"Hazelnuts collected: {nutsCountCollected}");
        }

        public static void TrapMessage(int nutsCountCollected)
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {nutsCountCollected}");
        }

        public static void OutFieldMeessage(int nutsCountCollected)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {nutsCountCollected}");
        }

        public static bool isInRenage(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0) &&
                   col >= 0 && col < field.GetLength(1);
        }

        public static void CreateFieldAndInfo(char[,] field, ref int squRow,
            ref int squCol,
            ref int allNutsCount)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] fieldInput = Console.ReadLine()!.ToCharArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = fieldInput[col];

                    if (field[row, col] == 's')
                    {
                        squRow = row; squCol = col;
                    }
                    else if (field[row, col] == 'h')
                    {
                        allNutsCount++;
                    }
                }
            }
        }
    }
}