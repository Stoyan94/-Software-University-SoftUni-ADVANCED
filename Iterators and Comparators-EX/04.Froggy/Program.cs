using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            Lake lake = new Lake(elements);

            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
