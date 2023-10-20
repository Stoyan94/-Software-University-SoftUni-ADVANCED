using System.Text;

namespace TEST_BASIC_OOP
{
    public class TEST_ONE_OBJ
    {
        public TEST_ONE_OBJ(string name, string position, double rating, int games)
        {
            this.Name = name;
            this.Position = position;
            this.Rating = rating;
            this.Games = games;
        }

        public string Name { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
        public int Games { get; set; }
        public bool Retired { get; set; } = false;

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"");
            output.AppendLine($" ");
            output.AppendLine($"");
            output.AppendLine($"");

            return output.ToString().Trim();
        }
    }
}
