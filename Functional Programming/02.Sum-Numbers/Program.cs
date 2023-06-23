using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").
                Select(int.Parse).ToArray();

            Func<int[], int> sumNums = x=> x.Sum();
            Func<int[],int> lenght = x=> x.Length;

            Console.WriteLine(lenght(nums));
            Console.WriteLine(sumNums(nums));            
           
        }
    }
}
