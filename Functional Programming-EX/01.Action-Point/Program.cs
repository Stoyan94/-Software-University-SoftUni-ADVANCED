using System;

namespace _01.Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] names = Console.ReadLine().Split();
            
            Action<string[]> print = names=> 
            Console.WriteLine(string.Join(Environment.NewLine,names));

            print(names);
        }
    }
}
