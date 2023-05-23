using System;
using System.Collections.Generic;

namespace _07.Queues_HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peopels = Console.ReadLine().Split();
            int tossesCount = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(peopels);

            int crrTosses = 1;
            
            while (kids.Count>1)
            {
                string kidWithPopato = kids.Dequeue();               
                if (crrTosses!=tossesCount)
                {
                    crrTosses++;
                    kids.Enqueue(kidWithPopato);
                }
                else
                {
                    crrTosses = 1;
                    Console.WriteLine($"Removed {kidWithPopato}");
                }

            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
