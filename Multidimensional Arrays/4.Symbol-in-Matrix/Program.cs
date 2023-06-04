using System;
using System.Linq;

namespace _4.Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputSize = int.Parse(Console.ReadLine());

            char [,] symbols = new char [inputSize,inputSize];

            for (int row = 0; row < symbols.GetLength(0); row++)
            {
                string inputSymbols = Console.ReadLine();                

                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    symbols[row,col] = inputSymbols[col];
                }
            }   

            char contains  = char.Parse(Console.ReadLine());

            for (int row = 0; row < symbols.GetLength(0); row++)
            {
                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    if (symbols[row,col]==contains)
                    {
                        Console.WriteLine($"({row}, {col})");
                        Environment.Exit(0);
                    }
                }   
            } 
            
            Console.WriteLine($"{contains} does not occur in the matrix");
            
        }
    }
}
