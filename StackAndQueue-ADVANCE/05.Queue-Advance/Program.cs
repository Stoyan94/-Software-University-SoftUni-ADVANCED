using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Queue_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenWindow = int.Parse(Console.ReadLine());
            int yellowWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string input;          
            int carsPassed=0;

            while ((input=Console.ReadLine())!="END")
            {
                if (input!="green")
                {
                    cars.Enqueue(input);
                    continue;
                }

                int currentGreen = greenWindow;
              

                while (currentGreen>0 && cars.Count>0)
                {
                    string currCar=cars.Dequeue();

                    if (currentGreen-currCar.Length>=0)
                    {
                        currentGreen -= currCar.Length;
                        carsPassed++;
                        continue;
                    }

                    if (currentGreen+yellowWindow - currCar.Length>=0)
                    {
                        currentGreen = 0;
                        carsPassed++;
                        continue;
                    }

                    int hitChar = currentGreen + yellowWindow;

                    Console.WriteLine($"A crash happened!");
                    Console.WriteLine($"{currCar} was hit at {currCar[hitChar]}.");

                    Environment.Exit(0);
                }
              
            }

            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}
