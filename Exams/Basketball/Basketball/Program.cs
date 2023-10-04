using System;
using System.Collections.Generic;
using System.Numerics;

namespace Basketball
{
    public class StartUp
    {
        static void Main()
        {
            // Initialize the repository (Team)
            Team team = new Team("BHTC", 5, 'A');

            // Initialize entity
            Player firstPlayer = new Player("Viktor", "Center", 97.5, 10);

            // Print player
            Console.WriteLine(firstPlayer);
            /*
            -Player: Viktor
            --Position: Center
            --Rating: 97.5
            --Games played: 10
            */

            // Add Player
            Console.WriteLine(team.AddPlayer(firstPlayer));
            /* 
            Successfully added Viktor to the team. Remaining open positions: 4.
            */

            // Check count of added players
            Console.WriteLine(team.Count);
            /* 
            1
            */

            // Remove Player
            Console.WriteLine(team.RemovePlayer("Slavi"));
            /* 
            False
            */

            Player secondPlayer = new Player("Slavi", "Point Guard", 94.3, 47);
            Player thirdPlayer = new Player("Evgeni", "Shooting Guard", 93.7, 16);
            Player fourthPlayer = new Player("Momchil", "Small forward", 67.9, 3);
            Player fifthPlayer = new Player("Vasil", "Power forward", 86.9, 10);
            Player sixthPlayer = new Player("Stefan", "Center", 95.6, 25);
            Player seventhPlayer = new Player("Ivan", " Small forward ", 98.5, 89);


            // Add players
            Console.WriteLine(team.AddPlayer(secondPlayer));
            Console.WriteLine(team.AddPlayer(thirdPlayer));
            Console.WriteLine(team.AddPlayer(fourthPlayer));
            Console.WriteLine(team.AddPlayer(fifthPlayer));
            Console.WriteLine(team.AddPlayer(sixthPlayer));
            Console.WriteLine(team.AddPlayer(seventhPlayer));

            Console.WriteLine(team.RemovePlayer("Ivan"));

            Console.WriteLine(team.RemovePlayerByPosition("Center"));

            Console.WriteLine(team.RetirePlayer("Slavi"));

            List<Player> players = team.AwardPlayers(15);

            foreach (var playerToBeAwarded in players)
            {
                Console.WriteLine(playerToBeAwarded);
            }

        }
    }
}
