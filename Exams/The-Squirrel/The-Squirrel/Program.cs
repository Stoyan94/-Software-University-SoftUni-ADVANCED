namespace The_Squirrel
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);

            List<string> squCommands = new List<string>(Console.ReadLine()!.Split());

            string[,] field = new string[size, size];

            foreach (var command in squCommands)
            {
                
            }
            int squRow = 0;
            int squCol = 0;

            CreateFieldAndInfo(field, squRow, squCol);
           
        }

        public static void CreateFieldAndInfo(string[,] field, int squRow, int squCol)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                string[] fieldInput = Console.ReadLine()!.Split(); 

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row,col] = fieldInput[col];

                    if (field[row,col] == "S")
                    {
                        squRow = row; squCol = col;
                    }
                }
            }
        }
    }
}