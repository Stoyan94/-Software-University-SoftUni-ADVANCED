using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Advance_Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string, int>> wardrobe = new Dictionary<string,Dictionary<string,int>>();
            FillWardrobe(wardrobe);

            string[] dressToFound = Console.ReadLine().Split(" ");
            var color = dressToFound[0];
            var clothes = dressToFound[1];

            foreach (var currColor in wardrobe)
            { 
                Console.WriteLine($"{currColor.Key}clothes:");
                foreach (var currClothes in currColor.Value)
                {                  
                    if (currColor.Key.Trim() == color && currClothes.Key.Trim()==clothes)
                    {
                        Console.WriteLine($"* {currClothes.Key} - {currClothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {currClothes.Key} - {currClothes.Value}");
                    }
                }
               
            }

        }

        private static Dictionary<string, Dictionary<string, int>> FillWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            int clothesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < clothesCount; i++)
            {
                string[] currColor = Console.ReadLine().Split("-> ",StringSplitOptions.RemoveEmptyEntries);
                string []currClothes = currColor[1].Split(",",StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(currColor[0]))
                {
                    wardrobe.Add(currColor[0], new Dictionary<string, int>());
                }


                for (int j = 0; j < currClothes.Length; j++)
                {
                    if (!wardrobe[currColor[0]].ContainsKey(currClothes[j]))
                    {
                        wardrobe[currColor[0]].Add(currClothes[j],0);
                    }
                    wardrobe[currColor[0]][currClothes[j]]++;
                }
               
            }

            return wardrobe;
        }
    }
}
