using System;
using System.Text;

namespace Renovators
{
    public class Renovator
    {       
        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
            this.Days = days;
        }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public double Rate { get; set; }

        public int Days { get; set; }

        public bool Hired { get; set; } = false;
                      

        public override string ToString()
        {
            StringBuilder ouput = new StringBuilder();

            ouput.AppendLine($"-Renovator: {Name})");
            ouput.AppendLine($"--Specialty: {Type}");
            ouput.AppendLine($"--Rate per day: {Rate:f2} BGN");

            return ouput.ToString().Trim();
        }
    }
}
