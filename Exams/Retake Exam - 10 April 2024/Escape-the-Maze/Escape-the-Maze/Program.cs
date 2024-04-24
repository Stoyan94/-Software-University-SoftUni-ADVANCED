
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

}