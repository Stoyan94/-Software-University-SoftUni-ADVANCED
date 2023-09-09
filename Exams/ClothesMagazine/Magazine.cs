using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.Clothes = new List<Cloth>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)=> this.Clothes.Remove
            (this.Clothes.FirstOrDefault(x=>x.Color==color));

        public Cloth GetSmallestCloth()=>this.Clothes.OrderByDescending(x=>x.Size).FirstOrDefault();

        public Cloth GetCloth(string color)=>this.Clothes.FirstOrDefault(x=>x.Color==color);

        public  string Report()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("Zara magazine contains:");

            foreach (var cloth in Clothes.OrderBy(x=>x.Size))
            {
                output.AppendLine(cloth.ToString());
            }

            return output.ToString().TrimEnd();
        }
    }
}
