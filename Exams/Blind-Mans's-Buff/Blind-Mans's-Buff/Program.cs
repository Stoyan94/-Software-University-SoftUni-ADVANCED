namespace Blind_Mans_s_Buff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()!.Split(" ")
                 .Select(int.Parse).ToArray();

            int playerRow = 0;
            int playerCol = 0;

            string[,] field = new string[dimension[0], dimension[1]];

            for (int rows = 0; rows < field.GetLength(0); rows++)
            {
                string[] fieldInput = Console.ReadLine()!.Split(" ");

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[rows, col] = fieldInput[col];

                    if (field[rows, col] == "B")
                    {
                        playerRow = rows;
                        playerCol = col;
                        field[rows, col] = "-";
                    }
                }
            }

            int moveCounter = 0;
            int countWins = 0;

            string playerMove;
            while ((playerMove = Console.ReadLine()!) != "Finish")
            {


                if (playerMove == "Finish")
                {
                    break;
                }

                int nextRow = 0;
                int nextCol = 0;

                if (playerMove == "up")
                {
                    nextRow = -1;
                }
                else if (playerMove == "down")
                {
                    nextRow = 1;
                }
                else if (playerMove == "left")
                {
                    nextCol = -1;
                }
                else if (playerMove == "right")
                {
                    nextCol = 1;
                }
                playerRow += nextRow;
                playerCol += nextCol;

                if (!InRnage(field, playerRow + 1, playerCol))
                {
                    continue;
                }

                if (field[playerRow, playerCol] == "O")
                {
                    continue;
                }
                if (field[playerRow, playerCol] == "P")
                {
                    field[playerRow, playerCol] = "-";
                    countWins++;

                }
                moveCounter++;
            }

            Console.WriteLine($"Game over!");
            Console.WriteLine($"Touched opponents: {countWins} Moves made: {moveCounter}");
        }

        private static bool InRnage(string[,] field, int playerRow, int playerCol)
        {
            return playerRow >= 0 && playerRow < field.GetLength(0) &&
                   playerCol >= 0 && playerCol < field.GetLength(1);
        }
    }
}