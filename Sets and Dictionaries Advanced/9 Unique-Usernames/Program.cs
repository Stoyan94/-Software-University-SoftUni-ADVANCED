using System;
using System.Collections.Generic;

namespace _9_Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int nNmaes = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNmaes; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
