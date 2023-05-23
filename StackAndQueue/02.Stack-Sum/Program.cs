using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> sumNums = new Stack<int>(nums);

            string commands;

            while ((commands= Console.ReadLine().ToLower())!="end")
            {
                string [] cmdArgs = commands.Split(' ');

                string command = cmdArgs[0];

                if (command=="add")
                {
                    sumNums.Push(int.Parse(cmdArgs[1]));
                    sumNums.Push(int.Parse(cmdArgs[2]));
                }
                else if (command == "remove")
                {
                    int countTimesRemove = int.Parse(cmdArgs[1]);
                    if (countTimesRemove > sumNums.Count)
                    {
                        continue;
                    }

                    for (int i = 1; i <= countTimesRemove; i++)
                    {
                        sumNums.Pop();
                    }
                }

            }
            Console.WriteLine($"Sum: {sumNums.Sum()}");
        }
    }
}
