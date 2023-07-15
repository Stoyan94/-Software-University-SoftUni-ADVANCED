using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trainer
{
    public class Pokemons
    {
        private string name;
        private string element;
        private int healt;
        public Pokemons(string name, string element, int healt)
        {
            Name = name;
            Element = element;
            Healt = healt;
        }

        public string Name { get { return name; } set { name = value; } }

        public string Element { get { return element; } set { element = value; } }

        public int Healt { get { return healt; } set { healt = value; } }
    }
}
