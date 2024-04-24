namespace EscapeTheMaze
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int health = 100;

            string[,] maze = new string[size, size];

            int playerRow = -1;
            int playerCol = -1;

            for (int i = 0; i < maze.GetLength(0); i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (row[j].ToString() == "P")
                    {
                        playerRow = i;
                        playerCol = j;

                        maze[i, j] = "-";
                    }
                    else
                    {
                        maze[i, j] = row[j].ToString();
                    }
                }
            }

            while (true)
            {
                string direction = Console.ReadLine();

                bool isOutOfBounds = DefineCommandIsOutOfBoundaries(maze, direction, playerRow, playerCol);

                if (isOutOfBounds) continue;

                PlayerStep(direction, ref playerRow, ref playerCol);

                string position = maze[playerRow, playerCol];

                if (position == "M")
                {
                    health -= 40;
                    if (health <= 0)
                    {
                        health = 0;
                        Console.WriteLine("Player is dead. Maze over!");
                        break;
                    }
                    maze[playerRow, playerCol] = "-";
                }
                if (position == "H")
                {
                    health += 15;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    maze[playerRow, playerCol] = "-";
                }
                if (position == "X")
                {
                    Console.WriteLine("Player escaped the maze. Danger passed!");
                    break;
                }
            }

            maze[playerRow, playerCol] = "P";

            Console.WriteLine($"Player's health: {health} units");

            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write(maze[i, j].ToString());
                }
                Console.WriteLine();
            }
        }

        private static void PlayerStep(string? direction, ref int playerRow, ref int playerCol)
        {
            if (direction == "left")
            {
                playerCol--;
            }
            if (direction == "up")
            {
                playerRow--;
            }
            if (direction == "right")
            {
                playerCol++;
            }
            if (direction == "down")
            {
                playerRow++;
            }
        }

        private static bool DefineCommandIsOutOfBoundaries(string[,] maze, string? direction, int playerRow, int playerCol)
        {
            if ((direction == "up" && playerRow == 0) || (direction == "down" && playerRow == maze.GetLength(0) - 1) ||
                (direction == "left" && playerCol == 0) || (direction == "right" && playerCol == maze.GetLength(1) - 1))
            {
                return true;
            }
            return false;
        }
    }
}
