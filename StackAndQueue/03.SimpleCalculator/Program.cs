using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textCalculator = Console.ReadLine();
            string[] reversed = textCalculator.Split(' ').Reverse().ToArray();
            Stack<string> calculator = new Stack<string>(reversed);
            int sum = 0;

            while (calculator.Count>0)
            {
                if (calculator.Peek()=="-")
                {
                    calculator.Pop();
                    sum -= int.Parse(calculator.Peek());
                    calculator.Pop();
                }
                else if (calculator.Peek()=="+")
                {
                    calculator.Pop();
                    sum += int.Parse(calculator.Peek());
                    calculator.Pop();
                }
                else
                {
                    sum+= int.Parse(calculator.Peek());
                    calculator.Pop();
                }
                
            }

            Console.WriteLine(sum);
        }
    }
}
