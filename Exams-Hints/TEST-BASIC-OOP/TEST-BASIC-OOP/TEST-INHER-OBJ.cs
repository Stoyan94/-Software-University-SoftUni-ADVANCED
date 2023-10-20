using System.Numerics;
using System.Text;

namespace TEST_BASIC_OOP
{
    public class TEST_INHER_OBJ
    {
        private List<TEST_ONE_OBJ> objects;

        public TEST_INHER_OBJ(string name, int openPosition, char group)
        {
            Name = name;
            OpenPosition = openPosition;
            Group = group;
            objects = new List<TEST_ONE_OBJ>();
        }

        public List<TEST_ONE_OBJ> Objects { get; set; }
        public string Name { get; set; }
        public int OpenPosition { get; set; }
        public char Group { get; set; }

        public int Count => this.Objects.Count;


        public string AddPlayer(TEST_ONE_OBJ player)
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

            this.Objects.Add(player);
            OpenPosition--;

            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPosition}.";
        }


        public bool RemovePlayer(string playerName)
        {
            var removePlayer = this.Objects?.FirstOrDefault(p => p.Name == playerName);

            if (removePlayer is not null)
            {
                this.Objects!.Remove(this.Objects.FirstOrDefault(x => x.Name == playerName)!);
                return true;
            }
            return false;
        }


        public int RemovePlayerByPosition(string playerPosition)
        {
            int count = this.Objects.RemoveAll(x => x.Position == playerPosition);

            return count;
        }

        public TEST_ONE_OBJ RetirePlayer(string playerName)
        {
            var player = this.Objects.FirstOrDefault(x => x.Name == playerName);

            if (player == null)
            {
                return null;
            }
            player.Retired = true;

            return player;
        }

        public List<TEST_ONE_OBJ> AwardPlayers(int minGamesPlayed)
        {
            var filteredPlayers = this.Objects.FindAll(x => x.Games >= minGamesPlayed);

            return filteredPlayers;
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            foreach (var player in this.Objects.Where(x => x.Retired != true))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
