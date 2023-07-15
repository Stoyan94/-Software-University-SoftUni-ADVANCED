using System;
using System.Linq;
using System.Collections.Generic;

namespace Pokemon_Trainer
{
    public class Program
    {
        static void Main(string[] args)
        {          
            List<Trainers> trainers = new List<Trainers>();

            string trainerInpu;

            while ((trainerInpu=Console.ReadLine())!="Tournament")
            {
                string[] trainerInfo = trainerInpu.Split();

                string trainerName= trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string pokemonType = trainerInfo[2];
                int pokemonHealt = int.Parse(trainerInfo[3]);

                Pokemons pokemon = new Pokemons(pokemonName,pokemonType,pokemonHealt);
                Trainers trainer = new Trainers(trainerName,pokemonName,pokemonType,pokemonHealt);

                if (trainers.Any(x=>x.Name==trainerName))
                {
                    trainers.Find(t=>t.Name==trainerName).Pokemons.Add(pokemon);
                }
                else
                {
                    trainers.Add(trainer);
                }

                

            }

            string pokemonElement;

            while ((pokemonElement=Console.ReadLine())!="End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (trainers[i].Pokemons.Any(x=>x.Element==pokemonElement))
                    {
                        trainers[i].Badges += 1;
                    }
                    else
                    {
                        DecreasePokemnHpAndChek(trainers[i].Pokemons);
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t=>t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void DecreasePokemnHpAndChek(List<Pokemons> pokemons)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                pokemons[i].Healt -= 10;
                if (pokemons[i].Healt<=0)
                {
                    pokemons.RemoveAt(i);
                }
            }
        }
    }
}
