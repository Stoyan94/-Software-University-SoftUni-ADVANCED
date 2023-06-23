using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //numbers = numbers.Where(x =>x >3).ToList();

            numbers = Where(numbers, x => x > 3);

            Console.WriteLine(String.Join(",",numbers));
        }

        public static List<int> Where(List<int> list ,Func<int, bool> cheker)
        {
            List<int> result = new List<int>();

            foreach (var item in list)
            {
                if (cheker(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
