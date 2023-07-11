using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Animal
    {
        public Animal(string species,bool isHungry)
        {
            Console.WriteLine($"I am in constructor");          
            Species = species;           
            IsHungry = isHungry;
        }

        //invoke ctro in ctro
        public Animal(string name, string gender,string species, bool isHungry) : this(species,isHungry)
        {
            Name = name;
            Gender = gender;
        }           
          

        public string Species { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public bool IsHungry { get; set; }
    }
}
