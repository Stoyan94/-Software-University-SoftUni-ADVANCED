using System;
using System.Collections.Generic;

namespace _12.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> nums = new Dictionary<int, int>();

            FillNums(nums);

            foreach (var currNum in nums)
            {
                if (currNum.Value % 2==0)
                {
                    Console.WriteLine(currNum.Key);
                }
            }
           
        }

        private static Dictionary<int, int> FillNums(Dictionary<int, int> nums)
        {
            int nLenght = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLenght; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!nums.ContainsKey(num))
                {
                    nums[num] = 0;
                }
                nums[num]++;
            }

            return nums;
        }
    }
}
