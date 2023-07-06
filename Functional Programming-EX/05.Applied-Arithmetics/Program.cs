using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();  
            
            List<int> result = new List<int>();

            string command;

            Func<List<int>, List<int>> add = numbers=>numbers.Select(x=>x+1).ToList();

            Func<List<int>, List<int>> subtract = numbers => numbers.Select(x => x -1).ToList();

            Func<List<int>, List<int>> multiply = numbers => numbers.Select(x => x * 2).ToList();

            Action<List<int>> print = allNums =>
            Console.WriteLine(string.Join(" ",allNums));
            

            while ((command=Console.ReadLine())!="end")
            {
                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }           
        }        
    }
}
