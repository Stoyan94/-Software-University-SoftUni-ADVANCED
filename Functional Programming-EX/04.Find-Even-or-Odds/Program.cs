using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Find_Even_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int[] ranges = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = ranges[0]; i <=ranges[1]; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> even = evenNums=> evenNums % 2 == 0;

            Predicate<int> odd = oddNums => oddNums % 2 != 0;

            Action<List<int>> print = nums=>
            Console.WriteLine(String.Join(" ",nums));

            string command = Console.ReadLine();

            if (command=="even")
            {
                numbers= numbers.FindAll(even);
            }
            else if (command == "odd")
            {
                numbers = numbers.FindAll(odd);
            }

            print(numbers);
        }
    }
}
