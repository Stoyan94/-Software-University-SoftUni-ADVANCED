using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] sortedNum = numbers.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(String.Join(" ",sortedNum));
        }
    }
}
