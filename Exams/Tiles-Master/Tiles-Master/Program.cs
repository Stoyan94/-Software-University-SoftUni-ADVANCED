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

            Dictionary<string, int> table = new Dictionary<string,int>()
            {
                ["Sink"] = 40,                
                ["Oven"] = 50,                
                ["Countertop"] = 60,
                ["Wall"] = 70,
                ["Floor"] = 0,
            };

            Dictionary<string, int> typeAreaRenovation = new Dictionary<string, int>();

            while (whiteTiles.Any() || greyTiles.Any())
            {
                int result = whiteTiles.Peek() + greyTiles.Peek();

                if (table.ContainsValue(result))
                {
                    string nameArea = table.FirstOrDefault(x=>x.Value == result).Key;

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
                   
                    if (!typeAreaRenovation.ContainsKey())
                    {
                        typeAreaRenovation[] = 0;
                    }
                    typeAreaRenovation["Floor"] += 1;
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                }
            }

            Console.WriteLine();
        }
    }
}