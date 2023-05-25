using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Queue_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int preparedDishes = int.Parse(Console.ReadLine());
            int[] platesOrder = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(platesOrder);

            int biggestOrder = orders.Max();
            Console.WriteLine(biggestOrder);

            for (int i = 0; i < platesOrder.Length; i++)
            {
                int currOrder = platesOrder[i];

                if (preparedDishes-currOrder <0)
                {
                    break;              
                }
                preparedDishes -= currOrder;
                orders.Dequeue();
            }

            if (orders.Count>0)
            {                
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
            else
            {               
                Console.WriteLine("Orders complete");
            }
        }
    }
}
