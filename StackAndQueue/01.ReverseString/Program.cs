using System;
using System.Collections.Generic;

namespace _01.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reverseString = Console.ReadLine();
            Stack<char> newString = new Stack<char>();

            foreach (var item in reverseString)
            {
                newString.Push(item);
            }

            while (newString.Count > 0)
            {
                Console.Write(newString.Pop());
            }
        }
    }
}
