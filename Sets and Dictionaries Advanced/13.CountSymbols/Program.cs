using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            FillSymbols(symbols);

            foreach (var currSymbol in symbols)
            {
                Console.WriteLine($"{currSymbol.Key}: {currSymbol.Value} time/s");
            }

             //: 1 time / s
             //S: 1 time / s

        }

        private static SortedDictionary<char, int> FillSymbols(SortedDictionary<char, int> symbols)
        {
            string text = Console.ReadLine();            

            for (int i = 0; i <text.Length; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols.Add(text[i], 0);
                }
                symbols[text[i]]++;
            }
           
            return symbols;
        }
    }
}
