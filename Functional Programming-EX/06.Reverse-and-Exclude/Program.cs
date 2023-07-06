using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .Reverse().ToArray();

            int divNum = int.Parse(Console.ReadLine());

            Func<int, int, bool> divByN = (x, y) => x % y != 0;

            Action<List<int>> print = result =>
            Console.WriteLine(String.Join(" ",result));

            List<int> result =  numbers.Where(x=> divByN(x,divNum)).ToList();

            print(result);
        }
    }
}
