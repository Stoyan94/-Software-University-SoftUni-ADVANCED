using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trainer
{
    public class Trainers
    {
        private string name;
        private int badges;
        private List<Pokemons> pokemons;
        public Trainers(string trainerName)
        {
            Name = trainerName;
            Badges = 0;
            Pokemons = new List<Pokemons>();
        }

        public Trainers(string trainerName,string pokemName,string element,int healt): this(trainerName)
        {
            Pokemons.Add(new Pokemons(pokemName,element,healt));
        }

        public string Name { get { return name; } set { name = value; } }

        public int Badges { get { return badges; } set { badges = value; } }

        public List<Pokemons> Pokemons { get { return pokemons; } set { pokemons = value; } }
    }
}
