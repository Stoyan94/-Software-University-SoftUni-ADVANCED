using System;
using System.Collections.Generic;

namespace _7._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            string input;

            while ((input = Console.ReadLine())!="END")
            {
                string[] inputArgs = input.Split(",");

                string command  = inputArgs[0];
                string carNumber = inputArgs[1];

                if (command=="IN")
                {
                    carNumbers.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    carNumbers.Remove(carNumber);
                }
            }

            if (carNumbers.Count>0)
            {
                foreach (var carNumber in carNumbers)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
