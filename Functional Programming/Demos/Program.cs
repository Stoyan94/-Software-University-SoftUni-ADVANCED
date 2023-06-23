using System;
using System.Collections.Generic;
using System.Linq;

namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            Func<int, int, int> getCalcMethod = GetCalcMethod(sign);

            Console.WriteLine(getCalcMethod(x, y)); 
        }

        static int Default(int x, int y)
        {
           return -1;
        } static int Multiply(int x, int y)
        {
           return x * y;
        }
         static int Subtract(int x, int y)
        {
           return x - y;
        }
         static int Sum(int x, int y)
        {
           return x + y;
        }

        static Func<int, int, int> GetCalcMethod(string input)
        {
            switch (input)
            {
                case "*": return Multiply;
                case "-": return Subtract;
                case "+": return Sum;
                    default: return Default;
               
            }
        }
    }
}
