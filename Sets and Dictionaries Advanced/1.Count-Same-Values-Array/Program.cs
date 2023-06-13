using System;
using System.Collections.Generic;
using System.Linq;


namespace _1.Count_Same_Values_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Dictionary<double,int> repeat = new Dictionary<double,int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!repeat.ContainsKey(array[i]))
                {
                    repeat.Add(array[i], 0);
                }

                repeat[array[i]]++;
            }

            foreach (var item in repeat)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
