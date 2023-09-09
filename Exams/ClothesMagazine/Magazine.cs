using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{public class Magazine
    {
        private List<Cloth> clothesSold;
        public Magazine(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.Clothes = new List<Cloth>();
            this.clothesSold = new List<Cloth>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public List<Cloth> Clothes { get; set; }        

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
                Capacity++;
            }
        }

        public int GetClothCount() => this.Clothes.Count;
        public bool RemoveCloth(string color)
        {
            Cloth cloth = this.Clothes.FirstOrDefault(c => c.Color == color);
            if (cloth != null)
            {
                this.Clothes.Remove(cloth);
                return true;
            }
            else return false;
        }

        public Cloth GetSmallestCloth()=>this.Clothes.OrderByDescending(x=>x.Size).FirstOrDefault();

        public Cloth GetCloth(string color)=>this.Clothes.FirstOrDefault(x=>x.Color==color);

        public string Report()
        {      

            StringBuilder output = new StringBuilder();

            if (Clothes.Count == 0)
            {
                output.AppendLine($"Out of clothes");
            }
            else
            {
                output.AppendLine("Zara magazine contains:");

                foreach (var cloth in Clothes.OrderBy(x => x.Size))
                {
                    output.AppendLine(cloth.ToString());
                }                
            }

            if (clothesSold.Count > 0)
            {
                output.AppendLine("Clothes sold:");

                foreach (var clothSold in clothesSold)
                {
                    output.AppendLine(clothSold.ToString());
                }
            }

            return output.ToString().TrimEnd();
        }       

        public void BuyCloths(Cloth buyCloth)
        {
           Cloth cloth = this.Clothes.Where(this.Clothes.Contains).FirstOrDefault();

            if (cloth != null)
            {
                this.Clothes.Remove(cloth);
                this.clothesSold.Add(cloth);
            }
            else
            {
                Console.WriteLine("Sorry this garment is not available!");
            }
        }
    }
}
