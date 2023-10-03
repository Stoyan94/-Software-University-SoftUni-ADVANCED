using System;

namespace Basketball
{
    public class Player
    {
        public Player(string name, string position, double rating, int games)
        {
            Name = name;
            Position = position;
            Rating = rating;
            Games = games;
        }

        public string Name { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
        public int Games { get; set; }
        public bool Retired { get; set; }



       

    }
}
