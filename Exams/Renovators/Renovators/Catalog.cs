using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public IReadOnlyCollection<Renovator> Renovators => this.renovators;

        public string Name { get; private set; }
        public int NeededRenovators { get; private set; }
        public string Project { get; private set; }

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

            NeededRenovators--;
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

        public int RemoveRenovatorBySpecialty(string removeBySpecialty)
        {
            int countRemoves = this.renovators.RemoveAll(x => x.Type == removeBySpecialty);

            if (countRemoves == 0)
            {
                return 0;
            }

            return countRemoves;
        }

        public Renovator HireRenovator(string hireByName)
        {
            var hire = Renovators.FirstOrDefault(x=>x.Name == hireByName);

            if (hire is null)
            {
                return null;
            }
            hire.Hired = true;
            return hire;
        }

        public  List<Renovator> PayRenovators(int countDaysWork) 
        {
            var renovatorChek = renovators.FindAll(x=>x.Days > countDaysWork);

            return renovatorChek;
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Renovators available for Project {this.Project}:");

            foreach (var renovator in Renovators.Where(x=>x.Hired == false))
            {
                output.AppendLine($"{renovator}");
            }

           

            return output.ToString().Trim();
        }
    }
}
