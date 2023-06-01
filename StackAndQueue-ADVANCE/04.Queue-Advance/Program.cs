using System;
using System.Linq;
using System.Collections.Generic;


namespace _04.Stack_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPums = int.Parse(Console.ReadLine());            

            Queue<int[]> pumpsInfo = new Queue<int[]>();
            

            for (int i = 0; i < countPums; i++)
            {
                int[] inputPumpsInfo = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

                pumpsInfo.Enqueue(inputPumpsInfo);
            }

            int startIndex = 0;
            

            while (true)
            {
                bool isComplete = true;
                int totalLiters = 0;

                foreach (int[] item in pumpsInfo)
                {
                    int currLiters =+ item[0];
                    int distance =+ item[1];

                    totalLiters += currLiters;
                    if (totalLiters - distance< 0)
                    {
                        startIndex++;

                        int [] currPomp = pumpsInfo.Dequeue();
                        pumpsInfo.Enqueue(currPomp);

                        isComplete = false;
                        break;
                    }
                    totalLiters-=distance;
                }

                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break; 
                }
            }
        }
    }
}
