using System;
using System.Collections.Generic;
using System.Linq;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;
        public Team(string name, int openPosition, char group)
        {
            this.Name = name;
            this.OpenPosition = openPosition;
            this.Group = group;
            this.players = new List<Player>();
        }

        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public int OpenPosition { get; set; }
        public char Group { get; set; }

        public int Count=>this.players.Count;

        public string AddPlayer(Player player)
        {       

            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {                 
                return "Invalid player's information.";
            }
            else if (OpenPosition == players.Count)
            {
                return "There are no more open positions.";
            }
            else if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }

            this.players.Add(player);
            OpenPosition++;

            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPosition}.";
        }

       public bool RemovePlayer(string playerName) => Players.Remove(Players.FirstOrDefault(x=>x.Name == playerName));
    }
}
