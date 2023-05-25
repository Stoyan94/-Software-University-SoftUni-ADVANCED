using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Stack_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timesOperations = int.Parse(Console.ReadLine());

            Stack<int> nums = new Stack<int>();

            for (int i = 1; i <= timesOperations; i++)
            {
                int[] typesOperation = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToArray();

                int cmdType = typesOperation[0];
                

                if (cmdType==1)
                {
                    nums.Push(typesOperation[1]);                   
                }
                else if (cmdType == 2)
                {
                    if (nums.Count>0)
                    {
                        nums.Pop();
                    }                    
                }
                else if (cmdType == 3)
                {
                    if (nums.Count > 0)
                    {
                        Console.WriteLine(nums.Max());
                    }
                }
                else if (cmdType==4)
                {
                    if (nums.Count > 0)
                    {
                        Console.WriteLine(nums.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ",nums));
        }
    }
}
