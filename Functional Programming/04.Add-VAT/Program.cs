using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] numms = Console.ReadLine().Split(",")
                .Select(double.Parse).ToArray();
                
            Action<double[]> action = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] += (x[i] * 0.20);
                }
            };

            Action<double[]> print = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine($"{x[i]:F2}");
                }
            };

            action(numms);
            print(numms);

           
        }
    }
}
