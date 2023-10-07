using System;
using System.Collections.Generic;
using System.Linq;

namespace Renovators
{
    public class Catalog
    {
        private const string InvalidName = "Invalid renovator's information.";
        private const string NoNeedRn = "Renovators are no more needed.";
        private const string InvalidRate = "Invalid renovator's rate.";
        private const double ChekMaxRate = 350;

        private List<Renovator> renovators;

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            renovators = new List<Renovator>();
        }

        public IReadOnlyCollection<Renovator> Renovators => renovators;

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count => renovators.Count;


        public string AddRenovator(Renovator renovator)
        {
            if (NeededRenovators == 0)
            {
                return NoNeedRn;
            }
            else if (String.IsNullOrEmpty(renovator.Name))
            {
                return InvalidName;
            }
            else if (renovator.Rate > ChekMaxRate)
            {
                return InvalidRate;
            }

            renovators.Add(renovator);

            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string renovatorName)
        {
            var removedPlayer = Renovators.FirstOrDefault(x=>x.Name == renovatorName);

            if (removedPlayer != null)
            {
                return true;
            }
            return false;
        }
    }
}
