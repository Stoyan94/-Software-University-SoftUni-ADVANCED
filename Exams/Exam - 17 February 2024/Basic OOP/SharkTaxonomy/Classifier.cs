using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; private set; }

        //this may be HashSet<Shark>, but by assignment requires List<Shark>
        public List<Shark> Species { get; set; }

        public int GetCount => Species.Count();

        public void AddShark(Shark addShark)
        {
            if (Species.Count() < Capacity && !Species.Contains(addShark))
            {
                Species.Add(addShark);
            }
        }

        public bool RemoveShark(string kind) => Species.Remove(Species.FirstOrDefault(x => x.Kind == kind));

        public Shark GetLargestShark() =>Species.MaxBy(x => x.Length);

        public double GetAverageLength() => Species.Average(x=> x.Length);

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Species.Count()} sharks classified:");

            foreach(Shark sharks in Species)
            {
                sb.AppendLine(sharks.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
