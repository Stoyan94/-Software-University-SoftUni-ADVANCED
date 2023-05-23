using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Queues_PrintEvenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(nums);

            while (numbers.Count>0)
            {
                if (numbers.Peek()% 2==0)
                {
                    if (numbers.Count==1)
                    {
                        Console.Write($"{numbers.Peek()}");
                    }
                    else
                    {
                        Console.Write($"{numbers.Peek()}, ");

                    }
                }
                numbers.Dequeue();
            }
        }
    }
}
