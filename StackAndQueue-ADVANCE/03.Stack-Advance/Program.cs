using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Stack_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputInfo = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> box = new Stack<int>(inputInfo);

            int racksUsed = 0;
            int currentRackCapacity = 0;
            while (box.Count > 0)
            {
                if (currentRackCapacity - box.Peek() < 0)
                {
                    racksUsed++;
                    currentRackCapacity = capacity;
                }
                else
                {
                    currentRackCapacity -= box.Pop();
                }
            }
            Console.WriteLine(racksUsed);
        }
    }
}
