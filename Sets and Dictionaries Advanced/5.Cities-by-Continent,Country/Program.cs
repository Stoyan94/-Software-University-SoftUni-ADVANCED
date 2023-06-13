using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.Cities_by_Continent_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            int continenetsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < continenetsCount; i++)
            {
                FillDictionary(continents);
            }

            foreach (var currentContinent in continents)
            {
                Console.WriteLine($"{currentContinent.Key}:");

                foreach (var currentCountry in currentContinent.Value)
                {
                    Console.WriteLine($"  {currentCountry.Key} -> {string.Join(", ", currentCountry.Value)}");
                }
            }


        }
        private static Dictionary<string, Dictionary<string, List<string>>> FillDictionary(Dictionary<string, Dictionary<string, List<string>>> continents)
        {
            string[] input = Console.ReadLine().Split(" ");

            var continent = input[0];
            var country = input[1];
            var city = input[2];


            if (!continents.ContainsKey(continent))
            {
                continents.Add(continent, new Dictionary<string, List<string>>());
            }
            if (!continents[continent].ContainsKey(country))
            {
                continents[continent].Add(country, new List<string>());
            }
            continents[continent][country].Add(city);

            return continents;
        }
    }
}
