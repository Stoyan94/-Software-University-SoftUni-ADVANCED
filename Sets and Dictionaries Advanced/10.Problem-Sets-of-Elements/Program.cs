using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Problem_Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> seckondSet = new HashSet<int>();

            int[] lenghtSets= Console.ReadLine().Split().Select(int.Parse).ToArray();
            FillSet(firstSet, lenghtSets[0]);
            FillSet(seckondSet, lenghtSets[1]);
           
            foreach (var currNum in firstSet)
            {
                if (seckondSet.Contains(currNum))
                {
                    Console.Write(currNum+ " ");
                }
            }
        }

        private static HashSet<int> FillSet(HashSet<int> Set, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Set.Add(int.Parse(Console.ReadLine()));
            }

            return Set;
        }
    }
}
