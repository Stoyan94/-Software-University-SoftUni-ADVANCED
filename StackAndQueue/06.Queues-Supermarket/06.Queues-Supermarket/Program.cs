using System;
using System.Collections.Generic;

namespace _06.Queues_Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> paidCustomers = new Queue<string>();
            string customores;

            while ((customores = Console.ReadLine())!="End")
            {
                if (customores=="Paid")
                {
                    foreach (var customer in paidCustomers)
                    {
                        Console.WriteLine(customer);
                    }
                    paidCustomers.Clear();
                }
                else
                {
                    paidCustomers.Enqueue(customores);
                }                
            }

            Console.WriteLine($"{paidCustomers.Count} people remaining.");
        }
    }
}
