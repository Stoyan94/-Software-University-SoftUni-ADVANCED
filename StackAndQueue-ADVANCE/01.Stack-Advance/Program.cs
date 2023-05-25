using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Stack_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] stackOperations =Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();
            int [] numsToAdd =Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>();

            int timeAdds = stackOperations[0];

            for (int i = 0; i < timeAdds; i++)
            {
                 numbers.Push(numsToAdd[i]);

            }
            int operationsLeft = 0;

            while (stackOperations[1] !=operationsLeft)
            {
                operationsLeft++;

                numbers.Pop();
            }

            if (numbers.Contains(stackOperations[2]))
            {
                Console.WriteLine("true");
            }
            else if(numbers.Count > 0)
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
