using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Queue_Advacne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stackOperations = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();
            int[] numsToAdd = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>();

            int timeAdds = stackOperations[0];

            for (int i = 0; i < timeAdds; i++)
            {
                numbers.Enqueue(numsToAdd[i]);

            }
            int operationsLeft = 0;

            while (stackOperations[1] != operationsLeft)
            {
                operationsLeft++;

                numbers.Dequeue();
            }

            if (numbers.Contains(stackOperations[2]))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
