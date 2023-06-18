using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> elemts = new HashSet<string>();
            int elememtsCount = int.Parse(Console.ReadLine());
            FillSet(elemts, elememtsCount);

            foreach (var element in elemts.OrderBy(x=>x))
            {
                Console.Write(element + " ");
            }
        }

        private static HashSet<string> FillSet(HashSet<string> elemets, int elememtsCount)
        {

            for (int i = 0; i < elememtsCount; i++)
            {
                List<string> compunds =Console.ReadLine().Split().ToList();
                compunds.ForEach(compunds => elemets.Add(compunds));
            }
           

            return elemets;
        }
    }
}
