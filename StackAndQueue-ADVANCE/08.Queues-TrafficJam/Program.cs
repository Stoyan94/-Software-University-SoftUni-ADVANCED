using System;
using System.Collections.Generic;

namespace _08.Queues_TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int nPasses = int.Parse(Console.ReadLine());            
            Queue<string> carsWait = new Queue<string>();
            string currCar;
            int passCount = 0;

            while ((currCar=Console.ReadLine())!="end")
            {
                if (currCar=="green")
                {                   
                    for (int i = 1; i <=nPasses; i++)
                    {
                        if (carsWait.Count == 0)
                        {
                            break;
                        }
                        string car= carsWait.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        passCount++;
                    }
                }
                else
                {
                    carsWait.Enqueue(currCar);
                }
            }

            Console.WriteLine($"{passCount} cars passed the crossroads.");
        }
    }
}
