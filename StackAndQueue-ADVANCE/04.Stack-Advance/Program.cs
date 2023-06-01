using System;
using System.Linq;
using System.Collections.Generic;


namespace _04.Stack_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isBalanced = true;
            Stack<char> parantheses = new Stack<char>();

            foreach (var item in input)
            {

                if (item == '(' ||
                    item == '[' ||
                    item =='{' )
                {
                    parantheses.Push(item);
                    continue;
                }

                if (parantheses.Count <= 0)
                {
                    isBalanced = false;
                    break;
                }

                char currChar = parantheses.Peek();

                if (item==')' && parantheses.Peek() =='(')
                {
                    parantheses.Pop();
                }
                else if (item == '}' && parantheses.Peek() == '{')
                {
                    parantheses.Pop();
                }
                else if (item == ']' && parantheses.Peek() =='[')
                {
                    parantheses.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }               
            }

            if (!isBalanced ||parantheses.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
