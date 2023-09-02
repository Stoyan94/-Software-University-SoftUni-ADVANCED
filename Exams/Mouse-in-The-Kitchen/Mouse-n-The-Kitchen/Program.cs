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
                }
            }
            Console.WriteLine();
        }
    }
}