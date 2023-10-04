using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

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

        public int Count => this.players.Count;


        public string AddPlayer(Player player)
        {

            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            else if (OpenPosition == 0)
            {
                return "There are no more open positions.";
            }
            else if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }

            this.players.Add(player);
            OpenPosition--;

            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPosition}.";
        }


        public bool RemovePlayer(string playerName)
        {
            var removePlayer = this.Players?.FirstOrDefault(p => p.Name == playerName);

            if (removePlayer is not null)
            {
                this.Players.Remove(this.Players.FirstOrDefault(x => x.Name == playerName));
                return true;
            }
            return false;
        }
        
        
        public int RemovePlayerByPosition(string playerPosition)
        {
            int count = this.players.RemoveAll(x => x.Position == playerPosition);

            return count;
        }

        public Player RetirePlayer(string playerName)
        {
            var player = this.players.FirstOrDefault(x => x.Name == playerName);

            if(player == null)
            {
                return null;
            }
            player.Retired = true;

            return player;
        }

        public List<Player> AwardPlayers(int minGamesPlayed)
        {
            var filteredPlayers = this.players.FindAll(x=>x.Games >= minGamesPlayed);
            
            return filteredPlayers;
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            foreach (var player in this.players.Where(x => x.Retired != true))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
