using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Sort_Even_Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split (",").
                Select(int.Parse).ToList();

            Predicate<int> even = x=> x % 2 == 0;            

            nums = nums.FindAll(even).OrderBy(x=>x).ToList();

            Action<List<int>> print = x => Console.WriteLine(String.Join(", ",x));

            print(nums);

        }
    }
}
