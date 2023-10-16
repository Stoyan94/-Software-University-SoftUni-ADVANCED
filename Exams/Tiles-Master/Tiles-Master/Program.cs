using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> table = new Dictionary<string, int>()
            {
                ["Sink"] = 40,
                ["Oven"] = 50,
                ["Countertop"] = 60,
                ["Wall"] = 70,
                ["Floor"] = 0,
            };

            SortedDictionary<string, int> typeAreaRenovation = new SortedDictionary<string, int>()
            {
                ["Floor"] = 0
            };

            while (whiteTiles.Any() && greyTiles.Any())
            {
                if (whiteTiles.Peek() != greyTiles.Peek())
                {
                    int greyAreaBack = greyTiles.Dequeue();
                    int devideAreas = whiteTiles.Pop() % greyAreaBack;

                    whiteTiles.Push(devideAreas / 2);
                    greyTiles.Enqueue(greyAreaBack);
                    continue;
                }

                int result = whiteTiles.Peek() + greyTiles.Peek();

                if (table.ContainsValue(result))
                {
                    string nameArea = table.FirstOrDefault(x => x.Value == result).Key;

                    if (!typeAreaRenovation.ContainsKey(nameArea))
                    {
                        typeAreaRenovation[nameArea] = 0;
                    }
                    typeAreaRenovation[nameArea] += 1;

                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                }
                else
                {
                    typeAreaRenovation["Floor"] += 1;
                    whiteTiles.Pop();
                    greyTiles.Dequeue();

                }
            }

            string isWihteTilesUsed = whiteTiles.Count() > 0 
                ? string.Join(", ", whiteTiles) : "none";

            string isGteyTilesUsed = greyTiles.Count() > 0 
                ? string.Join (", ", greyTiles) : "none";

            Console.WriteLine($"White tiles left: {isWihteTilesUsed}");
            Console.WriteLine($"Grey tiles left: {isGteyTilesUsed}");

            foreach (var item in typeAreaRenovation.OrderByDescending(v=>v.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
