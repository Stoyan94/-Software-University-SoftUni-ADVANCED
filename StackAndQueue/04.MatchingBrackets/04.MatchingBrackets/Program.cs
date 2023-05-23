using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expresion = Console.ReadLine();
            Stack<int> subExpresion = new Stack<int>();

            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i]=='(')
                {
                    subExpresion.Push(i);
                }
                else if (expresion[i]==')')
                {
                    int startIndex = subExpresion.Pop();
                    int endIndex = i;
                    Console.WriteLine(expresion.Substring(startIndex,endIndex-startIndex+1));
                }
            }
        }
    }
}
