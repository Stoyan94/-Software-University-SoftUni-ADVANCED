using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getMinNum = numbers =>
             numbers.Min();

            int [] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

             int minNum =  getMinNum(numbers);


            Console.WriteLine(minNum);
        }
    }
}
